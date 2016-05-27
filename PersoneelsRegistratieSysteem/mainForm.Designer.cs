namespace PersoneelsRegistratieSysteem
{
    partial class mainForm
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
            this.mainForm_menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bestandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afsluitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.magazijnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.overzichtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invoerenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verlofToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainForm_menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainForm_menuStrip1
            // 
            this.mainForm_menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bestandToolStripMenuItem,
            this.magazijnToolStripMenuItem,
            this.loginToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.mainForm_menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.mainForm_menuStrip1.Name = "mainForm_menuStrip1";
            this.mainForm_menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.mainForm_menuStrip1.TabIndex = 1;
            this.mainForm_menuStrip1.Text = "menuStrip1";
            // 
            // bestandToolStripMenuItem
            // 
            this.bestandToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afsluitenToolStripMenuItem});
            this.bestandToolStripMenuItem.Name = "bestandToolStripMenuItem";
            this.bestandToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.bestandToolStripMenuItem.Text = "Bestand";
            // 
            // afsluitenToolStripMenuItem
            // 
            this.afsluitenToolStripMenuItem.Name = "afsluitenToolStripMenuItem";
            this.afsluitenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.afsluitenToolStripMenuItem.Text = "Afsluiten";
            // 
            // magazijnToolStripMenuItem
            // 
            this.magazijnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.overzichtToolStripMenuItem,
            this.invoerenToolStripMenuItem,
            this.verlofToolStripMenuItem});
            this.magazijnToolStripMenuItem.Name = "magazijnToolStripMenuItem";
            this.magazijnToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.magazijnToolStripMenuItem.Text = "Urenregistratie";
            // 
            // overzichtToolStripMenuItem
            // 
            this.overzichtToolStripMenuItem.Name = "overzichtToolStripMenuItem";
            this.overzichtToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.overzichtToolStripMenuItem.Text = "Overzicht";
            // 
            // invoerenToolStripMenuItem
            // 
            this.invoerenToolStripMenuItem.Name = "invoerenToolStripMenuItem";
            this.invoerenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.invoerenToolStripMenuItem.Text = "Invoeren";
            this.invoerenToolStripMenuItem.Click += new System.EventHandler(this.invoerenToolStripMenuItem_Click);
            // 
            // verlofToolStripMenuItem
            // 
            this.verlofToolStripMenuItem.Name = "verlofToolStripMenuItem";
            this.verlofToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.verlofToolStripMenuItem.Text = "Verlof";
            this.verlofToolStripMenuItem.Click += new System.EventHandler(this.verlofToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Enabled = false;
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Visible = false;
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databaseSettingsToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // databaseSettingsToolStripMenuItem
            // 
            this.databaseSettingsToolStripMenuItem.Name = "databaseSettingsToolStripMenuItem";
            this.databaseSettingsToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.databaseSettingsToolStripMenuItem.Text = "Database Settings";
            this.databaseSettingsToolStripMenuItem.Click += new System.EventHandler(this.databaseSettingsToolStripMenuItem_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1008, 726);
            this.Controls.Add(this.mainForm_menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.mainForm_menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRS - Personeel Registratie Systeem V0.1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.mainForm_menuStrip1.ResumeLayout(false);
            this.mainForm_menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainForm_menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bestandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afsluitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem magazijnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem overzichtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invoerenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verlofToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseSettingsToolStripMenuItem;
    }
}

