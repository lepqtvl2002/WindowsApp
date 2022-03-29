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
    public partial class Form2 : Form
    {
        private QLSV qLSV = new QLSV();
        public Form2()
        {
            InitializeComponent();
            comboBoxClassSH.Items.Add("All");
            foreach (string i in qLSV.GetAllLopSH().Distinct())
            {
                comboBoxClassSH.Items.Add(i);
            }
        }

        public void show_Text(string s)
        {
            txtSearch.Text = s;
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            string LSH = comboBoxClassSH.SelectedItem.ToString();
            dataGridView1.DataSource = qLSV.GetSVByLopSH(LSH);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            QLSV qlsv = new QLSV();
             
            f3.Show();
        }

        private void comboBoxClassSH_SelectedIndexChanged(object sender, EventArgs e)
        {
            QLSV qlsv = new QLSV();
            if (comboBoxClassSH.SelectedIndex >= 0)
                dataGridView1.DataSource = qlsv.GetSVByLopSH(comboBoxClassSH.SelectedItem.ToString());
        }
    }
}
