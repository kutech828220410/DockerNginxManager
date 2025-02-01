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
    public partial class Dialog_add_location : MyDialog
    {
        public Location location;
        public Dialog_add_location(Location location)
        {
            InitializeComponent();
            this.location = location;
            LoadFinishedEvent += Dialog_add_location_LoadFinishedEvent;
            rJ_Button_Confirm.MouseDownEvent += RJ_Button_Confirm_MouseDownEvent;
            rJ_Button_cancel.MouseDownEvent += RJ_Button_cancel_MouseDownEvent;
        }
        private void Dialog_add_location_LoadFinishedEvent(EventArgs e)
        {
            rJ_TextBox_Path.Text = location.Path;
            rJ_TextBox_ProxyPass.Text = location.ProxyPass;
            rJ_TextBox_ProxyHttpVersion.Text = location.ProxyHttpVersion;
            rJ_TextBox_ProxySetHeaderConnection.Text = location.ProxySetHeaderConnection;
            rJ_TextBox_ProxySetHeaderUpgrade.Text = location.ProxySetHeaderUpgrade;
            rJ_TextBox_ProxySetHeaderXForwardedHost.Text = location.ProxySetHeaderXForwardedHost;
            rJ_TextBox_ProxyCacheBypass.Text = location.ProxyCacheBypass;
            rJ_TextBox_ProxyRedirect.Text = location.ProxyRedirect;
            checkBox_ProxyBuffering.Checked = location.ProxyBuffering == "on";
            rJ_TextBox_ProxyBuffers.Text = location.ProxyBuffers;
            rJ_TextBox_ProxyBufferSize.Text = location.ProxyBufferSize;
            rJ_TextBox_ProxyConnectTimeout.Text = location.ProxyConnectTimeout;
            rJ_TextBox_ProxySendTimeout.Text = location.ProxySendTimeout;
            rJ_TextBox_ProxyReadTimeout.Text = location.ProxyReadTimeout;
            rJ_TextBox_ProxyMaxTempFileSize.Text = location.ProxyMaxTempFileSize;

        }

        private void RJ_Button_cancel_MouseDownEvent(MouseEventArgs mevent)
        {
            this.Close();
        }
        private void RJ_Button_Confirm_MouseDownEvent(MouseEventArgs mevent)
        {
            location.Path = rJ_TextBox_Path.Text;
            location.ProxyPass = rJ_TextBox_ProxyPass.Text;
            location.ProxyHttpVersion = rJ_TextBox_ProxyHttpVersion.Text;
            location.ProxySetHeaderConnection = rJ_TextBox_ProxySetHeaderConnection.Text;
            location.ProxySetHeaderUpgrade = rJ_TextBox_ProxySetHeaderUpgrade.Text;
            location.ProxySetHeaderXForwardedHost = rJ_TextBox_ProxySetHeaderXForwardedHost.Text;
            location.ProxyCacheBypass = rJ_TextBox_ProxyCacheBypass.Text;
            location.ProxyRedirect = rJ_TextBox_ProxyRedirect.Text;
            location.ProxyBuffering = checkBox_ProxyBuffering.Checked ? "on" : "off";
            location.ProxyBuffers = rJ_TextBox_ProxyBuffers.Text;
            location.ProxyBufferSize = rJ_TextBox_ProxyBufferSize.Text;
            location.ProxyConnectTimeout = rJ_TextBox_ProxyConnectTimeout.Text;
            location.ProxySendTimeout = rJ_TextBox_ProxySendTimeout.Text;
            location.ProxyReadTimeout = rJ_TextBox_ProxyReadTimeout.Text;
            location.ProxyMaxTempFileSize = rJ_TextBox_ProxyMaxTempFileSize.Text;

            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

       
    }
}
