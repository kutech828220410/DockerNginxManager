using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace DockerNginxManagerLib
{
    /// <summary>
    /// ��� Docker �M������T�C
    /// </summary>
    public class DockerImageInfo
    {
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
    public class DockerOperations
    {
        private readonly PowerShellHost powerShellHost;

        /// <summary>
        /// ��l�� DockerOperations ���O���s�������C
        /// </summary>
        /// <param name="powerShellHost">�Ω���� PowerShell �R�O�� PowerShellHost ��ҡC</param>
        public DockerOperations(PowerShellHost powerShellHost)
        {
            this.powerShellHost = powerShellHost;
        }

        /// <summary>
        /// ��ܸ�Ƨ��èϥθӸ�Ƨ����� Dockerfile �ظm Docker �M���C
        /// </summary>
        /// <param name="imageName">Docker �M���W�١C</param>
        /// <param name="imageVersion">Docker �M�������C</param>
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
        /// �ϥΫ��w���|���� Dockerfile �ظm Docker �M���C
        /// </summary>
        /// <param name="folderPath">Dockerfile �Ҧb����Ƨ����|�C</param>
        /// <param name="imageName">Docker �M���W�١C</param>
        /// <param name="imageVersion">Docker �M�������C</param>
        public void BuildDockerImage(string folderPath, string imageName, string imageVersion)
        {
            string command = $"docker build -t {imageName}:{imageVersion} {folderPath}";
            string result = powerShellHost.RunCommand(command);
            Console.WriteLine(result);
        }

        /// <summary>
        /// �x�s Docker �M������w�����|�C
        /// </summary>
        /// <param name="imageName">Docker �M���W�١C</param>
        /// <param name="savePath">�x�s���|�C</param>
        public void SaveDockerImage(string imageName, string savePath)
        {
            string command = $"docker save -o {savePath} {imageName}";
            string result = powerShellHost.RunCommand(command);
            Console.WriteLine(result);
        }

        /// <summary>
        /// �q���w�����|���J Docker �M���C
        /// </summary>
        /// <param name="imagePath">Docker �M�����|�C</param>
        public void LoadDockerImage(string imagePath)
        {
            string command = $"docker load -i {imagePath}";
            string result = powerShellHost.RunCommand(command);
            Console.WriteLine(result);
        }

        /// <summary>
        /// �C�X�Ҧ� Docker �M���C
        /// </summary>
        /// <returns>Docker �M����T���C��C</returns>
        public List<DockerImageInfo> ListAllDockerImages()
        {
            string command = "docker images --format \"{{.Repository}}|{{.Tag}}|{{.ID}}|{{.CreatedSince}}|{{.Size}}\"";
            string result = powerShellHost.RunCommand(command);
            Console.WriteLine(result);

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
    }

}
