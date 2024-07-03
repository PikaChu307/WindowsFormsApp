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
    public partial class frm_TimThu : Form
    {
        public frm_TimThu()
        {
            InitializeComponent();
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            int number = int.Parse(txt_Thu.Text);

            switch (number)
            {
                case 2:
                    txt_Thu.Text = "Thứ Hai";
                    break;
                case 3:
                    txt_Thu.Text = "Thứ Ba";
                    break;
                case 4:
                    txt_Thu.Text = "Thứ Tư";
                    break;
                case 5:
                    txt_Thu.Text = "Thứ Năm";
                    break;
                case 6:
                    txt_Thu.Text = "Thứ Sáu";
                    break;
                case 7:
                    txt_Thu.Text = "Thứ Bảy";
                    break;
                case 8:
                    txt_Thu.Text = "Chủ Nhật";
                    break;
                default:
                    txt_Thu.Text = "Số nhập vào không hợp lệ";
                    break;
            }
        }
    }
}
