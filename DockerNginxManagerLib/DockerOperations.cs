using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using System.ComponentModel;
using Basic;

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
            [Description("容器ID,VARCHAR,64,INDEX")]
            ContainerId,
            [Description("名稱,VARCHAR,100,NONE")]
            Name,
            [Description("映像,VARCHAR,100,NONE")]
            Image,
            [Description("狀態,VARCHAR,50,NONE")]
            Status,
            [Description("埠,VARCHAR,50,NONE")]
            Ports,
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
    public class DockerOperations
    {
        private readonly PowerShellHost powerShellHost;

        public DockerOperations(PowerShellHost powerShellHost)
        {
            this.powerShellHost = powerShellHost;
        }

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

        public List<DockerImageInfo> ListAllDockerImages()
        {
            string command = "docker images --format \"{{.Repository}}|{{.Tag}}|{{.ID}}|{{.CreatedSince}}|{{.Size}}\"";
            var (result, error) = powerShellHost.ExecuteCommand(command);
            //Console.WriteLine(result);
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

        public List<DockerContainerInfo> ListAllDockerContainers()
        {
            string command = "docker ps --format \"{{.ID}}|{{.Names}}|{{.Image}}|{{.Status}}|{{.Ports}}\"";
            var (result, error) = powerShellHost.ExecuteCommand(command);
            //Console.WriteLine(result);
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
                    containers.Add(new DockerContainerInfo
                    {
                        ContainerId = parts[0],
                        Name = parts[1],
                        Image = parts[2],
                        Status = parts[3],
                        Ports = parts[4]
                    });
                }
            }

            return containers;
        }
    }

}
