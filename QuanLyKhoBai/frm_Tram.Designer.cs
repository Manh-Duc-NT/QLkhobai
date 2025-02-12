
namespace QuanLyKhoBai
{
    partial class frm_Tram
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenTram = new System.Windows.Forms.TextBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.grThietBi = new System.Windows.Forms.DataGridView();
            this.txtMaTram = new System.Windows.Forms.TextBox();
            this.picTram = new System.Windows.Forms.PictureBox();
            this.btn_HinhAnh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nbSLX = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbNguoiQuanLy = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtBD = new System.Windows.Forms.DateTimePicker();
            this.dtDC = new System.Windows.Forms.DateTimePicker();
            this.cbKhuVuc = new System.Windows.Forms.ComboBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianMoCua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianDongCua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KhuVuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NguoiQuanLy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HinhAnh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grThietBi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbSLX)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Trạm";
            // 
            // txtTenTram
            // 
            this.txtTenTram.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTram.Location = new System.Drawing.Point(468, 35);
            this.txtTenTram.Name = "txtTenTram";
            this.txtTenTram.Size = new System.Drawing.Size(569, 32);
            this.txtTenTram.TabIndex = 1;
            this.txtTenTram.WordWrap = false;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(665, 340);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(113, 34);
            this.btn_Them.TabIndex = 2;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(924, 340);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(113, 34);
            this.btn_Xoa.TabIndex = 3;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(794, 340);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(113, 34);
            this.btn_Sua.TabIndex = 4;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // grThietBi
            // 
            this.grThietBi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grThietBi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grThietBi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Ten,
            this.DonVi,
            this.ThoiGianMoCua,
            this.ThoiGianDongCua,
            this.KhuVuc,
            this.NguoiQuanLy,
            this.HinhAnh});
            this.grThietBi.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grThietBi.Location = new System.Drawing.Point(12, 405);
            this.grThietBi.Name = "grThietBi";
            this.grThietBi.RowHeadersWidth = 51;
            this.grThietBi.RowTemplate.Height = 24;
            this.grThietBi.Size = new System.Drawing.Size(1028, 252);
            this.grThietBi.TabIndex = 5;
            this.grThietBi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grThietBi_CellClick);
            // 
            // txtMaTram
            // 
            this.txtMaTram.Enabled = false;
            this.txtMaTram.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTram.Location = new System.Drawing.Point(321, 338);
            this.txtMaTram.Name = "txtMaTram";
            this.txtMaTram.Size = new System.Drawing.Size(278, 32);
            this.txtMaTram.TabIndex = 6;
            this.txtMaTram.Visible = false;
            this.txtMaTram.WordWrap = false;
            // 
            // picTram
            // 
            this.picTram.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picTram.Location = new System.Drawing.Point(12, 12);
            this.picTram.Name = "picTram";
            this.picTram.Size = new System.Drawing.Size(128, 118);
            this.picTram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTram.TabIndex = 7;
            this.picTram.TabStop = false;
            // 
            // btn_HinhAnh
            // 
            this.btn_HinhAnh.Location = new System.Drawing.Point(173, 44);
            this.btn_HinhAnh.Name = "btn_HinhAnh";
            this.btn_HinhAnh.Size = new System.Drawing.Size(75, 23);
            this.btn_HinhAnh.TabIndex = 8;
            this.btn_HinhAnh.Text = "Hình ảnh";
            this.btn_HinhAnh.UseVisualStyleBackColor = true;
            this.btn_HinhAnh.Click += new System.EventHandler(this.btn_HinhAnh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Số lượng xe";
            // 
            // nbSLX
            // 
            this.nbSLX.Location = new System.Drawing.Point(468, 91);
            this.nbSLX.Name = "nbSLX";
            this.nbSLX.Size = new System.Drawing.Size(142, 22);
            this.nbSLX.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Khu vực";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(317, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Người quản lý";
            // 
            // cbNguoiQuanLy
            // 
            this.cbNguoiQuanLy.FormattingEnabled = true;
            this.cbNguoiQuanLy.Location = new System.Drawing.Point(468, 196);
            this.cbNguoiQuanLy.Name = "cbNguoiQuanLy";
            this.cbNguoiQuanLy.Size = new System.Drawing.Size(260, 24);
            this.cbNguoiQuanLy.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(318, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Thời gian bắt đầu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(689, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Thời gian đóng cửa";
            // 
            // dtBD
            // 
            this.dtBD.Location = new System.Drawing.Point(468, 271);
            this.dtBD.Name = "dtBD";
            this.dtBD.Size = new System.Drawing.Size(200, 22);
            this.dtBD.TabIndex = 17;
            // 
            // dtDC
            // 
            this.dtDC.Location = new System.Drawing.Point(837, 271);
            this.dtDC.Name = "dtDC";
            this.dtDC.Size = new System.Drawing.Size(200, 22);
            this.dtDC.TabIndex = 18;
            // 
            // cbKhuVuc
            // 
            this.cbKhuVuc.FormattingEnabled = true;
            this.cbKhuVuc.Location = new System.Drawing.Point(468, 141);
            this.cbKhuVuc.Name = "cbKhuVuc";
            this.cbKhuVuc.Size = new System.Drawing.Size(260, 24);
            this.cbKhuVuc.TabIndex = 19;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Mã trạm";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            // 
            // Ten
            // 
            this.Ten.DataPropertyName = "Ten";
            this.Ten.HeaderText = "Tên trạm";
            this.Ten.MinimumWidth = 6;
            this.Ten.Name = "Ten";
            // 
            // DonVi
            // 
            this.DonVi.DataPropertyName = "SoLuongXe";
            this.DonVi.HeaderText = "Số lượng xe";
            this.DonVi.MinimumWidth = 6;
            this.DonVi.Name = "DonVi";
            // 
            // ThoiGianMoCua
            // 
            this.ThoiGianMoCua.DataPropertyName = "ThoiGianMoCua";
            this.ThoiGianMoCua.HeaderText = "Thời gian mở cửa";
            this.ThoiGianMoCua.MinimumWidth = 6;
            this.ThoiGianMoCua.Name = "ThoiGianMoCua";
            // 
            // ThoiGianDongCua
            // 
            this.ThoiGianDongCua.DataPropertyName = "ThoiGianDongCua";
            this.ThoiGianDongCua.HeaderText = "Thời gian đóng cửa";
            this.ThoiGianDongCua.MinimumWidth = 6;
            this.ThoiGianDongCua.Name = "ThoiGianDongCua";
            // 
            // KhuVuc
            // 
            this.KhuVuc.DataPropertyName = "KhuVuc";
            this.KhuVuc.HeaderText = "Khu vực";
            this.KhuVuc.MinimumWidth = 6;
            this.KhuVuc.Name = "KhuVuc";
            // 
            // NguoiQuanLy
            // 
            this.NguoiQuanLy.DataPropertyName = "NguoiQuanLy";
            this.NguoiQuanLy.HeaderText = "Người quản lý";
            this.NguoiQuanLy.MinimumWidth = 6;
            this.NguoiQuanLy.Name = "NguoiQuanLy";
            // 
            // HinhAnh
            // 
            this.HinhAnh.DataPropertyName = "HinhAnh";
            this.HinhAnh.HeaderText = "Hình ảnh";
            this.HinhAnh.MinimumWidth = 6;
            this.HinhAnh.Name = "HinhAnh";
            // 
            // frm_Tram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 678);
            this.Controls.Add(this.cbKhuVuc);
            this.Controls.Add(this.dtDC);
            this.Controls.Add(this.dtBD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbNguoiQuanLy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nbSLX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_HinhAnh);
            this.Controls.Add(this.picTram);
            this.Controls.Add(this.txtMaTram);
            this.Controls.Add(this.grThietBi);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.txtTenTram);
            this.Controls.Add(this.label1);
            this.Name = "frm_Tram";
            this.Text = "Quản lý trạm";
            ((System.ComponentModel.ISupportInitialize)(this.grThietBi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbSLX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenTram;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.DataGridView grThietBi;
        private System.Windows.Forms.TextBox txtMaTram;
        private System.Windows.Forms.PictureBox picTram;
        private System.Windows.Forms.Button btn_HinhAnh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nbSLX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbNguoiQuanLy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtBD;
        private System.Windows.Forms.DateTimePicker dtDC;
        private System.Windows.Forms.ComboBox cbKhuVuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianMoCua;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianDongCua;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhuVuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn NguoiQuanLy;
        private System.Windows.Forms.DataGridViewTextBoxColumn HinhAnh;
    }
}