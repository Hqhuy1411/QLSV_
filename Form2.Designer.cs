
namespace Bai4
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtDTB = new System.Windows.Forms.TextBox();
            this.txtTenSV = new System.Windows.Forms.TextBox();
            this.textMaSV = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.radioFemale = new System.Windows.Forms.RadioButton();
            this.radioMale = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbcmnnd = new System.Windows.Forms.CheckBox();
            this.cbHocBa = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CbAnh = new System.Windows.Forms.CheckBox();
            this.labe6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(603, 86);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 31);
            this.dateTimePicker1.TabIndex = 26;
            // 
            // txtDTB
            // 
            this.txtDTB.Location = new System.Drawing.Point(565, 150);
            this.txtDTB.Name = "txtDTB";
            this.txtDTB.Size = new System.Drawing.Size(196, 31);
            this.txtDTB.TabIndex = 24;
            // 
            // txtTenSV
            // 
            this.txtTenSV.Location = new System.Drawing.Point(242, 153);
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.Size = new System.Drawing.Size(196, 31);
            this.txtTenSV.TabIndex = 23;
            // 
            // textMaSV
            // 
            this.textMaSV.Location = new System.Drawing.Point(242, 86);
            this.textMaSV.Name = "textMaSV";
            this.textMaSV.Size = new System.Drawing.Size(196, 31);
            this.textMaSV.TabIndex = 22;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(647, 455);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(139, 48);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(462, 455);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(139, 48);
            this.btnOk.TabIndex = 13;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // radioFemale
            // 
            this.radioFemale.AutoSize = true;
            this.radioFemale.Location = new System.Drawing.Point(42, 105);
            this.radioFemale.Name = "radioFemale";
            this.radioFemale.Size = new System.Drawing.Size(115, 29);
            this.radioFemale.TabIndex = 14;
            this.radioFemale.TabStop = true;
            this.radioFemale.Text = "FeMale";
            this.radioFemale.UseVisualStyleBackColor = true;
            // 
            // radioMale
            // 
            this.radioMale.AutoSize = true;
            this.radioMale.Location = new System.Drawing.Point(42, 43);
            this.radioMale.Name = "radioMale";
            this.radioMale.Size = new System.Drawing.Size(90, 29);
            this.radioMale.TabIndex = 13;
            this.radioMale.TabStop = true;
            this.radioMale.Text = "Male";
            this.radioMale.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "18T",
            "19T",
            "20T"});
            this.comboBox1.Location = new System.Drawing.Point(242, 225);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(196, 33);
            this.comboBox1.TabIndex = 25;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioFemale);
            this.groupBox2.Controls.Add(this.radioMale);
            this.groupBox2.Location = new System.Drawing.Point(141, 300);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 157);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gender";
            // 
            // cbcmnnd
            // 
            this.cbcmnnd.AutoSize = true;
            this.cbcmnnd.Location = new System.Drawing.Point(30, 147);
            this.cbcmnnd.Name = "cbcmnnd";
            this.cbcmnnd.Size = new System.Drawing.Size(107, 29);
            this.cbcmnnd.TabIndex = 17;
            this.cbcmnnd.Text = "CMND";
            this.cbcmnnd.UseVisualStyleBackColor = true;
            // 
            // cbHocBa
            // 
            this.cbHocBa.AutoSize = true;
            this.cbHocBa.Location = new System.Drawing.Point(30, 96);
            this.cbHocBa.Name = "cbHocBa";
            this.cbHocBa.Size = new System.Drawing.Size(112, 29);
            this.cbHocBa.TabIndex = 16;
            this.cbHocBa.Text = "Học bạ";
            this.cbHocBa.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbcmnnd);
            this.groupBox1.Controls.Add(this.cbHocBa);
            this.groupBox1.Controls.Add(this.CbAnh);
            this.groupBox1.Location = new System.Drawing.Point(485, 215);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 198);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hồ sơ nộp";
            // 
            // CbAnh
            // 
            this.CbAnh.AutoSize = true;
            this.CbAnh.Location = new System.Drawing.Point(33, 47);
            this.CbAnh.Name = "CbAnh";
            this.CbAnh.Size = new System.Drawing.Size(82, 29);
            this.CbAnh.TabIndex = 15;
            this.CbAnh.Text = "Ảnh";
            this.CbAnh.UseVisualStyleBackColor = true;
            // 
            // labe6
            // 
            this.labe6.AutoSize = true;
            this.labe6.Location = new System.Drawing.Point(489, 153);
            this.labe6.Name = "labe6";
            this.labe6.Size = new System.Drawing.Size(54, 25);
            this.labe6.TabIndex = 18;
            this.labe6.Text = "DTB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(489, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Lớp SH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tên SV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mã SV";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 589);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtDTB);
            this.Controls.Add(this.txtTenSV);
            this.Controls.Add(this.textMaSV);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labe6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtDTB;
        private System.Windows.Forms.TextBox txtTenSV;
        private System.Windows.Forms.TextBox textMaSV;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.RadioButton radioFemale;
        private System.Windows.Forms.RadioButton radioMale;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbcmnnd;
        private System.Windows.Forms.CheckBox cbHocBa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox CbAnh;
        private System.Windows.Forms.Label labe6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}