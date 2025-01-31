using System;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace DockerManagerLib
{
    public class InstallationChecker
    {
        private readonly PowerShellHost powerShellHost;

        /// <summary>
        /// 初始化 InstallationChecker 類別的新執行個體。
        /// </summary>
        /// <param name="powerShellHost">用於執行 PowerShell 命令的 PowerShellHost 實例。</param>
        public InstallationChecker(PowerShellHost powerShellHost)
        {
            this.powerShellHost = powerShellHost;
        }

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

                var (output, error) = powerShellHost.ExecuteCommand(command);

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

                var (output, error) = powerShellHost.ExecuteCommand(command);

                return output;
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

                var (output, error) = powerShellHost.ExecuteCommand(command);

                return output.Contains("WSL 2");
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
                string command = $"{programName} {arguments}";

                var (output, error) = powerShellHost.ExecuteCommand(command);

                return !string.IsNullOrEmpty(output);
            }
            catch
            {
                return false;
            }
        }
    }
}
