using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using System.ComponentModel;
using Basic;
using System.Linq; // Add this using directive
using System.IO;

namespace DockerManagerLib
{

    /// <summary>
    /// DockerOperations 類別提供了與 Docker 相關的操作方法。
    /// </summary>
    public class DockerOperations
    {
        private readonly PowerShellHost powerShellHost;

        /// <summary>
        /// 初始化 DockerOperations 類別的新執行個體。
        /// </summary>
        /// <param name="powerShellHost">PowerShellHost 實例，用於執行 PowerShell 命令。</param>
        public DockerOperations(PowerShellHost powerShellHost)
        {
            this.powerShellHost = powerShellHost;
        }

        /// <summary>
        /// 選擇資料夾並構建 Docker 映像。
        /// </summary>
        /// <param name="imageName">映像名稱。</param>
        /// <param name="imageVersion">映像版本。</param>
        public void SelectFolderAndBuildDockerImage(string imageName, string imageVersion)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string folderPath = folderDialog.SelectedPath;
                    Console.WriteLine($"選擇的資料夾: {folderPath}");
                    BuildDockerImage(folderPath, imageName, imageVersion);
                }
            }
        }

        /// <summary>
        /// 構建 Docker 映像。
        /// </summary>
        /// <param name="folderPath">Dockerfile 所在的資料夾路徑。</param>
        /// <param name="imageName">映像名稱。</param>
        /// <param name="imageVersion">映像版本。</param>
        public void BuildDockerImage(string folderPath, string imageName, string imageVersion)
        {
            string command = $"docker build -t {imageName}:{imageVersion} {folderPath}";
            var (result, error) = powerShellHost.ExecuteCommand(command);
            Console.WriteLine(result);
            if (!string.IsNullOrEmpty(error))
            {
                Console.WriteLine($"Error: {error}");
            }
        }

        /// <summary>
        /// 移除 Docker 映像。
        /// </summary>
        /// <param name="imageName">映像名稱。</param>
        /// <param name="imageTag">映像標籤。</param>
        public void RemoveDockerImage(string imageName, string imageTag)
        {
            string command = $"docker rmi {imageName}:{imageTag}";
            var (result, error) = powerShellHost.ExecuteCommand(command);
            Console.WriteLine(result);
            if (!string.IsNullOrEmpty(error))
            {
                Console.WriteLine($"Error: {error}");
            }
        }

        /// <summary>
        /// 保存 Docker 映像到指定路徑。
        /// </summary>
        /// <param name="imageName">映像名稱。</param>
        /// <param name="savePath">保存路徑。</param>
        public void SaveDockerImage(string imageName, string savePath)
        {
            string command = $"docker save -o {savePath} {imageName}";
            var (result, error) = powerShellHost.ExecuteCommand(command);
            Console.WriteLine(result);
            if (!string.IsNullOrEmpty(error))
            {
                Console.WriteLine($"Error: {error}");
            }
        }

        /// <summary>
        /// 從指定路徑加載 Docker 映像。
        /// </summary>
        /// <param name="imagePath">映像路徑。</param>
        public void LoadDockerImage(string imagePath)
        {
            string command = $"docker load -i {imagePath}";
            var (result, error) = powerShellHost.ExecuteCommand(command);
            Console.WriteLine(result);
            if (!string.IsNullOrEmpty(error))
            {
                Console.WriteLine($"Error: {error}");
            }
        }

        /// <summary>
        /// 列出所有 Docker 映像。
        /// </summary>
        /// <returns>DockerImageInfo 的列表。</returns>
        public List<DockerImageInfo> ListAllDockerImages()
        {
            string command = "docker images --format \"{{.Repository}}|{{.Tag}}|{{.ID}}|{{.CreatedSince}}|{{.Size}}\"";
            var (result, error) = powerShellHost.ExecuteCommand(command);
            if (!string.IsNullOrEmpty(error))
            {
                Console.WriteLine($"Error: {error}");
            }

            var images = new List<DockerImageInfo>();
            var lines = result.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var line in lines)
            {
                var parts = line.Split('|');
                if (parts.Length == 5)
                {
                    images.Add(new DockerImageInfo
                    {
                        GUID = $"{parts[0]}:{parts[1]}",
                        Repository = parts[0],
                        Tag = parts[1],
                        ImageId = parts[2],
                        Created = parts[3],
                        Size = parts[4]
                    }); 
                }
            }

            return images;
        }

        /// <summary>
        /// 列出所有 Docker 容器。
        /// </summary>
        /// <returns>DockerContainerInfo 的列表。</returns>
        public List<DockerContainerInfo> ListAllDockerContainers()
        {
            string command = "docker ps -a --format \"{{.ID}}|{{.Names}}|{{.Image}}|{{.Status}}|{{.Ports}}\"";
            var (result, error) = powerShellHost.ExecuteCommand(command);
            if (!string.IsNullOrEmpty(error))
            {
                Console.WriteLine($"Error: {error}");
            }

            var containers = new List<DockerContainerInfo>();
            var lines = result.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var line in lines)
            {
                var parts = line.Split('|');
                if (parts.Length == 5)
                {
                    var containerInfo = new DockerContainerInfo
                    {
                        ContainerId = parts[0],
                        Name = parts[1],
                        Image = parts[2],
                        Status = parts[3],
                        Ports = parts[4]
                    };

                    if (string.IsNullOrEmpty(containerInfo.Ports))
                    {
                        string inspectCommand = $"docker inspect --format='{{{{.HostConfig.NetworkMode}}}}' {containerInfo.ContainerId}";
                        var (inspectResult, inspectError) = powerShellHost.ExecuteCommand(inspectCommand);
                        if (string.IsNullOrEmpty(inspectError) && inspectResult.Trim() == "host")
                        {
                            string portsCommand = $"docker inspect --format='{{{{json .Config.ExposedPorts}}}}' {containerInfo.ContainerId}";
                            var (portsResult, portsError) = powerShellHost.ExecuteCommand(portsCommand);
                            if (string.IsNullOrEmpty(portsError) && portsResult.Trim() != "{}")
                            {

                                var exposedPorts = System.Text.Json.JsonSerializer.Deserialize<Dictionary<string, object>>(portsResult.Trim());
                                var tcpPorts = exposedPorts.Keys.Where(k => k.EndsWith("/tcp")).ToList();
                                containerInfo.Ports = string.Join(", ", tcpPorts);
                            }
                        }
                    }

                    containers.Add(containerInfo);
                }
            }

            return containers;
        }

        /// <summary>
        /// 刪除 Docker 容器。
        /// </summary>
        /// <param name="containerId">容器 ID。</param>
        public void RemoveDockerContainer(string containerId)
        {
            string command = $"docker rm -f {containerId}";
            var (result, error) = powerShellHost.ExecuteCommand(command);
            Console.WriteLine(result);
            if (!string.IsNullOrEmpty(error))
            {
                Console.WriteLine($"Error: {error}");
            }
        }

        /// <summary>
        /// 執行 Docker 容器。
        /// </summary>
        /// <param name="parameters">Docker 容器運行參數。</param>
        public void RunDockerContainer(DockerContainerParameters parameters)
        {
            string command = parameters.ToString();

            var (result, error) = powerShellHost.ExecuteCommand(command);
            Console.WriteLine(result);
            if (!string.IsNullOrEmpty(error))
            {
                Console.WriteLine($"Error: {error}");
            }
        }

        /// <summary>
        /// 停止 Docker 容器。
        /// </summary>
        /// <param name="containerId">容器 ID。</param>
        public void StopDockerContainer(string containerId)
        {
            string command = $"docker stop {containerId}";
            var (result, error) = powerShellHost.ExecuteCommand(command);
            Console.WriteLine(result);
            if (!string.IsNullOrEmpty(error))
            {
                Console.WriteLine($"Error: {error}");
            }
        }

        /// <summary>
        /// 重新啟動 Docker 容器。
        /// </summary>
        /// <param name="containerId">容器 ID。</param>
        public void RestartDockerContainer(string containerId)
        {
            string command = $"docker restart {containerId}";
            var (result, error) = powerShellHost.ExecuteCommand(command);
            Console.WriteLine(result);
            if (!string.IsNullOrEmpty(error))
            {
                Console.WriteLine($"Error: {error}");
            }
        }

        /// <summary>
        /// 啟動 Docker 容器。
        /// </summary>
        /// <param name="containerId">容器 ID。</param>
        public void StartDockerContainer(string containerId)
        {
            string command = $"docker start {containerId}";
            var (result, error) = powerShellHost.ExecuteCommand(command);
            Console.WriteLine(result);
            if (!string.IsNullOrEmpty(error))
            {
                Console.WriteLine($"Error: {error}");
            }
        }
        /// <summary>
        /// 設定 Docker 容器開機自動啟動。
        /// </summary>
        /// <param name="containerId">容器 ID。</param>
        public void SetContainerAutoStart(string containerId)
        {
            string command = $"docker update --restart always {containerId}";
            var (result, error) = powerShellHost.ExecuteCommand(command);
            Console.WriteLine(result);
            if (!string.IsNullOrEmpty(error))
            {
                Console.WriteLine($"Error: {error}");
            }
        }

    }


    
  

}
