using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mohammed_alsalimi_الاختبار
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Count() <= 8)

                textBox1.BackColor = Color.GhostWhite;
            else
                textBox1.BackColor = Color.Red;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
                textBox1.PasswordChar = '\0';
            else
                textBox1.PasswordChar='*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "محمد" || comboBox1.Text == "احمد " || comboBox1.Text == "علي" || textBox1.Text == "123" || textBox1.Text == "1234" || textBox1.Text == "12345")
            {
                groupBox1.Visible = false;
                الرئيسية ma = new الرئيسية();
                ma.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("كلمة المرور غير صحيحة");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            groupBox2.Visible = true;
            groupBox1.Visible=false;
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            groupBox2.Visible = false;
            groupBox1.Visible = true;
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Count() <= 8)

                textBox3.BackColor = Color.GhostWhite;
            else
                textBox3.BackColor = Color.Red;

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text==textBox3.Text)
            {
                textBox4.BackColor = Color.Green;
                label7.Text = "كلمة المرور مطابقة";
                label7.ForeColor = Color.Green;
                button3.ForeColor = Color.White;
            }
            else
            {
               
                textBox4.BackColor = Color.Red;
                label7.Text = "كلمة المرور غير مطابقة";
                label7.ForeColor = Color.Red;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox4.PasswordChar = '\0';
                textBox3.PasswordChar = '\0';
            }
            else
            {
                textBox4.PasswordChar = '*';
                textBox3.PasswordChar = '*';
            }
            }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            groupBox2.Visible = true;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            groupBox3.Visible = false;
            groupBox2.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("تم انشاء حساب جديد");
            groupBox3.Visible = false;
            groupBox1.Visible = true;
        
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox2.Text);
            groupBox2.Visible = false;
            groupBox3.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //if (pictureBox1.Image!=".png")
            //{
            //    MessageBox.Show("ملف غير صحيح");
            //}
        }
    }
}
