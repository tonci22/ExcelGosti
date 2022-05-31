namespace ExcelGosti
{
    partial class GostiUpis
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSelect = new System.Windows.Forms.Button();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.dgvExcel = new System.Windows.Forms.DataGridView();
            this.lbl = new System.Windows.Forms.Label();
            this.lblGuestSum = new System.Windows.Forms.Label();
            this.txtSheetName = new System.Windows.Forms.TextBox();
            this.lblSheet = new System.Windows.Forms.Label();
            this.lblMoneySum = new System.Windows.Forms.Label();
            this.txtMoneySum = new System.Windows.Forms.TextBox();
            this.lblBillCount = new System.Windows.Forms.Label();
            this.txtBillCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcel)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            this.btnSelect.AllowDrop = true;
            this.btnSelect.Location = new System.Drawing.Point(9, 10);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(102, 22);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "Select Excel File";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // fileDialog
            // 
            this.fileDialog.FileName = "openFileDialog1";
            // 
            // dgvExcel
            // 
            this.dgvExcel.AllowDrop = true;
            this.dgvExcel.AllowUserToAddRows = false;
            this.dgvExcel.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 13.25F);
            this.dgvExcel.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvExcel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvExcel.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvExcel.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dgvExcel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 13.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvExcel.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvExcel.Location = new System.Drawing.Point(9, 36);
            this.dgvExcel.Margin = new System.Windows.Forms.Padding(2);
            this.dgvExcel.Name = "dgvExcel";
            this.dgvExcel.ReadOnly = true;
            this.dgvExcel.RowTemplate.Height = 24;
            this.dgvExcel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExcel.Size = new System.Drawing.Size(964, 640);
            this.dgvExcel.TabIndex = 1;
            this.dgvExcel.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvExcel_DataBindingComplete);
            // 
            // lbl
            // 
            this.lbl.AllowDrop = true;
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(849, 17);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(90, 13);
            this.lbl.TabIndex = 3;
            this.lbl.Text = "Number of guests";
            // 
            // lblGuestSum
            // 
            this.lblGuestSum.AllowDrop = true;
            this.lblGuestSum.AutoSize = true;
            this.lblGuestSum.Location = new System.Drawing.Point(936, 17);
            this.lblGuestSum.Name = "lblGuestSum";
            this.lblGuestSum.Size = new System.Drawing.Size(13, 13);
            this.lblGuestSum.TabIndex = 4;
            this.lblGuestSum.Text = "0";
            // 
            // txtSheetName
            // 
            this.txtSheetName.Location = new System.Drawing.Point(322, 10);
            this.txtSheetName.Name = "txtSheetName";
            this.txtSheetName.Size = new System.Drawing.Size(78, 20);
            this.txtSheetName.TabIndex = 5;
            this.txtSheetName.Text = "Export";
            // 
            // lblSheet
            // 
            this.lblSheet.AutoSize = true;
            this.lblSheet.Location = new System.Drawing.Point(252, 13);
            this.lblSheet.Name = "lblSheet";
            this.lblSheet.Size = new System.Drawing.Size(64, 13);
            this.lblSheet.TabIndex = 6;
            this.lblSheet.Text = "Sheet name";
            // 
            // lblMoneySum
            // 
            this.lblMoneySum.AutoSize = true;
            this.lblMoneySum.Location = new System.Drawing.Point(439, 13);
            this.lblMoneySum.Name = "lblMoneySum";
            this.lblMoneySum.Size = new System.Drawing.Size(62, 13);
            this.lblMoneySum.TabIndex = 10;
            this.lblMoneySum.Text = "Sum money";
            // 
            // txtMoneySum
            // 
            this.txtMoneySum.Location = new System.Drawing.Point(509, 10);
            this.txtMoneySum.Name = "txtMoneySum";
            this.txtMoneySum.Size = new System.Drawing.Size(78, 20);
            this.txtMoneySum.TabIndex = 9;
            this.txtMoneySum.Text = "121960";
            this.txtMoneySum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMoneySum_KeyPress);
            // 
            // lblBillCount
            // 
            this.lblBillCount.AutoSize = true;
            this.lblBillCount.Location = new System.Drawing.Point(753, 17);
            this.lblBillCount.Name = "lblBillCount";
            this.lblBillCount.Size = new System.Drawing.Size(53, 13);
            this.lblBillCount.TabIndex = 11;
            this.lblBillCount.Text = "Bill count:";
            // 
            // txtBillCount
            // 
            this.txtBillCount.AutoSize = true;
            this.txtBillCount.Location = new System.Drawing.Point(802, 17);
            this.txtBillCount.Name = "txtBillCount";
            this.txtBillCount.Size = new System.Drawing.Size(13, 13);
            this.txtBillCount.TabIndex = 12;
            this.txtBillCount.Text = "0";
            // 
            // GostiUpis
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 722);
            this.Controls.Add(this.txtBillCount);
            this.Controls.Add(this.lblBillCount);
            this.Controls.Add(this.lblMoneySum);
            this.Controls.Add(this.txtMoneySum);
            this.Controls.Add(this.lblSheet);
            this.Controls.Add(this.txtSheetName);
            this.Controls.Add(this.lblGuestSum);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.dgvExcel);
            this.Controls.Add(this.btnSelect);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GostiUpis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excel gosti";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.GostiUpis_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.GostiUpis_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.OpenFileDialog fileDialog;
        private System.Windows.Forms.DataGridView dgvExcel;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblGuestSum;
        private System.Windows.Forms.TextBox txtSheetName;
        private System.Windows.Forms.Label lblSheet;
        private System.Windows.Forms.Label lblMoneySum;
        private System.Windows.Forms.TextBox txtMoneySum;
        private System.Windows.Forms.Label lblBillCount;
        private System.Windows.Forms.Label txtBillCount;
    }
}

