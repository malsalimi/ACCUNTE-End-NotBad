using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
namespace mohammed_alsalimi_الاختبار
{
    public partial class الرئيسية : Form
    {
        public الرئيسية()
        {
            InitializeComponent();
            timer1.Start();
        }
        Stopwatch Stopwatch;
        private void جديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();


        }

        private void فتحToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            richTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);
        }

        private void حفظToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File.WriteAllText(openFileDialog1.FileName, richTextBox1.Text);
        }

        private void حفظبأسمToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void اغلاقToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            label2.Text = string.Format("{0:hh\\:mm\\:ss\\:ff}", Stopwatch.Elapsed);
        }

        private void الرئيسية_Load(object sender, EventArgs e)
        {
            Stopwatch=new Stopwatch();
        }

        private void لصقToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void قصToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void تراجعToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void نسخToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void حفظالنصالمحددToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
