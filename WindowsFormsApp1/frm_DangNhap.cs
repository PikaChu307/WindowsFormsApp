using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frm_DangNhap : Form
    {
        public frm_DangNhap()
        {
            InitializeComponent();
        }
        private int dem = 0;
        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            
            if (txt_TenTaiKhoan.Text.ToLower() == "admin" && txt_MatKhau.Text == "123456")
            {
                frm_QLSinhVien formvs = new frm_QLSinhVien();
                formvs.Show();
            }
            //else
            //{
            //    lbl_ThongBao.Text = "Sai mật khẩu hoặc tên đăng nhập";
            //}
            else
            {
                dem++;
                MessageBox.Show("Sai mật khẩu hoặc tên đăng nhập !!!", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if(dem >= 3)
                {
                    MessageBox.Show("Bạn sai quá 3 lần !!!", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    Application.Exit();
                }

            }

        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bạn có muốn thoát không ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btb_NhapLai_Click(object sender, EventArgs e)
        {
            foreach (Control tbx in this.Controls)
            {
                if (tbx is TextBox)
                    ((TextBox)tbx).Text = "";

            }
        }

    }
}
