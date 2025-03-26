private void InitializeComponent()
{
    this.label1 = new System.Windows.Forms.Label();
    this.label2 = new System.Windows.Forms.Label();
    this.txtDangNhap = new System.Windows.Forms.TextBox();
    this.txtMatKhau = new System.Windows.Forms.TextBox();
    this.btnDangNhap = new System.Windows.Forms.Button();
    this.btnThoat = new System.Windows.Forms.Button();
    this.SuspendLayout();
    // 
    // label1
    // 
    this.label1.AutoSize = true;
    this.label1.Location = new System.Drawing.Point(78, 76);
    this.label1.Name = "label1";
    this.label1.Size = new System.Drawing.Size(102, 16);
    this.label1.TabIndex = 0;
    this.label1.Text = "Tên Đăng Nhập";
    // 
    // label2
    // 
    this.label2.AutoSize = true;
    this.label2.Location = new System.Drawing.Point(78, 183);
    this.label2.Name = "label2";
    this.label2.Size = new System.Drawing.Size(62, 16);
    this.label2.TabIndex = 0;
    this.label2.Text = "Mật Khẩu";
    // 
    // txtDangNhap
    // 
    this.txtDangNhap.Location = new System.Drawing.Point(81, 118);
    this.txtDangNhap.Multiline = true;
    this.txtDangNhap.Name = "txtDangNhap";
    this.txtDangNhap.Size = new System.Drawing.Size(624, 36);
    this.txtDangNhap.TabIndex = 1;
    // 
    // txtMatKhau
    // 
    this.txtMatKhau.Location = new System.Drawing.Point(81, 219);
    this.txtMatKhau.Multiline = true;
    this.txtMatKhau.Name = "txtMatKhau";
    this.txtMatKhau.Size = new System.Drawing.Size(624, 36);
    this.txtMatKhau.TabIndex = 1;
    // 
    // btnDangNhap
    // 
    this.btnDangNhap.Location = new System.Drawing.Point(81, 303);
    this.btnDangNhap.Name = "btnDangNhap";
    this.btnDangNhap.Size = new System.Drawing.Size(148, 37);
    this.btnDangNhap.TabIndex = 2;
    this.btnDangNhap.Text = "Đăng Nhập";
    this.btnDangNhap.UseVisualStyleBackColor = true;
    // 
    // btnThoat
    // 
    this.btnThoat.Location = new System.Drawing.Point(557, 303);
    this.btnThoat.Name = "btnThoat";
    this.btnThoat.Size = new System.Drawing.Size(148, 37);
    this.btnThoat.TabIndex = 2;
    this.btnThoat.Text = "Thoát";
    this.btnThoat.UseVisualStyleBackColor = true;
    // 
    // frmLogin
    // 
    this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    this.ClientSize = new System.Drawing.Size(800, 450);
    this.Controls.Add(this.btnThoat);
    this.Controls.Add(this.btnDangNhap);
    this.Controls.Add(this.txtMatKhau);
    this.Controls.Add(this.txtDangNhap);
    this.Controls.Add(this.label2);
    this.Controls.Add(this.label1);
    this.Name = "frmLogin";
    this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
    this.Text = "Đăng Nhập";
    this.ResumeLayout(false);
    this.PerformLayout();
}
