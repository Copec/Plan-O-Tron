namespace Plan_o_Tron_6000.UI
{
    partial class Form1
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
            this.DebugButton = new System.Windows.Forms.Button();
            this.WizardButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AboutButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ImportButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DebugButton
            // 
            this.DebugButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DebugButton.BackColor = System.Drawing.Color.Fuchsia;
            this.DebugButton.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DebugButton.Location = new System.Drawing.Point(688, 689);
            this.DebugButton.Name = "DebugButton";
            this.DebugButton.Size = new System.Drawing.Size(420, 126);
            this.DebugButton.TabIndex = 1;
            this.DebugButton.Text = "Debug Me!";
            this.DebugButton.UseVisualStyleBackColor = false;
            this.DebugButton.Visible = false;
            this.DebugButton.Click += new System.EventHandler(this.Debug_Click);
            // 
            // WizardButton
            // 
            this.WizardButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.WizardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WizardButton.ForeColor = System.Drawing.SystemColors.InfoText;
            this.WizardButton.Location = new System.Drawing.Point(434, 317);
            this.WizardButton.Name = "WizardButton";
            this.WizardButton.Size = new System.Drawing.Size(210, 133);
            this.WizardButton.TabIndex = 5;
            this.WizardButton.Text = "Assistent starten";
            this.WizardButton.UseVisualStyleBackColor = false;
            this.WizardButton.Click += new System.EventHandler(this.WizardButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1069, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ein Programm sie zu knechten,sie alle zu finden, ins dunkel zu treiben und Kalkul" +
                "ation für Fahrradhändler";
            this.label1.Visible = false;
            // 
            // AboutButton
            // 
            this.AboutButton.BackgroundImage = global::Plan_o_Tron_6000.Properties.Resources.about;
            this.AboutButton.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutButton.ForeColor = System.Drawing.Color.Lime;
            this.AboutButton.Location = new System.Drawing.Point(963, 821);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(145, 71);
            this.AboutButton.TabIndex = 4;
            this.AboutButton.Text = "Über...";
            this.AboutButton.UseVisualStyleBackColor = true;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Plan_o_Tron_6000.Properties.Resources.logo2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1108, 892);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // ImportButton
            // 
            this.ImportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportButton.Location = new System.Drawing.Point(223, 317);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(153, 133);
            this.ImportButton.TabIndex = 12;
            this.ImportButton.Text = "XML Import...";
            this.ImportButton.UseVisualStyleBackColor = true;
            this.ImportButton.Click += new System.EventHandler(this.ImportButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 892);
            this.Controls.Add(this.ImportButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WizardButton);
            this.Controls.Add(this.AboutButton);
            this.Controls.Add(this.DebugButton);
            this.Controls.Add(this.pictureBox1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Ibsys Super Solver Engine";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button DebugButton;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.Button WizardButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ImportButton;
    }
}

