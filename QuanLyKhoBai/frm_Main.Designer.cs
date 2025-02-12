
namespace QuanLyKhoBai
{
    partial class frm_Main
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
            this.frm_Mainform = new System.Windows.Forms.MenuStrip();
            this.danhMụcVậtTưToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NguoiDungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QuanLyTramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QuanLyDangKyTramtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QuanLyLuanChuyenTramtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chứngTừToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PhieuNhapKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PhieuXuatKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frm_Mainform.SuspendLayout();
            this.SuspendLayout();
            // 
            // frm_Mainform
            // 
            this.frm_Mainform.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.frm_Mainform.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhMụcVậtTưToolStripMenuItem,
            this.chứngTừToolStripMenuItem});
            this.frm_Mainform.Location = new System.Drawing.Point(0, 0);
            this.frm_Mainform.Name = "frm_Mainform";
            this.frm_Mainform.Size = new System.Drawing.Size(800, 28);
            this.frm_Mainform.TabIndex = 0;
            this.frm_Mainform.Text = "menuStrip1";
            // 
            // danhMụcVậtTưToolStripMenuItem
            // 
            this.danhMụcVậtTưToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NguoiDungToolStripMenuItem,
            this.QuanLyTramToolStripMenuItem,
            this.QuanLyDangKyTramtoolStripMenuItem,
            this.QuanLyLuanChuyenTramtoolStripMenuItem});
            this.danhMụcVậtTưToolStripMenuItem.Name = "danhMụcVậtTưToolStripMenuItem";
            this.danhMụcVậtTưToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.danhMụcVậtTưToolStripMenuItem.Text = "Danh mục";
            // 
            // NguoiDungToolStripMenuItem
            // 
            this.NguoiDungToolStripMenuItem.Name = "NguoiDungToolStripMenuItem";
            this.NguoiDungToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.NguoiDungToolStripMenuItem.Text = "Quản lý người dùng";
            this.NguoiDungToolStripMenuItem.Click += new System.EventHandler(this.NguoiDungToolStripMenuItem_Click);
            // 
            // QuanLyTramToolStripMenuItem
            // 
            this.QuanLyTramToolStripMenuItem.Name = "QuanLyTramToolStripMenuItem";
            this.QuanLyTramToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.QuanLyTramToolStripMenuItem.Text = "Quản lý trạm xe";
            this.QuanLyTramToolStripMenuItem.Click += new System.EventHandler(this.QuanLyTramToolStripMenuItem_Click);
            // 
            // QuanLyDangKyTramtoolStripMenuItem
            // 
            this.QuanLyDangKyTramtoolStripMenuItem.Name = "QuanLyDangKyTramtoolStripMenuItem";
            this.QuanLyDangKyTramtoolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.QuanLyDangKyTramtoolStripMenuItem.Text = "Quản lý đăng ký trạm";
            this.QuanLyDangKyTramtoolStripMenuItem.Click += new System.EventHandler(this.QuanLyDangKyTramToolStripMenuItem_Click);
            // 
            // QuanLyLuanChuyenTramtoolStripMenuItem
            // 
            this.QuanLyLuanChuyenTramtoolStripMenuItem.Name = "QuanLyLuanChuyenTramtoolStripMenuItem";
            this.QuanLyLuanChuyenTramtoolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.QuanLyLuanChuyenTramtoolStripMenuItem.Text = "Quản lý luân chuyển trạm";
            this.QuanLyLuanChuyenTramtoolStripMenuItem.Click += new System.EventHandler(this.QuanLyLuanChuyenTramToolStripMenuItem_Click);
            // 
            // chứngTừToolStripMenuItem
            // 
            this.chứngTừToolStripMenuItem.Name = "chứngTừToolStripMenuItem";
            this.chứngTừToolStripMenuItem.Size = new System.Drawing.Size(14, 24);
            // 
            // PhieuNhapKhoToolStripMenuItem
            // 
            this.PhieuNhapKhoToolStripMenuItem.Name = "PhieuNhapKhoToolStripMenuItem";
            this.PhieuNhapKhoToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // PhieuXuatKhoToolStripMenuItem
            // 
            this.PhieuXuatKhoToolStripMenuItem.Name = "PhieuXuatKhoToolStripMenuItem";
            this.PhieuXuatKhoToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.frm_Mainform);
            this.MainMenuStrip = this.frm_Mainform;
            this.Name = "frm_Main";
            this.Text = "Quản lý bãi đậu xe";
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.frm_Mainform.ResumeLayout(false);
            this.frm_Mainform.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip frm_Mainform;
        private System.Windows.Forms.ToolStripMenuItem danhMụcVậtTưToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NguoiDungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QuanLyTramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chứngTừToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PhieuNhapKhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PhieuXuatKhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QuanLyDangKyTramtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QuanLyLuanChuyenTramtoolStripMenuItem;
    }
}

