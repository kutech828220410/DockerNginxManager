using System;

namespace DockerNginxManagerConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // 建立 InstallationChecker 的實例
            InstallationChecker checker = new InstallationChecker();

            // 檢查 Docker 是否已安裝
            bool isDockerInstalled = checker.IsDockerInstalled();
            Console.WriteLine($"Docker 已安裝：{isDockerInstalled}");

            // 檢查 WSL 是否已安裝
            bool isWslInstalled = checker.IsWslInstalled();
            Console.WriteLine($"WSL 已安裝：{isWslInstalled}");

            // 如果 WSL 已安裝，檢查特定的 WSL 發行版本（例如 Ubuntu-24.04）是否已安裝
            if (isWslInstalled)
            {
                string distributionName = "Ubuntu-24.04";
                bool isUbuntuInstalled = checker.IsWslDistributionInstalled(distributionName);
                Console.WriteLine($"{distributionName} 已安裝：{isUbuntuInstalled}");
            }
            else
            {
                Console.WriteLine("WSL 未安裝，無法檢查特定的發行版本。");
            }
            Console.ReadKey();
        }
    }
}
