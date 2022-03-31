using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    public class DataSV
    {
        private static DataSV _Instance;
        public static DataSV Instance
        {
            get
            {
                if(_Instance == null)
                {
                    _Instance = new DataSV();
                }
                return _Instance;
            }
            private set { }
        }
        public DataTable DTSV { get; set; }
        private DataSV()
        {
            DTSV = new DataTable();
            DTSV.Columns.AddRange(new DataColumn[]
            {
                new DataColumn {ColumnName ="MSSV",DataType=typeof(string)},
                new DataColumn {ColumnName ="NameSV",DataType=typeof(string)},
                new DataColumn {ColumnName ="LopSH",DataType=typeof(string)},
                new DataColumn {ColumnName ="Gender",DataType=typeof(bool)},
                new DataColumn {ColumnName ="NS",DataType=typeof(DateTime)},
                new DataColumn {ColumnName ="DTB",DataType=typeof(double)},
                new DataColumn {ColumnName ="Anh",DataType=typeof(bool)},
                new DataColumn {ColumnName ="HB",DataType=typeof(bool)},
                new DataColumn {ColumnName ="CMND",DataType=typeof(bool)},

            });
            DTSV.Rows.Add("103", "NVA", "18T", true, DateTime.Now, 1.1, true, true, false);
            DTSV.Rows.Add("102", "NVBB", "19T", true, DateTime.Now, 1.5, false, true, true);
            DTSV.Rows.Add("104", "NVC", "20T", true, DateTime.Now, 1.3, true, false, false);
        }
        public void Add(SV sv)
        {
            DTSV.Rows.Add(sv.MaSV,sv.TenSV,sv.LopSH,sv.Gtinh,sv.NS,sv.DTB,sv.Anh,sv.CMND,sv.HBa);
        }
        public void Detete(int x)
        {
            DTSV.Rows.RemoveAt(x);
        }
        public void Update(SV sv,int x)
        {
            DTSV.Rows[x][1] = sv.TenSV;
            DTSV.Rows[x][2] = sv.LopSH;
            DTSV.Rows[x][3] = sv.Gtinh;
            DTSV.Rows[x][4] = sv.NS;
            DTSV.Rows[x][5] = sv.DTB;
            DTSV.Rows[x][6] = sv.Anh;
            DTSV.Rows[x][7] = sv.HBa;
            DTSV.Rows[x][8] = sv.CMND;
        }
    }
}
