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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Xml.Serialization;
using System.Reflection;

namespace website
{
    public partial class Form1 : Form
    {
        int panelpage = 0;
        int answer;
        int[] check = new int[5];
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            page();
        }


        void page()
        {
            if (panelpage == 0)
            {
                panel1.AutoScrollPosition = new Point(0, 0);
                label1.Text = "Home";
                richTextBox1.Text = "test test\nexample tutorial\n";
                richTextBox2.Text = "placeholder text";
                pictureBox1.ImageLocation = "D://vstudio//website//website//images//exim.png";
                richTextBox1.Height = 100;
                pictureBox1.Width = 600;
                pictureBox1.Height = 100;
                richTextBox1.Location = new Point(4, 3);
                pictureBox1.Location = new Point(4, 109);
                richTextBox2.Location = new Point(4,216);
                checkBox1.Hide();
                checkBox2.Hide();
                checkBox3.Hide();
                checkBox4.Hide();
                richTextBox1.Show();
                richTextBox2.Show();
                pictureBox1.Show();
                button3.Hide();
                button2.Show();
                button1.Hide();
            }

            if (panelpage == 1)
            {
                panel1.AutoScrollPosition = new Point(0, 0);
                label1.Text = "Page 1";
                richTextBox1.Text = "placeholder";
                richTextBox2.Text = "placeholder text";
                pictureBox1.ImageLocation = "D://vstudio//website//website//images//stringim.png";
                richTextBox1.Height = 100;
                pictureBox1.Width = 484;
                pictureBox1.Height = 91;
                richTextBox1.Location = new Point(4, 3);
                pictureBox1.Location = new Point(4, 109);
                richTextBox2.Location = new Point(4, 206);
                checkBox1.Hide();
                checkBox2.Hide();
                checkBox3.Hide();
                checkBox4.Hide();
                richTextBox1.Show();
                richTextBox2.Show();
                pictureBox1.Show();
                button3.Hide();
                button2.Show();
                button1.Show();
            }

            if (panelpage == 2)
            {
                panel1.AutoScrollPosition = new Point(0, 0);
                label1.Text = "Page 2";
                richTextBox1.Text = "test\ntest\ntest\ntest\ntest";
                richTextBox2.Text = "placeholder text";
                pictureBox1.ImageLocation = "D://vstudio//website//website//images//intim.png";
                richTextBox1.Height = 151;
                pictureBox1.Width = 484;
                pictureBox1.Height = 91;
                richTextBox1.Location = new Point(4, 97);
                pictureBox1.Location = new Point(4, 3);
                richTextBox2.Location = new Point(4, 254);
                checkBox1.Hide();
                checkBox2.Hide();
                checkBox3.Hide();
                checkBox4.Hide();
                richTextBox1.Show();
                richTextBox2.Show();
                pictureBox1.Show();
                button3.Hide();
                button2.Show();
                button1.Show();
            }

            if (panelpage == 3)
            {
                panel1.AutoScrollPosition = new Point(0, 0);
                label1.Text = "Page 3";
                richTextBox1.Text = "exapmple tutorial";
                richTextBox2.Text = "placeholder text";
                pictureBox1.ImageLocation = "D://vstudio//website//website//images//charim.png";
                richTextBox1.Height = 165;
                pictureBox1.Width = 250;
                pictureBox1.Height = 150;
                richTextBox1.Location = new Point(4, 3);
                pictureBox1.Location = new Point(4, 174);
                richTextBox2.Location = new Point(4, 331);
                checkBox1.Hide();
                checkBox2.Hide();
                checkBox3.Hide();
                checkBox4.Hide();
                richTextBox1.Show();
                richTextBox2.Show();
                pictureBox1.Show();
                button3.Hide();
                button2.Show();
                button1.Show();
            }

            if (panelpage == 4)
            {
                panel1.AutoScrollPosition = new Point(0, 0);
                label1.Text = "multiple choice quiz";
                richTextBox1.Text = "float?";
                richTextBox2.Text = "placeholder text";
                pictureBox1.ImageLocation = "D://vstudio//website//website//images//charim.png";
                richTextBox1.Height = 20;
                pictureBox1.Width = 150;
                pictureBox1.Height = 150;
                richTextBox1.Location = new Point(4, 3);
                pictureBox1.Location = new Point(4, 174);
                richTextBox2.Location = new Point(4, 331);
                checkBox1.Text = "single character";
                checkBox2.Text = "number with decimals";
                checkBox3.Text = "sequence of characters";
                checkBox4.Text = "whole number";
                checkBox1.CheckState = CheckState.Unchecked;
                checkBox2.CheckState = CheckState.Unchecked;
                checkBox3.CheckState = CheckState.Unchecked;
                checkBox4.CheckState = CheckState.Unchecked;
                answer = 2;
                checkBox1.Show();
                checkBox2.Show();
                checkBox3.Show();
                checkBox4.Show();
                richTextBox1.Show();
                richTextBox2.Hide();
                pictureBox1.Hide();
                button3.Show();
                button2.Hide();
                button1.Show();
            }


            if (panelpage == 5)
            {
                panel1.AutoScrollPosition = new Point(0, 0);
                label1.Text = "finish";
                richTextBox1.Text = "end of tutorial";
                richTextBox2.Text = "placeholder text";
                pictureBox1.ImageLocation = "D://vstudio//website//website//images//charim.png";
                richTextBox1.Height = 165;
                pictureBox1.Width = 600;
                pictureBox1.Height = 150;
                richTextBox1.Location = new Point(4, 3);
                pictureBox1.Location = new Point(4, 174);
                richTextBox2.Location = new Point(4, 331);
                checkBox1.Hide();
                checkBox2.Hide();
                checkBox3.Hide();
                checkBox4.Hide();
                richTextBox1.Show();
                richTextBox2.Show();
                pictureBox1.Show();
                button3.Hide();
                button2.Hide();
                button1.Show();
            }

            if (panelpage == 99)
            {
                panel1.AutoScrollPosition = new Point(0, 0);
                label1.Text = "links";
                richTextBox1.Text = "example resources\n\nvisual studio";
                richTextBox2.Text = "placeholder text";
                pictureBox1.ImageLocation = "D://vstudio//website//website//images//955AFA2D-F224-4EE2-83DC-43BABE4CA648.jpg";
                richTextBox1.Height = 165;
                pictureBox1.Width = 50;
                pictureBox1.Height = 150;
                richTextBox1.Location = new Point(4, 3);
                pictureBox1.Location = new Point(4, 174);
                richTextBox2.Location = new Point(4, 331);
                checkBox1.Hide();
                checkBox2.Hide();
                checkBox3.Hide();
                checkBox4.Hide();
                richTextBox1.Show();
                richTextBox2.Hide();
                pictureBox1.Hide();
                button3.Hide();
                button2.Hide();
                button1.Hide();
            }



        }

