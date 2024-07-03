namespace WindowsFormsApp1
{
    partial class frm_QLSinhVien
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
            this.btn_Luu = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lbl_SoDienThoai = new System.Windows.Forms.Label();
            this.txt_SoDienThoai = new System.Windows.Forms.TextBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.cls_NgoaiNgu = new System.Windows.Forms.CheckedListBox();
            this.lbl_NgoaiNgu = new System.Windows.Forms.Label();
            this.chk_HoiGiao = new System.Windows.Forms.CheckBox();
            this.chk_TinLanh = new System.Windows.Forms.CheckBox();
            this.chk_ThienChua = new System.Windows.Forms.CheckBox();
            this.chk_PhatGiao = new System.Windows.Forms.CheckBox();
            this.lbl_TonGiao = new System.Windows.Forms.Label();
            this.cb_DanToc = new System.Windows.Forms.ComboBox();
            this.lbl_DanToc = new System.Windows.Forms.Label();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.lbl_DiaChi = new System.Windows.Forms.Label();
            this.date_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lbl_NgaySinh = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdo_Khac = new System.Windows.Forms.RadioButton();
            this.rdo_Nu = new System.Windows.Forms.RadioButton();
            this.rdo_Nam = new System.Windows.Forms.RadioButton();
            this.lbl_GioiTinh = new System.Windows.Forms.Label();
            this.lbl_Nganh = new System.Windows.Forms.Label();
            this.txt_Nganh = new System.Windows.Forms.TextBox();
            this.lbl_Khoa = new System.Windows.Forms.Label();
            this.txt_Khoa = new System.Windows.Forms.TextBox();
            this.lbl_Lop = new System.Windows.Forms.Label();
            this.txt_Lop = new System.Windows.Forms.TextBox();
            this.lbl_Truong = new System.Windows.Forms.Label();
            this.txt_Truong = new System.Windows.Forms.TextBox();
            this.lbl_TenDayDu = new System.Windows.Forms.Label();
            this.txt_TenDayDu = new System.Windows.Forms.TextBox();
            this.lbl_Masv = new System.Windows.Forms.Label();
            this.txt_Masv = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Luu
            // 
            this.btn_Luu.Location = new System.Drawing.Point(563, 581);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(108, 34);
            this.btn_Luu.TabIndex = 33;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(252, 646);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(236, 25);
            this.linkLabel1.TabIndex = 32;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "http://kcntt.duytan.edu.vn";
            // 
            // lbl_SoDienThoai
            // 
            this.lbl_SoDienThoai.AutoSize = true;
            this.lbl_SoDienThoai.Location = new System.Drawing.Point(415, 487);
            this.lbl_SoDienThoai.Name = "lbl_SoDienThoai";
            this.lbl_SoDienThoai.Size = new System.Drawing.Size(99, 19);
            this.lbl_SoDienThoai.TabIndex = 31;
            this.lbl_SoDienThoai.Text = "Số điện thoại";
            // 
            // txt_SoDienThoai
            // 
            this.txt_SoDienThoai.Location = new System.Drawing.Point(520, 479);
            this.txt_SoDienThoai.Name = "txt_SoDienThoai";
            this.txt_SoDienThoai.Size = new System.Drawing.Size(151, 27);
            this.txt_SoDienThoai.TabIndex = 30;
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Location = new System.Drawing.Point(415, 427);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(49, 19);
            this.lbl_Email.TabIndex = 29;
            this.lbl_Email.Text = "Email";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(520, 419);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(151, 27);
            this.txt_Email.TabIndex = 28;
            // 
            // cls_NgoaiNgu
            // 
            this.cls_NgoaiNgu.FormattingEnabled = true;
            this.cls_NgoaiNgu.Items.AddRange(new object[] {
            "Tiếng Anh",
            "Tiếng Pháp",
            "Tiếng Trung ",
            "Tiếng Nhật",
            "Tiếng Đức"});
            this.cls_NgoaiNgu.Location = new System.Drawing.Point(520, 255);
            this.cls_NgoaiNgu.Name = "cls_NgoaiNgu";
            this.cls_NgoaiNgu.Size = new System.Drawing.Size(151, 136);
            this.cls_NgoaiNgu.TabIndex = 27;
            // 
            // lbl_NgoaiNgu
            // 
            this.lbl_NgoaiNgu.AutoSize = true;
            this.lbl_NgoaiNgu.Location = new System.Drawing.Point(415, 255);
            this.lbl_NgoaiNgu.Name = "lbl_NgoaiNgu";
            this.lbl_NgoaiNgu.Size = new System.Drawing.Size(79, 19);
            this.lbl_NgoaiNgu.TabIndex = 26;
            this.lbl_NgoaiNgu.Text = "Ngoại ngữ";
            // 
            // chk_HoiGiao
            // 
            this.chk_HoiGiao.AutoSize = true;
            this.chk_HoiGiao.Location = new System.Drawing.Point(254, 528);
            this.chk_HoiGiao.Name = "chk_HoiGiao";
            this.chk_HoiGiao.Size = new System.Drawing.Size(90, 23);
            this.chk_HoiGiao.TabIndex = 25;
            this.chk_HoiGiao.Text = "Hồi giáo";
            this.chk_HoiGiao.UseVisualStyleBackColor = true;
            // 
            // chk_TinLanh
            // 
            this.chk_TinLanh.AutoSize = true;
            this.chk_TinLanh.Location = new System.Drawing.Point(154, 528);
            this.chk_TinLanh.Name = "chk_TinLanh";
            this.chk_TinLanh.Size = new System.Drawing.Size(84, 23);
            this.chk_TinLanh.TabIndex = 24;
            this.chk_TinLanh.Text = "Tin lành";
            this.chk_TinLanh.UseVisualStyleBackColor = true;
            // 
            // chk_ThienChua
            // 
            this.chk_ThienChua.AutoSize = true;
            this.chk_ThienChua.Location = new System.Drawing.Point(254, 487);
            this.chk_ThienChua.Name = "chk_ThienChua";
            this.chk_ThienChua.Size = new System.Drawing.Size(104, 23);
            this.chk_ThienChua.TabIndex = 23;
            this.chk_ThienChua.Text = "Thiên chúa";
            this.chk_ThienChua.UseVisualStyleBackColor = true;
            // 
            // chk_PhatGiao
            // 
            this.chk_PhatGiao.AutoSize = true;
            this.chk_PhatGiao.Location = new System.Drawing.Point(154, 487);
            this.chk_PhatGiao.Name = "chk_PhatGiao";
            this.chk_PhatGiao.Size = new System.Drawing.Size(94, 23);
            this.chk_PhatGiao.TabIndex = 22;
            this.chk_PhatGiao.Text = "Phật giáo";
            this.chk_PhatGiao.UseVisualStyleBackColor = true;
            // 
            // lbl_TonGiao
            // 
            this.lbl_TonGiao.AutoSize = true;
            this.lbl_TonGiao.Location = new System.Drawing.Point(49, 487);
            this.lbl_TonGiao.Name = "lbl_TonGiao";
            this.lbl_TonGiao.Size = new System.Drawing.Size(68, 19);
            this.lbl_TonGiao.TabIndex = 21;
            this.lbl_TonGiao.Text = "Tôn giáo";
            // 
            // cb_DanToc
            // 
            this.cb_DanToc.FormattingEnabled = true;
            this.cb_DanToc.Items.AddRange(new object[] {
            "Kinh",
            "Thái",
            "Tày",
            "Dao",
            "Khác"});
            this.cb_DanToc.Location = new System.Drawing.Point(154, 419);
            this.cb_DanToc.Name = "cb_DanToc";
            this.cb_DanToc.Size = new System.Drawing.Size(151, 27);
            this.cb_DanToc.TabIndex = 20;
            // 
            // lbl_DanToc
            // 
            this.lbl_DanToc.AutoSize = true;
            this.lbl_DanToc.Location = new System.Drawing.Point(49, 419);
            this.lbl_DanToc.Name = "lbl_DanToc";
            this.lbl_DanToc.Size = new System.Drawing.Size(62, 19);
            this.lbl_DanToc.TabIndex = 18;
            this.lbl_DanToc.Text = "Dân tộc";
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(154, 308);
            this.txt_DiaChi.Multiline = true;
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(151, 92);
            this.txt_DiaChi.TabIndex = 17;
            // 
            // lbl_DiaChi
            // 
            this.lbl_DiaChi.AutoSize = true;
            this.lbl_DiaChi.Location = new System.Drawing.Point(49, 308);
            this.lbl_DiaChi.Name = "lbl_DiaChi";
            this.lbl_DiaChi.Size = new System.Drawing.Size(58, 19);
            this.lbl_DiaChi.TabIndex = 16;
            this.lbl_DiaChi.Text = "Địa chỉ";
            // 
            // date_NgaySinh
            // 
            this.date_NgaySinh.CustomFormat = "dd/MM/yyyy";
            this.date_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_NgaySinh.Location = new System.Drawing.Point(154, 247);
            this.date_NgaySinh.Name = "date_NgaySinh";
            this.date_NgaySinh.Size = new System.Drawing.Size(151, 27);
            this.date_NgaySinh.TabIndex = 15;
            // 
            // lbl_NgaySinh
            // 
            this.lbl_NgaySinh.AutoSize = true;
            this.lbl_NgaySinh.Location = new System.Drawing.Point(49, 247);
            this.lbl_NgaySinh.Name = "lbl_NgaySinh";
            this.lbl_NgaySinh.Size = new System.Drawing.Size(76, 19);
            this.lbl_NgaySinh.TabIndex = 14;
            this.lbl_NgaySinh.Text = "Ngày sinh";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdo_Khac);
            this.panel1.Controls.Add(this.rdo_Nu);
            this.panel1.Controls.Add(this.rdo_Nam);
            this.panel1.Location = new System.Drawing.Point(154, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(98, 94);
            this.panel1.TabIndex = 13;
            // 
            // rdo_Khac
            // 
            this.rdo_Khac.AutoSize = true;
            this.rdo_Khac.Location = new System.Drawing.Point(4, 62);
            this.rdo_Khac.Name = "rdo_Khac";
            this.rdo_Khac.Size = new System.Drawing.Size(65, 23);
            this.rdo_Khac.TabIndex = 2;
            this.rdo_Khac.TabStop = true;
            this.rdo_Khac.Text = "Khác";
            this.rdo_Khac.UseVisualStyleBackColor = true;
            // 
            // rdo_Nu
            // 
            this.rdo_Nu.AutoSize = true;
            this.rdo_Nu.Location = new System.Drawing.Point(4, 33);
            this.rdo_Nu.Name = "rdo_Nu";
            this.rdo_Nu.Size = new System.Drawing.Size(51, 23);
            this.rdo_Nu.TabIndex = 1;
            this.rdo_Nu.TabStop = true;
            this.rdo_Nu.Text = "Nữ";
            this.rdo_Nu.UseVisualStyleBackColor = true;
            // 
            // rdo_Nam
            // 
            this.rdo_Nam.AutoSize = true;
            this.rdo_Nam.Location = new System.Drawing.Point(4, 4);
            this.rdo_Nam.Name = "rdo_Nam";
            this.rdo_Nam.Size = new System.Drawing.Size(62, 23);
            this.rdo_Nam.TabIndex = 0;
            this.rdo_Nam.TabStop = true;
            this.rdo_Nam.Text = "Nam";
            this.rdo_Nam.UseVisualStyleBackColor = true;
            // 
            // lbl_GioiTinh
            // 
            this.lbl_GioiTinh.AutoSize = true;
            this.lbl_GioiTinh.Location = new System.Drawing.Point(49, 133);
            this.lbl_GioiTinh.Name = "lbl_GioiTinh";
            this.lbl_GioiTinh.Size = new System.Drawing.Size(70, 19);
            this.lbl_GioiTinh.TabIndex = 12;
            this.lbl_GioiTinh.Text = "Giới tính";
            // 
            // lbl_Nganh
            // 
            this.lbl_Nganh.AutoSize = true;
            this.lbl_Nganh.Location = new System.Drawing.Point(415, 184);
            this.lbl_Nganh.Name = "lbl_Nganh";
            this.lbl_Nganh.Size = new System.Drawing.Size(52, 19);
            this.lbl_Nganh.TabIndex = 11;
            this.lbl_Nganh.Text = "Ngành";
            // 
            // txt_Nganh
            // 
            this.txt_Nganh.Location = new System.Drawing.Point(520, 176);
            this.txt_Nganh.Name = "txt_Nganh";
            this.txt_Nganh.Size = new System.Drawing.Size(151, 27);
            this.txt_Nganh.TabIndex = 10;
            // 
            // lbl_Khoa
            // 
            this.lbl_Khoa.AutoSize = true;
            this.lbl_Khoa.Location = new System.Drawing.Point(415, 133);
            this.lbl_Khoa.Name = "lbl_Khoa";
            this.lbl_Khoa.Size = new System.Drawing.Size(45, 19);
            this.lbl_Khoa.TabIndex = 9;
            this.lbl_Khoa.Text = "Khoa";
            // 
            // txt_Khoa
            // 
            this.txt_Khoa.Location = new System.Drawing.Point(520, 125);
            this.txt_Khoa.Name = "txt_Khoa";
            this.txt_Khoa.Size = new System.Drawing.Size(151, 27);
            this.txt_Khoa.TabIndex = 8;
            // 
            // lbl_Lop
            // 
            this.lbl_Lop.AutoSize = true;
            this.lbl_Lop.Location = new System.Drawing.Point(415, 86);
            this.lbl_Lop.Name = "lbl_Lop";
            this.lbl_Lop.Size = new System.Drawing.Size(36, 19);
            this.lbl_Lop.TabIndex = 7;
            this.lbl_Lop.Text = "Lớp";
            // 
            // txt_Lop
            // 
            this.txt_Lop.Location = new System.Drawing.Point(520, 78);
            this.txt_Lop.Name = "txt_Lop";
            this.txt_Lop.Size = new System.Drawing.Size(151, 27);
            this.txt_Lop.TabIndex = 6;
            // 
            // lbl_Truong
            // 
            this.lbl_Truong.AutoSize = true;
            this.lbl_Truong.Location = new System.Drawing.Point(415, 34);
            this.lbl_Truong.Name = "lbl_Truong";
            this.lbl_Truong.Size = new System.Drawing.Size(57, 19);
            this.lbl_Truong.TabIndex = 5;
            this.lbl_Truong.Text = "Trường";
            // 
            // txt_Truong
            // 
            this.txt_Truong.Location = new System.Drawing.Point(520, 26);
            this.txt_Truong.Name = "txt_Truong";
            this.txt_Truong.Size = new System.Drawing.Size(151, 27);
            this.txt_Truong.TabIndex = 4;
            // 
            // lbl_TenDayDu
            // 
            this.lbl_TenDayDu.AutoSize = true;
            this.lbl_TenDayDu.Location = new System.Drawing.Point(49, 86);
            this.lbl_TenDayDu.Name = "lbl_TenDayDu";
            this.lbl_TenDayDu.Size = new System.Drawing.Size(83, 19);
            this.lbl_TenDayDu.TabIndex = 3;
            this.lbl_TenDayDu.Text = "Tên đầy đủ";
            // 
            // txt_TenDayDu
            // 
            this.txt_TenDayDu.Location = new System.Drawing.Point(154, 78);
            this.txt_TenDayDu.Name = "txt_TenDayDu";
            this.txt_TenDayDu.Size = new System.Drawing.Size(151, 27);
            this.txt_TenDayDu.TabIndex = 2;
            // 
            // lbl_Masv
            // 
            this.lbl_Masv.AutoSize = true;
            this.lbl_Masv.Location = new System.Drawing.Point(49, 36);
            this.lbl_Masv.Name = "lbl_Masv";
            this.lbl_Masv.Size = new System.Drawing.Size(49, 19);
            this.lbl_Masv.TabIndex = 1;
            this.lbl_Masv.Text = "Mã sv";
            // 
            // txt_Masv
            // 
            this.txt_Masv.Location = new System.Drawing.Point(154, 28);
            this.txt_Masv.Name = "txt_Masv";
            this.txt_Masv.Size = new System.Drawing.Size(151, 27);
            this.txt_Masv.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Luu);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.lbl_SoDienThoai);
            this.groupBox1.Controls.Add(this.txt_SoDienThoai);
            this.groupBox1.Controls.Add(this.lbl_Email);
            this.groupBox1.Controls.Add(this.txt_Email);
            this.groupBox1.Controls.Add(this.cls_NgoaiNgu);
            this.groupBox1.Controls.Add(this.lbl_NgoaiNgu);
            this.groupBox1.Controls.Add(this.chk_HoiGiao);
            this.groupBox1.Controls.Add(this.chk_TinLanh);
            this.groupBox1.Controls.Add(this.chk_ThienChua);
            this.groupBox1.Controls.Add(this.chk_PhatGiao);
            this.groupBox1.Controls.Add(this.lbl_TonGiao);
            this.groupBox1.Controls.Add(this.cb_DanToc);
            this.groupBox1.Controls.Add(this.lbl_DanToc);
            this.groupBox1.Controls.Add(this.txt_DiaChi);
            this.groupBox1.Controls.Add(this.lbl_DiaChi);
            this.groupBox1.Controls.Add(this.date_NgaySinh);
            this.groupBox1.Controls.Add(this.lbl_NgaySinh);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.lbl_GioiTinh);
            this.groupBox1.Controls.Add(this.lbl_Nganh);
            this.groupBox1.Controls.Add(this.txt_Nganh);
            this.groupBox1.Controls.Add(this.lbl_Khoa);
            this.groupBox1.Controls.Add(this.txt_Khoa);
            this.groupBox1.Controls.Add(this.lbl_Lop);
            this.groupBox1.Controls.Add(this.txt_Lop);
            this.groupBox1.Controls.Add(this.lbl_Truong);
            this.groupBox1.Controls.Add(this.txt_Truong);
            this.groupBox1.Controls.Add(this.lbl_TenDayDu);
            this.groupBox1.Controls.Add(this.txt_TenDayDu);
            this.groupBox1.Controls.Add(this.lbl_Masv);
            this.groupBox1.Controls.Add(this.txt_Masv);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(31, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(758, 697);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sinh viên";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "QUẢN LÝ SINH VIÊN";
            // 
            // frm_QLSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 751);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frm_QLSinhVien";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lbl_SoDienThoai;
        private System.Windows.Forms.TextBox txt_SoDienThoai;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.CheckedListBox cls_NgoaiNgu;
        private System.Windows.Forms.Label lbl_NgoaiNgu;
        private System.Windows.Forms.CheckBox chk_HoiGiao;
        private System.Windows.Forms.CheckBox chk_TinLanh;
        private System.Windows.Forms.CheckBox chk_ThienChua;
        private System.Windows.Forms.CheckBox chk_PhatGiao;
        private System.Windows.Forms.Label lbl_TonGiao;
        private System.Windows.Forms.ComboBox cb_DanToc;
        private System.Windows.Forms.Label lbl_DanToc;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.Label lbl_DiaChi;
        private System.Windows.Forms.DateTimePicker date_NgaySinh;
        private System.Windows.Forms.Label lbl_NgaySinh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdo_Khac;
        private System.Windows.Forms.RadioButton rdo_Nu;
        private System.Windows.Forms.RadioButton rdo_Nam;
        private System.Windows.Forms.Label lbl_GioiTinh;
        private System.Windows.Forms.Label lbl_Nganh;
        private System.Windows.Forms.TextBox txt_Nganh;
        private System.Windows.Forms.Label lbl_Khoa;
        private System.Windows.Forms.TextBox txt_Khoa;
        private System.Windows.Forms.Label lbl_Lop;
        private System.Windows.Forms.TextBox txt_Lop;
        private System.Windows.Forms.Label lbl_Truong;
        private System.Windows.Forms.TextBox txt_Truong;
        private System.Windows.Forms.Label lbl_TenDayDu;
        private System.Windows.Forms.TextBox txt_TenDayDu;
        private System.Windows.Forms.Label lbl_Masv;
        private System.Windows.Forms.TextBox txt_Masv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}

