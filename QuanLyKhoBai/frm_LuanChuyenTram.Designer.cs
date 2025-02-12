
namespace QuanLyKhoBai
{
    partial class frm_LuanChuyenTram
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
            this.grDanhSachDangKy = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTaiXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BienSoXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tram = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianDen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianDi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTaiXe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTramMoi = new System.Windows.Forms.ComboBox();
            this.btnLuanChuyen = new System.Windows.Forms.Button();
            this.lbMaTramDK = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grDanhSachDangKy)).BeginInit();
            this.SuspendLayout();
            // 
            // grDanhSachDangKy
            // 
            this.grDanhSachDangKy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grDanhSachDangKy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grDanhSachDangKy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.TenTaiXe,
            this.BienSoXe,
            this.Tram,
            this.ThoiGianDen,
            this.ThoiGianDi});
            this.grDanhSachDangKy.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grDanhSachDangKy.Location = new System.Drawing.Point(36, 34);
            this.grDanhSachDangKy.Name = "grDanhSachDangKy";
            this.grDanhSachDangKy.RowHeadersWidth = 51;
            this.grDanhSachDangKy.RowTemplate.Height = 24;
            this.grDanhSachDangKy.Size = new System.Drawing.Size(992, 276);
            this.grDanhSachDangKy.TabIndex = 6;
            this.grDanhSachDangKy.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grDanhSachDangKy_CellClick);
            this.grDanhSachDangKy.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grDanhSachDangKy_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Mã lịch trạm";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            // 
            // TenTaiXe
            // 
            this.TenTaiXe.DataPropertyName = "TenTaiXe";
            this.TenTaiXe.HeaderText = "Tên tài xế";
            this.TenTaiXe.MinimumWidth = 6;
            this.TenTaiXe.Name = "TenTaiXe";
            // 
            // BienSoXe
            // 
            this.BienSoXe.DataPropertyName = "BienSoXe";
            this.BienSoXe.HeaderText = "Biển số xe";
            this.BienSoXe.MinimumWidth = 6;
            this.BienSoXe.Name = "BienSoXe";
            // 
            // Tram
            // 
            this.Tram.DataPropertyName = "Tram";
            this.Tram.HeaderText = "Trạm";
            this.Tram.MinimumWidth = 6;
            this.Tram.Name = "Tram";
            // 
            // ThoiGianDen
            // 
            this.ThoiGianDen.DataPropertyName = "ThoiGianDen";
            this.ThoiGianDen.HeaderText = "Thời gian đến";
            this.ThoiGianDen.MinimumWidth = 6;
            this.ThoiGianDen.Name = "ThoiGianDen";
            // 
            // ThoiGianDi
            // 
            this.ThoiGianDi.DataPropertyName = "ThoiGianDi";
            this.ThoiGianDi.HeaderText = "Thời gian đi";
            this.ThoiGianDi.MinimumWidth = 6;
            this.ThoiGianDi.Name = "ThoiGianDi";
            // 
            // txtTaiXe
            // 
            this.txtTaiXe.Location = new System.Drawing.Point(143, 352);
            this.txtTaiXe.Name = "txtTaiXe";
            this.txtTaiXe.Size = new System.Drawing.Size(186, 22);
            this.txtTaiXe.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tài xế:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Chọn trạm mới:";
            // 
            // cbTramMoi
            // 
            this.cbTramMoi.FormattingEnabled = true;
            this.cbTramMoi.Location = new System.Drawing.Point(528, 357);
            this.cbTramMoi.Name = "cbTramMoi";
            this.cbTramMoi.Size = new System.Drawing.Size(302, 24);
            this.cbTramMoi.TabIndex = 10;
            this.cbTramMoi.SelectedIndexChanged += new System.EventHandler(this.cbTramMoi_SelectedIndexChanged);
            // 
            // btnLuanChuyen
            // 
            this.btnLuanChuyen.Location = new System.Drawing.Point(868, 353);
            this.btnLuanChuyen.Name = "btnLuanChuyen";
            this.btnLuanChuyen.Size = new System.Drawing.Size(111, 31);
            this.btnLuanChuyen.TabIndex = 11;
            this.btnLuanChuyen.Text = "Chuyển trạm";
            this.btnLuanChuyen.UseVisualStyleBackColor = true;
            this.btnLuanChuyen.Click += new System.EventHandler(this.btnLuanChuyen_Click);
            // 
            // lbMaTramDK
            // 
            this.lbMaTramDK.AutoSize = true;
            this.lbMaTramDK.Location = new System.Drawing.Point(140, 403);
            this.lbMaTramDK.Name = "lbMaTramDK";
            this.lbMaTramDK.Size = new System.Drawing.Size(27, 17);
            this.lbMaTramDK.TabIndex = 12;
            this.lbMaTramDK.Text = "Mã";
            // 
            // frm_LuanChuyenTram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 458);
            this.Controls.Add(this.lbMaTramDK);
            this.Controls.Add(this.btnLuanChuyen);
            this.Controls.Add(this.cbTramMoi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTaiXe);
            this.Controls.Add(this.grDanhSachDangKy);
            this.Name = "frm_LuanChuyenTram";
            this.Text = "frm_LuanChuyenTram";
            ((System.ComponentModel.ISupportInitialize)(this.grDanhSachDangKy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grDanhSachDangKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTaiXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn BienSoXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tram;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianDen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianDi;
        private System.Windows.Forms.TextBox txtTaiXe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTramMoi;
        private System.Windows.Forms.Button btnLuanChuyen;
        private System.Windows.Forms.Label lbMaTramDK;
    }
}