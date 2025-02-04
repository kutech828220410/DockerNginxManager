using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Basic;
using DockerManagerLib;
using NginxManagerLib;
using MyUI;
namespace DockerTools
{
    partial class Form1 : Form
    {
        private DockerOperations dockerOperations;
        private PowerShellHost psHost;
        private MyThread myThread_refreshDockerImages;
        private MyThread myThread_refreshDockerContainers;
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            psHost = new PowerShellHost(richTextBox_powershell);

            saveFileDialog.Filter = "Tar files (*.tar)|*.tar";
            saveFileDialog.DefaultExt = "tar";
            openFileDialog.Filter = "Tar files (*.tar)|*.tar";
            openFileDialog.DefaultExt = "tar";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadingForm.form = this.FindForm();
            MyMessageBox.form = this.FindForm();
            MyMessageBox.音效 = false;

            this.sqL_DataGridView_Docker_Images.RowsHeight = 50;
            this.sqL_DataGridView_Docker_Images.Init(new SQLUI.Table(new DockerImageInfo.DockerImageAttributes()));
            this.sqL_DataGridView_Docker_Images.Set_ColumnWidth(200, DataGridViewContentAlignment.MiddleCenter, DockerImageInfo.DockerImageAttributes.Repository);
            this.sqL_DataGridView_Docker_Images.Set_ColumnWidth(100, DataGridViewContentAlignment.MiddleCenter, DockerImageInfo.DockerImageAttributes.Tag);
            this.sqL_DataGridView_Docker_Images.Set_ColumnWidth(150, DataGridViewContentAlignment.MiddleCenter, DockerImageInfo.DockerImageAttributes.ImageId);
            this.sqL_DataGridView_Docker_Images.Set_ColumnWidth(150, DataGridViewContentAlignment.MiddleCenter, DockerImageInfo.DockerImageAttributes.Created);
            this.sqL_DataGridView_Docker_Images.Set_ColumnWidth(100, DataGridViewContentAlignment.MiddleCenter, DockerImageInfo.DockerImageAttributes.Size);
            this.sqL_DataGridView_Docker_Images.Set_ColumnVisible(false, DockerImageInfo.DockerImageAttributes.GUID);
            this.sqL_DataGridView_Docker_Images.Set_ColumnVisible(false, DockerImageInfo.DockerImageAttributes.Size);

            this.sqL_DataGridView_Docker_Containers.RowsHeight = 50;
            this.sqL_DataGridView_Docker_Containers.Init(new SQLUI.Table(new DockerContainerInfo.DockerContainerAttributes()));
            this.sqL_DataGridView_Docker_Containers.Set_ColumnWidth(200, DataGridViewContentAlignment.MiddleCenter, DockerContainerInfo.DockerContainerAttributes.ContainerId);
            this.sqL_DataGridView_Docker_Containers.Set_ColumnWidth(200, DataGridViewContentAlignment.MiddleCenter, DockerContainerInfo.DockerContainerAttributes.Image);
            this.sqL_DataGridView_Docker_Containers.Set_ColumnWidth(200, DataGridViewContentAlignment.MiddleCenter, DockerContainerInfo.DockerContainerAttributes.Name);
            this.sqL_DataGridView_Docker_Containers.Set_ColumnWidth(100, DataGridViewContentAlignment.MiddleCenter, DockerContainerInfo.DockerContainerAttributes.Ports);
            this.sqL_DataGridView_Docker_Containers.Set_ColumnWidth(200, DataGridViewContentAlignment.MiddleCenter, DockerContainerInfo.DockerContainerAttributes.Status);
            this.sqL_DataGridView_Docker_Containers.Set_ColumnVisible(false, DockerContainerInfo.DockerContainerAttributes.ContainerId);

            ToolStripMenuItem_檢查環境.Click += ToolStripMenuItem_檢查環境_Click;
            ToolStripMenuItem_nginx配置生成.Click += ToolStripMenuItem_nginx配置生成_Click;

