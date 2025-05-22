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


        void page()
        {
            if (panelpage == 0)
            {
                panel1.AutoScrollPosition = new Point(0, 0);
                label1.Text = "Home";
                richTextBox1.Text = "test test\nwhen i find myself in times of trouble";
                richTextBox2.Text = "long before time had a name";
                pictureBox1.ImageLocation = "D://vstudio//website//website//images//rice.jpg";
                richTextBox1.Height = 100;
                pictureBox1.Width = 600;
                pictureBox1.Height = 100;
                richTextBox1.Location = new Point(4, 3);
                pictureBox1.Location = new Point(4, 109);
                richTextBox2.Location = new Point(4,216);
                richTextBox1.Show();
                richTextBox2.Show();
                pictureBox1.Show();
                button2.Show();
                button1.Hide();
            }

            if (panelpage == 1)
            {
                panel1.AutoScrollPosition = new Point(0, 0);
                label1.Text = "Page 1";
                richTextBox1.Text = "expansion drive";
                richTextBox2.Text = "the first spinjitsu master";
                pictureBox1.ImageLocation = "D://vstudio//website//website//images//anhphan.jpg";
                richTextBox1.Height = 100;
                pictureBox1.Width = 484;
                pictureBox1.Height = 91;
                richTextBox1.Location = new Point(4, 3);
                pictureBox1.Location = new Point(4, 109);
                richTextBox2.Location = new Point(4, 206);
                richTextBox1.Show();
                richTextBox2.Show();
                pictureBox1.Show();
                button2.Show();
                button1.Show();
            }

            if (panelpage == 2)
            {
                panel1.AutoScrollPosition = new Point(0, 0);
                label1.Text = "Page 2";
                richTextBox1.Text = "test\ntest\ntest\ntest\ntest\ntest\ntest\ntest\ntest\ntest\ntest\ntest\ntest";
                richTextBox2.Text = "created Ninjago!";
                pictureBox1.ImageLocation = "D://vstudio//website//website//images//anhphan.jpg";
                richTextBox1.Height = 100;
                pictureBox1.Width = 484;
                pictureBox1.Height = 300;
                richTextBox1.Location = new Point(4, 309);
                pictureBox1.Location = new Point(4, 3);
                richTextBox2.Location = new Point(4, 415);
                richTextBox1.Show();
                richTextBox2.Show();
                pictureBox1.Show();
                button2.Show();
                button1.Show();
            }

            if (panelpage == 3)
            {
                panel1.AutoScrollPosition = new Point(0, 0);
                label1.Text = "Page 3";
                richTextBox1.Text = "Rich\nMillionaire! test test\n\n\n\n\n\n\n\n\n\nbrazillionaire";
                richTextBox2.Text = "bananas";
                pictureBox1.ImageLocation = "D://vstudio//website//website//images//955AFA2D-F224-4EE2-83DC-43BABE4CA648.jpg";
                richTextBox1.Height = 165;
                pictureBox1.Width = 50;
                pictureBox1.Height = 150;
                richTextBox1.Location = new Point(4, 3);
                pictureBox1.Location = new Point(4, 174);
                richTextBox2.Location = new Point(4, 331);
                richTextBox1.Show();
                richTextBox2.Show();
                pictureBox1.Show();
                button2.Hide();
                button1.Show();
            }

            if (panelpage == 99)
            {
                panel1.AutoScrollPosition = new Point(0, 0);
                label1.Text = "Page 3";
                richTextBox1.Text = "example resources\n\nvisual studio";
                richTextBox2.Text = "bananas";
                pictureBox1.ImageLocation = "D://vstudio//website//website//images//955AFA2D-F224-4EE2-83DC-43BABE4CA648.jpg";
                richTextBox1.Height = 165;
                pictureBox1.Width = 50;
                pictureBox1.Height = 150;
                richTextBox1.Location = new Point(4, 3);
                pictureBox1.Location = new Point(4, 174);
                richTextBox2.Location = new Point(4, 331);
                richTextBox1.Show();
                richTextBox2.Hide();
                pictureBox1.Hide();
                button2.Hide();
                button1.Hide();
            }

        }



        private void button1_Click(object sender, EventArgs e)
        {
            panelpage = (panelpage - 1);
            page();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelpage = (panelpage + 1);
            page();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelpage = 0;
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

        private void page3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelpage = 3;
            page();
        }

        private void linksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelpage = 99;
            page();
        }
    }
}
