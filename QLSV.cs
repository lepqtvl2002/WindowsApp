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
    public class QLSV
    {
        public List<SV> dsSV = new List<SV>();
        public void AddSV(SV sv)
        {
            dsSV.Add(sv);
        }

        public List<SV> GetAllSV()
        {
            List<SV> data = new List<SV>();
            foreach(DataRow i in DBSV.Instance.DTSV.Rows)
            {
                data.Add(GetSVByDataRow(i));
            }
            return data;
        }

        public SV GetSVByDataRow(int i)
        {
            return new SV
            {
                MSSV = i["MSSV"].ToString(),
                NameSV = i["Name"].ToString(),
                LopSH = i["LopSH"].ToString(),
                Gender = Convert.ToBoolean(i["Gender"].ToString()),
                NgaySinh = Convert.ToDateTime(i["NgaySinh"].ToString()),
                Photo = Convert.ToBoolean(i["Photo"].ToString()),
                HocBa = Convert.ToBoolean(i["HocBa"].ToString()),
                CMND = Convert.ToBoolean(i["CMND"].ToString()),
                DTB = Convert.ToDouble(i["DTB"].ToString())
            };
        }
        
        public List<SV> GetSVByLopSH(string LopSH)
        {
            List<SV> result = new List<SV>();
            //code here
            if (LopSH == "All")
            {
                result = GetAllSV();
            }
            else
            {
                foreach (SV i in GetAllSV())
                {
                    if (i.LopSH == LopSH)
                    {
                        result.Add(i);
                    }
                }
            }            
            return result;
        }

        public List<string> GetAllLopSH()
        {
            List<string> data = new List<string>();
            foreach (SV i in GetAllSV())
            {
                data.Add(i.LopSH);
            }
            return data;
        }
        

    }
}