            ToolStripMenuItem_PFX_to_PEM.Click += ToolStripMenuItem_PFX_to_PEM_Click;

            rJ_Button_docker_add_image.MouseDownEvent += RJ_Button_docker_add_image_MouseDownEvent;
            rJ_Button_docker_delete_image.MouseDownEvent += RJ_Button_docker_delete_image_MouseDownEvent;
            rJ_Button_docker_download_image.MouseDownEvent += RJ_Button_docker_download_image_MouseDownEvent;
            rJ_Button_docker_upload_image.MouseDownEvent += RJ_Button_docker_upload_image_MouseDownEvent;


            rJ_Button_docker_add_container.MouseDownEvent += RJ_Button_docker_add_container_MouseDownEvent;
            rJ_Button_docker_remove_container.MouseDownEvent += RJ_Button_docker_remove_container_MouseDownEvent;
            rJ_Button_docker_run_container.MouseDownEvent += RJ_Button_docker_run_container_MouseDownEvent;
            rJ_Button_docker_stop_container.MouseDownEvent += RJ_Button_docker_stop_container_MouseDownEvent;
            rJ_Button_docker_restart_container.MouseDownEvent += RJ_Button_docker_restart_container_MouseDownEvent;


            myThread_refreshDockerImages = new MyThread();
            myThread_refreshDockerImages.AutoRun(true);
            myThread_refreshDockerImages.SetSleepTime(500);
            myThread_refreshDockerImages.Add_Method(() =>
            {
                PowerShellHost psHost_t = new PowerShellHost();
                DockerOperations dockerOperations = new DockerOperations(psHost_t);
                List<DockerImageInfo> dockerImageInfos = dockerOperations.ListAllDockerImages();
                List<object[]> list_value = dockerImageInfos.ClassToSQL<DockerImageInfo, DockerImageInfo.DockerImageAttributes>();
                this.sqL_DataGridView_Docker_Images.RefreshGridByUpdate(list_value);
                psHost_t.Close();
            });


            myThread_refreshDockerContainers = new MyThread();
            myThread_refreshDockerContainers.AutoRun(true);
            myThread_refreshDockerContainers.SetSleepTime(500);
            myThread_refreshDockerContainers.Add_Method(() =>
            {
                PowerShellHost psHost_t = new PowerShellHost();
                DockerOperations dockerOperations = new DockerOperations(psHost_t);
                List<DockerContainerInfo> dockerContainerInfos = dockerOperations.ListAllDockerContainers();
                List<object[]> list_value = dockerContainerInfos.ClassToSQL<DockerContainerInfo, DockerContainerInfo.DockerContainerAttributes>();
                this.sqL_DataGridView_Docker_Containers.RefreshGridByUpdate(list_value);
                psHost_t.Close();
            });
            myThread_refreshDockerImages.Trigger();

        }

        private void ToolStripMenuItem_PFX_to_PEM_Click(object sender, EventArgs e)
        {
            Dialog_PFX_to_PEM dialog_PFX_To_PEM = new Dialog_PFX_to_PEM();
            dialog_PFX_To_PEM.ShowDialog();
        }
        private void ToolStripMenuItem_nginx配置生成_Click(object sender, EventArgs e)
        {
           Dialog_set_naginx_conf dialog_Set_Naginx_Conf = new Dialog_set_naginx_conf();
            dialog_Set_Naginx_Conf.ShowDialog();
        }
        private void ToolStripMenuItem_檢查環境_Click(object sender, EventArgs e)
        {
            NginxParameters nginxParameters = new NginxParameters();
            nginxParameters.UseHttp = false;
            string str = nginxParameters.ToString();

            string msg = "";
            InstallationChecker installationChecker = new InstallationChecker(psHost);
            bool flag_IsDockerInstalled = installationChecker.IsDockerInstalled();
            bool flag_IsWslInstalled = installationChecker.IsWslInstalled();
            bool flag_IsUbuntuInstalled = installationChecker.IsWslDistributionInstalled("Ubuntu");
            installationChecker.GetWslVersion();
            msg += $"{(flag_IsDockerInstalled ? " Docker 已安裝" : "Docker 未安裝")}\n";
            msg += $"{(flag_IsWslInstalled ? " WSL 已安裝" : "WSL 未安裝")}\n";
            msg += $"{(flag_IsUbuntuInstalled ? " Ubuntu 已安裝" : "Ubuntu 未安裝")}\n";

            MyMessageBox.ShowDialog(msg);
        }

