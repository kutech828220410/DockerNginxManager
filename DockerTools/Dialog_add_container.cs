using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Basic;
using MyUI;
using SQLUI;
using DockerManagerLib;
namespace DockerTools
{
    public partial class Dialog_add_container : MyDialog
    {

        public static string currentDirectory = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

        public DockerContainerParameters Value
        {
            get => new DockerContainerParameters(this.rJ_TextBox_docker_command.Text);
        }

        private List<string> image_name;
        private Dictionary<string, string> dic_filenames_contents;


        [EnumDescription("VolumeMappings")]
        public enum EnumVolumeMappings
        {
            [Description("GUID,VARCHAR,100,NONE")]
            GUID,
            [Description("Path,VARCHAR,100,NONE")]
            Path,
        }

        public Dialog_add_container()
        {
            form.Invoke(new Action(delegate
            {
                InitializeComponent();
                this.LoadFinishedEvent += Dialog_add_container_LoadFinishedEvent;

                this.sqL_DataGridView_VolumeMappings.RowsHeight = 30;
                this.sqL_DataGridView_VolumeMappings.Init(new SQLUI.Table(new EnumVolumeMappings()));
                this.sqL_DataGridView_VolumeMappings.Set_ColumnWidth(200, DataGridViewContentAlignment.MiddleLeft, EnumVolumeMappings.Path);
                this.sqL_DataGridView_VolumeMappings.Set_ColumnVisible(false, EnumVolumeMappings.GUID);

                PowerShellHost powerShellHost = new PowerShellHost();
                DockerOperations dockerOperations = new DockerOperations(powerShellHost);
                List<DockerImageInfo> images = dockerOperations.ListAllDockerImages();
                image_name = (from image in images select $"{image.Repository}:{image.Tag}").ToList();

            }));
        
        }

        private void Dialog_add_container_LoadFinishedEvent(EventArgs e)
        {      
            rJ_Button_cancel.MouseDownEvent += RJ_Button_cancel_MouseDownEvent;
            rJ_Button_creat.MouseDownEvent += RJ_Button_creat_MouseDownEvent;
            rJ_Button_VolumeMappings_add.MouseDownEvent += RJ_Button_VolumeMappings_add_MouseDownEvent;
            rJ_Button_VolumeMappings_delete.MouseDownEvent += RJ_Button_VolumeMappings_delete_MouseDownEvent;
            rJ_Button_VolumeMappings_edit.MouseDownEvent += RJ_Button_VolumeMappings_edit_MouseDownEvent;
            rJ_Button_refresh_docker_command.MouseDownEvent += RJ_Button_refresh_docker_command_MouseDownEvent;
            rJ_Button_generate.MouseDownEvent += RJ_Button_generate_MouseDownEvent;
            rJ_Button_load_template.MouseDownEvent += RJ_Button_load_template_MouseDownEvent;

            comboBox_ImageName.Items.AddRange(image_name.ToArray());
            if(image_name.Count > 0)comboBox_ImageName.SelectedIndex = 0;

            dic_filenames_contents = DockerContainerParameters.ReadTxtFilesInFolder(currentDirectory + "\\containers");
            comboBox_template.Items.AddRange(dic_filenames_contents.Keys.ToArray());
            if (comboBox_template.Items.Count > 0) comboBox_template.SelectedIndex = 0;
            this.Refresh();
        }

   

