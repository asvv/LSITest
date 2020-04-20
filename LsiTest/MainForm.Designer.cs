namespace LsiTest
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.exportDataGrid = new System.Windows.Forms.DataGridView();
            this.localsComboBox = new System.Windows.Forms.ComboBox();
            this.dateFromPicker = new System.Windows.Forms.DateTimePicker();
            this.dateToPicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.ExportName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExportDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExportHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocalName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.exportDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // exportDataGrid
            // 
            this.exportDataGrid.AllowUserToAddRows = false;
            this.exportDataGrid.AllowUserToDeleteRows = false;
            this.exportDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.exportDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ExportName,
            this.ExportDate,
            this.ExportHour,
            this.UserFullName,
            this.LocalName});
            this.exportDataGrid.Location = new System.Drawing.Point(244, 12);
            this.exportDataGrid.Name = "exportDataGrid";
            this.exportDataGrid.ReadOnly = true;
            this.exportDataGrid.Size = new System.Drawing.Size(544, 426);
            this.exportDataGrid.TabIndex = 0;
            // 
            // localsComboBox
            // 
            this.localsComboBox.DisplayMember = "Name";
            this.localsComboBox.FormattingEnabled = true;
            this.localsComboBox.Location = new System.Drawing.Point(12, 40);
            this.localsComboBox.Name = "localsComboBox";
            this.localsComboBox.Size = new System.Drawing.Size(226, 21);
            this.localsComboBox.TabIndex = 1;
            this.localsComboBox.SelectedIndexChanged += new System.EventHandler(this.localsComboBox_SelectedIndexChanged);
            // 
            // dateFromPicker
            // 
            this.dateFromPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFromPicker.Location = new System.Drawing.Point(12, 87);
            this.dateFromPicker.Name = "dateFromPicker";
            this.dateFromPicker.Size = new System.Drawing.Size(226, 20);
            this.dateFromPicker.TabIndex = 2;
            // 
            // dateToPicker
            // 
            this.dateToPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateToPicker.Location = new System.Drawing.Point(12, 130);
            this.dateToPicker.Name = "dateToPicker";
            this.dateToPicker.Size = new System.Drawing.Size(226, 20);
            this.dateToPicker.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lokal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Od";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Do";
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(12, 168);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(117, 23);
            this.confirmButton.TabIndex = 7;
            this.confirmButton.Text = "Zatwierdź";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // ExportName
            // 
            this.ExportName.DataPropertyName = "ExportName";
            this.ExportName.HeaderText = "Nazwa";
            this.ExportName.Name = "ExportName";
            this.ExportName.ReadOnly = true;
            // 
            // ExportDate
            // 
            this.ExportDate.DataPropertyName = "ExportDate";
            this.ExportDate.HeaderText = "Data";
            this.ExportDate.Name = "ExportDate";
            this.ExportDate.ReadOnly = true;
            // 
            // ExportHour
            // 
            this.ExportHour.DataPropertyName = "ExportDate";
            this.ExportHour.HeaderText = "Godzina";
            this.ExportHour.Name = "ExportHour";
            this.ExportHour.ReadOnly = true;
            // 
            // UserFullName
            // 
            this.UserFullName.DataPropertyName = "UserFullName";
            this.UserFullName.HeaderText = "Użytkownik";
            this.UserFullName.Name = "UserFullName";
            this.UserFullName.ReadOnly = true;
            // 
            // LocalName
            // 
            this.LocalName.DataPropertyName = "LocalName";
            this.LocalName.HeaderText = "Lokal";
            this.LocalName.Name = "LocalName";
            this.LocalName.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateToPicker);
            this.Controls.Add(this.dateFromPicker);
            this.Controls.Add(this.localsComboBox);
            this.Controls.Add(this.exportDataGrid);
            this.Name = "MainForm";
            this.Text = "Main window";
            ((System.ComponentModel.ISupportInitialize)(this.exportDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView exportDataGrid;
        private System.Windows.Forms.ComboBox localsComboBox;
        private System.Windows.Forms.DateTimePicker dateFromPicker;
        private System.Windows.Forms.DateTimePicker dateToPicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExportName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExportDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExportHour;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocalName;
    }
}

