using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class frm_Bac : Form
    {
        public frm_Bac()
        {
            InitializeComponent();
        }

        int bac;
        
        char kytu = 'A';

        public int Bac { get => bac; set => bac = value; }

        private void frm_Bac_Load(object sender, EventArgs e)
        {
            lbl_Bac.Text = lbl_Bac.Text + bac.ToString();
            for (int i = 0; i <= bac; i++)
            {
                Label lbl_HeSo = new Label();
                lbl_HeSo.Text = "Hệ sô " + kytu;
                kytu++;
                lbl_HeSo.Left = 70;
                lbl_HeSo.Top = (70 + i * 50);
                lbl_HeSo.AutoSize = true;
                this.Controls.Add(lbl_HeSo);

                TextBox txt_HeSo = new TextBox();
                txt_HeSo.Left = 13
                    0;
                txt_HeSo.Top = (70 + i * 50);
                this.Controls.Add (txt_HeSo);
            }
            Button btn_Giai = new Button();
            btn_Giai.Text = "Giải";
            btn_Giai.Location = new Point(80, 100 + (bac * 50));

            Button btn_Thoat = new Button();
            btn_Thoat.Text = "Thoát";
            btn_Thoat.Location = new Point(160, 100 + (bac * 50));

            this.Controls.Add(btn_Giai);
            this.Controls.Add(btn_Thoat);

        }
    }
}
