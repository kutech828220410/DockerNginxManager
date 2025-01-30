using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Basic;
using DockerNginxManagerLib;
using MyUI;
namespace DockerTools
{
    partial class Form1 : Form
    {
        private DockerOperations dockerOperations;
        private PowerShellHost psHost;
        private MyThread myThread_refreshDockerImages;
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            psHost = new PowerShellHost(richTextBox_powershell);
           
            this.rJ_Button_檢查環境.MouseDownEvent += RJ_Button_檢查環境_MouseDownEvent;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadingForm.form = this.FindForm();
            MyMessageBox.form = this.FindForm();
            MyMessageBox.音效 = false;

            this.sqL_DataGridView_Docker_Image.RowsHeight = 40;
            this.sqL_DataGridView_Docker_Image.Init(new SQLUI.Table(new DockerImageInfo.DockerImageAttributes()));
            this.sqL_DataGridView_Docker_Image.Set_ColumnWidth(200, DataGridViewContentAlignment.MiddleCenter, DockerImageInfo.DockerImageAttributes.Repository);
            this.sqL_DataGridView_Docker_Image.Set_ColumnWidth(100, DataGridViewContentAlignment.MiddleCenter, DockerImageInfo.DockerImageAttributes.Tag);
            this.sqL_DataGridView_Docker_Image.Set_ColumnWidth(150, DataGridViewContentAlignment.MiddleCenter, DockerImageInfo.DockerImageAttributes.ImageId);
            this.sqL_DataGridView_Docker_Image.Set_ColumnWidth(150, DataGridViewContentAlignment.MiddleCenter, DockerImageInfo.DockerImageAttributes.Created);
            this.sqL_DataGridView_Docker_Image.Set_ColumnWidth(100, DataGridViewContentAlignment.MiddleCenter, DockerImageInfo.DockerImageAttributes.Size);
            this.sqL_DataGridView_Docker_Image.Set_ColumnVisible(false, DockerImageInfo.DockerImageAttributes.Size);

            rJ_Button_docker_add_image.MouseDownEvent += RJ_Button_docker_add_image_MouseDownEvent;
            rJ_Button_delete_image.MouseDownEvent += RJ_Button_delete_image_MouseDownEvent;

            myThread_refreshDockerImages = new MyThread();
            myThread_refreshDockerImages.AutoRun(true);
            myThread_refreshDockerImages.SetSleepTime(500);
            myThread_refreshDockerImages.Add_Method(() =>
            {
                PowerShellHost psHost_t = new PowerShellHost();
                DockerOperations dockerOperations = new DockerOperations(psHost_t);
                List<DockerImageInfo> dockerImageInfos = dockerOperations.ListAllDockerImages();
                List<object[]> list_value = dockerImageInfos.ClassToSQL<DockerImageInfo, DockerImageInfo.DockerImageAttributes>();
                this.sqL_DataGridView_Docker_Image.RefreshGridByUpdate(list_value);
                psHost_t.Close();
            });
            myThread_refreshDockerImages.Trigger();

        }

        private void RJ_Button_delete_image_MouseDownEvent(MouseEventArgs mevent)
        {
            List<object[]> list_value = this.sqL_DataGridView_Docker_Image.Get_All_Select_RowsValues();
            if(list_value.Count == 0)
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

        private void RJ_Button_檢查環境_MouseDownEvent(MouseEventArgs mevent)
        {
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
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
        }
    }
}
