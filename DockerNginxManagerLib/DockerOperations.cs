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

    /// <summary>
    /// ��� Docker �e���B��ѼơC
    /// </summary>
    public class DockerRunParameters
    {
        /// <summary>
        /// ����γ]�m Docker �e���������Ҧ��C
        /// </summary>
        public string Network { get; set; }
        /// <summary>
        /// ����γ]�m�O�_�H�����Ҧ��B��e���C
        /// </summary>
        public bool Detach { get; set; }
        /// <summary>
        /// ����γ]�m Docker �e�����W�١C
        /// </summary>
        public string ContainerName { get; set; }
        /// <summary>
        /// ����γ]�m Docker �e������M�g�C
        /// </summary>
        public string PortForward { get; set; }
        /// <summary>
        /// ����γ]�m Docker �e�������M�g�C��C
        /// </summary>
        public List<string> VolumeMappings { get; set; }
        /// <summary>
        /// ����γ]�m Docker �M�����W�١C
        /// </summary>
        public string ImageName { get; set; }
        /// <summary>
        /// ����γ]�m Docker �M�������ҡC
        /// </summary>
        public string ImageTag { get; set; }

        /// <summary>
        /// ��l�� DockerRunParameters ���O���s�������C
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
            var parts = command.Replace("`", "").Split(' '); // �����Ϥ޸�

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
        /// �s�W���M�g�� VolumeMappings �C��C
        /// </summary>
        /// <param name="windowsPath">Windows ���|�C</param>
        /// <param name="linuxPath">Linux ���|�C</param>
        public void AddVolumeMapping(string windowsPath, string linuxPath)
        {
            VolumeMappings.Add($"{windowsPath}:{linuxPath}");
        }
        /// <summary>
        /// �ͦ� Docker �R�O�r��C
        /// </summary>
        /// <returns>Docker �R�O�r��C</returns>
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
        /// �q Docker �R�O�r��ѪR DockerRunParameters�C
        /// </summary>
        /// <param name="command">Docker �R�O�r��C</param>
        /// <returns>DockerRunParameters ����C</returns>
  
    }

    /// <summary>
    /// DockerOperations ���O���ѤF�P Docker �������ާ@��k�C
    /// </summary>
    public class DockerOperations
    {
        private readonly PowerShellHost powerShellHost;

        /// <summary>
        /// ��l�� DockerOperations ���O���s�������C
        /// </summary>
        /// <param name="powerShellHost">PowerShellHost ��ҡA�Ω���� PowerShell �R�O�C</param>
        public DockerOperations(PowerShellHost powerShellHost)
        {
            this.powerShellHost = powerShellHost;
        }

        /// <summary>
        /// ��ܸ�Ƨ��úc�� Docker �M���C
        /// </summary>
        /// <param name="imageName">�M���W�١C</param>
        /// <param name="imageVersion">�M�������C</param>
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

        /// <summary>
        /// �c�� Docker �M���C
        /// </summary>
        /// <param name="folderPath">Dockerfile �Ҧb����Ƨ����|�C</param>
        /// <param name="imageName">�M���W�١C</param>
        /// <param name="imageVersion">�M�������C</param>
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
        /// ���� Docker �M���C
        /// </summary>
        /// <param name="imageName">�M���W�١C</param>
        /// <param name="imageTag">�M�����ҡC</param>
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
        /// �O�s Docker �M������w���|�C
        /// </summary>
        /// <param name="imageName">�M���W�١C</param>
        /// <param name="savePath">�O�s���|�C</param>
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
        /// �q���w���|�[�� Docker �M���C
        /// </summary>
        /// <param name="imagePath">�M�����|�C</param>
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
        /// �C�X�Ҧ� Docker �M���C
        /// </summary>
        /// <returns>DockerImageInfo ���C��C</returns>
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
        /// �C�X�Ҧ� Docker �e���C
        /// </summary>
        /// <returns>DockerContainerInfo ���C��C</returns>
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
        /// ���� Docker �e���C
        /// </summary>
        /// <param name="parameters">Docker �e���B��ѼơC</param>
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
