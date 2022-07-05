namespace Views
{
    partial class frmMainView
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
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.dgvDataView = new System.Windows.Forms.DataGridView();
            this.grpActiveFilters = new System.Windows.Forms.GroupBox();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.btnRemoveOne = new System.Windows.Forms.Button();
            this.txtActiveFilters = new System.Windows.Forms.TextBox();
            this.grpApplyFilter = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnApplyFilter = new System.Windows.Forms.Button();
            this.txtFilterInput = new System.Windows.Forms.TextBox();
            this.cmbColumn = new System.Windows.Forms.ComboBox();
            this.rdImportHeaders = new System.Windows.Forms.RadioButton();
            this.rdInputHeaders = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataView)).BeginInit();
            this.grpActiveFilters.SuspendLayout();
            this.grpApplyFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(26, 14);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(139, 57);
            this.btnLoadFile.TabIndex = 0;
            this.btnLoadFile.Text = "Load file";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvDataView
            // 
            this.dgvDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataView.Location = new System.Drawing.Point(346, 12);
            this.dgvDataView.Name = "dgvDataView";
            this.dgvDataView.Size = new System.Drawing.Size(833, 626);
            this.dgvDataView.TabIndex = 1;
            // 
            // grpActiveFilters
            // 
            this.grpActiveFilters.Controls.Add(this.btnRemoveAll);
            this.grpActiveFilters.Controls.Add(this.btnRemoveOne);
            this.grpActiveFilters.Controls.Add(this.txtActiveFilters);
            this.grpActiveFilters.Location = new System.Drawing.Point(12, 84);
            this.grpActiveFilters.Name = "grpActiveFilters";
            this.grpActiveFilters.Size = new System.Drawing.Size(306, 185);
            this.grpActiveFilters.TabIndex = 2;
            this.grpActiveFilters.TabStop = false;
            this.grpActiveFilters.Text = "Active Filters";
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Location = new System.Drawing.Point(153, 155);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(147, 23);
            this.btnRemoveAll.TabIndex = 2;
            this.btnRemoveAll.Text = "Remove all filters";
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            // 
            // btnRemoveOne
            // 
            this.btnRemoveOne.Location = new System.Drawing.Point(6, 155);
            this.btnRemoveOne.Name = "btnRemoveOne";
            this.btnRemoveOne.Size = new System.Drawing.Size(147, 23);
            this.btnRemoveOne.TabIndex = 1;
            this.btnRemoveOne.Text = "Remove current filter";
            this.btnRemoveOne.UseVisualStyleBackColor = true;
            // 
            // txtActiveFilters
            // 
            this.txtActiveFilters.Location = new System.Drawing.Point(6, 19);
            this.txtActiveFilters.Multiline = true;
            this.txtActiveFilters.Name = "txtActiveFilters";
            this.txtActiveFilters.Size = new System.Drawing.Size(294, 130);
            this.txtActiveFilters.TabIndex = 0;
            this.txtActiveFilters.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // grpApplyFilter
            // 
            this.grpApplyFilter.Controls.Add(this.label2);
            this.grpApplyFilter.Controls.Add(this.label1);
            this.grpApplyFilter.Controls.Add(this.btnApplyFilter);
            this.grpApplyFilter.Controls.Add(this.txtFilterInput);
            this.grpApplyFilter.Controls.Add(this.cmbColumn);
            this.grpApplyFilter.Location = new System.Drawing.Point(12, 275);
            this.grpApplyFilter.Name = "grpApplyFilter";
            this.grpApplyFilter.Size = new System.Drawing.Size(306, 170);
            this.grpApplyFilter.TabIndex = 3;
            this.grpApplyFilter.TabStop = false;
            this.grpApplyFilter.Text = "Apply Filter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Filter Value";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Column";
            // 
            // btnApplyFilter
            // 
            this.btnApplyFilter.Location = new System.Drawing.Point(85, 89);
            this.btnApplyFilter.Name = "btnApplyFilter";
            this.btnApplyFilter.Size = new System.Drawing.Size(147, 39);
            this.btnApplyFilter.TabIndex = 2;
            this.btnApplyFilter.Text = "Apply Filter";
            this.btnApplyFilter.UseVisualStyleBackColor = true;
            // 
            // txtFilterInput
            // 
            this.txtFilterInput.Location = new System.Drawing.Point(85, 63);
            this.txtFilterInput.Name = "txtFilterInput";
            this.txtFilterInput.Size = new System.Drawing.Size(147, 20);
            this.txtFilterInput.TabIndex = 1;
            // 
            // cmbColumn
            // 
            this.cmbColumn.FormattingEnabled = true;
            this.cmbColumn.Location = new System.Drawing.Point(85, 36);
            this.cmbColumn.Name = "cmbColumn";
            this.cmbColumn.Size = new System.Drawing.Size(147, 21);
            this.cmbColumn.TabIndex = 0;
            this.cmbColumn.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // rdImportHeaders
            // 
            this.rdImportHeaders.AutoSize = true;
            this.rdImportHeaders.Location = new System.Drawing.Point(171, 21);
            this.rdImportHeaders.Name = "rdImportHeaders";
            this.rdImportHeaders.Size = new System.Drawing.Size(137, 17);
            this.rdImportHeaders.TabIndex = 4;
            this.rdImportHeaders.TabStop = true;
            this.rdImportHeaders.Text = "Use top row as headers";
            this.rdImportHeaders.UseVisualStyleBackColor = true;
            // 
            // rdInputHeaders
            // 
            this.rdInputHeaders.AutoSize = true;
            this.rdInputHeaders.Location = new System.Drawing.Point(171, 44);
            this.rdInputHeaders.Name = "rdInputHeaders";
            this.rdInputHeaders.Size = new System.Drawing.Size(134, 17);
            this.rdInputHeaders.TabIndex = 5;
            this.rdInputHeaders.TabStop = true;
            this.rdInputHeaders.Text = "Input headers manually";
            this.rdInputHeaders.UseVisualStyleBackColor = true;
            // 
            // frmMainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 650);
            this.Controls.Add(this.rdInputHeaders);
            this.Controls.Add(this.rdImportHeaders);
            this.Controls.Add(this.grpApplyFilter);
            this.Controls.Add(this.dgvDataView);
            this.Controls.Add(this.btnLoadFile);
            this.Controls.Add(this.grpActiveFilters);
            this.Name = "frmMainView";
            this.Text = "CSV Viewer";
            this.Load += new System.EventHandler(this.frmMainView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataView)).EndInit();
            this.grpActiveFilters.ResumeLayout(false);
            this.grpActiveFilters.PerformLayout();
            this.grpApplyFilter.ResumeLayout(false);
            this.grpApplyFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.DataGridView dgvDataView;
        private System.Windows.Forms.GroupBox grpActiveFilters;
        private System.Windows.Forms.TextBox txtActiveFilters;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.Button btnRemoveOne;
        private System.Windows.Forms.GroupBox grpApplyFilter;
        private System.Windows.Forms.ComboBox cmbColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnApplyFilter;
        private System.Windows.Forms.TextBox txtFilterInput;
        private System.Windows.Forms.RadioButton rdImportHeaders;
        private System.Windows.Forms.RadioButton rdInputHeaders;
    }
}

