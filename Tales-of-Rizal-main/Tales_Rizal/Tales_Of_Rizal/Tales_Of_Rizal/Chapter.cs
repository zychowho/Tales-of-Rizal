using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tales_Of_Rizal
{
    public partial class Chapter : Form
    {
        public Chapter()
        {
            InitializeComponent();

            comboBox1.Items.Add("Chapter 1");
            comboBox1.Items.Add("Chapter 2");
            comboBox1.Items.Add("Chapter 3");

        }
        int count = 0;

        private void HomeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (count < 64) {
                count++;
            }
            label3.Text = (count + 1).ToString();
            pictureBox2.Image = imageList1.Images[count];
        }

        
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (count > 0)
            {
                count--;
            }
            label3.Text = (count + 1).ToString();
            pictureBox2.Image = imageList1.Images[count];
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = comboBox1.SelectedIndex;
            if (selectedIndex >= 0) // Check if a valid item is selected
            {
                switch (selectedIndex)
                {
                    case 0:
                        string path = @"C:\Users\63915\Documents\GitHub\Tales-of-Rizal\Tales-of-Rizal-main\Tales-of-Rizal-main\Tales_Rizal\Tales_Of_Rizal\Tales_Of_Rizal\nolichapters\chapter1.txt";
                        // Perform actions specific to "Item 1" selection
                        break;
                    case 1:
                        // Perform actions specific to "Item 2" selection
                        // ...
                        break;
                    case 2:
                        // Perform actions specific to "Item 3" selection
                        // ...
                        break;
                    default:
                        // Handle unexpected selection (optional)
                        break;
                }
            }
        }

        private void Chapter_Load(object sender, EventArgs e)
        {

        }
    }
}
