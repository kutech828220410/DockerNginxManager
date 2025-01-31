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
    public partial class Dialog_add_volume_path : MyDialog
    {
        private string windows_path;
        private string linux_path;
        private bool _readonly;
        public string Value
        {
            get => this.rJ_TextBox_windows_path.Text + ":" + this.rJ_TextBox_linux_path.Text + (this.checkBox_readonly.Checked ? ":ro" : "");
        }

        public Dialog_add_volume_path(string windows_path, string linux_path, bool _readonly = false)
        {
            InitializeComponent();
            this.LoadFinishedEvent += Dialog_add_volume_path_LoadFinishedEvent;
            this.windows_path = windows_path;
            this.linux_path = linux_path;
            this._readonly = _readonly;
        }
        public Dialog_add_volume_path()
        {
            InitializeComponent();

            this.LoadFinishedEvent += Dialog_add_volume_path_LoadFinishedEvent;
        }

        private void Dialog_add_volume_path_LoadFinishedEvent(EventArgs e)
        {
            this.rJ_TextBox_windows_path.Text = windows_path;
            this.rJ_TextBox_linux_path.Text = linux_path;
            this.checkBox_readonly.Checked = _readonly;

            rJ_Button_OK.MouseDownEvent += RJ_Button_OK_MouseDownEvent;
            rJ_Button_cancel.MouseDownEvent += RJ_Button_cancel_MouseDownEvent;
        }

        private void RJ_Button_cancel_MouseDownEvent(MouseEventArgs mevent)
        {
            this.Close();
        }

        private void RJ_Button_OK_MouseDownEvent(MouseEventArgs mevent)
        {
            if (string.IsNullOrEmpty(this.rJ_TextBox_windows_path.Text) || string.IsNullOrEmpty(this.rJ_TextBox_linux_path.Text))
            {
                MyMessageBox.ShowDialog("請輸入完整資訊");
                return;
            }
            DialogResult = DialogResult.Yes;
            this.Close();
        }
    }
}
