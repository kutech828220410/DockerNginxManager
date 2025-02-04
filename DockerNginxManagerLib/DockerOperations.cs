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
        /// �R�� Docker �e���C
        /// </summary>
        /// <param name="containerId">�e�� ID�C</param>
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
        /// ���� Docker �e���C
        /// </summary>
        /// <param name="parameters">Docker �e���B��ѼơC</param>
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
        /// ���� Docker �e���C
        /// </summary>
        /// <param name="containerId">�e�� ID�C</param>
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
        /// ���s�Ұ� Docker �e���C
        /// </summary>
        /// <param name="containerId">�e�� ID�C</param>
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
        /// �Ұ� Docker �e���C
        /// </summary>
        /// <param name="containerId">�e�� ID�C</param>
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
        /// �]�w Docker �e���}���۰ʱҰʡC
        /// </summary>
        /// <param name="containerId">�e�� ID�C</param>
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
