using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    public class QLSV
    {
        public delegate bool Compare(SV a, SV b);
        public List<SV> getAllSV()
        {
            List<SV> list = new List<SV>();
            foreach(DataRow row in DataSV.Instance.DTSV.Rows)
            {
                list.Add(getSVbyDataRow(row));
            }
            return list;
        }
        public SV getSVbyDataRow(DataRow i)
        {
            SV sv = new SV()
            {
                MaSV = i[0].ToString(),
                TenSV = i[1].ToString(),
                LopSH = i[2].ToString(),
                Gtinh = Convert.ToBoolean(i[3].ToString()),
                NS = Convert.ToDateTime(i[4].ToString()),
                DTB = Convert.ToDouble(i[5].ToString()),
                Anh = Convert.ToBoolean(i[6].ToString()),
                HBa = Convert.ToBoolean(i[7].ToString()),
                CMND = Convert.ToBoolean(i[8].ToString())
            };
            return sv;
        }
        public List<SV> getLopSH(String lop)
        {
            List<SV> list = new List<SV>();
            if(lop == "All")
            {
                list = getAllSV();
            }
            else
            {
                foreach(SV sv in getAllSV())
                {
                    if(sv.LopSH == lop)
                    {
                        list.Add(sv);
                    }
                }
            }
            return list;
        }
        public List<SV> getBySearch(String keyword,List<SV> listcurrent)
        {
            List<SV> list = new List<SV>();
            if (keyword == "")
            {
                list = listcurrent;
            }
            else
            {
                foreach (SV sv in listcurrent)
                {
                    if (sv.TenSV.Contains(keyword) || sv.LopSH.Contains(keyword))
                    {
                        list.Add(sv);
                    }
                }
            }
            return list;
        }
        public List<String> getLopSH()
        {
            List<String> list = new List<string>();
            foreach(SV sv in getAllSV())
            {
                list.Add(sv.LopSH);
            }
            return list;
        }
        public void Add(SV sv)
        {
            DataSV.Instance.Add(sv);
        }
        public void Delete(SV sv)
        {
            int x = indexof(sv);
            DataSV.Instance.Detete(x);
        }
        public void Update(SV sv)
        {
            int x = indexof(sv);
            DataSV.Instance.Update(sv,x);
        }
        public int indexof(SV sv)
        {
            for(int i=0; i <getAllSV().Count ; i++)
            {
                if(sv.MaSV == getAllSV()[i].MaSV)
                {
                    return i;
                }
            }
            return -1;
        }
        public List<SV> sortby(List<SV> current , Compare compare)
        {
           for(int i=0; i < current.Count; i++)
            {
                for(int j= i+1; j < current.Count; j++)
                {
                    if (compare(current[i], current[j]))
                    {
                        SV temp = current[i];
                        current[i] = current[j];
                        current[j] = temp;
                    }
                }
            }
            return current;
        }
       
    }
}
