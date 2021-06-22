
namespace ChatClient
{
    partial class Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            this.PanelCon = new Guna.UI.WinForms.GunaShadowPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxName = new Guna.UI.WinForms.GunaTextBox();
            this.radioButtonNa = new System.Windows.Forms.RadioButton();
            this.radioButtonAn = new System.Windows.Forms.RadioButton();
            this.textBoxIP = new Guna.UI.WinForms.GunaTextBox();
            this.textBoxPort = new Guna.UI.WinForms.GunaTextBox();
            this.buttonConnect = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.labelIP = new System.Windows.Forms.Label();
            this.labelPort = new System.Windows.Forms.Label();
            this.gunaShadowPanel2 = new Guna.UI.WinForms.GunaShadowPanel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaShadowPanel3 = new Guna.UI.WinForms.GunaShadowPanel();
            this.close = new Guna.UI.WinForms.GunaCircleButton();
            this.gunaCircleButton1 = new Guna.UI.WinForms.GunaCircleButton();
            this.PanelConbut = new Guna.UI.WinForms.GunaCircleButton();
            this.gunaShadowPanel4 = new Guna.UI.WinForms.GunaShadowPanel();
            this.buttonSend = new Guna.UI.WinForms.GunaCircleButton();
            this.textBoxSend = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.richTextBoxChat = new Guna.UI.WinForms.GunaTextBox();
            this.PanelCon.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gunaShadowPanel2.SuspendLayout();
            this.gunaShadowPanel3.SuspendLayout();
            this.gunaShadowPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelCon
            // 
            this.PanelCon.BackColor = System.Drawing.Color.Transparent;
            this.PanelCon.BaseColor = System.Drawing.Color.White;
            this.PanelCon.Controls.Add(this.groupBox2);
            this.PanelCon.Controls.Add(this.textBoxIP);
            this.PanelCon.Controls.Add(this.textBoxPort);
            this.PanelCon.Controls.Add(this.buttonConnect);
            this.PanelCon.Controls.Add(this.gunaLabel1);
            this.PanelCon.Controls.Add(this.labelIP);
            this.PanelCon.Controls.Add(this.labelPort);
            this.PanelCon.Location = new System.Drawing.Point(77, 0);
            this.PanelCon.Name = "PanelCon";
            this.PanelCon.Radius = 10;
            this.PanelCon.ShadowColor = System.Drawing.Color.Gainsboro;
            this.PanelCon.Size = new System.Drawing.Size(530, 524);
            this.PanelCon.TabIndex = 16;
            this.PanelCon.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.textBoxName);
            this.groupBox2.Controls.Add(this.radioButtonNa);
            this.groupBox2.Controls.Add(this.radioButtonAn);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.groupBox2.Location = new System.Drawing.Point(45, 265);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(417, 127);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User Name";
            // 
            // textBoxName
            // 
            this.textBoxName.BaseColor = System.Drawing.Color.White;
            this.textBoxName.BorderColor = System.Drawing.Color.Silver;
            this.textBoxName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxName.FocusedBaseColor = System.Drawing.Color.White;
            this.textBoxName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.textBoxName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxName.Location = new System.Drawing.Point(124, 80);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.PasswordChar = '\0';
            this.textBoxName.Size = new System.Drawing.Size(204, 32);
            this.textBoxName.TabIndex = 14;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            this.textBoxName.Leave += new System.EventHandler(this.textBoxName_Leave);
            // 
            // radioButtonNa
            // 
            this.radioButtonNa.AutoSize = true;
            this.radioButtonNa.Location = new System.Drawing.Point(34, 80);
            this.radioButtonNa.Name = "radioButtonNa";
            this.radioButtonNa.Size = new System.Drawing.Size(63, 19);
            this.radioButtonNa.TabIndex = 1;
            this.radioButtonNa.Text = "Name :";
            this.radioButtonNa.UseVisualStyleBackColor = true;
            this.radioButtonNa.CheckedChanged += new System.EventHandler(this.radioButtonNa_CheckedChanged);
            // 
            // radioButtonAn
            // 
            this.radioButtonAn.AutoSize = true;
            this.radioButtonAn.Checked = true;
            this.radioButtonAn.Location = new System.Drawing.Point(34, 33);
            this.radioButtonAn.Name = "radioButtonAn";
            this.radioButtonAn.Size = new System.Drawing.Size(90, 19);
            this.radioButtonAn.TabIndex = 0;
            this.radioButtonAn.TabStop = true;
            this.radioButtonAn.Text = "Anonymous";
            this.radioButtonAn.UseVisualStyleBackColor = true;
            // 
            // textBoxIP
            // 
            this.textBoxIP.BaseColor = System.Drawing.Color.White;
            this.textBoxIP.BorderColor = System.Drawing.Color.Silver;
            this.textBoxIP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxIP.FocusedBaseColor = System.Drawing.Color.White;
            this.textBoxIP.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.textBoxIP.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxIP.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxIP.Location = new System.Drawing.Point(150, 130);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.PasswordChar = '\0';
            this.textBoxIP.Size = new System.Drawing.Size(204, 32);
            this.textBoxIP.TabIndex = 13;
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
            this.textBoxPort.Location = new System.Drawing.Point(151, 194);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.PasswordChar = '\0';
            this.textBoxPort.Size = new System.Drawing.Size(204, 32);
            this.textBoxPort.TabIndex = 12;
            // 
            // buttonConnect
            // 
            this.buttonConnect.AnimationHoverSpeed = 0.07F;
            this.buttonConnect.AnimationSpeed = 0.03F;
            this.buttonConnect.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.buttonConnect.BorderColor = System.Drawing.Color.Black;
            this.buttonConnect.CheckedBaseColor = System.Drawing.Color.Gray;
            this.buttonConnect.CheckedBorderColor = System.Drawing.Color.Black;
            this.buttonConnect.CheckedForeColor = System.Drawing.Color.White;
            this.buttonConnect.CheckedImage = ((System.Drawing.Image)(resources.GetObject("buttonConnect.CheckedImage")));
            this.buttonConnect.CheckedLineColor = System.Drawing.Color.DimGray;
            this.buttonConnect.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonConnect.FocusedColor = System.Drawing.Color.Empty;
            this.buttonConnect.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonConnect.ForeColor = System.Drawing.Color.White;
            this.buttonConnect.Image = null;
            this.buttonConnect.ImageSize = new System.Drawing.Size(20, 20);
            this.buttonConnect.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.buttonConnect.Location = new System.Drawing.Point(162, 423);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.buttonConnect.OnHoverBorderColor = System.Drawing.Color.Black;
            this.buttonConnect.OnHoverForeColor = System.Drawing.Color.White;
            this.buttonConnect.OnHoverImage = null;
            this.buttonConnect.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.buttonConnect.OnPressedColor = System.Drawing.Color.Black;
            this.buttonConnect.Size = new System.Drawing.Size(180, 42);
            this.buttonConnect.TabIndex = 11;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 17F);
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(0)))), ((int)(((byte)(74)))));
            this.gunaLabel1.Location = new System.Drawing.Point(156, 33);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(217, 31);
            this.gunaLabel1.TabIndex = 10;
            this.gunaLabel1.Text = "Server coonnection";
            // 
            // labelIP
            // 
            this.labelIP.AutoSize = true;
            this.labelIP.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.labelIP.Location = new System.Drawing.Point(71, 141);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(32, 21);
            this.labelIP.TabIndex = 0;
            this.labelIP.Text = "IP :";
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.labelPort.Location = new System.Drawing.Point(71, 197);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(48, 21);
            this.labelPort.TabIndex = 1;
            this.labelPort.Text = "Port :";
            // 
            // gunaShadowPanel2
            // 
            this.gunaShadowPanel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel2.BaseColor = System.Drawing.Color.White;
            this.gunaShadowPanel2.Controls.Add(this.gunaLabel3);
            this.gunaShadowPanel2.Location = new System.Drawing.Point(75, -29);
            this.gunaShadowPanel2.Name = "gunaShadowPanel2";
            this.gunaShadowPanel2.Radius = 10;
            this.gunaShadowPanel2.ShadowColor = System.Drawing.Color.Gainsboro;
            this.gunaShadowPanel2.Size = new System.Drawing.Size(522, 113);
            this.gunaShadowPanel2.TabIndex = 15;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 17F);
            this.gunaLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(0)))), ((int)(((byte)(74)))));
            this.gunaLabel3.Location = new System.Drawing.Point(211, 63);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(133, 31);
            this.gunaLabel3.TabIndex = 10;
            this.gunaLabel3.Text = "Group Chat";
            // 
            // gunaShadowPanel3
            // 
            this.gunaShadowPanel3.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(0)))), ((int)(((byte)(74)))));
            this.gunaShadowPanel3.Controls.Add(this.close);
            this.gunaShadowPanel3.Controls.Add(this.gunaCircleButton1);
            this.gunaShadowPanel3.Controls.Add(this.PanelConbut);
            this.gunaShadowPanel3.Location = new System.Drawing.Point(-70, 13);
            this.gunaShadowPanel3.Name = "gunaShadowPanel3";
            this.gunaShadowPanel3.Radius = 20;
            this.gunaShadowPanel3.ShadowColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel3.Size = new System.Drawing.Size(139, 516);
            this.gunaShadowPanel3.TabIndex = 14;
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
            this.close.Location = new System.Drawing.Point(72, 306);
            this.close.Name = "close";
            this.close.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(57)))), ((int)(((byte)(255)))));
            this.close.OnHoverBorderColor = System.Drawing.Color.Black;
            this.close.OnHoverForeColor = System.Drawing.Color.White;
            this.close.OnHoverImage = null;
            this.close.OnPressedColor = System.Drawing.Color.Black;
            this.close.Size = new System.Drawing.Size(45, 45);
            this.close.TabIndex = 14;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // gunaCircleButton1
            // 
            this.gunaCircleButton1.AnimationHoverSpeed = 0.07F;
            this.gunaCircleButton1.AnimationSpeed = 0.03F;
            this.gunaCircleButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaCircleButton1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaCircleButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaCircleButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaCircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaCircleButton1.ForeColor = System.Drawing.Color.White;
            this.gunaCircleButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaCircleButton1.Image")));
            this.gunaCircleButton1.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaCircleButton1.Location = new System.Drawing.Point(71, 228);
            this.gunaCircleButton1.Name = "gunaCircleButton1";
            this.gunaCircleButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(57)))), ((int)(((byte)(255)))));
            this.gunaCircleButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaCircleButton1.OnHoverImage = null;
            this.gunaCircleButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.Size = new System.Drawing.Size(45, 45);
            this.gunaCircleButton1.TabIndex = 13;
            // 
            // PanelConbut
            // 
            this.PanelConbut.AnimationHoverSpeed = 0.07F;
            this.PanelConbut.AnimationSpeed = 0.03F;
            this.PanelConbut.BackColor = System.Drawing.Color.Transparent;
            this.PanelConbut.BaseColor = System.Drawing.Color.Transparent;
            this.PanelConbut.BorderColor = System.Drawing.Color.Black;
            this.PanelConbut.DialogResult = System.Windows.Forms.DialogResult.None;
            this.PanelConbut.FocusedColor = System.Drawing.Color.Empty;
            this.PanelConbut.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PanelConbut.ForeColor = System.Drawing.Color.White;
            this.PanelConbut.Image = ((System.Drawing.Image)(resources.GetObject("PanelConbut.Image")));
            this.PanelConbut.ImageSize = new System.Drawing.Size(30, 30);
            this.PanelConbut.Location = new System.Drawing.Point(72, 152);
            this.PanelConbut.Name = "PanelConbut";
            this.PanelConbut.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(57)))), ((int)(((byte)(255)))));
            this.PanelConbut.OnHoverBorderColor = System.Drawing.Color.Black;
            this.PanelConbut.OnHoverForeColor = System.Drawing.Color.White;
            this.PanelConbut.OnHoverImage = null;
            this.PanelConbut.OnPressedColor = System.Drawing.Color.Black;
            this.PanelConbut.Size = new System.Drawing.Size(45, 45);
            this.PanelConbut.TabIndex = 12;
            this.PanelConbut.Click += new System.EventHandler(this.PanelConbut_Click);
            // 
            // gunaShadowPanel4
            // 
            this.gunaShadowPanel4.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel4.BaseColor = System.Drawing.Color.White;
            this.gunaShadowPanel4.Controls.Add(this.buttonSend);
            this.gunaShadowPanel4.Controls.Add(this.textBoxSend);
            this.gunaShadowPanel4.Controls.Add(this.gunaLabel2);
            this.gunaShadowPanel4.Controls.Add(this.richTextBoxChat);
            this.gunaShadowPanel4.Location = new System.Drawing.Point(75, 92);
            this.gunaShadowPanel4.Name = "gunaShadowPanel4";
            this.gunaShadowPanel4.Radius = 10;
            this.gunaShadowPanel4.ShadowColor = System.Drawing.Color.Gainsboro;
            this.gunaShadowPanel4.Size = new System.Drawing.Size(522, 435);
            this.gunaShadowPanel4.TabIndex = 13;
            // 
            // buttonSend
            // 
            this.buttonSend.AnimationHoverSpeed = 0.07F;
            this.buttonSend.AnimationSpeed = 0.03F;
            this.buttonSend.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.buttonSend.BorderColor = System.Drawing.Color.Black;
            this.buttonSend.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonSend.FocusedColor = System.Drawing.Color.Empty;
            this.buttonSend.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonSend.ForeColor = System.Drawing.Color.White;
            this.buttonSend.Image = ((System.Drawing.Image)(resources.GetObject("buttonSend.Image")));
            this.buttonSend.ImageSize = new System.Drawing.Size(22, 22);
            this.buttonSend.Location = new System.Drawing.Point(464, 378);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.buttonSend.OnHoverBorderColor = System.Drawing.Color.Black;
            this.buttonSend.OnHoverForeColor = System.Drawing.Color.White;
            this.buttonSend.OnHoverImage = null;
            this.buttonSend.OnPressedColor = System.Drawing.Color.Black;
            this.buttonSend.Size = new System.Drawing.Size(45, 45);
            this.buttonSend.TabIndex = 10;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // textBoxSend
            // 
            this.textBoxSend.BackColor = System.Drawing.Color.Transparent;
            this.textBoxSend.BaseColor = System.Drawing.Color.White;
            this.textBoxSend.BorderColor = System.Drawing.Color.LightGray;
            this.textBoxSend.BorderSize = 1;
            this.textBoxSend.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxSend.FocusedBaseColor = System.Drawing.Color.White;
            this.textBoxSend.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.textBoxSend.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxSend.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxSend.Location = new System.Drawing.Point(3, 380);
            this.textBoxSend.Name = "textBoxSend";
            this.textBoxSend.PasswordChar = '\0';
            this.textBoxSend.Radius = 20;
            this.textBoxSend.Size = new System.Drawing.Size(455, 43);
            this.textBoxSend.TabIndex = 10;
            this.textBoxSend.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSend_KeyDown);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.BackColor = System.Drawing.Color.White;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(3, 361);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(516, 80);
            this.gunaLabel2.TabIndex = 10;
            // 
            // richTextBoxChat
            // 
            this.richTextBoxChat.BackColor = System.Drawing.Color.Transparent;
            this.richTextBoxChat.BaseColor = System.Drawing.Color.White;
            this.richTextBoxChat.BorderColor = System.Drawing.Color.LightGray;
            this.richTextBoxChat.BorderSize = 0;
            this.richTextBoxChat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.richTextBoxChat.FocusedBaseColor = System.Drawing.Color.White;
            this.richTextBoxChat.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.richTextBoxChat.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.richTextBoxChat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.richTextBoxChat.Location = new System.Drawing.Point(3, 4);
            this.richTextBoxChat.MultiLine = true;
            this.richTextBoxChat.Name = "richTextBoxChat";
            this.richTextBoxChat.PasswordChar = '\0';
            this.richTextBoxChat.Radius = 20;
            this.richTextBoxChat.Size = new System.Drawing.Size(516, 420);
            this.richTextBoxChat.TabIndex = 11;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(617, 528);
            this.ControlBox = false;
            this.Controls.Add(this.PanelCon);
            this.Controls.Add(this.gunaShadowPanel2);
            this.Controls.Add(this.gunaShadowPanel3);
            this.Controls.Add(this.gunaShadowPanel4);
            this.Name = "Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Client_FormClosing);
            this.Load += new System.EventHandler(this.Client_Load);
            this.PanelCon.ResumeLayout(false);
            this.PanelCon.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gunaShadowPanel2.ResumeLayout(false);
            this.gunaShadowPanel2.PerformLayout();
            this.gunaShadowPanel3.ResumeLayout(false);
            this.gunaShadowPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaShadowPanel PanelCon;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI.WinForms.GunaTextBox textBoxName;
        private System.Windows.Forms.RadioButton radioButtonNa;
        private System.Windows.Forms.RadioButton radioButtonAn;
        private Guna.UI.WinForms.GunaTextBox textBoxIP;
        private Guna.UI.WinForms.GunaTextBox textBoxPort;
        private Guna.UI.WinForms.GunaAdvenceButton buttonConnect;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.Label labelIP;
        private System.Windows.Forms.Label labelPort;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel3;
        private Guna.UI.WinForms.GunaCircleButton close;
        private Guna.UI.WinForms.GunaCircleButton gunaCircleButton1;
        private Guna.UI.WinForms.GunaCircleButton PanelConbut;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel4;
        private Guna.UI.WinForms.GunaCircleButton buttonSend;
        private Guna.UI.WinForms.GunaTextBox textBoxSend;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaTextBox richTextBoxChat;
    }
}