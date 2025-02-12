
namespace QuanLyKhoBai
{
    partial class frm_DangKyTram
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DangKyTram));
            this.cbTram = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBienSo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtBD = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaLichDatTram = new System.Windows.Forms.TextBox();
            this.grLichDatTram = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTaiXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BienSoXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianDen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianDi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.txtTenTaiXe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtKT = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grLichDatTram)).BeginInit();
            this.SuspendLayout();
            // 
            // cbTram
            // 
            resources.ApplyResources(this.cbTram, "cbTram");
            this.cbTram.FormattingEnabled = true;
            this.cbTram.Name = "cbTram";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // txtBienSo
            // 
            resources.ApplyResources(this.txtBienSo, "txtBienSo");
            this.txtBienSo.Name = "txtBienSo";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // dtBD
            // 
            resources.ApplyResources(this.dtBD, "dtBD");
            this.dtBD.Name = "dtBD";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // txtMaLichDatTram
            // 
            resources.ApplyResources(this.txtMaLichDatTram, "txtMaLichDatTram");
            this.txtMaLichDatTram.Name = "txtMaLichDatTram";
            // 
            // grLichDatTram
            // 
            this.grLichDatTram.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grLichDatTram.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grLichDatTram.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.TenTaiXe,
            this.BienSoXe,
            this.ThoiGianDen,
            this.ThoiGianDi});
            this.grLichDatTram.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grLichDatTram.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.grLichDatTram, "grLichDatTram");
            this.grLichDatTram.Name = "grLichDatTram";
            this.grLichDatTram.RowTemplate.Height = 24;
            this.grLichDatTram.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grLichDatTram.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grLichDatTram_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            resources.ApplyResources(this.Id, "Id");
            this.Id.Name = "Id";
            // 
            // TenTaiXe
            // 
            this.TenTaiXe.DataPropertyName = "TenTaiXe";
            resources.ApplyResources(this.TenTaiXe, "TenTaiXe");
            this.TenTaiXe.Name = "TenTaiXe";
            // 
            // BienSoXe
            // 
            this.BienSoXe.DataPropertyName = "BienSoXe";
            resources.ApplyResources(this.BienSoXe, "BienSoXe");
            this.BienSoXe.Name = "BienSoXe";
            // 
            // ThoiGianDen
            // 
            this.ThoiGianDen.DataPropertyName = "ThoiGianDen";
            resources.ApplyResources(this.ThoiGianDen, "ThoiGianDen");
            this.ThoiGianDen.Name = "ThoiGianDen";
            // 
            // ThoiGianDi
            // 
            this.ThoiGianDi.DataPropertyName = "ThoiGianDi";
            resources.ApplyResources(this.ThoiGianDi, "ThoiGianDi");
            this.ThoiGianDi.Name = "ThoiGianDi";
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.btn_Sua, "btn_Sua");
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            resources.ApplyResources(this.btn_Xoa, "btn_Xoa");
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            resources.ApplyResources(this.btn_Them, "btn_Them");
            this.btn_Them.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // txtTenTaiXe
            // 
            resources.ApplyResources(this.txtTenTaiXe, "txtTenTaiXe");
            this.txtTenTaiXe.Name = "txtTenTaiXe";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // dtKT
            // 
            resources.ApplyResources(this.dtKT, "dtKT");
            this.dtKT.Name = "dtKT";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // frm_DangKyTram
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.dtKT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbTram);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBienSo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtBD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaLichDatTram);
            this.Controls.Add(this.grLichDatTram);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.txtTenTaiXe);
            this.Controls.Add(this.label1);
            this.Name = "frm_DangKyTram";
            ((System.ComponentModel.ISupportInitialize)(this.grLichDatTram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbTram;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBienSo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtBD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaLichDatTram;
        private System.Windows.Forms.DataGridView grLichDatTram;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.TextBox txtTenTaiXe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtKT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTaiXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn BienSoXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianDen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianDi;
    }
}