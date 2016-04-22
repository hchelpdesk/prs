namespace PersoneelsRegistratieSysteem.Login
{
    partial class login
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
            this.login_usernamelbl = new System.Windows.Forms.Label();
            this.login_usernameltxtbox = new System.Windows.Forms.TextBox();
            this.login_wachtwoordlbl = new System.Windows.Forms.Label();
            this.login_wachtwoordtxtbox = new System.Windows.Forms.TextBox();
            this.login_inloggenbtn = new System.Windows.Forms.Button();
            this.login_cancelbtn = new System.Windows.Forms.Button();
            this.login_picbox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.login_picbox1)).BeginInit();
            this.SuspendLayout();
            // 
            // login_usernamelbl
            // 
            this.login_usernamelbl.AutoSize = true;
            this.login_usernamelbl.Location = new System.Drawing.Point(14, 195);
            this.login_usernamelbl.Name = "login_usernamelbl";
            this.login_usernamelbl.Size = new System.Drawing.Size(84, 13);
            this.login_usernamelbl.TabIndex = 0;
            this.login_usernamelbl.Text = "Gebruikersnaam";
            // 
            // login_usernameltxtbox
            // 
            this.login_usernameltxtbox.Location = new System.Drawing.Point(14, 212);
            this.login_usernameltxtbox.Name = "login_usernameltxtbox";
            this.login_usernameltxtbox.Size = new System.Drawing.Size(86, 20);
            this.login_usernameltxtbox.TabIndex = 1;
            // 
            // login_wachtwoordlbl
            // 
            this.login_wachtwoordlbl.AutoSize = true;
            this.login_wachtwoordlbl.Location = new System.Drawing.Point(139, 196);
            this.login_wachtwoordlbl.Name = "login_wachtwoordlbl";
            this.login_wachtwoordlbl.Size = new System.Drawing.Size(68, 13);
            this.login_wachtwoordlbl.TabIndex = 2;
            this.login_wachtwoordlbl.Text = "Wachtwoord";
            // 
            // login_wachtwoordtxtbox
            // 
            this.login_wachtwoordtxtbox.Location = new System.Drawing.Point(142, 212);
            this.login_wachtwoordtxtbox.Name = "login_wachtwoordtxtbox";
            this.login_wachtwoordtxtbox.Size = new System.Drawing.Size(86, 20);
            this.login_wachtwoordtxtbox.TabIndex = 3;
            // 
            // login_inloggenbtn
            // 
            this.login_inloggenbtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.login_inloggenbtn.Location = new System.Drawing.Point(142, 245);
            this.login_inloggenbtn.Name = "login_inloggenbtn";
            this.login_inloggenbtn.Size = new System.Drawing.Size(86, 26);
            this.login_inloggenbtn.TabIndex = 4;
            this.login_inloggenbtn.Text = "Inloggen";
            this.login_inloggenbtn.UseVisualStyleBackColor = false;
            // 
            // login_cancelbtn
            // 
            this.login_cancelbtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.login_cancelbtn.Location = new System.Drawing.Point(12, 245);
            this.login_cancelbtn.Name = "login_cancelbtn";
            this.login_cancelbtn.Size = new System.Drawing.Size(86, 26);
            this.login_cancelbtn.TabIndex = 5;
            this.login_cancelbtn.Text = "Annuleren";
            this.login_cancelbtn.UseVisualStyleBackColor = false;
            // 
            // login_picbox1
            // 
            this.login_picbox1.Image = global::PersoneelsRegistratieSysteem.Properties.Resources.login_img;
            this.login_picbox1.Location = new System.Drawing.Point(12, 12);
            this.login_picbox1.Name = "login_picbox1";
            this.login_picbox1.Size = new System.Drawing.Size(213, 180);
            this.login_picbox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.login_picbox1.TabIndex = 6;
            this.login_picbox1.TabStop = false;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(238, 287);
            this.Controls.Add(this.login_picbox1);
            this.Controls.Add(this.login_cancelbtn);
            this.Controls.Add(this.login_inloggenbtn);
            this.Controls.Add(this.login_wachtwoordtxtbox);
            this.Controls.Add(this.login_wachtwoordlbl);
            this.Controls.Add(this.login_usernameltxtbox);
            this.Controls.Add(this.login_usernamelbl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "login";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRS - Login";
            ((System.ComponentModel.ISupportInitialize)(this.login_picbox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label login_usernamelbl;
        private System.Windows.Forms.TextBox login_usernameltxtbox;
        private System.Windows.Forms.Label login_wachtwoordlbl;
        private System.Windows.Forms.TextBox login_wachtwoordtxtbox;
        private System.Windows.Forms.Button login_inloggenbtn;
        private System.Windows.Forms.Button login_cancelbtn;
        private System.Windows.Forms.PictureBox login_picbox1;
    }
}