namespace QuanLyNhaHang
{
    partial class frmBanAn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBanAn));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaBanAn = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenBanAn = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbxTrangThai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnThem = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnSua = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnXoa = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnTimKiem = new Guna.UI2.WinForms.Guna2ImageButton();
            this.dgBanAn = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgBanAn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã bàn ăn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 162);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên bàn ăn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 231);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Trạng thái";
            // 
            // txtMaBanAn
            // 
            this.txtMaBanAn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaBanAn.DefaultText = "";
            this.txtMaBanAn.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaBanAn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaBanAn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaBanAn.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaBanAn.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaBanAn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaBanAn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaBanAn.Location = new System.Drawing.Point(114, 70);
            this.txtMaBanAn.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtMaBanAn.Name = "txtMaBanAn";
            this.txtMaBanAn.PlaceholderText = "";
            this.txtMaBanAn.SelectedText = "";
            this.txtMaBanAn.Size = new System.Drawing.Size(221, 51);
            this.txtMaBanAn.TabIndex = 9;
            // 
            // txtTenBanAn
            // 
            this.txtTenBanAn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenBanAn.DefaultText = "";
            this.txtTenBanAn.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenBanAn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenBanAn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenBanAn.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenBanAn.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenBanAn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenBanAn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenBanAn.Location = new System.Drawing.Point(114, 147);
            this.txtTenBanAn.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtTenBanAn.Name = "txtTenBanAn";
            this.txtTenBanAn.PlaceholderText = "";
            this.txtTenBanAn.SelectedText = "";
            this.txtTenBanAn.Size = new System.Drawing.Size(221, 51);
            this.txtTenBanAn.TabIndex = 9;
            // 
            // cbxTrangThai
            // 
            this.cbxTrangThai.BackColor = System.Drawing.Color.Transparent;
            this.cbxTrangThai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTrangThai.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxTrangThai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxTrangThai.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.cbxTrangThai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxTrangThai.ItemHeight = 30;
            this.cbxTrangThai.Items.AddRange(new object[] {
            "Trống",
            "Không trống"});
            this.cbxTrangThai.Location = new System.Drawing.Point(127, 231);
            this.cbxTrangThai.Name = "cbxTrangThai";
            this.cbxTrangThai.Size = new System.Drawing.Size(140, 36);
            this.cbxTrangThai.TabIndex = 10;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiem.DefaultText = "";
            this.txtTimKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.Location = new System.Drawing.Point(373, 308);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PlaceholderText = "";
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.Size = new System.Drawing.Size(258, 51);
            this.txtTimKiem.TabIndex = 9;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Transparent;
            this.btnThem.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnThem.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnThem.ImageRotate = 0F;
            this.btnThem.Location = new System.Drawing.Point(12, 308);
            this.btnThem.Name = "btnThem";
            this.btnThem.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnThem.Size = new System.Drawing.Size(64, 54);
            this.btnThem.TabIndex = 12;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnSua.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnSua.ImageRotate = 0F;
            this.btnSua.Location = new System.Drawing.Point(93, 308);
            this.btnSua.Name = "btnSua";
            this.btnSua.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnSua.Size = new System.Drawing.Size(64, 54);
            this.btnSua.TabIndex = 12;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnXoa.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnXoa.ImageRotate = 0F;
            this.btnXoa.Location = new System.Drawing.Point(183, 308);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnXoa.Size = new System.Drawing.Size(64, 54);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnTimKiem.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnTimKiem.ImageRotate = 0F;
            this.btnTimKiem.Location = new System.Drawing.Point(676, 305);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnTimKiem.Size = new System.Drawing.Size(64, 54);
            this.btnTimKiem.TabIndex = 12;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dgBanAn
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgBanAn.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgBanAn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgBanAn.ColumnHeadersHeight = 4;
            this.dgBanAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgBanAn.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgBanAn.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgBanAn.Location = new System.Drawing.Point(373, 70);
            this.dgBanAn.Name = "dgBanAn";
            this.dgBanAn.RowHeadersVisible = false;
            this.dgBanAn.RowHeadersWidth = 51;
            this.dgBanAn.RowTemplate.Height = 24;
            this.dgBanAn.Size = new System.Drawing.Size(367, 197);
            this.dgBanAn.TabIndex = 13;
            this.dgBanAn.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgBanAn.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgBanAn.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgBanAn.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgBanAn.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgBanAn.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgBanAn.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgBanAn.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgBanAn.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgBanAn.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgBanAn.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgBanAn.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgBanAn.ThemeStyle.HeaderStyle.Height = 4;
            this.dgBanAn.ThemeStyle.ReadOnly = false;
            this.dgBanAn.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgBanAn.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgBanAn.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgBanAn.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgBanAn.ThemeStyle.RowsStyle.Height = 24;
            this.dgBanAn.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgBanAn.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // frmBanAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 422);
            this.Controls.Add(this.dgBanAn);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cbxTrangThai);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.txtTenBanAn);
            this.Controls.Add(this.txtMaBanAn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frmBanAn";
            this.Text = "Quản lý bàn ăn";
            ((System.ComponentModel.ISupportInitialize)(this.dgBanAn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtMaBanAn;
        private Guna.UI2.WinForms.Guna2TextBox txtTenBanAn;
        private Guna.UI2.WinForms.Guna2ComboBox cbxTrangThai;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private Guna.UI2.WinForms.Guna2ImageButton btnThem;
        private Guna.UI2.WinForms.Guna2ImageButton btnSua;
        private Guna.UI2.WinForms.Guna2ImageButton btnXoa;
        private Guna.UI2.WinForms.Guna2ImageButton btnTimKiem;
        private Guna.UI2.WinForms.Guna2DataGridView dgBanAn;
    }
}