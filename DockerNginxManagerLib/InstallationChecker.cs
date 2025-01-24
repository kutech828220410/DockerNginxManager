using System;
using System.Diagnostics;
using System.Text;

namespace DockerNginxManagerLib
{
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
                string command = "wsl --list --verbose";

                string output = RunCommand(command);

                return output.IndexOf(distributionName, StringComparison.OrdinalIgnoreCase) >= 0;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 取得目前 WSL 的版本資訊。
        /// </summary>
        /// <returns>WSL 版本資訊的字串。</returns>
        public string GetWslVersion()
        {
            try
            {
                string command = "wsl --version";

                return RunCommand(command);
            }
            catch (Exception ex)
            {
                return $"取得 WSL 版本資訊時發生錯誤：{ex.Message}";
            }
        }

        /// <summary>
        /// 設定預設的 WSL 版本為 2。
        /// </summary>
        /// <returns>如果設定成功則返回 true，否則返回 false。</returns>
        public bool SetWslDefaultVersion2()
        {
            try
            {
                string command = "wsl --set-default-version 2";

                string output = RunCommand(command);

                return output.Contains("WSL 2");
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 執行系統命令並回傳結果。
        /// </summary>
        /// <param name="command">要執行的命令。</param>
        /// <returns>命令執行後的輸出。</returns>
        private string RunCommand(string command)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = $"/c {command}",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true,
                StandardOutputEncoding = Encoding.Unicode
            };

            using (Process process = Process.Start(startInfo))
            {
                string output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();
               
                output = output.Replace("\0", "").Trim(); // 移除空字元與首尾空格
                return output;
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
                string command = $"{programName} {arguments}";

                string output = RunCommand(command);

                return !string.IsNullOrEmpty(output);
            }
            catch
            {
                return false;
            }
        }
    }
}
