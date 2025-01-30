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

namespace DockerTools
{
    public partial class Dialog_add_image : MyDialog
    {
        public (string imagename,string tag, string filepath) GetValue()
        {
            return (this.rJ_TextBox_image_name.Text, this.rJ_TextBox_version_tag.Text, this.rJ_TextBox_filepath.Text);
        }

        public Dialog_add_image()
        {
            InitializeComponent();
            this.LoadFinishedEvent += Dialog_add_image_LoadFinishedEvent;
        }

        private void Dialog_add_image_LoadFinishedEvent(EventArgs e)
        {
            rJ_Button_cancel.MouseDownEvent += RJ_Button_cancel_MouseDownEvent;
            rJ_Button_creat.MouseDownEvent += RJ_Button_creat_MouseDownEvent;
            rJ_Button_browse_folder.MouseDownEvent += RJ_Button_browse_folder_MouseDownEvent;
        }

        private void RJ_Button_browse_folder_MouseDownEvent(MouseEventArgs mevent)
        {
            this.Invoke(new Action(delegate
            {
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    this.rJ_TextBox_filepath.Text = folderBrowserDialog.SelectedPath;
                    this.rJ_TextBox_image_name.Enabled = true;
                    this.rJ_TextBox_version_tag.Enabled = true;
                }
            }));

        }

        private void RJ_Button_creat_MouseDownEvent(MouseEventArgs mevent)
        {
            if (string.IsNullOrEmpty(this.rJ_TextBox_image_name.Text) || string.IsNullOrEmpty(this.rJ_TextBox_version_tag.Text) || string.IsNullOrEmpty(this.rJ_TextBox_filepath.Text))
            {
                MyMessageBox.ShowDialog("請輸入完整資訊");
                return;
            }

            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void RJ_Button_cancel_MouseDownEvent(MouseEventArgs mevent)
        {
            this.Close();
        }
    }
}