        private void RJ_Button_docker_restart_container_MouseDownEvent(MouseEventArgs mevent)
        {
            if (this.sqL_DataGridView_Docker_Containers.Get_All_Select_RowsValues().Count == 0)
            {
                MyMessageBox.ShowDialog("請選擇容器");
                return;
            }
            LoadingForm.ShowLoadingForm();
            List<object[]> list_value = this.sqL_DataGridView_Docker_Containers.Get_All_Select_RowsValues();
            foreach (var item in list_value)
            {
                string containerId = item[(int)DockerContainerInfo.DockerContainerAttributes.ContainerId].ObjectToString();
                DockerOperations dockerOperations = new DockerOperations(psHost);
                dockerOperations.SetContainerAutoStart(containerId);
                dockerOperations.RestartDockerContainer(containerId);
            }
            LoadingForm.CloseLoadingForm();
        }

        private void RJ_Button_docker_stop_container_MouseDownEvent(MouseEventArgs mevent)
        {
            if (this.sqL_DataGridView_Docker_Containers.Get_All_Select_RowsValues().Count == 0)
            {
                MyMessageBox.ShowDialog("請選擇容器");
                return;
            }
            LoadingForm.ShowLoadingForm();
            List<object[]> list_value = this.sqL_DataGridView_Docker_Containers.Get_All_Select_RowsValues();
            foreach (var item in list_value)
            {
                string containerId = item[(int)DockerContainerInfo.DockerContainerAttributes.ContainerId].ObjectToString();
                DockerOperations dockerOperations = new DockerOperations(psHost);
                dockerOperations.StopDockerContainer(containerId);
            }
            LoadingForm.CloseLoadingForm();
        }
        private void RJ_Button_docker_run_container_MouseDownEvent(MouseEventArgs mevent)
        {
            if (this.sqL_DataGridView_Docker_Containers.Get_All_Select_RowsValues().Count == 0)
            {
                MyMessageBox.ShowDialog("請選擇容器");
                return;
            }
            LoadingForm.ShowLoadingForm();
            List<object[]> list_value = this.sqL_DataGridView_Docker_Containers.Get_All_Select_RowsValues();
            foreach (var item in list_value)
            {
                string containerId = item[(int)DockerContainerInfo.DockerContainerAttributes.ContainerId].ObjectToString();
                DockerOperations dockerOperations = new DockerOperations(psHost);
                dockerOperations.SetContainerAutoStart(containerId);
                dockerOperations.StartDockerContainer(containerId);
            }
            LoadingForm.CloseLoadingForm();
        }

