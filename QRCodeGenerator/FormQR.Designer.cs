namespace QRCodeEnDecode
{
    partial class FormQR
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQR));
            this.pictureBoxQR = new System.Windows.Forms.PictureBox();
            this.textBoxQR = new System.Windows.Forms.TextBox();
            this.buttonGenerieren = new System.Windows.Forms.Button();
            this.buttonDecodieren = new System.Windows.Forms.Button();
            this.buttonOeffnen = new System.Windows.Forms.Button();
            this.textBoxGroesse = new System.Windows.Forms.TextBox();
            this.labelGroesse = new System.Windows.Forms.Label();
            this.buttonLogo = new System.Windows.Forms.Button();
            this.comboBoxFehler = new System.Windows.Forms.ComboBox();
            this.openFileDialogQR = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogLogo = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogQR = new System.Windows.Forms.SaveFileDialog();
            this.buttonSpeichern = new System.Windows.Forms.Button();
            this.comboBoxFarbe = new System.Windows.Forms.ComboBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPicLeeren = new System.Windows.Forms.Button();
            this.buttonTextLeeren = new System.Windows.Forms.Button();
            this.buttonScann = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxQR
            // 
            this.pictureBoxQR.BackColor = System.Drawing.Color.Black;
            this.pictureBoxQR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxQR.Location = new System.Drawing.Point(10, 10);
            this.pictureBoxQR.Name = "pictureBoxQR";
            this.pictureBoxQR.Size = new System.Drawing.Size(500, 500);
            this.pictureBoxQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxQR.TabIndex = 0;
            this.pictureBoxQR.TabStop = false;
            // 
            // textBoxQR
            // 
            this.textBoxQR.BackColor = System.Drawing.Color.Black;
            this.textBoxQR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxQR.ForeColor = System.Drawing.Color.Lime;
            this.textBoxQR.Location = new System.Drawing.Point(116, 574);
            this.textBoxQR.Multiline = true;
            this.textBoxQR.Name = "textBoxQR";
            this.textBoxQR.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxQR.Size = new System.Drawing.Size(394, 100);
            this.textBoxQR.TabIndex = 1;
            // 
            // buttonGenerieren
            // 
            this.buttonGenerieren.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGenerieren.Location = new System.Drawing.Point(435, 516);
            this.buttonGenerieren.Name = "buttonGenerieren";
            this.buttonGenerieren.Size = new System.Drawing.Size(75, 23);
            this.buttonGenerieren.TabIndex = 2;
            this.buttonGenerieren.Text = "generieren";
            this.buttonGenerieren.UseVisualStyleBackColor = true;
            this.buttonGenerieren.Click += new System.EventHandler(this.buttonGenerieren_Click);
            // 
            // buttonDecodieren
            // 
            this.buttonDecodieren.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDecodieren.Location = new System.Drawing.Point(91, 516);
            this.buttonDecodieren.Name = "buttonDecodieren";
            this.buttonDecodieren.Size = new System.Drawing.Size(75, 23);
            this.buttonDecodieren.TabIndex = 3;
            this.buttonDecodieren.Text = "decodieren";
            this.buttonDecodieren.UseVisualStyleBackColor = true;
            this.buttonDecodieren.Click += new System.EventHandler(this.buttonLesen_Click);
            // 
            // buttonOeffnen
            // 
            this.buttonOeffnen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOeffnen.Location = new System.Drawing.Point(10, 516);
            this.buttonOeffnen.Name = "buttonOeffnen";
            this.buttonOeffnen.Size = new System.Drawing.Size(75, 23);
            this.buttonOeffnen.TabIndex = 4;
            this.buttonOeffnen.Text = "öffnen";
            this.buttonOeffnen.UseVisualStyleBackColor = true;
            this.buttonOeffnen.Click += new System.EventHandler(this.buttonOeffnen_Click);
            // 
            // textBoxGroesse
            // 
            this.textBoxGroesse.BackColor = System.Drawing.Color.Black;
            this.textBoxGroesse.ForeColor = System.Drawing.Color.Lime;
            this.textBoxGroesse.Location = new System.Drawing.Point(384, 547);
            this.textBoxGroesse.Name = "textBoxGroesse";
            this.textBoxGroesse.Size = new System.Drawing.Size(45, 20);
            this.textBoxGroesse.TabIndex = 5;
            // 
            // labelGroesse
            // 
            this.labelGroesse.AutoSize = true;
            this.labelGroesse.Location = new System.Drawing.Point(342, 550);
            this.labelGroesse.Name = "labelGroesse";
            this.labelGroesse.Size = new System.Drawing.Size(36, 13);
            this.labelGroesse.TabIndex = 6;
            this.labelGroesse.Text = "Größe";
            // 
            // buttonLogo
            // 
            this.buttonLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogo.Location = new System.Drawing.Point(10, 544);
            this.buttonLogo.Name = "buttonLogo";
            this.buttonLogo.Size = new System.Drawing.Size(75, 23);
            this.buttonLogo.TabIndex = 7;
            this.buttonLogo.Text = "Logo";
            this.buttonLogo.UseVisualStyleBackColor = true;
            this.buttonLogo.Click += new System.EventHandler(this.buttonLogo_Click);
            // 
            // comboBoxFehler
            // 
            this.comboBoxFehler.BackColor = System.Drawing.Color.Black;
            this.comboBoxFehler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFehler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxFehler.ForeColor = System.Drawing.Color.Lime;
            this.comboBoxFehler.FormattingEnabled = true;
            this.comboBoxFehler.Items.AddRange(new object[] {
            "H (30%)",
            "Q (25%)",
            "M (15%)",
            "L (7%)"});
            this.comboBoxFehler.Location = new System.Drawing.Point(367, 516);
            this.comboBoxFehler.Name = "comboBoxFehler";
            this.comboBoxFehler.Size = new System.Drawing.Size(62, 21);
            this.comboBoxFehler.TabIndex = 8;
            // 
            // openFileDialogQR
            // 
            this.openFileDialogQR.Filter = "PNG|*.png|JPEG|*.jpg|BMP|*.bmp|GIF|*.gif|Alle(*.*)|*.*";
            // 
            // openFileDialogLogo
            // 
            this.openFileDialogLogo.Filter = "PNG|*.png|JPEG|*.jpg|BMP|*.bmp|GIF|*.gif|Alle(*.*)|*.*";
            // 
            // saveFileDialogQR
            // 
            this.saveFileDialogQR.Filter = "PNG|*.png|JPEG|*.jpg|BMP|*.bmp|GIF|*.gif";
            // 
            // buttonSpeichern
            // 
            this.buttonSpeichern.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSpeichern.Location = new System.Drawing.Point(435, 545);
            this.buttonSpeichern.Name = "buttonSpeichern";
            this.buttonSpeichern.Size = new System.Drawing.Size(75, 23);
            this.buttonSpeichern.TabIndex = 9;
            this.buttonSpeichern.Text = "speichern";
            this.buttonSpeichern.UseVisualStyleBackColor = true;
            this.buttonSpeichern.Click += new System.EventHandler(this.buttonSpeichern_Click);
            // 
            // comboBoxFarbe
            // 
            this.comboBoxFarbe.BackColor = System.Drawing.Color.Black;
            this.comboBoxFarbe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFarbe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxFarbe.ForeColor = System.Drawing.Color.Lime;
            this.comboBoxFarbe.FormattingEnabled = true;
            this.comboBoxFarbe.Items.AddRange(new object[] {
            "Rot",
            "Grün",
            "Blau",
            "Schwarz"});
            this.comboBoxFarbe.Location = new System.Drawing.Point(293, 516);
            this.comboBoxFarbe.Name = "comboBoxFarbe";
            this.comboBoxFarbe.Size = new System.Drawing.Size(68, 21);
            this.comboBoxFarbe.TabIndex = 10;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxLogo.Location = new System.Drawing.Point(10, 573);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 11;
            this.pictureBoxLogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 521);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Farbe";
            // 
            // buttonPicLeeren
            // 
            this.buttonPicLeeren.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPicLeeren.Location = new System.Drawing.Point(172, 516);
            this.buttonPicLeeren.Name = "buttonPicLeeren";
            this.buttonPicLeeren.Size = new System.Drawing.Size(75, 23);
            this.buttonPicLeeren.TabIndex = 14;
            this.buttonPicLeeren.Text = "Pic leeren";
            this.buttonPicLeeren.UseVisualStyleBackColor = true;
            this.buttonPicLeeren.Click += new System.EventHandler(this.buttonPicLeeren_Click);
            // 
            // buttonTextLeeren
            // 
            this.buttonTextLeeren.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTextLeeren.Location = new System.Drawing.Point(172, 544);
            this.buttonTextLeeren.Name = "buttonTextLeeren";
            this.buttonTextLeeren.Size = new System.Drawing.Size(75, 23);
            this.buttonTextLeeren.TabIndex = 15;
            this.buttonTextLeeren.Text = "Text leeren";
            this.buttonTextLeeren.UseVisualStyleBackColor = true;
            this.buttonTextLeeren.Click += new System.EventHandler(this.buttonTextLeeren_Click);
            // 
            // buttonScann
            // 
            this.buttonScann.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonScann.Location = new System.Drawing.Point(91, 544);
            this.buttonScann.Name = "buttonScann";
            this.buttonScann.Size = new System.Drawing.Size(75, 23);
            this.buttonScann.TabIndex = 16;
            this.buttonScann.Text = "scan";
            this.buttonScann.UseVisualStyleBackColor = true;
            this.buttonScann.Click += new System.EventHandler(this.buttonScann_Click);
            // 
            // FormQR
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(521, 685);
            this.Controls.Add(this.buttonScann);
            this.Controls.Add(this.buttonTextLeeren);
            this.Controls.Add(this.buttonPicLeeren);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.comboBoxFarbe);
            this.Controls.Add(this.buttonSpeichern);
            this.Controls.Add(this.comboBoxFehler);
            this.Controls.Add(this.buttonLogo);
            this.Controls.Add(this.labelGroesse);
            this.Controls.Add(this.textBoxGroesse);
            this.Controls.Add(this.buttonOeffnen);
            this.Controls.Add(this.buttonDecodieren);
            this.Controls.Add(this.buttonGenerieren);
            this.Controls.Add(this.textBoxQR);
            this.Controls.Add(this.pictureBoxQR);
            this.ForeColor = System.Drawing.Color.Lime;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(537, 724);
            this.Name = "FormQR";
            this.Opacity = 0.9D;
            this.Text = "QRCodeEn&Decode";
            this.Load += new System.EventHandler(this.FormQR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxQR;
        private System.Windows.Forms.TextBox textBoxQR;
        private System.Windows.Forms.Button buttonGenerieren;
        private System.Windows.Forms.Button buttonDecodieren;
        private System.Windows.Forms.Button buttonOeffnen;
        private System.Windows.Forms.TextBox textBoxGroesse;
        private System.Windows.Forms.Label labelGroesse;
        private System.Windows.Forms.Button buttonLogo;
        private System.Windows.Forms.ComboBox comboBoxFehler;
        private System.Windows.Forms.OpenFileDialog openFileDialogQR;
        private System.Windows.Forms.OpenFileDialog openFileDialogLogo;
        private System.Windows.Forms.SaveFileDialog saveFileDialogQR;
        private System.Windows.Forms.Button buttonSpeichern;
        private System.Windows.Forms.ComboBox comboBoxFarbe;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPicLeeren;
        private System.Windows.Forms.Button buttonTextLeeren;
        private System.Windows.Forms.Button buttonScann;
    }
}

