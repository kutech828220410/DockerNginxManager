using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace DockerNginxManagerLib
{
    /// <summary>
    /// 表示 Docker 映像的資訊。
    /// </summary>
    public class DockerImageInfo
    {
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
    public class DockerOperations
    {
        private readonly PowerShellHost powerShellHost;

        /// <summary>
        /// 初始化 DockerOperations 類別的新執行個體。
        /// </summary>
        /// <param name="powerShellHost">用於執行 PowerShell 命令的 PowerShellHost 實例。</param>
        public DockerOperations(PowerShellHost powerShellHost)
        {
            this.powerShellHost = powerShellHost;
        }

        /// <summary>
        /// 選擇資料夾並使用該資料夾中的 Dockerfile 建置 Docker 映像。
        /// </summary>
        /// <param name="imageName">Docker 映像名稱。</param>
        /// <param name="imageVersion">Docker 映像版本。</param>
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
        /// 使用指定路徑中的 Dockerfile 建置 Docker 映像。
        /// </summary>
        /// <param name="folderPath">Dockerfile 所在的資料夾路徑。</param>
        /// <param name="imageName">Docker 映像名稱。</param>
        /// <param name="imageVersion">Docker 映像版本。</param>
        public void BuildDockerImage(string folderPath, string imageName, string imageVersion)
        {
            string command = $"docker build -t {imageName}:{imageVersion} {folderPath}";
            string result = powerShellHost.RunCommand(command);
            Console.WriteLine(result);
        }

        /// <summary>
        /// 儲存 Docker 映像到指定的路徑。
        /// </summary>
        /// <param name="imageName">Docker 映像名稱。</param>
        /// <param name="savePath">儲存路徑。</param>
        public void SaveDockerImage(string imageName, string savePath)
        {
            string command = $"docker save -o {savePath} {imageName}";
            string result = powerShellHost.RunCommand(command);
            Console.WriteLine(result);
        }

        /// <summary>
        /// 從指定的路徑載入 Docker 映像。
        /// </summary>
        /// <param name="imagePath">Docker 映像路徑。</param>
        public void LoadDockerImage(string imagePath)
        {
            string command = $"docker load -i {imagePath}";
            string result = powerShellHost.RunCommand(command);
            Console.WriteLine(result);
        }

        /// <summary>
        /// 列出所有 Docker 映像。
        /// </summary>
        /// <returns>Docker 映像資訊的列表。</returns>
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
