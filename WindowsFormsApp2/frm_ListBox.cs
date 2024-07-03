using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class frm_ListBox : Form
    {
        Dictionary<string, string[]> hoten;
        public frm_ListBox()
        {
            InitializeComponent();
            Hoten = new Dictionary<string, string[]>();
            Hoten.Add("Nguyễn", new string[] { "Nguyễn Văn A", "Nguyễn Văn B", "Nguyễn Văn C" });
            Hoten.Add("Trần", new string[] { "Trần Văn A", "Trần Văn B", "Trần Văn C" });
            Hoten.Add("Bùi", new string[] { "Bùi Văn A", "Bùi Văn B", "Bùi Văn C" });
            Hoten.Add("Lý", new string[] { "Lý Văn A", "Lý Văn B", "Lý Văn C" });
            Hoten.Add("Lê", new string[] { "Lê Văn A", "Lê Văn B", "Lê Văn C" });
        }

        public Dictionary<string, string[]> Hoten { get => hoten; set => hoten = value; }

        private void btn_1_Click(object sender, EventArgs e)
        {
            for (int i = lib_A.SelectedItems.Count - 1;i>=0; i--)
            {
                lib_B.Items.Add(lib_A.SelectedItems[i]);
                lib_A.Items.Remove(lib_A.SelectedItems[i]);
            }
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            for(int i= 0; i < lib_A.Items.Count; i++)
            {
                lib_B.Items.Add(lib_A.Items[i]);
            }
            lib_A.Items.Clear();
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            for (int i = lib_B.SelectedItems.Count - 1; i>=0 ; i--)
            {
                lib_A.Items.Add(lib_B.SelectedItems[i]);
                lib_B.Items.Remove(lib_B.SelectedItems[i]);
            }
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lib_B.Items.Count; i++)
            {
                lib_A.Items.Add(lib_B.Items[i]);
            }
            lib_B.Items.Clear();
        }

        private void frm_ListBox_Load(object sender, EventArgs e)
        {
            foreach (var ho in Hoten.Keys)
            {
                cb_Ho.Items.Add(ho);
            }
        }

        private void cb_Ho_SelectedIndexChanged(object sender, EventArgs e)
        {
            lib_A.Items.Clear();
            foreach (var item in Hoten[cb_Ho.SelectedItem.ToString()])
            {
                lib_A.Items.Add(item);
            }
        }
    }
}
