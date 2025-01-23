using System;
using System.Diagnostics;
using System.Text;

public class InstallationChecker
{
    /// <summary>
    /// 檢查系統是否已安裝 Docker。
    /// </summary>
    /// <returns>如果已安裝則返回 true，否則返回 false。</returns>
    public bool IsDockerInstalled()
    {
        return IsProgramInstalled("docker", "--version");
    }

    /// <summary>
    /// 檢查系統是否已安裝 WSL。
    /// </summary>
    /// <returns>如果已安裝則返回 true，否則返回 false。</returns>
    public bool IsWslInstalled()
    {
        return IsProgramInstalled("wsl", "--list --quiet");
    }

    /// <summary>
    /// 檢查系統是否已安裝特定的 WSL 發行版本（例如 Ubuntu）。
    /// </summary>
    /// <param name="distributionName">發行版本名稱，例如 "Ubuntu"</param>
    /// <returns>如果已安裝則返回 true，否則返回 false。</returns>
    public bool IsWslDistributionInstalled(string distributionName)
    {
        try
        {
            // 設定 PowerShell 腳本，將輸出編碼設定為 UTF-8，然後執行 wsl 命令
            string psScript = $"[Console]::OutputEncoding = [Text.Encoding]::UTF8; wsl --list --verbose";

            // 設定 ProcessStartInfo
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments = $"-NoProfile -Command \"{psScript}\"",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true,
                StandardOutputEncoding = Encoding.UTF8 // 設定輸出編碼為 UTF-8
            };

            using (Process process = Process.Start(startInfo))
            {
                string output = process.StandardOutput.ReadToEnd();
                output = output.Replace("\0", "");
                process.WaitForExit();
                // 檢查輸出中是否包含指定的發行版本名稱
                return output.IndexOf(distributionName, StringComparison.OrdinalIgnoreCase) >= 0;
            }
        }
        catch
        {
            return false;
        }
    }

    /// <summary>
    /// 通用方法：檢查系統是否已安裝指定的程式。
    /// </summary>
    /// <param name="programName">程式名稱</param>
    /// <param name="arguments">檢查版本的參數</param>
    /// <returns>如果已安裝則返回 true，否則返回 false。</returns>
    private bool IsProgramInstalled(string programName, string arguments)
    {
        try
        {
            // 設定 PowerShell 腳本，將輸出編碼設定為 UTF-8，然後執行指定的命令
            string psScript = $"[Console]::OutputEncoding = [Text.Encoding]::UTF8; {programName} {arguments}";

            // 設定 ProcessStartInfo
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments = $"-NoProfile -Command \"{psScript}\"",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true,
                StandardOutputEncoding = Encoding.UTF8 // 設定輸出編碼為 UTF-8
            };

            using (Process process = Process.Start(startInfo))
            {
                string output = process.StandardOutput.ReadToEnd();
                output = output.Replace("\0", "");
                process.WaitForExit();
                return process.ExitCode == 0;
            }
        }
        catch
        {
            return false;
        }
    }
}
