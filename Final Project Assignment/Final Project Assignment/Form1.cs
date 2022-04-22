using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "admin") && (textBox2.Text == "12345"))
            {
                Form Form2 = new Form2();
                Form2.Show();
                this.Hide();
            }
            else MessageBox.Show("Username หรือ Password ไม่ถูกต้อง");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("แน่ใจว่าจะออก", "!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.OK)
                this.Close();
        }
    }
}
