using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using System.ComponentModel;
using Basic;
using System.Linq; // Add this using directive

namespace DockerNginxManagerLib
{

 



    /// <summary>
    /// 表示 Docker 映像的資訊。
    /// </summary>
    public class DockerImageInfo
    {
        /// <summary>
        /// 表示 Docker 映像的屬性。
        /// </summary>
        [EnumDescription("DockerImageAttributes")]
        public enum DockerImageAttributes
        {
            [Description("Repository,VARCHAR,100,INDEX")]
            Repository,
            [Description("Tag,VARCHAR,50,NONE")]
            Tag,
            [Description("ImageId,VARCHAR,64,NONE")]
            ImageId,
            [Description("Created,VARCHAR,50,NONE")]
            Created,
            [Description("Size,VARCHAR,20,NONE")]
            Size,
        }
        /// <summary>
        /// 獲取或設置 Docker 映像的儲存庫名稱。
        /// </summary>
        public string Repository { get; set; }

        /// <summary>
        /// 獲取或設置 Docker 映像的標籤。
        /// </summary>
        public string Tag { get; set; }

        /// <summary>
        /// 獲取或設置 Docker 映像的 ID。
        /// </summary>
        public string ImageId { get; set; }

        /// <summary>
        /// 獲取或設置 Docker 映像的建立時間。
        /// </summary>
        public string Created { get; set; }

        /// <summary>
        /// 獲取或設置 Docker 映像的大小。
        /// </summary>
        public string Size { get; set; }                
    }

    /// <summary>
    /// 表示 Docker 容器的資訊。
    /// </summary>
    public class DockerContainerInfo
    {
        [EnumDescription("DockerContainerAttributes")]
        public enum DockerContainerAttributes
        {
            [Description("Name,VARCHAR,100,NONE")]
            Name,
            [Description("ContainerId,VARCHAR,64,INDEX")]
            ContainerId,      
            [Description("Image,VARCHAR,100,NONE")]
            Image,
            [Description("Ports,VARCHAR,50,NONE")]
            Ports,
            [Description("Status,VARCHAR,50,NONE")]
            Status,        
        }
        /// <summary>
        /// 獲取或設置 Docker 容器的 ID。
        /// </summary>
        public string ContainerId { get; set; }

        /// <summary>
        /// 獲取或設置 Docker 容器的名稱。
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 獲取或設置 Docker 容器的映像。
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// 獲取或設置 Docker 容器的狀態。
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// 獲取或設置 Docker 容器的埠。
        /// </summary>
        public string Ports { get; set; }
    }

    /// <summary>
    /// 表示 Docker 容器運行參數。
    /// </summary>
    public class DockerRunParameters
    {
        /// <summary>
        /// 獲取或設置 Docker 容器的網路模式。
        /// </summary>
        public string Network { get; set; }
        /// <summary>
        /// 獲取或設置是否以分離模式運行容器。
        /// </summary>
        public bool Detach { get; set; }
        /// <summary>
        /// 獲取或設置 Docker 容器的名稱。
        /// </summary>
        public string ContainerName { get; set; }
        /// <summary>
        /// 獲取或設置 Docker 容器的埠映射。
        /// </summary>
        public string PortForward { get; set; }
        /// <summary>
        /// 獲取或設置 Docker 容器的卷映射列表。
        /// </summary>
        public List<string> VolumeMappings { get; set; }
        /// <summary>
        /// 獲取或設置 Docker 映像的名稱。
        /// </summary>
        public string ImageName { get; set; }
        /// <summary>
        /// 獲取或設置 Docker 映像的標籤。
        /// </summary>
        public string ImageTag { get; set; }

        /// <summary>
        /// 初始化 DockerRunParameters 類別的新執行個體。
        /// </summary>
        public DockerRunParameters()
        {
            VolumeMappings = new List<string>();
        }
        public DockerRunParameters(string command)
        {
            VolumeMappings = new List<string>();
            command = command.Replace("\r", "");
            command = command.Replace("\n", "");
            var parts = command.Replace("`", "").Split(' '); // 移除反引號

            for (int i = 0; i < parts.Length; i++)
            {
                switch (parts[i])
                {
                    case "--network":
                        this.Network = parts[++i];
                        break;
                    case "-d":
                        this.Detach = true;
                        break;
                    case "--name":
                        this.ContainerName = parts[++i];
                        break;
                    case "-p":
                        this.PortForward = parts[++i];
                        break;
                    case "-v":
                        this.VolumeMappings.Add(parts[++i]);
                        break;
                    default:
                        if (parts[i].StartsWith("docker run"))
                        {
                            continue;
                        }
                        if (parts[i].Contains(":"))
                        {
                            var imageParts = parts[i].Split(':');
                            this.ImageName = imageParts[0];
                            this.ImageTag = imageParts.Length > 1 ? imageParts[1] : "latest";
                        }
                        break;
                }
            }
        }
        /// <summary>
        /// 新增卷映射到 VolumeMappings 列表。
        /// </summary>
        /// <param name="windowsPath">Windows 路徑。</param>
        /// <param name="linuxPath">Linux 路徑。</param>
        public void AddVolumeMapping(string windowsPath, string linuxPath)
        {
            VolumeMappings.Add($"{windowsPath}:{linuxPath}");
        }
        /// <summary>
        /// 生成 Docker 命令字串。
        /// </summary>
        /// <returns>Docker 命令字串。</returns>
        public override string ToString()
        {
            var volumeMappings = string.Join(" ", VolumeMappings.Select(v => $"-v {v}"));
            var networkOption = string.IsNullOrEmpty(Network) ? "" : $"--network {Network} ";
            return $"docker run {networkOption}" +
                   $"{(Detach ? "-d" : "")} " +
                   $"--name {ContainerName} " +
                   $"-p {PortForward} " +
                   $"{volumeMappings} " +
                   $"{ImageName}:{ImageTag}";
        }

        /// <summary>
        /// 從 Docker 命令字串解析 DockerRunParameters。
        /// </summary>
        /// <param name="command">Docker 命令字串。</param>
        /// <returns>DockerRunParameters 物件。</returns>
  
    }

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
        /// 執行 Docker 容器。
        /// </summary>
        /// <param name="parameters">Docker 容器運行參數。</param>
        public void RunDockerContainer(DockerRunParameters parameters)
        {
            string command = parameters.ToString();

            var (result, error) = powerShellHost.ExecuteCommand(command);
            Console.WriteLine(result);
            if (!string.IsNullOrEmpty(error))
            {
                Console.WriteLine($"Error: {error}");
            }
        }

    }

    
  

}
