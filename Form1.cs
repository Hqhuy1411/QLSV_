using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4
{
    public partial class Form1 : Form
    {
        private QLSV qlsv = new QLSV();
        public Form1()
        {
            InitializeComponent();
            cbLSH.Items.Add("All");
            foreach(String name in qlsv.getLopSH().Distinct())
            {
                cbLSH.Items.Add(name);
            }
        }
        public void Add(SV sv)
        {
            int ktra = qlsv.indexof(sv);
            if (ktra == -1)
            {

                qlsv.Add(sv);
            }
            else
            {
                MessageBox.Show("Ma SV trung ");
            }
        }
        public void Edit(SV sv)
        {
            qlsv.Update(sv);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.add = new Form2.DelAdd(Add);
            f.ShowDialog();
            dataGridView1.DataSource = qlsv.getAllSV();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            SV sv = getSV(dataGridView1.SelectedRows[0]);
            f.ShowSV(sv);
            f.edit = new Form2.DelAdd(Edit);
            f.ShowDialog();
            dataGridView1.DataSource = qlsv.getAllSV();

        }

        private void btndel_Click(object sender, EventArgs e)
        {
            SV sv = getSV(dataGridView1.SelectedRows[0]);
            qlsv.Delete(sv);
            dataGridView1.DataSource = qlsv.getAllSV();
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            String lopSH = cbLSH.Text;
            dataGridView1.DataSource = qlsv.getLopSH(lopSH);
        }
        private SV getSV(DataGridViewRow row)
        {
            SV student = new SV();

            student.MaSV = row.Cells[0].Value.ToString();
            student.TenSV = row.Cells[1].Value.ToString();
            student.LopSH = row.Cells[2].Value.ToString();
            student.Gtinh = Convert.ToBoolean(row.Cells[3].Value);
            student.NS = Convert.ToDateTime(row.Cells[4].Value);
            student.DTB = Convert.ToDouble(row.Cells[5].Value.ToString());
            student.Anh = Convert.ToBoolean(row.Cells[6].Value);
            student.HBa = Convert.ToBoolean(row.Cells[7].Value);
              student.CMND = Convert.ToBoolean(row.Cells[8].Value);
            
            return student;
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            DataGridView current = dataGridView1;
            List<SV> listcurrrent = new List<SV>();
            foreach(DataGridViewRow row in current.Rows)
            {
                listcurrrent.Add(getSV(row));
            }
            dataGridView1.DataSource = qlsv.getBySearch(txtsearch.Text, listcurrrent);
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            DataGridView current = dataGridView1;
            List<SV> listcurrrent = new List<SV>();
            foreach (DataGridViewRow row in current.Rows)
            {
                listcurrrent.Add(getSV(row));
            }
            if(cbSort.Text == "")
            {
                MessageBox.Show("Cần chọn thuộc tính sắp xếp");
            }else if(cbSort.SelectedItem.ToString() == "MSSV")
            {
                dataGridView1.DataSource = qlsv.sortby(listcurrrent, sortByID);
            }
            else if(cbSort.SelectedItem.ToString() == "NameSV")
            {
                dataGridView1.DataSource = qlsv.sortby(listcurrrent, sortByName);
            }
            else if(cbSort.SelectedItem.ToString() == "DTB")
            {
                dataGridView1.DataSource = qlsv.sortby(listcurrrent, sortByDTB);
            }
       //     dataGridView1.DataSource = qlsv.sortby(listcurrrent, sortByID);
        }
        public bool sortByDTB(SV sv1, SV sv2)
        {
            return sv1.DTB > sv2.DTB;
        }

        public bool sortByName(SV sv1, SV sv2)
        {
            return sv1.TenSV.CompareTo(sv2.TenSV) > 0;
        }
        public bool sortByID(SV sv1, SV sv2)
        {
            return int.Parse(sv1.MaSV) > int.Parse(sv2.MaSV);
        }
    }
}
