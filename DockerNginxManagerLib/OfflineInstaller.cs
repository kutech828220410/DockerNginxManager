using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace DockerNginxManagerLib
{
    public class OfflineInstaller
    {
        private const string DistroName = "Ubuntu";

      
        /// <summary>
        /// 檢查 WSL Ubuntu 是否正在運行
        /// </summary>
        public bool IsUbuntuRunning()
        {
            string command = "wsl --list --verbose";
            string output;
            bool success = RunCommand(command, out output);

            if (success && output.Contains(DistroName))
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
            string output;
            bool success = RunCommand(command, out output);

            if (success)
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

                        RunCommand(createUserCmd, out output);
                        RunCommand(addToSudoCmd, out output);

                        Console.WriteLine($"✅ 使用者 {newUser} 已建立並加入 sudo 群組！");
                        Console.WriteLine($"⚡ 請手動編輯 `/etc/wsl.conf` 設為預設使用者，然後 `wsl --shutdown` 重啟 WSL。");
                    }
                }
            }
            else
            {
                Console.WriteLine($"❌ {DistroName} 啟動失敗，錯誤訊息：\n{output}");
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
            string output;
            bool success = RunCommand(command, out output);

            if (success)
                Console.WriteLine($"✅ {DistroName} 已成功卸載。");
            else
                Console.WriteLine($"❌ 卸載失敗，錯誤訊息：\n{output}");
        }

        /// <summary>
        /// 執行系統命令並回傳結果。
        /// </summary>
        private bool RunCommand(string command, out string output)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = $"/c {command}",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true,
                StandardOutputEncoding = Encoding.Unicode,
                StandardErrorEncoding = Encoding.Unicode
            };

            try
            {
                using (Process process = Process.Start(startInfo))
                {
                    string stdOutput = process.StandardOutput.ReadToEnd();
                    string errorOutput = process.StandardError.ReadToEnd();
                    process.WaitForExit();

                    stdOutput = stdOutput.Replace("\0", "").Trim();
                    errorOutput = errorOutput.Replace("\0", "").Trim();

                    if (process.ExitCode == 0)
                    {
                        output = stdOutput;
                        return true;
                    }
                    else
                    {
                        output = $"錯誤代碼：{process.ExitCode}\n錯誤訊息：{stdOutput}";
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                output = $"執行命令時發生錯誤：{ex.Message}";
                return false;
            }
        }
    }
}
