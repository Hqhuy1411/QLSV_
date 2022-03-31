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
    public partial class Form2 : Form
    {
        public delegate void DelAdd(SV sv);
        public DelAdd add { get; set; }

        public DelAdd edit { get; set; }
        public Form2()
        {
            InitializeComponent();
            radioMale.Checked = true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (textMaSV.Enabled == false)
            {
                
                SV sv = new SV();
                sv.MaSV = textMaSV.Text;
                sv.TenSV = txtTenSV.Text;
                sv.LopSH = comboBox1.Text;
                sv.NS = Convert.ToDateTime(dateTimePicker1.Value);
                sv.Gtinh = radioMale.Checked ? true : false;
                sv.DTB = Convert.ToDouble(txtDTB.Text);
                sv.Anh = CbAnh.Checked ? true : false;
                sv.HBa = cbHocBa.Checked ? true : false;
                sv.CMND = cbcmnnd.Checked ? true : false;
                edit(sv);
            }
            else
            {
                
                SV sv = new SV();
                sv.MaSV = textMaSV.Text;
                sv.TenSV = txtTenSV.Text;
                sv.LopSH = comboBox1.Text;
                sv.NS = Convert.ToDateTime(dateTimePicker1.Value);
                sv.Gtinh = radioMale.Checked ? true : false;
                sv.DTB = Convert.ToDouble(txtDTB.Text);
                sv.Anh = CbAnh.Checked ? true : false;
                sv.HBa = cbHocBa.Checked ? true : false;
                sv.CMND = cbcmnnd.Checked ? true : false;
                add(sv);
            }
            this.Dispose();
        }
        public void ShowSV(SV sv)
        {
            textMaSV.Text = sv.MaSV;
            txtTenSV.Text = sv.TenSV;
            txtDTB.Text = sv.DTB.ToString();
            comboBox1.Text = sv.LopSH;
            dateTimePicker1.Value = sv.NS;
            if(sv.Gtinh) { radioMale.Checked = true; } else
            {
                radioFemale.Checked = true;
            }
            if (sv.Anh) CbAnh.Checked = true;
            if (sv.HBa) cbHocBa.Checked = true;
            if (sv.CMND) cbcmnnd.Checked = true;
            textMaSV.Enabled = false;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
