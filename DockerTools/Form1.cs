using System;
using System.Windows.Forms;

public class PowerShellForm : Form
{
    private PowerShellHost psHost;
    private RichTextBox outputBox;

    public PowerShellForm()
    {
        this.Text = "Embedded PowerShell";
        this.Size = new System.Drawing.Size(800, 500);

        outputBox = new RichTextBox
        {
            Dock = DockStyle.Fill,
            ReadOnly = false,
            Multiline = true,
            Font = new System.Drawing.Font("Consolas", 10),
            AcceptsTab = true
        };

        this.Controls.Add(outputBox);
        psHost = new PowerShellHost(outputBox);
    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
        base.OnFormClosing(e);
    }

    [STAThread]
    public static void Main()
    {
        Application.EnableVisualStyles();
        Application.Run(new PowerShellForm());
    }
}
