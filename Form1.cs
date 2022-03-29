using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbbTramRang.SelectedIndex = 0;  
        }

        private void lbTitle_Click(object sender, EventArgs e)
        {

        }

        int total()
        {
            int s = 0;
            if (cbCaoVoi.Checked) s += 100000;
            if (cbTayTrang.Checked) s += 1200000;
            if (cbChupHinhRang.Checked) s += 200000;
            int soRangTram = Convert.ToInt32(cbbTramRang.SelectedItem.ToString());
            s += soRangTram * 80000;
            return s;
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Vui long nhap ten khach hang!");
            }
            else
            {
                txtTotal.Text = "$" + total().ToString();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
