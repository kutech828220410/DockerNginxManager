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
using DockerNginxManagerLib;
namespace DockerTools
{
    public partial class Dialog_add_container : MyDialog
    {
        [EnumDescription("VolumeMappings")]
        public enum EnumVolumeMappings
        {
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
            }));
        
        }

        private void Dialog_add_container_LoadFinishedEvent(EventArgs e)
        {
       
            rJ_Button_cancel.MouseDownEvent += RJ_Button_cancel_MouseDownEvent;

            this.rJ_Button_refresh_docker_command.MouseDownEvent += RJ_Button_refresh_docker_command_MouseDownEvent;
            this.Refresh();
        }

        private void RJ_Button_refresh_docker_command_MouseDownEvent(MouseEventArgs mevent)
        {
            DockerRunParameters parameters = new DockerRunParameters(this.rJ_TextBox_docker_command.Text);

            if(parameters != null)
            {
                this.Invoke(new Action(delegate
                {
                    rJ_TextBox_ContainerName.Text = parameters.ContainerName;
                    rJ_TextBox_Network.Text = parameters.Network;
                    rJ_TextBox_PortForward.Text = parameters.PortForward;
                    comboBox_ImageName.Text = parameters.ImageName;
                    rJ_TextBox_ImageTag.Text = parameters.ImageTag;

                    sqL_DataGridView_VolumeMappings.ClearGrid();

                    for(int i = 0; i < parameters.VolumeMappings.Count; i++)
                    {
                        sqL_DataGridView_VolumeMappings.AddRow(new object[] { parameters.VolumeMappings[i] }, false);
                    }
                    sqL_DataGridView_VolumeMappings.RefreshGrid();  
                }));
            }
            else
            {
                MyMessageBox.ShowDialog("Docker Command is invalid");
            }
        }


        private void RJ_Button_cancel_MouseDownEvent(MouseEventArgs mevent)
        {
            this.Close();   
        }
    }
}
