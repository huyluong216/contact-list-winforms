﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddContactForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã lưu liên hệ:\nHọ tên: " + txtHoTen.Text + "\nSĐT: " + txtSoDienThoai.Text);
            this.Close();
        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddContactForm addForm = new AddContactForm();
            addForm.ShowDialog(); // Mở form thêm liên hệ
        }
    }
}
