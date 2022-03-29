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
    public partial class Form3 : Form
    {
        public delegate List<SV> Enter(SV sV);
        public static Enter enter;
        public QLSV qLSV = new QLSV();
        public Form3()
        {
            InitializeComponent();
        }
        public void loadSV(SV sV)
        {
            txtMSSV.Text = sV.MSSV;
            txtName.Text = sV.NameSV;
            txtClass.Text = sV.LopSH;
            txtDTB.Text =  sV.DTB.ToString();
            radioButtonFemale.Checked = !sV.Gender;
            radioButtonMale.Checked = sV.Gender;
            checkBoxPhoto.Checked = sV.Photo;
            checkBoxHocBa.Checked = sV.HocBa;
            checkBoxCMND.Checked = sV.CMND;
            dateTimePicker1.Text = sV.NgaySinh.ToString();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //d(txtMSSV.Text);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SV sv = new SV(txtMSSV.Text, txtName.Text, txtClass.Text, radioButtonMale.Checked, 
                Convert.ToDateTime(dateTimePicker1.Text), Convert.ToDouble(txtDTB), 
                checkBoxPhoto.Checked, checkBoxHocBa.Checked, checkBoxCMND.Checked);

            Close();
        }
    }
}
