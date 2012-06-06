namespace Plan_o_Tron_6000.UI
{
    partial class DebugWindow
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
            this.dataSet1 = new System.Data.DataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ItemListButton = new System.Windows.Forms.Button();
            this.StockButton = new System.Windows.Forms.Button();
            this.WorkstationButton = new System.Windows.Forms.Button();
            this.JobInspectorButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1068, 552);
            this.dataGridView1.TabIndex = 0;
            // 
            // ItemListButton
            // 
            this.ItemListButton.Location = new System.Drawing.Point(0, 573);
            this.ItemListButton.Name = "ItemListButton";
            this.ItemListButton.Size = new System.Drawing.Size(75, 23);
            this.ItemListButton.TabIndex = 1;
            this.ItemListButton.Text = "Stückliste";
            this.ItemListButton.UseVisualStyleBackColor = true;
            this.ItemListButton.Click += new System.EventHandler(this.ItemListButton_Click);
            // 
            // StockButton
            // 
            this.StockButton.Location = new System.Drawing.Point(81, 573);
            this.StockButton.Name = "StockButton";
            this.StockButton.Size = new System.Drawing.Size(75, 23);
            this.StockButton.TabIndex = 2;
            this.StockButton.Text = "Bestand";
            this.StockButton.UseVisualStyleBackColor = true;
            this.StockButton.Click += new System.EventHandler(this.StockButton_Click);
            // 
            // WorkstationButton
            // 
            this.WorkstationButton.Location = new System.Drawing.Point(162, 573);
            this.WorkstationButton.Name = "WorkstationButton";
            this.WorkstationButton.Size = new System.Drawing.Size(75, 23);
            this.WorkstationButton.TabIndex = 3;
            this.WorkstationButton.Text = "Arbeitsplätze";
            this.WorkstationButton.UseVisualStyleBackColor = true;
            this.WorkstationButton.Click += new System.EventHandler(this.WorkstationButton_Click);
            // 
            // JobInspectorButton
            // 
            this.JobInspectorButton.Location = new System.Drawing.Point(517, 573);
            this.JobInspectorButton.Name = "JobInspectorButton";
            this.JobInspectorButton.Size = new System.Drawing.Size(117, 23);
            this.JobInspectorButton.TabIndex = 4;
            this.JobInspectorButton.Text = "JobInspector...";
            this.JobInspectorButton.UseVisualStyleBackColor = true;
            this.JobInspectorButton.Click += new System.EventHandler(this.JobInspectorButton_Click);
            // 
            // DebugWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 595);
            this.Controls.Add(this.JobInspectorButton);
            this.Controls.Add(this.WorkstationButton);
            this.Controls.Add(this.StockButton);
            this.Controls.Add(this.ItemListButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DebugWindow";
            this.Text = "Teileliste";
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ItemListButton;
        private System.Windows.Forms.Button StockButton;
        private System.Windows.Forms.Button WorkstationButton;
        private System.Windows.Forms.Button JobInspectorButton;

    }
}