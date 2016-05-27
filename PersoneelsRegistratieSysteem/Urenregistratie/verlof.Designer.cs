namespace PersoneelsRegistratieSysteem.Urenregistratie
{
    partial class verlof
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
            this.verlof_medewerkercmbobox = new System.Windows.Forms.GroupBox();
            this.verlof_medewerkercmbbox = new System.Windows.Forms.ComboBox();
            this.verlof_gegevens = new System.Windows.Forms.GroupBox();
            this.verlof_datum = new System.Windows.Forms.DateTimePicker();
            this.verlof_annulerenBTN = new System.Windows.Forms.Button();
            this.verlof_aanvragenBTN = new System.Windows.Forms.Button();
            this.verlof_omschrijving_richtxtbx = new System.Windows.Forms.RichTextBox();
            this.verlof_omschrijving_lbl = new System.Windows.Forms.Label();
            this.verlof_txtbox_tijd = new System.Windows.Forms.TextBox();
            this.verlof_tijd_lbl = new System.Windows.Forms.Label();
            this.verlof_datum_lbl = new System.Windows.Forms.Label();
            this.verlof_medewerkercmbobox.SuspendLayout();
            this.verlof_gegevens.SuspendLayout();
            this.SuspendLayout();
            // 
            // verlof_medewerkercmbobox
            // 
            this.verlof_medewerkercmbobox.Controls.Add(this.verlof_medewerkercmbbox);
            this.verlof_medewerkercmbobox.Location = new System.Drawing.Point(13, 13);
            this.verlof_medewerkercmbobox.Name = "verlof_medewerkercmbobox";
            this.verlof_medewerkercmbobox.Size = new System.Drawing.Size(208, 53);
            this.verlof_medewerkercmbobox.TabIndex = 0;
            this.verlof_medewerkercmbobox.TabStop = false;
            this.verlof_medewerkercmbobox.Text = "Medewerker";
            // 
            // verlof_medewerkercmbbox
            // 
            this.verlof_medewerkercmbbox.DropDownHeight = 105;
            this.verlof_medewerkercmbbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.verlof_medewerkercmbbox.FormattingEnabled = true;
            this.verlof_medewerkercmbbox.IntegralHeight = false;
            this.verlof_medewerkercmbbox.Location = new System.Drawing.Point(7, 20);
            this.verlof_medewerkercmbbox.Name = "verlof_medewerkercmbbox";
            this.verlof_medewerkercmbbox.Size = new System.Drawing.Size(167, 21);
            this.verlof_medewerkercmbbox.TabIndex = 0;
            this.verlof_medewerkercmbbox.SelectedIndexChanged += new System.EventHandler(this.verlof_medewerkercmbbox_SelectedIndexChanged);
            // 
            // verlof_gegevens
            // 
            this.verlof_gegevens.Controls.Add(this.verlof_datum);
            this.verlof_gegevens.Controls.Add(this.verlof_annulerenBTN);
            this.verlof_gegevens.Controls.Add(this.verlof_aanvragenBTN);
            this.verlof_gegevens.Controls.Add(this.verlof_omschrijving_richtxtbx);
            this.verlof_gegevens.Controls.Add(this.verlof_omschrijving_lbl);
            this.verlof_gegevens.Controls.Add(this.verlof_txtbox_tijd);
            this.verlof_gegevens.Controls.Add(this.verlof_tijd_lbl);
            this.verlof_gegevens.Controls.Add(this.verlof_datum_lbl);
            this.verlof_gegevens.Enabled = false;
            this.verlof_gegevens.Location = new System.Drawing.Point(13, 73);
            this.verlof_gegevens.Name = "verlof_gegevens";
            this.verlof_gegevens.Size = new System.Drawing.Size(208, 230);
            this.verlof_gegevens.TabIndex = 1;
            this.verlof_gegevens.TabStop = false;
            this.verlof_gegevens.Text = "Verlof Gegevens";
            this.verlof_gegevens.Visible = false;
            // 
            // verlof_datum
            // 
            this.verlof_datum.Location = new System.Drawing.Point(10, 37);
            this.verlof_datum.Name = "verlof_datum";
            this.verlof_datum.Size = new System.Drawing.Size(183, 20);
            this.verlof_datum.TabIndex = 10;
            // 
            // verlof_annulerenBTN
            // 
            this.verlof_annulerenBTN.Location = new System.Drawing.Point(7, 195);
            this.verlof_annulerenBTN.Name = "verlof_annulerenBTN";
            this.verlof_annulerenBTN.Size = new System.Drawing.Size(75, 23);
            this.verlof_annulerenBTN.TabIndex = 7;
            this.verlof_annulerenBTN.Text = "Annuleren";
            this.verlof_annulerenBTN.UseVisualStyleBackColor = true;
            this.verlof_annulerenBTN.Click += new System.EventHandler(this.verlof_annulerenBTN_Click);
            // 
            // verlof_aanvragenBTN
            // 
            this.verlof_aanvragenBTN.Location = new System.Drawing.Point(118, 195);
            this.verlof_aanvragenBTN.Name = "verlof_aanvragenBTN";
            this.verlof_aanvragenBTN.Size = new System.Drawing.Size(75, 23);
            this.verlof_aanvragenBTN.TabIndex = 6;
            this.verlof_aanvragenBTN.Text = "Aanvragen";
            this.verlof_aanvragenBTN.UseVisualStyleBackColor = true;
            this.verlof_aanvragenBTN.Click += new System.EventHandler(this.verlof_aanvragenBTN_Click);
            // 
            // verlof_omschrijving_richtxtbx
            // 
            this.verlof_omschrijving_richtxtbx.Location = new System.Drawing.Point(6, 120);
            this.verlof_omschrijving_richtxtbx.Name = "verlof_omschrijving_richtxtbx";
            this.verlof_omschrijving_richtxtbx.Size = new System.Drawing.Size(187, 69);
            this.verlof_omschrijving_richtxtbx.TabIndex = 5;
            this.verlof_omschrijving_richtxtbx.Text = "";
            // 
            // verlof_omschrijving_lbl
            // 
            this.verlof_omschrijving_lbl.AutoSize = true;
            this.verlof_omschrijving_lbl.Location = new System.Drawing.Point(6, 103);
            this.verlof_omschrijving_lbl.Name = "verlof_omschrijving_lbl";
            this.verlof_omschrijving_lbl.Size = new System.Drawing.Size(67, 13);
            this.verlof_omschrijving_lbl.TabIndex = 4;
            this.verlof_omschrijving_lbl.Text = "Omschrijving";
            // 
            // verlof_txtbox_tijd
            // 
            this.verlof_txtbox_tijd.Location = new System.Drawing.Point(7, 79);
            this.verlof_txtbox_tijd.Name = "verlof_txtbox_tijd";
            this.verlof_txtbox_tijd.Size = new System.Drawing.Size(66, 20);
            this.verlof_txtbox_tijd.TabIndex = 3;
            // 
            // verlof_tijd_lbl
            // 
            this.verlof_tijd_lbl.AutoSize = true;
            this.verlof_tijd_lbl.Location = new System.Drawing.Point(7, 64);
            this.verlof_tijd_lbl.Name = "verlof_tijd_lbl";
            this.verlof_tijd_lbl.Size = new System.Drawing.Size(47, 13);
            this.verlof_tijd_lbl.TabIndex = 2;
            this.verlof_tijd_lbl.Text = "Hoe laat";
            // 
            // verlof_datum_lbl
            // 
            this.verlof_datum_lbl.AutoSize = true;
            this.verlof_datum_lbl.Location = new System.Drawing.Point(7, 20);
            this.verlof_datum_lbl.Name = "verlof_datum_lbl";
            this.verlof_datum_lbl.Size = new System.Drawing.Size(38, 13);
            this.verlof_datum_lbl.TabIndex = 0;
            this.verlof_datum_lbl.Text = "Datum";
            // 
            // verlof
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 317);
            this.Controls.Add(this.verlof_gegevens);
            this.Controls.Add(this.verlof_medewerkercmbobox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "verlof";
            this.Text = "Verlof Aanvragen";
            this.Load += new System.EventHandler(this.verlof_Load);
            this.verlof_medewerkercmbobox.ResumeLayout(false);
            this.verlof_gegevens.ResumeLayout(false);
            this.verlof_gegevens.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox verlof_medewerkercmbobox;
        private System.Windows.Forms.ComboBox verlof_medewerkercmbbox;
        private System.Windows.Forms.GroupBox verlof_gegevens;
        private System.Windows.Forms.Button verlof_annulerenBTN;
        private System.Windows.Forms.Button verlof_aanvragenBTN;
        private System.Windows.Forms.RichTextBox verlof_omschrijving_richtxtbx;
        private System.Windows.Forms.Label verlof_omschrijving_lbl;
        private System.Windows.Forms.TextBox verlof_txtbox_tijd;
        private System.Windows.Forms.Label verlof_tijd_lbl;
        private System.Windows.Forms.Label verlof_datum_lbl;
        private System.Windows.Forms.DateTimePicker verlof_datum;
    }
}