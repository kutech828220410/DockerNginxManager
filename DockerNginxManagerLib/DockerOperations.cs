using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using System.ComponentModel;
using Basic;

namespace DockerNginxManagerLib
{

 



  /// <summary>
    /// ��� Docker �M������T�C
    /// </summary>
    public class DockerImageInfo
    {
        /// <summary>
        /// ��� Docker �M�����ݩʡC
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
        /// ����γ]�m Docker �M�����x�s�w�W�١C
        /// </summary>
        public string Repository { get; set; }

        /// <summary>
        /// ����γ]�m Docker �M�������ҡC
        /// </summary>
        public string Tag { get; set; }

        /// <summary>
        /// ����γ]�m Docker �M���� ID�C
        /// </summary>
        public string ImageId { get; set; }

        /// <summary>
        /// ����γ]�m Docker �M�����إ߮ɶ��C
        /// </summary>
        public string Created { get; set; }

        /// <summary>
        /// ����γ]�m Docker �M�����j�p�C
        /// </summary>
        public string Size { get; set; }
     
    }

    /// <summary>
    /// ��� Docker �e������T�C
    /// </summary>
    public class DockerContainerInfo
    {
        [EnumDescription("DockerContainerAttributes")]
        public enum DockerContainerAttributes
        {
            [Description("�e��ID,VARCHAR,64,INDEX")]
            ContainerId,
            [Description("�W��,VARCHAR,100,NONE")]
            Name,
            [Description("�M��,VARCHAR,100,NONE")]
            Image,
            [Description("���A,VARCHAR,50,NONE")]
            Status,
            [Description("��,VARCHAR,50,NONE")]
            Ports,
        }
        /// <summary>
        /// ����γ]�m Docker �e���� ID�C
        /// </summary>
        public string ContainerId { get; set; }

        /// <summary>
        /// ����γ]�m Docker �e�����W�١C
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// ����γ]�m Docker �e�����M���C
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// ����γ]�m Docker �e�������A�C
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// ����γ]�m Docker �e������C
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
                    Console.WriteLine($"��ܪ���Ƨ�: {folderPath}");
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
