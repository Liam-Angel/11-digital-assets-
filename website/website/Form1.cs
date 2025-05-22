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

namespace website
{
    public partial class Form1 : Form
    {
        int panelpage = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "classic anh";
            page();
        }

        private void page1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelpage = 1;
            page();
        }

        private void page2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelpage = 2;
            page();
        }

        void page()
        {
            if (panelpage == 0)
            {
                label1.Text = "Home";
                richTextBox1.Text = "expansion drive";
                pictureBox1.Width = 600;
                pictureBox1.Height = 91;
                pictureBox1.ImageLocation = "D://vstudio//website//website//images//rice.jpg";
            }

            if (panelpage == 1)
            {
                label1.Text = "Page 1";
                richTextBox1.Text = "expansion drive";
                pictureBox1.Width = 484;
                pictureBox1.Height = 91;
                pictureBox1.ImageLocation = "D://vstudio//website//website//images//anhphan.jpg";
            }

            if (panelpage == 2)
            {
                label1.Text = "Page 2";
                richTextBox1.Text = "Rich\nMillionaire! test test\n\n\n\n\n\n\n\n\n\nbrazillionaire";
                pictureBox1.Width = 50;
                pictureBox1.Height = 50;
                pictureBox1.Height = 50;
                pictureBox1.ImageLocation = "D://vstudio//website//website//images//955AFA2D-F224-4EE2-83DC-43BABE4CA648.jpg";
            }
        }
    }
}
