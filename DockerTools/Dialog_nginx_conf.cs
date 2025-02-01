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
using NginxManagerLib;

namespace DockerTools
{
    public partial class Dialog_nginx_conf : MyDialog
    {
        private NginxParameters nginxParameters;
        public Dialog_nginx_conf(NginxParameters nginxParameters)
        {
            InitializeComponent();
            this.nginxParameters = nginxParameters;
            LoadFinishedEvent += Dialog_nginx_conf_LoadFinishedEvent;
        }

        private void Dialog_nginx_conf_LoadFinishedEvent(EventArgs e)
        {
            rJ_Button_OK.MouseDownEvent += RJ_Button_OK_MouseDownEvent;
            rJ_Button_copy.MouseDownEvent += RJ_Button_copy_MouseDownEvent;
            rJ_Button_refresh.MouseDownEvent += RJ_Button_refresh_MouseDownEvent;
            richTextBox_nginx_conf.Text = nginxParameters.ToString();

        }

        private void RJ_Button_refresh_MouseDownEvent(MouseEventArgs mevent)
        {
            this.Invoke(new Action(delegate
            {
                richTextBox_nginx_conf.Text = nginxParameters.ToString();
            }));
        }
        private void RJ_Button_copy_MouseDownEvent(MouseEventArgs mevent)
        {
            this.Invoke(new Action(delegate
            {
                Clipboard.SetText(richTextBox_nginx_conf.Text);
            }));
        }

        private void RJ_Button_OK_MouseDownEvent(MouseEventArgs mevent)
        {
            this.Close();
        }
    }
}
