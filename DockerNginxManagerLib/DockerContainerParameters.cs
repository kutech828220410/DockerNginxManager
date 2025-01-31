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
    /// 表示 Docker 容器運行參數。
    /// </summary>
    public class DockerContainerParameters
    {
        public enum DefaultDockerContainers
        {
            Nginx,
            Redis,
            MySQL,
            Postgres
        }
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
        /// 初始化 DockerContainerParameters 類別的新執行個體。
        /// </summary>
        public DockerContainerParameters()
        {
            VolumeMappings = new List<string>();
        }
        public DockerContainerParameters(string command)
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
        public void AddVolumeMapping(string windowsPath, string linuxPath, bool readOnly = false)
        {
            string volumeMapping = readOnly ? $"{windowsPath}:{linuxPath}:ro" : $"{windowsPath}:{linuxPath}";
            VolumeMappings.Add(volumeMapping);
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


        static public DockerContainerParameters GetDefaultDockerContainerParameters(string container)
        {
            if (Enum.TryParse(container, true, out DefaultDockerContainers parsedContainer))
            {
                return GetDefaultDockerContainerParameters(parsedContainer);
            }
            else
            {
                throw new ArgumentException($"Invalid container name: {container}", nameof(container));
            }
        }

        /// <summary>
        /// 從 Docker 命令字串解析 DockerContainerParameters。
        /// </summary>
        /// <param name="command">Docker 命令字串。</param>
        /// <returns>DockerContainerParameters 物件。</returns>
        static public DockerContainerParameters GetDefaultDockerContainerParameters(DefaultDockerContainers container)
        {
            switch (container)
            {
                case DefaultDockerContainers.Nginx:
                    return new DockerContainerParameters
                    {
                        ImageName = "nginx",
                        ImageTag = "a1",
                        ContainerName = "nginx-container",
                        PortForward = "443",
                        Detach = true,
                        Network = "host",
                        VolumeMappings = new List<string>
                        {
                            "/C/Nginx/cert.key:/etc/nginx/ssl/cert.key:ro",
                            "/C/Nginx/full_chain.crt:/etc/nginx/ssl/full_chain.crt:ro" ,
                            "/C/Nginx/nginx.conf:/etc/nginx/conf.d/default.conf:ro",
                            "/C/Nginx/nginx_core.conf:/etc/nginx/nginx.conf:ro",
                            "/C/Nginx/sysctl.conf:/etc/sysctl.conf:ro"
                        }
                    };
                case DefaultDockerContainers.Redis:
                    return new DockerContainerParameters
                    {
                        ImageName = "redis",
                        ImageTag = "latest",
                        ContainerName = "redis-container",
                        PortForward = "6379:6379",
                        Detach = true
                    };
                case DefaultDockerContainers.MySQL:
                    return new DockerContainerParameters
                    {
                        ImageName = "mysql",
                        ImageTag = "latest",
                        ContainerName = "mysql-container",
                        PortForward = "3306:3306",
                        Detach = true
                    };
                case DefaultDockerContainers.Postgres:
                    return new DockerContainerParameters
                    {
                        ImageName = "postgres",
                        ImageTag = "latest",
                        ContainerName = "postgres-container",
                        PortForward = "5432:5432",
                        Detach = true
                    };
                default:
                    throw new ArgumentOutOfRangeException(nameof(container), container, null);
            }
        }

        /// <summary>
        /// 讀取指定資料夾內的所有 TXT 檔案，並返回檔名及內容。
        /// </summary>
        /// <param name="folderPath">資料夾路徑。</param>
        /// <returns>包含檔名及內容的字典。</returns>
        static public Dictionary<string, string> ReadTxtFilesInFolder(string folderPath)
        {
            var result = new Dictionary<string, string>();

            if (Directory.Exists(folderPath))
            {
                var txtFiles = Directory.GetFiles(folderPath, "*.txt");
                foreach (var file in txtFiles)
                {
                    string fileName = Path.GetFileNameWithoutExtension(file); // 只獲取檔名，不包含副檔名
                    string content = File.ReadAllText(file);
                    result.Add(fileName, content);
                }
            }
            else
            {
                Console.WriteLine($"資料夾不存在: {folderPath}");
            }

            return result;
        }
        /// <param name="command">Docker 命令字串。</param>
        /// <returns>如果命令合法，返回 true；否則返回 false。</returns>
        static public bool IsValidDockerCommand(string command)
        {
            if (string.IsNullOrWhiteSpace(command))
            {
                return false;
            }

            var requiredParts = new[] { "docker", "run", "--name", "-p", "-v" };
            foreach (var part in requiredParts)
            {
                if (!command.Contains(part))
                {
                    return false;
                }
            }

            return true;
        }
    }

}
