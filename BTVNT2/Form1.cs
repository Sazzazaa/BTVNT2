using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTVNT2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            ListViewItem lv = new ListViewItem(txt_ten.Text);

            lv.SubItems.Add(txt_ho.Text);
            lv.SubItems.Add(txt_sdt.Text);

            lv_info.Items.Add(lv);
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (lv_info.SelectedItems.Count > 0)
            {
                ListViewItem selecteditem = lv_info.SelectedItems[0];

                selecteditem.SubItems[0].Text = txt_ten.Text;
                selecteditem.SubItems[1].Text = txt_ho.Text;
                selecteditem.SubItems[2].Text = txt_sdt.Text;

            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (lv_info.SelectedItems.Count > 0)
            {
                lv_info.Items.Remove(lv_info.SelectedItems[0]);
            }

        }
    }
}
