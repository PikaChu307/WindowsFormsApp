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
    public partial class frm_NhapBac : Form
    {
        public frm_NhapBac()
        {
            InitializeComponent();
        }
        private void btn_NhapBac_Click(object sender, EventArgs e)
        {
            frm_Bac frmbac = new frm_Bac();
            frmbac.Bac = int.Parse(txt_NhapBac.Text);
            frmbac.Show();
        }
    }
}
