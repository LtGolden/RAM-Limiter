using System.Windows.Forms;
namespace DiscordRamLimiter
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnStart;
        private Button btnStop;
        private Label lblStatus;
        private TextBox txtProcesses;
        private Label lblInstructions;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnStart = new Button();
            this.btnStop = new Button();
            this.lblStatus = new Label();
            this.txtProcesses = new TextBox();
            this.lblInstructions = new Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 75);
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.Text = "Start";
            this.btnStart.Click += new EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(93, 75);
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.Text = "Stop";
            this.btnStop.Enabled = false;
            this.btnStop.Click += new EventHandler(this.btnStop_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(12, 110);
            this.lblStatus.Size = new System.Drawing.Size(260, 23);
            this.lblStatus.Text = "Status: Idle";
            // 
            // txtProcesses
            // 
            this.txtProcesses.Location = new System.Drawing.Point(12, 25);
            this.txtProcesses.Size = new System.Drawing.Size(260, 20);
            this.txtProcesses.Text = "discord,chrome,firefox,edge,thorium";
            // 
            // lblInstructions
            // 
            this.lblInstructions.Location = new System.Drawing.Point(12, 5);
            this.lblInstructions.Size = new System.Drawing.Size(260, 15);
            this.lblInstructions.Text = "Comma-separated process names:";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 141);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.txtProcesses);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Text = "Discord Ram Limiter";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