        private void RJ_Button_docker_remove_container_MouseDownEvent(MouseEventArgs mevent)
        {
            if(this.sqL_DataGridView_Docker_Containers.Get_All_Select_RowsValues().Count == 0)
            {
                MyMessageBox.ShowDialog("請選擇要刪除的容器");
                return;
            }
            DialogResult dialogResult = MyMessageBox.ShowDialog("確定要刪除選中的容器?", MyMessageBox.enum_BoxType.Warning, MyMessageBox.enum_Button.Confirm_Cancel);
            if (dialogResult != DialogResult.Yes)
            {
                return;
            }
            LoadingForm.ShowLoadingForm();
            List<object[]> list_value = this.sqL_DataGridView_Docker_Containers.Get_All_Select_RowsValues();
            foreach (var item in list_value)
            {
                string containerId = item[(int)DockerContainerInfo.DockerContainerAttributes.ContainerId].ObjectToString();
                DockerOperations dockerOperations = new DockerOperations(psHost);
                dockerOperations.RemoveDockerContainer(containerId);
            }
            LoadingForm.CloseLoadingForm();
        }
        private void RJ_Button_docker_add_container_MouseDownEvent(MouseEventArgs mevent)
        {
            Dialog_add_container dialog_Add_Container = new Dialog_add_container();
            dialog_Add_Container.ShowDialog();
            System.Threading.Thread.Sleep(300);
            if (dialog_Add_Container.DialogResult != DialogResult.Yes)
            {
                return;
            }
            LoadingForm.ShowLoadingForm();
            DockerOperations dockerOperations = new DockerOperations(psHost);
            dockerOperations.RunDockerContainer(dialog_Add_Container.Value);
            LoadingForm.CloseLoadingForm();
        }

        private void RJ_Button_docker_upload_image_MouseDownEvent(MouseEventArgs mevent)
        {
            this.Invoke(new Action(delegate
            {
              
                if (openFileDialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                LoadingForm.ShowLoadingForm();

                dockerOperations = new DockerOperations(psHost);
                dockerOperations.LoadDockerImage(openFileDialog.FileName);

                LoadingForm.CloseLoadingForm();
            }));
        }
        private void RJ_Button_docker_download_image_MouseDownEvent(MouseEventArgs mevent)
        {
            this.Invoke(new Action(delegate 
            {
                List<object[]> list_value = this.sqL_DataGridView_Docker_Images.Get_All_Select_RowsValues();
                if (list_value.Count == 0)
                {
                    MyMessageBox.ShowDialog("請選擇要下載的映像");
                    return;
                }
                string imageName = "";
                string tag = "";
                foreach (var item in list_value)
                {
                    imageName = item[0].ToString();
                    tag = item[1].ToString();

                }
                if (saveFileDialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                LoadingForm.ShowLoadingForm();

                dockerOperations = new DockerOperations(psHost);
                dockerOperations.SaveDockerImage($"{imageName}", saveFileDialog.FileName);

                LoadingForm.CloseLoadingForm();
            }));
           
        }
        private void RJ_Button_docker_delete_image_MouseDownEvent(MouseEventArgs mevent)
        {
            List<object[]> list_value = this.sqL_DataGridView_Docker_Images.Get_All_Select_RowsValues();
            if (list_value.Count == 0)
            {
                MyMessageBox.ShowDialog("請選擇要刪除的映像");
                return;
            }
            string imageName = "";
            string tag = "";
            foreach (var item in list_value)
            {
                imageName = item[0].ToString();
                tag = item[1].ToString();

            }
            DialogResult dialogResult = MyMessageBox.ShowDialog($"確定要刪除選中的映像 [{imageName}:{tag}] ?", MyMessageBox.enum_BoxType.Warning, MyMessageBox.enum_Button.Confirm_Cancel);
            if (dialogResult != DialogResult.Yes)
            {
                return;
            }

            LoadingForm.ShowLoadingForm();

            dockerOperations = new DockerOperations(psHost);
            dockerOperations.RemoveDockerImage(imageName, tag);

            LoadingForm.CloseLoadingForm();
        }
        private void RJ_Button_docker_add_image_MouseDownEvent(MouseEventArgs mevent)
        {
            Dialog_add_image dialog_Add_Image = new Dialog_add_image();
            dialog_Add_Image.ShowDialog();
            if(dialog_Add_Image.DialogResult != DialogResult.Yes)
            {
                return;
            }
            (string imagename, string tag, string filepath) = dialog_Add_Image.GetValue();
            LoadingForm.ShowLoadingForm();
            dockerOperations = new DockerOperations(psHost);
            dockerOperations.BuildDockerImage(filepath, imagename, tag);
            LoadingForm.CloseLoadingForm();
        }

  
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
        }
    }
}