        void uncheck(int exclude)
        {

            for (int i = 0; i < check.Length; i++)
            {
                if(i != exclude)
                {
                    check[i] = 0;
                }
            }
            if (exclude!= 0)
            {
                button3.Text = "Confirm";
            }
            checkupdate();
        }

        void checkupdate()
        {
            
            if (check[1] == 0)
            {
                checkBox1.CheckState = CheckState.Unchecked;               
            }

            if (check[2] == 0)
            {
                checkBox2.CheckState = CheckState.Unchecked;
            }

            if (check[3] == 0)
            {
                checkBox3.CheckState = CheckState.Unchecked;
            }

            if (check[4] == 0)
            {
                checkBox4.CheckState = CheckState.Unchecked;
            }
        }

        void correctcheck()
        {
            if (check[answer] == 1)
            {
                button2.Show();
                button3.Text = "correct";
            }
            else
            {
                button3.Text = "incorrect";
                uncheck(0);
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

        private void quizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelpage = 4;
            page();
        }

        private void finishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelpage = 5;
            page();
        }

        private void linksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelpage = 99;
            page();
        }






        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (check[1] == 0)
            {
                check[1] = 1;
                uncheck(1);
            }
            else
            {
                check[1] = 0;
            }
        }

        private void checkBox2_Click(object sender, EventArgs e)
        {
            if (check[2] == 0)
            {
                check[2] = 1;
                uncheck(2);
            }
            else
            {
                check[2] = 0;
            }
        }

        private void checkBox3_Click(object sender, EventArgs e)
        {
            if (check[3] == 0)
            {
                check[3] = 1;
                uncheck(3);
            }
            else
            {
                check[3] = 0;
            }
        }

        private void checkBox4_Click(object sender, EventArgs e)
        {
            if (check[4] == 0)
            {
                check[4] = 1;
                uncheck(4);
            }
            else
            {
                check[4] = 0;
            }
        }








        private void button3_Click(object sender, EventArgs e)
        {
            correctcheck();
        }

       
    }
}
