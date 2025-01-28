using System;
using System.Collections.Generic;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

/// <summary>
/// PowerShellHost 類別用於在 Windows Forms 應用程式中嵌入 PowerShell 主機。
/// 這個類別允許使用者在應用程式中執行 PowerShell 命令並顯示結果。
/// </summary>
public class PowerShellHost
{
    private PowerShell psInstance; // PowerShell 實例，用於執行 PowerShell 命令
    private RichTextBox outputBox; // RichTextBox 控制項，用於顯示 PowerShell 的輸出
    private int lastPromptIndex; // 記錄最後一次提示符的位置
    private string currentPath = @"C:\\Windows\\System32"; // 當前的工作目錄
    private bool isCommandRunning = false; // 標記是否有命令正在執行
    private List<string> commandHistory = new List<string>(); // 儲存命令歷史記錄的列表
    private int historyIndex = -1; // 命令歷史記錄的索引
    public Color ErrorTextColor { get; set; } = Color.Red; // 錯誤文字顏色
    public Color ResultTextColor { get; set; } = Color.LightGray; // 結果文字顏色
    public Color BackgroundColor { get; set; } = Color.MidnightBlue; // 背景顏色

    /// <summary>
    /// 命令完成事件，當命令執行完成時觸發。
    /// </summary>
    public event EventHandler<CommandCompletedEventArgs> CommandCompleted;

    /// <summary>
    /// 初始化 PowerShellHost 類別的新執行個體。
    /// 設定 RichTextBox 的外觀和 PowerShell 環境。
    /// </summary>
    /// <param name="outputBox">顯示輸出結果的 RichTextBox 控制項。</param>
    public PowerShellHost(RichTextBox outputBox)
    {
        this.outputBox = outputBox;
        this.outputBox.KeyDown += OutputBox_KeyDown;
        this.outputBox.BackColor = BackgroundColor;
        this.outputBox.Font = new Font("Consolas", 12);
        psInstance = PowerShell.Create();
        psInstance.AddScript("[Console]::OutputEncoding = [System.Text.Encoding]::Unicode").Invoke(); // 設定輸出編碼
        psInstance.AddScript("[Console]::InputEncoding = [System.Text.Encoding]::Unicode").Invoke(); // 設定輸入編碼
        psInstance.AddScript($"Set-Location '{currentPath}'").Invoke();
        AppendOutput("Windows PowerShell");
        AppendOutput($"PowerShell Ver: {GetPowerShellVersion()} ");
        AppendOutput("");
        UpdateCurrentPath();
    }

