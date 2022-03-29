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
    public class DBSV
    {
        private static DBSV _Instance;
        public static DBSV Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DBSV();
                }
                else
                {
                    return _Instance;
                }                   
            }
            private set { }
        }
        public DataTable DTSV { get; set; }
        private DBSV()
        {
            DTSV = new DataTable();
            DTSV.Columns.AddRange(new DataColumn[]
            {
                new DataColumn{ColumnName = "MSSV", DataType = typeof(string)},
                new DataColumn{ColumnName = "NameSV", DataType = typeof(string)},
                new DataColumn{ColumnName = "LopSH", DataType = typeof(string)},
                new DataColumn{ColumnName = "Gender", DataType = typeof(bool)},
                new DataColumn{ColumnName = "NgaySinh", DataType = typeof(DateTime)},
                new DataColumn{ColumnName = "DTB", DataType = typeof(double)},
                new DataColumn{ColumnName = "Photo", DataType = typeof(string)},
                new DataColumn{ColumnName = "HocBa", DataType = typeof(string)},
                new DataColumn{ColumnName = "CMND", DataType = typeof(string)}
            });
            DTSV.Rows.Add("101", "Tran Van A", "20T2", true, "01/01/2020", 8.5, true, true, true);
            DTSV.Rows.Add("102", "Tran Van B", "20T1", true, "01/01/2020", 8.5, true, true, true);
            DTSV.Rows.Add("103", "Tran Van C", "20T1", true, "01/01/2020", 8.5, true, true, true);
            DTSV.Rows.Add("104", "Tran Van D", "20T2", true, "01/01/2020", 8.5, true, true, true);   
            

            
        }
    }
}
