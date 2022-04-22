using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_Assignment
{
    public partial class Form2 : Form
    {
        private int i;
        private int sum;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox2.Items.Add("บึงกาฬ");
            comboBox2.Items.Add("อุดรธานี");
            comboBox2.Items.Add("ชัยภูมิ");
            comboBox2.Items.Add("หนองบัวลำภู");
            comboBox2.Items.Add("ขอนแก่น");
            comboBox2.Items.Add("ร้อยเอ็ด");
            comboBox2.Items.Add("ปทุมธานี");
            comboBox2.Items.Add("กรุงเทพมหานคร");
            comboBox2.Items.Add("เชียงใหม่");
            comboBox2.Items.Add("เชียงราย");

            comboNum.Items.Add("A1");
            comboNum.Items.Add("B2");
            comboNum.Items.Add("C3");
            comboNum.Items.Add("D4");
            comboNum.Items.Add("E5");
            comboNum.Items.Add("F6");
            comboNum.Items.Add("G7");
            comboNum.Items.Add("H8");
            comboNum.Items.Add("I9");
            comboNum.Items.Add("J10");
            
        }

        private void textName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                if (textName.Text == "")
                {
                    MessageBox.Show("กรุณาใส่ ชื่อ-นามสกุล", "!");
                    textName.Focus();
                }
                else
                {
                    comboBox2.Focus();
                }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            str = comboBox2.SelectedItem.ToString();
            switch (str)
            {
                case "บึงกาฬ": textprice.Text = "100"; break;
                case "อุดรธานี": textprice.Text = "140"; break;
                case "ชัยภูมิ": textprice.Text = "200"; break;
                case "หนองบัวลำภู": textprice.Text = "180"; break;
                case "ขอนแก่น": textprice.Text = "170"; break;
                case "ร้อยเอ็ด": textprice.Text = "220"; break;
                case "ปทุมธานี": textprice.Text = "650"; break;
                case "กรุงเทพมหานคร": textprice.Text = "680"; break;
                case "เชียงใหม่": textprice.Text = "980"; break;
                case "เชียงราย": textprice.Text = "990"; break;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                double price = 0, num = 0, sum = 0;
                num = double.Parse(numericUpDown1.Text);
                price = double.Parse(textprice.Text);
                sum = price * num;
                textBoxG_2.Text = sum.ToString("#,##.00");
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                double price = 0, num = 0, sum = 0;
                num = double.Parse(numericUpDown1.Text);
                price = double.Parse(textprice.Text);
                sum = (price * num) * 50 / 100;
                textBoxG_2.Text = sum.ToString("#,##.00");
            }
        }

        private void numericUpDown1_Click(object sender, EventArgs e)
        {
            buttonG2_Click(sender, e);
        }

        private void buttonG2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                double price = 0, num = 0, sum = 0;
                num = double.Parse(numericUpDown1.Text);
                price = double.Parse(textprice.Text);
                sum = price * num;
                textBoxG_2.Text = sum.ToString("#,##.00");
            }
            if (radioButton2.Checked == true)
            {
                double price = 0, num = 0, sum = 0;
                num = double.Parse(numericUpDown1.Text);
                price = double.Parse(textprice.Text);
                sum = (price * num) * 50 / 100;
                textBoxG_2.Text = sum.ToString("#,##.00");
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            buttonG3_Click(sender, e);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            buttonG3_Click(sender, e);
        }

        private void buttonG3_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                double price;
                price = double.Parse(textBoxG_2.Text);
                textBoxG_3.Text = price.ToString("#,##.00");
            }
            if (radioButton4.Checked == true)
            {
                double price, back;
                price = double.Parse(textBoxG_2.Text);
                back = price * 2;
                textBoxG_3.Text = back.ToString("#,##.00");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double total1 = 0, total2 = 0, sum = 0;
            total1 = double.Parse(textBoxG_3.Text);
            total2 = double.Parse(textBox3.Text);
            sum = total1 + total2;
            textBoxtotal.Text = sum.ToString("#,##.00");

            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = textName.Text;
            dataGridView1.Rows[n].Cells[1].Value = comboBox2.Text;
            dataGridView1.Rows[n].Cells[2].Value = comboNum.Text;
            dataGridView1.Rows[n].Cells[3].Value = textBoxtotal.Text;
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("คุณต้องการลบข้อมูลหรือไม่", "เตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                textName.Clear();
                textprice.Text = "0.00";
                textBoxG_2.Text = "0.00";
                textBoxG_3.Text = "0.00";
                textBoxtotal.Text = "0.00";
                textBox1.Text = "0.00";
                textBox2.Text = "0.00";
                textBox3.Text = "0.00";
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                numericUpDown1.Text = "0";
                comboNum.Text = "กรุณาเลือกที่นั่ง";
                comboBox2.Text = "กรุณาเลือกจังหวัด";
                textName.Focus();


            }
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("คุณต้องการออกจากระบบหรือไม่", "!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = " (*.csv)|*.csv";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] readAllLine = File.ReadAllLines(openFileDialog.FileName);
                string readAllText = File.ReadAllText(openFileDialog.FileName);
                for (int i = 0; i < readAllLine.Length; i++);
                {
                    string allDataRAW = readAllLine[i];
                    string[] allDataSplited = allDataRAW.Split(',');
                    this.dataGridView1.Rows.Add(allDataSplited[0], allDataSplited[1], allDataSplited[2], allDataSplited[3]);
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filepath = string.Empty;
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV(*.csv)|*.csv";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (!fileError)
                    {
                        try
                        {
                            int columnCount = dataGridView1.Columns.Count;
                            string column = "";
                            string[] outputCSV = new string[dataGridView1.Rows.Count + 1];
                            for (int i = 0; i < columnCount; i++)
                            {
                                column += dataGridView1.Columns[i].HeaderText.ToString() + ",";
                            }
                            outputCSV[0] += column;
                            for (int i = 1; (i - 1) < dataGridView1.Rows.Count; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    outputCSV[i] += dataGridView1.Rows[i - 1].Cells[j].Value.ToString() + ",";
                                }
                            }
                            File.WriteAllLines(sfd.FileName, outputCSV, Encoding.UTF8);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("ต้องการลบข้อมูลหรือไม่ ?", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dataGridView1.Rows.Clear();    //Removed(Rows);
                }
                
            }
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            double total1 = 0, total2 = 0, sum = 0;
            total1 = double.Parse(textBoxtotal.Text);
            total2 = double.Parse(textBox1.Text);
            sum = total1 - total2;
            textBox2.Text = sum.ToString("#,##.00");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            sum = 0;
            if (checkBox1.Checked) sum += 100;
            if (checkBox2.Checked) sum += 350;
            textBox3.Text = sum.ToString("#,##,00");

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           button3_Click(sender, e);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            button3_Click(sender, e);
        }
    }
}