    /// <summary>
    /// 處理 RichTextBox 的 KeyDown 事件。
    /// </summary>
    private void OutputBox_KeyDown(object sender, KeyEventArgs e)
    {
        if (isCommandRunning)
        {
            e.SuppressKeyPress = true;
            return;
        }
        if (outputBox.SelectionStart <= lastPromptIndex)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Left)
            {
                e.SuppressKeyPress = true;
                return;
            }
        }
        if (e.KeyCode == Keys.Up)
        {
            e.SuppressKeyPress = true;
            if (commandHistory.Count > 0)
            {
                historyIndex = Math.Max(0, historyIndex - 1);
                ReplaceCurrentCommand(commandHistory[historyIndex]);
            }
            return;
        }
        if (e.KeyCode == Keys.Down)
        {
            e.SuppressKeyPress = true;
            if (commandHistory.Count > 0)
            {
                historyIndex = Math.Min(commandHistory.Count - 1, historyIndex + 1);
                ReplaceCurrentCommand(commandHistory[historyIndex]);
            }
            return;
        }
        if (e.KeyCode == Keys.Enter && !e.Shift)
        {
            e.SuppressKeyPress = true;
            string inputText = outputBox.Text.Substring(lastPromptIndex).Trim();
            bool flag = !commandHistory.Contains(inputText);
            if (string.IsNullOrEmpty(inputText)) flag = false;
            if (flag) commandHistory.Add(inputText);
            historyIndex = commandHistory.Count;
            ExecuteCommand(inputText);
        }
    }

    /// <summary>
    /// 替換當前命令為歷史命令。
    /// </summary>
    private void ReplaceCurrentCommand(string command)
    {
        outputBox.Select(lastPromptIndex, outputBox.Text.Length - lastPromptIndex);
        outputBox.SelectedText = command;
        outputBox.SelectionStart = outputBox.Text.Length;
    }

    /// <summary>
    /// 執行給定的 PowerShell 命令。
    /// </summary>
    /// <param name="command">要執行的命令。</param>
    public void ExecuteCommand(string command)
    {
        isCommandRunning = true;
        outputBox.ReadOnly = true;
        AppendOutput("");

        if (command.StartsWith("cd "))
        {
            currentPath = command.Substring(3).Trim();
            psInstance.Commands.Clear();
            psInstance.AddScript($"Set-Location '{currentPath}'").Invoke();
            AppendPrompt();
            isCommandRunning = false;
            outputBox.ReadOnly = false;
            OnCommandCompleted(new CommandCompletedEventArgs(true, null));
            return;
        }

        psInstance.Commands.Clear();
        psInstance.AddScript(command);

        var results = psInstance.Invoke();
        bool isSuccess = true;
        string errorMessage = null;

        foreach (var result in results)
        {
            AppendOutput(result.ToString());
        }

        if (psInstance.Streams.Error.Count > 0)
        {
            isSuccess = false;
            foreach (var error in psInstance.Streams.Error)
            {
                AppendErrorOutput("==>" + error.ToString());
                errorMessage = error.ToString();
            }
            psInstance.Streams.Error.Clear();
        }

        UpdateCurrentPath();
        isCommandRunning = false;
        outputBox.ReadOnly = false;
        OnCommandCompleted(new CommandCompletedEventArgs(isSuccess, errorMessage));
    }

    /// <summary>
    /// 執行給定的 PowerShell 命令並回傳結果。
    /// </summary>
    /// <param name="command">要執行的命令。</param>
    /// <returns>命令執行後的輸出。</returns>
    public string RunCommand(string command)
    {
        psInstance.Commands.Clear();
        psInstance.AddScript(command);

        var results = psInstance.Invoke();
        StringBuilder outputBuilder = new StringBuilder();

        foreach (var result in results)
        {
            outputBuilder.AppendLine(result.ToString());
        }

        if (psInstance.Streams.Error.Count > 0)
        {
            foreach (var error in psInstance.Streams.Error)
            {
                outputBuilder.AppendLine("==>" + error.ToString());
            }
            psInstance.Streams.Error.Clear();
        }

        return outputBuilder.ToString().Trim();
    }

    /// <summary>
    /// 更新當前工作目錄並顯示提示符。
    /// </summary>
    private void UpdateCurrentPath()
    {
        psInstance.Commands.Clear();
        psInstance.AddScript("Write-Host \"::PWD::$(Get-Location)\"");
        var results = psInstance.Invoke();
        foreach (var result in results)
        {
            string output = result.ToString();
            if (output.StartsWith("::PWD::"))
            {
                currentPath = output.Substring(7).Trim();
            }
        }
        AppendPrompt();
    }

    /// <summary>
    /// 添加正常輸出到 RichTextBox。
    /// </summary>
    private void AppendOutput(string text)
    {
        text = DetectEncodingAndConvert(text);
        text = text.Replace("\0", "");
        if (outputBox.InvokeRequired)
        {
            outputBox.Invoke(new Action(() => AppendOutput(text)));
        }
        else
        {
            outputBox.SelectionColor = ResultTextColor;
            outputBox.AppendText(text + Environment.NewLine);

            lastPromptIndex = outputBox.Text.Length;
            outputBox.SelectionStart = lastPromptIndex;
            outputBox.ScrollToCaret();
        }
    }

    /// <summary>
    /// 添加錯誤輸出到 RichTextBox。
    /// </summary>
    private void AppendErrorOutput(string text)
    {
        text = DetectEncodingAndConvert(text);
        text = text.Replace("\0", "");
        if (outputBox.InvokeRequired)
        {
            outputBox.Invoke(new Action(() => AppendErrorOutput(text)));
        }
        else
        {
            outputBox.SelectionColor = ErrorTextColor;
            outputBox.AppendText(text + Environment.NewLine);
            outputBox.SelectionStart = outputBox.Text.Length;
            lastPromptIndex = outputBox.Text.Length;
            outputBox.ScrollToCaret();
        }
    }

    /// <summary>
    /// 添加提示符到 RichTextBox。
    /// </summary>
    private void AppendPrompt()
    {
        if (outputBox.InvokeRequired)
        {
            outputBox.Invoke(new Action(() => AppendPrompt()));
        }
        else
        {
            outputBox.SelectionColor = Color.White;
            outputBox.AppendText($"PS {currentPath}> ");
            lastPromptIndex = outputBox.Text.Length;
            outputBox.SelectionStart = lastPromptIndex;
            outputBox.ScrollToCaret();
        }
    }

    /// <summary>
    /// 獲取 PowerShell 版本。
    /// </summary>
    /// <returns>PowerShell 版本字串。</returns>
    private string GetPowerShellVersion()
    {
        psInstance.Commands.Clear();
        psInstance.AddScript("$PSVersionTable.PSVersion");
        var results = psInstance.Invoke();
        return results.Count > 0 ? results[0].ToString().Trim() : "Unknown";
    }

    /// <summary>
    /// 判斷 PowerShell 回傳的編碼，並自動轉換 UTF-8 或 Unicode。
    /// </summary>
    /// <param name="rawData">原始資料。</param>
    /// <returns>轉換後的字串。</returns>
    private string DetectEncodingAndConvert(string rawData)
    {
        if (rawData == null) return "";
        byte[] rawBytes = Encoding.Unicode.GetBytes(rawData);

        // 嘗試用 UTF-8 解碼
        string utf8Decoded = Encoding.UTF8.GetString(rawBytes);
        if (utf8Decoded.Contains("�")) // 如果有錯誤字元，可能是 Unicode
        {
            return Encoding.Unicode.GetString(rawBytes);
        }

        return utf8Decoded;
    }

    /// <summary>
    /// 觸發 CommandCompleted 事件。
    /// </summary>
    /// <param name="e">事件參數。</param>
    protected virtual void OnCommandCompleted(CommandCompletedEventArgs e)
    {
        CommandCompleted?.Invoke(this, e);
    }
}

/// <summary>
/// 命令完成事件的參數類別。
/// </summary>
public class CommandCompletedEventArgs : EventArgs
{
    public bool IsSuccess { get; }
    public string ErrorMessage { get; }

    public CommandCompletedEventArgs(bool isSuccess, string errorMessage)
    {
        IsSuccess = isSuccess;
        ErrorMessage = errorMessage;
    }
}
