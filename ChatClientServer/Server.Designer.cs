
namespace ChatClientServer
{
    partial class Server
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Server));
            this.labelIP = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.gunaShadowPanel2 = new Guna.UI.WinForms.GunaShadowPanel();
            this.close = new Guna.UI.WinForms.GunaCircleButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.textBoxPort = new Guna.UI.WinForms.GunaTextBox();
            this.buttonStart = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaShadowPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelIP
            // 
            this.labelIP.AutoSize = true;
            this.labelIP.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.labelIP.Location = new System.Drawing.Point(36, 81);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(52, 21);
            this.labelIP.TabIndex = 8;
            this.labelIP.Text = "Port : ";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.labelStatus.Location = new System.Drawing.Point(12, 164);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(125, 21);
            this.labelStatus.TabIndex = 9;
            this.labelStatus.Text = "Server is offline";
            // 
            // gunaShadowPanel2
            // 
            this.gunaShadowPanel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel2.BaseColor = System.Drawing.Color.White;
            this.gunaShadowPanel2.Controls.Add(this.close);
            this.gunaShadowPanel2.Controls.Add(this.gunaLabel1);
            this.gunaShadowPanel2.Location = new System.Drawing.Point(-2, -52);
            this.gunaShadowPanel2.Name = "gunaShadowPanel2";
            this.gunaShadowPanel2.Radius = 10;
            this.gunaShadowPanel2.ShadowColor = System.Drawing.Color.Gainsboro;
            this.gunaShadowPanel2.Size = new System.Drawing.Size(416, 113);
            this.gunaShadowPanel2.TabIndex = 18;
            // 
            // close
            // 
            this.close.AnimationHoverSpeed = 0.07F;
            this.close.AnimationSpeed = 0.03F;
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.BaseColor = System.Drawing.Color.Transparent;
            this.close.BorderColor = System.Drawing.Color.Black;
            this.close.DialogResult = System.Windows.Forms.DialogResult.None;
            this.close.FocusedColor = System.Drawing.Color.Empty;
            this.close.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.close.ForeColor = System.Drawing.Color.White;
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.ImageSize = new System.Drawing.Size(30, 30);
            this.close.Location = new System.Drawing.Point(339, 57);
            this.close.Name = "close";
            this.close.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(57)))), ((int)(((byte)(255)))));
            this.close.OnHoverBorderColor = System.Drawing.Color.Black;
            this.close.OnHoverForeColor = System.Drawing.Color.White;
            this.close.OnHoverImage = null;
            this.close.OnPressedColor = System.Drawing.Color.Black;
            this.close.Size = new System.Drawing.Size(45, 45);
            this.close.TabIndex = 17;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 17F);
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(0)))), ((int)(((byte)(74)))));
            this.gunaLabel1.Location = new System.Drawing.Point(74, 57);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(217, 31);
            this.gunaLabel1.TabIndex = 16;
            this.gunaLabel1.Text = "Server coonnection";
            // 
            // textBoxPort
            // 
            this.textBoxPort.BaseColor = System.Drawing.Color.White;
            this.textBoxPort.BorderColor = System.Drawing.Color.Silver;
            this.textBoxPort.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPort.FocusedBaseColor = System.Drawing.Color.White;
            this.textBoxPort.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.textBoxPort.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxPort.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxPort.Location = new System.Drawing.Point(104, 81);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.PasswordChar = '\0';
            this.textBoxPort.Size = new System.Drawing.Size(134, 32);
            this.textBoxPort.TabIndex = 17;
            // 
            // buttonStart
            // 
            this.buttonStart.AnimationHoverSpeed = 0.07F;
            this.buttonStart.AnimationSpeed = 0.03F;
            this.buttonStart.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(57)))), ((int)(((byte)(255)))));
            this.buttonStart.BorderColor = System.Drawing.Color.Black;
            this.buttonStart.CheckedBaseColor = System.Drawing.Color.Gray;
            this.buttonStart.CheckedBorderColor = System.Drawing.Color.Black;
            this.buttonStart.CheckedForeColor = System.Drawing.Color.White;
            this.buttonStart.CheckedImage = ((System.Drawing.Image)(resources.GetObject("buttonStart.CheckedImage")));
            this.buttonStart.CheckedLineColor = System.Drawing.Color.DimGray;
            this.buttonStart.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonStart.FocusedColor = System.Drawing.Color.Empty;
            this.buttonStart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonStart.ForeColor = System.Drawing.Color.White;
            this.buttonStart.Image = null;
            this.buttonStart.ImageSize = new System.Drawing.Size(20, 20);
            this.buttonStart.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.buttonStart.Location = new System.Drawing.Point(302, 81);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.buttonStart.OnHoverBorderColor = System.Drawing.Color.Black;
            this.buttonStart.OnHoverForeColor = System.Drawing.Color.White;
            this.buttonStart.OnHoverImage = null;
            this.buttonStart.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.buttonStart.OnPressedColor = System.Drawing.Color.Black;
            this.buttonStart.Size = new System.Drawing.Size(112, 104);
            this.buttonStart.TabIndex = 16;
            this.buttonStart.Text = "Start Server";
            this.buttonStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 207);
            this.ControlBox = false;
            this.Controls.Add(this.gunaShadowPanel2);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelIP);
            this.Controls.Add(this.labelStatus);
            this.Name = "Server";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.gunaShadowPanel2.ResumeLayout(false);
            this.gunaShadowPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIP;
        private System.Windows.Forms.Label labelStatus;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel2;
        private Guna.UI.WinForms.GunaCircleButton close;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox textBoxPort;
        private Guna.UI.WinForms.GunaAdvenceButton buttonStart;
    }
}