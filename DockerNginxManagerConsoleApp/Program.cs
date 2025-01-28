using System;
using System.Diagnostics;
using System.Security.Principal;
using System.Text;
using DockerNginxManagerLib;
using System.Windows.Forms;
namespace DockerNginxManagerConsoleApp
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; // 設定主控台輸出 UTF-8

            Console.WriteLine(new string('=', 50));
            Console.WriteLine("🚀 Docker & WSL 設定檢查工具 🚀");
            Console.WriteLine(new string('=', 50));

            // 檢查是否以系統管理員身份運行
            if (!IsAdministrator())
            {
                Console.WriteLine("\n⚠️  此操作需要系統管理員權限。");
                Console.Write("是否以系統管理員身份重新啟動應用程式？(Y/N): ");
                var response = Console.ReadLine();
                if (response?.ToUpper() == "Y")
                {
                    try
                    {
                        var startInfo = new ProcessStartInfo
                        {
                            UseShellExecute = true,
                            WorkingDirectory = Environment.CurrentDirectory,
                            FileName = Process.GetCurrentProcess().MainModule.FileName,
                            Verb = "runas"
                        };

                        Process.Start(startInfo);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"❌ 無法提升權限。錯誤訊息：{ex.Message}");
                    }
                }
                return;
            }

            // 創建 RichTextBox 控制項
            RichTextBox outputBox = new RichTextBox();
            // 初始化 PowerShellHost
            PowerShellHost powerShellHost = new PowerShellHost(outputBox);
            // 初始化 InstallationChecker
            InstallationChecker checker = new InstallationChecker(powerShellHost);
            OfflineInstaller installer = new OfflineInstaller(powerShellHost);

            Console.WriteLine("\n=== [1] Docker 檢查 ===");
            bool isDockerInstalled = checker.IsDockerInstalled();
            Console.WriteLine($"✅ Docker 已安裝：{isDockerInstalled}");

            Console.WriteLine("\n=== [2] WSL 檢查 ===");
            bool isWslInstalled = checker.IsWslInstalled();
            Console.WriteLine($"✅ WSL 已安裝：{isWslInstalled}");

            if (isWslInstalled)
            {
                Console.WriteLine("\n=== [3] WSL 版本資訊 ===");
                string wslVersionInfo = checker.GetWslVersion();
                Console.WriteLine($"🔹 WSL 版本資訊：\n{wslVersionInfo}");

                bool isDefaultSet = checker.SetWslDefaultVersion2();
                Console.WriteLine($"✅ 預設 WSL 版本設定為 2：{isDefaultSet}");

                Console.WriteLine("\n=== [4] 檢查 Ubuntu 是否安裝 ===");
                string distributionName = "Ubuntu";
                bool isUbuntuInstalled = checker.IsWslDistributionInstalled(distributionName);
                Console.WriteLine($"✅ {distributionName} 已安裝：{isUbuntuInstalled}");

                Console.WriteLine("\n=== [5] 檢查 Ubuntu 是否運行 ===");
                if (!installer.IsUbuntuRunning())
                {
                    Console.Write($"⚠️  {distributionName} 未運行，是否現在啟動？(Y/N): ");
                    string startResponse = Console.ReadLine();
                    if (startResponse?.ToUpper() == "Y")
                    {
                        installer.StartUbuntuDistro();
                    }
                    else
                    {
                        Console.WriteLine("❌ Ubuntu 未啟動，請手動啟動。");
                    }
                }
                else
                {
                    Console.WriteLine($"✅ {distributionName} 已在運行中。");
                }
            }
            else
            {
                Console.WriteLine("\n❌ WSL 未安裝，無法繼續。");
            }

            Console.WriteLine(new string('=', 50));
            Console.WriteLine("🎉 設定檢查完成！請確認所有訊息是否正確 🎉");
            Console.WriteLine(new string('=', 50));

            Console.ReadKey();
        }

        static bool IsAdministrator()
        {
            var identity = WindowsIdentity.GetCurrent();
            var principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }
    }
}
