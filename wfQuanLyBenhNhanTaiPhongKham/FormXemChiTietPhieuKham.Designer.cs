
namespace wfQuanLyBenhNhanTaiPhongKham
{
    partial class FormXemChiTietPhieuKham
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
            this.dtpNgaylappk = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenpk = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMapk = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnthoat = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpNgaylappk
            // 
            this.dtpNgaylappk.Location = new System.Drawing.Point(134, 35);
            this.dtpNgaylappk.Name = "dtpNgaylappk";
            this.dtpNgaylappk.Size = new System.Drawing.Size(218, 20);
            this.dtpNgaylappk.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ngày lấy phiếu khám";
            // 
            // txtTenpk
            // 
            this.txtTenpk.Location = new System.Drawing.Point(388, 35);
            this.txtTenpk.Name = "txtTenpk";
            this.txtTenpk.Size = new System.Drawing.Size(100, 20);
            this.txtTenpk.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tên phiếu khám";
            // 
            // txtMapk
            // 
            this.txtMapk.Location = new System.Drawing.Point(11, 35);
            this.txtMapk.Name = "txtMapk";
            this.txtMapk.Size = new System.Drawing.Size(100, 20);
            this.txtMapk.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã phiếu khám";
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(565, 36);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 18;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column16,
            this.Column17,
            this.Column18,
            this.Column19});
            this.dgv.Location = new System.Drawing.Point(14, 163);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(652, 233);
            this.dgv.TabIndex = 38;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Mapk";
            this.Column1.HeaderText = "Mã phiếu khám";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Ngaylappk";
            this.Column2.HeaderText = "Ngày lập phiếu khám";
            this.Column2.Name = "Column2";
            this.Column2.Visible = false;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Tenpk";
            this.Column3.HeaderText = "Tên phiếu khám";
            this.Column3.Name = "Column3";
            this.Column3.Visible = false;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "madt";
            this.Column4.HeaderText = "Mã thuốc";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Tendt";
            this.Column5.HeaderText = "Tên thuốc";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Soluong";
            this.Column6.HeaderText = "Số lượng";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Dongia";
            this.Column7.HeaderText = "Đơn giá";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "thanhtien";
            this.Column8.HeaderText = "Thành tiền";
            this.Column8.Name = "Column8";
            // 
            // Column16
            // 
            this.Column16.DataPropertyName = "Mabs";
            this.Column16.HeaderText = "Mã bs";
            this.Column16.Name = "Column16";
            // 
            // Column17
            // 
            this.Column17.DataPropertyName = "Mabn";
            this.Column17.HeaderText = "Mã bn";
            this.Column17.Name = "Column17";
            // 
            // Column18
            // 
            this.Column18.DataPropertyName = "Hotenbs";
            this.Column18.HeaderText = "Tên bs";
            this.Column18.Name = "Column18";
            // 
            // Column19
            // 
            this.Column19.DataPropertyName = "Hotenbn";
            this.Column19.HeaderText = "Tên bn";
            this.Column19.Name = "Column19";
            // 
            // FormXemChiTietPhieuKham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.dtpNgaylappk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenpk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMapk);
            this.Controls.Add(this.label1);
            this.Name = "FormXemChiTietPhieuKham";
            this.Text = "FormXemChiTietPhieuKham";
            this.Load += new System.EventHandler(this.FormXemChiTietPhieuKham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpNgaylappk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenpk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMapk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
    }
}