namespace DiscordRamLimiter
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtProcesses;
        private System.Windows.Forms.Label lblInstructions;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtProcesses = new System.Windows.Forms.TextBox();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.SuspendLayout();

            this.btnStart.Location = new System.Drawing.Point(12, 75);
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.Text = "Start";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);

            this.btnStop.Location = new System.Drawing.Point(93, 75);
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.Text = "Stop";
            this.btnStop.Enabled = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);

            this.lblStatus.Location = new System.Drawing.Point(12, 110);
            this.lblStatus.Size = new System.Drawing.Size(260, 23);
            this.lblStatus.Text = "Status: Idle";

            this.txtProcesses.Location = new System.Drawing.Point(12, 25);
            this.txtProcesses.Size = new System.Drawing.Size(260, 20);
            this.txtProcesses.Text = "discord,chrome,firefox,edge,thorium,steam";

            this.lblInstructions.Location = new System.Drawing.Point(12, 5);
            this.lblInstructions.Size = new System.Drawing.Size(260, 15);
            this.lblInstructions.Text = "Comma-separated process names:";

            this.ClientSize = new System.Drawing.Size(284, 141);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.txtProcesses);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Text = "Discord RAM Limiter";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
