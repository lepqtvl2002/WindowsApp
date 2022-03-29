using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App02
{
    public class SV
    {
        public SV(string txtMSSV, string txtName, string txtClass, 
            bool checked1, DateTime dateTime, double v, bool checked2, bool checked3, bool checked4)
        {
            MSSV = txtMSSV;
            NameSV = txtName;
            LopSH = txtClass;
            Gender = checked1;
            NgaySinh = dateTime;
            DTB = v;
            Photo = checked2;
            HocBa = checked3;
            CMND = checked4;
        }

        public string MSSV { get; set; }
        public string NameSV { get; set; }
        public bool Gender { get; set; } = true;
        public string LopSH { get; set; }
        public DateTime NgaySinh { get; set; }
        public double DTB { get; set; }
        public bool Photo { get; set; } = false ;
        public bool HocBa { get; set; } = false ;
        public bool CMND { get; set; } = false ;
    }
}
