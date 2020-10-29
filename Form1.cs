using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radiobutton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                MessageBox.Show("You have selected " + radioButton1.Text);
            }
            else if (radioButton2.Checked == true)
            {
                MessageBox.Show("You have selected " + radioButton2.Text);
            }
            else if (radioButton3.Checked == true)
            {
                MessageBox.Show("You have selected " + radioButton3.Text);
            }
            else
                MessageBox.Show("Please Select Country");
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                //MessageBox.Show("You have selected " + radioButton4.Text);
                groupBox1.BackColor = Color.Red;
            }
            else if (radioButton5.Checked == true)
            {
               // MessageBox.Show("You have selected " + radioButton5.Text);
                groupBox1.BackColor = Color.Green;
            }
            else if (radioButton6.Checked == true)
            {
               // MessageBox.Show("You have selected " + radioButton6.Text);
                groupBox1.BackColor = Color.Blue;
            }
            else
                MessageBox.Show("Please Select Color");
        }

        private void btnBackground_Click(object sender, EventArgs e)
        {
            if (radioButton7.Checked == true)
            {
                //MessageBox.Show("You have selected " + radioButton7.Text);
                this.BackColor = System.Drawing.Color.Purple;
            }
            else if (radioButton8.Checked == true)
            {
                //MessageBox.Show("You have selected " + radioButton8.Text);
                this.BackColor = System.Drawing.Color.Yellow;
            }
            else if (radioButton9.Checked == true)
            {
                //MessageBox.Show("You have selected " + radioButton9.Text);
                this.BackColor = System.Drawing.Color.Orange;
            }
            else
                MessageBox.Show("Please Select Color");
        }
    }
    }

