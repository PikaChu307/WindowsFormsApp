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
    public partial class frm_GiaiPTBac2 : Form
    {
        public frm_GiaiPTBac2()
        {
            InitializeComponent();
        }

        private void btn_Giai_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txt_SoA.Text);
            double b = double.Parse(txt_SoB.Text);
            double c = double.Parse(txt_SoC.Text);

            double delta = b * b - 4 * a * c;

            if (delta > 0)
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                txt_KetQua.Text = string.Format("Nghiệm x1 = {0:0.000}, x2 = {1:0.000}", x1, x2);
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                txt_KetQua.Text = string.Format("Nghiệm duy nhất x = {0:0.000}", x);
            }
            else
            {
                txt_KetQua.Text = "Phương trình vô nghiệm";
            }
        }

        private void btb_LuuPT_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bạn có muốn thoát không ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }


}
