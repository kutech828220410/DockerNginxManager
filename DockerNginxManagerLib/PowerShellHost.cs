using System;
using System.Collections.Generic;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

public class PowerShellHost
{
    private PowerShell psInstance;
    private RichTextBox outputBox;
    private int lastPromptIndex;
    private string currentPath = @"C:\\Windows\\System32";
    private bool isCommandRunning = false;
    private List<string> commandHistory = new List<string>();
    private int historyIndex = -1;
    public Color ErrorTextColor { get; set; } = Color.Red;
    public Color ResultTextColor { get; set; } = Color.LightGray;
    public Color BackgroundColor { get; set; } = Color.MidnightBlue;

    public PowerShellHost(RichTextBox outputBox)
    {
        this.outputBox = outputBox;
        this.outputBox.KeyDown += OutputBox_KeyDown;
        this.outputBox.BackColor = BackgroundColor;
        this.outputBox.Font = new Font("Consolas", 12);
        psInstance = PowerShell.Create();
        psInstance.AddScript("[Console]::OutputEncoding = [System.Text.Encoding]::Unicode").Invoke();
        psInstance.AddScript("[Console]::InputEncoding = [System.Text.Encoding]::Unicode").Invoke();
        psInstance.AddScript($"Set-Location '{currentPath}'").Invoke();
        AppendOutput("Windows PowerShell");
        AppendOutput($"PowerShell Ver: {GetPowerShellVersion()} ");
        AppendOutput("");
        UpdateCurrentPath();
    }

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

    private void ReplaceCurrentCommand(string command)
    {
        outputBox.Select(lastPromptIndex, outputBox.Text.Length - lastPromptIndex);
        outputBox.SelectedText = command;
        outputBox.SelectionStart = outputBox.Text.Length;
    }

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
            return;
        }

        psInstance.Commands.Clear();
        psInstance.AddScript(command);

        var results = psInstance.Invoke();

        foreach (var result in results)
        {
            AppendOutput(result.ToString());
        }

        if (psInstance.Streams.Error.Count > 0)
        {
            foreach (var error in psInstance.Streams.Error)
            {
                AppendErrorOutput("==>" + error.ToString());
            }
            psInstance.Streams.Error.Clear();
        }

        UpdateCurrentPath();
        isCommandRunning = false;
        outputBox.ReadOnly = false;
    }

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

    private string GetPowerShellVersion()
    {
        psInstance.Commands.Clear();
        psInstance.AddScript("$PSVersionTable.PSVersion");
        var results = psInstance.Invoke();
        return results.Count > 0 ? results[0].ToString().Trim() : "Unknown";
    }
    /// <summary>
    /// 判斷 PowerShell 回傳的編碼，並自動轉換 UTF-8 或 Unicode
    /// </summary>
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
}
