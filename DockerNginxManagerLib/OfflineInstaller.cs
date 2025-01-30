using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace DockerNginxManagerLib
{
    public class OfflineInstaller
    {
        private const string DistroName = "Ubuntu";
        private readonly PowerShellHost powerShellHost;

        /// <summary>
        /// 初始化 OfflineInstaller 類別的新執行個體。
        /// </summary>
        /// <param name="powerShellHost">用於執行 PowerShell 命令的 PowerShellHost 實例。</param>
        public OfflineInstaller(PowerShellHost powerShellHost)
        {
            this.powerShellHost = powerShellHost;
        }

        /// <summary>
        /// 檢查 WSL Ubuntu 是否正在運行
        /// </summary>
        public bool IsUbuntuRunning()
        {
            string command = "wsl --list --verbose";
            var (output, error) = powerShellHost.ExecuteCommand(command);

            if (output.Contains(DistroName))
            {
                string[] lines = output.Split('\n');
                foreach (string line in lines)
                {
                    if (line.Contains(DistroName) && line.Contains("Running"))
                    {
                        Console.WriteLine($"✅ {DistroName} 正在運行中。");
                        return true;
                    }
                }
            }

            Console.WriteLine($"❌ {DistroName} 未運行。");
            return false;
        }

        /// <summary>
        /// 啟動 WSL Ubuntu
        /// </summary>
        public void StartUbuntuDistro()
        {
            Console.WriteLine($"🔄 正在啟動 {DistroName} ...");

            string command = $"wsl -d {DistroName} -u root";
            var (output, error) = powerShellHost.ExecuteCommand(command);

            if (!string.IsNullOrEmpty(output))
            {
                Console.WriteLine($"✅ {DistroName} 已以 root 身份啟動。");

                Console.Write("\n⚠️ 檢測到 WSL 無使用者，是否建立新的 WSL 使用者？(Y/N): ");
                string response = Console.ReadLine();
                if (response?.ToUpper() == "Y")
                {
                    Console.Write("請輸入新的 WSL 使用者名稱（例如 ubuntuuser）：");
                    string newUser = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(newUser))
                    {
                        string createUserCmd = $"wsl -d {DistroName} -u root -- adduser {newUser}";
                        string addToSudoCmd = $"wsl -d {DistroName} -u root -- usermod -aG sudo {newUser}";

                        powerShellHost.ExecuteCommand(createUserCmd);
                        powerShellHost.ExecuteCommand(addToSudoCmd);

                        Console.WriteLine($"✅ 使用者 {newUser} 已建立並加入 sudo 群組！");
                        Console.WriteLine($"⚡ 請手動編輯 `/etc/wsl.conf` 設為預設使用者，然後 `wsl --shutdown` 重啟 WSL。");
                    }
                }
            }
            else
            {
                Console.WriteLine($"❌ {DistroName} 啟動失敗，錯誤訊息：\n{error}");
            }
        }

        /// <summary>
        /// 卸載 WSL Ubuntu
        /// </summary>
        public void UninstallUbuntuDistro()
        {
            Console.Write($"⚠️ 確定要卸載 {DistroName} 嗎？(Y/N): ");
            string response = Console.ReadLine();
            if (response?.ToUpper() != "Y")
            {
                Console.WriteLine("❌ 卸載已取消。");
                return;
            }

            string command = $"wsl --unregister {DistroName}";
            var (output, error) = powerShellHost.ExecuteCommand(command);

            if (!string.IsNullOrEmpty(output))
                Console.WriteLine($"✅ {DistroName} 已成功卸載。");
            else
                Console.WriteLine($"❌ 卸載失敗，錯誤訊息：\n{error}");
        }
    }
}
