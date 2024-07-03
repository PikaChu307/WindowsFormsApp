using System;
using System.Collections;
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
    public partial class frm_NhapMang : Form
    {
        public frm_NhapMang()
        {
            InitializeComponent();
        }

        private void btn_TinhToan_Click(object sender, EventArgs e)
        {
            string inputString = txtMangA.Text;
            string[] numbers = inputString.Split(' ');

            int sumOdd = 0;
            int sumEven = 0;
            int sumTotal = 0;

            foreach (string numberStr in numbers)
            {
                if (numberStr != "")
                {
                    int number = int.Parse(numberStr);

                    sumOdd += (number % 2 == 1) ? number : 0;
                    sumEven += (number % 2 == 0) ? number : 0;
                    sumTotal += number;
                }
            }

            txt_TongLe.Text = sumOdd.ToString();
            txt_TongChan.Text = sumEven.ToString();
            txt_TongMangA.Text = sumTotal.ToString();
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            txtMangA.Text = "";
            txt_TongLe.Text = "";
            txt_TongChan.Text = "";
            txt_TongMangA.Text = "";
        }

        private void btb_Thoat_Click(object sender, EventArgs e)
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