        private void RJ_Button_load_template_MouseDownEvent(MouseEventArgs mevent)
        {
            string cmb_text = comboBox_template.GetComboBoxText();

            if (cmb_text != null)
            {
                string content = dic_filenames_contents[cmb_text];
                DockerContainerParameters DockerContainerParameters = new DockerContainerParameters(content);
                if (DockerContainerParameters != null)
                {
                    this.Invoke(new Action(delegate
                    {
                        rJ_TextBox_ContainerName.Text = DockerContainerParameters.ContainerName;
                        rJ_TextBox_Network.Text = DockerContainerParameters.Network;
                        rJ_TextBox_PortForward.Text = DockerContainerParameters.PortForward;
                        checkBox_Detach.Checked = DockerContainerParameters.Detach;
                        sqL_DataGridView_VolumeMappings.ClearGrid();
                        foreach (string volume in DockerContainerParameters.VolumeMappings)
                        {
                            sqL_DataGridView_VolumeMappings.AddRow(new object[] { Guid.NewGuid().ToString(), volume }, false);
                        }
                        sqL_DataGridView_VolumeMappings.RefreshGrid();

                        rJ_TextBox_docker_command.Text = DockerContainerParameters.ToString();
                    }));
                }
            }
        }
        private void RJ_Button_generate_MouseDownEvent(MouseEventArgs mevent)
        {         
            this.Invoke(new Action(delegate
            {
                DockerContainerParameters DockerContainerParameters = new DockerContainerParameters();
                DockerContainerParameters.ContainerName = rJ_TextBox_ContainerName.Text;
                DockerContainerParameters.Network = rJ_TextBox_Network.Text;
                DockerContainerParameters.PortForward = rJ_TextBox_PortForward.Text;
                DockerContainerParameters.ImageName = comboBox_ImageName.Text.Split(':')[0];
                DockerContainerParameters.ImageTag = comboBox_ImageName.Text.Split(':')[1];
                DockerContainerParameters.Detach = checkBox_Detach.Checked;
                DockerContainerParameters.VolumeMappings = (from row in sqL_DataGridView_VolumeMappings.GetAllRows() select row[(int)EnumVolumeMappings.Path].ObjectToString()).ToList();
                rJ_TextBox_docker_command.Text = DockerContainerParameters.ToString();
            }));
        }
        private void RJ_Button_VolumeMappings_edit_MouseDownEvent(MouseEventArgs mevent)
        {
            List<object[]> list_value = this.sqL_DataGridView_VolumeMappings.Get_All_Select_RowsValues();
            if (list_value.Count == 0)
            {
                MyMessageBox.ShowDialog("請選擇要編輯的路徑");
                return;
            }
            bool _readonly = false;
            string[] str = list_value[0][(int)EnumVolumeMappings.Path].ObjectToString().Replace(":ro", "").Split(new char[] { ':' }, 2);
            if (str.Length < 2)
            {
                MyMessageBox.ShowDialog("路徑格式錯誤");
                return;
            }
            if (list_value[0][(int)EnumVolumeMappings.Path].ObjectToString().Contains(":ro")) _readonly = true;
            Dialog_add_volume_path dialog_Add_Volume_Path = new Dialog_add_volume_path(str[0], str[1] , _readonly);
            DialogResult result = dialog_Add_Volume_Path.ShowDialog();
            if (result == DialogResult.Yes)
            {
                string value = dialog_Add_Volume_Path.Value;
                sqL_DataGridView_VolumeMappings.ReplaceExtra(new object[] { list_value[0][(int)EnumVolumeMappings.GUID], value }, false);
                sqL_DataGridView_VolumeMappings.RefreshGrid();
            }
        }
        private void RJ_Button_VolumeMappings_delete_MouseDownEvent(MouseEventArgs mevent)
        {
            List<object[]> list_value = this.sqL_DataGridView_VolumeMappings.Get_All_Select_RowsValues();
            if (list_value.Count == 0)
            {
                MyMessageBox.ShowDialog("請選擇要刪除的路徑");
                return;
            }
            sqL_DataGridView_VolumeMappings.DeleteExtra(list_value, true);
        }
        private void RJ_Button_VolumeMappings_add_MouseDownEvent(MouseEventArgs mevent)
        {
            Dialog_add_volume_path dialog_Add_Volume_Path = new Dialog_add_volume_path();
            DialogResult result = dialog_Add_Volume_Path.ShowDialog();
            if (result == DialogResult.Yes)
            {
                string value = dialog_Add_Volume_Path.Value;
                sqL_DataGridView_VolumeMappings.AddRow(new object[] { Guid.NewGuid().ToString(), value }, false);
                sqL_DataGridView_VolumeMappings.RefreshGrid();
            }
        }
        private void RJ_Button_refresh_docker_command_MouseDownEvent(MouseEventArgs mevent)
        {
            DockerContainerParameters parameters = new DockerContainerParameters(this.rJ_TextBox_docker_command.Text);

            if(parameters != null)
            {
                this.Invoke(new Action(delegate
                {
                    rJ_TextBox_ContainerName.Text = parameters.ContainerName;
                    rJ_TextBox_Network.Text = parameters.Network;
                    rJ_TextBox_PortForward.Text = parameters.PortForward;
                    comboBox_ImageName.Text = $"{parameters.ImageName}:{parameters.ImageTag}";

                    sqL_DataGridView_VolumeMappings.ClearGrid();

                    for(int i = 0; i < parameters.VolumeMappings.Count; i++)
                    {
                        sqL_DataGridView_VolumeMappings.AddRow(new object[] { Guid.NewGuid().ToString(), parameters.VolumeMappings[i] }, false);
                    }
                    sqL_DataGridView_VolumeMappings.RefreshGrid();  
                }));
            }
            else
            {
                MyMessageBox.ShowDialog("Docker Command is invalid");
            }
        }

        private void RJ_Button_creat_MouseDownEvent(MouseEventArgs mevent)
        {
            this.Invoke(new Action(delegate
            {
                if (string.IsNullOrEmpty(this.rJ_TextBox_docker_command.Text))
                {
                    MyMessageBox.ShowDialog("請輸入完整資訊");
                    return;
                }
                if (DockerContainerParameters.IsValidDockerCommand(this.rJ_TextBox_docker_command.Text) == false)
                {
                    MyMessageBox.ShowDialog("Docker Command is invalid");
                    return;
                }
                DialogResult = DialogResult.Yes;
                this.Close();
            }));
          
        }
        private void RJ_Button_cancel_MouseDownEvent(MouseEventArgs mevent)
        {
            this.Invoke(new Action(delegate
            {
                this.Close();
            }));
        
        }
    }
}
