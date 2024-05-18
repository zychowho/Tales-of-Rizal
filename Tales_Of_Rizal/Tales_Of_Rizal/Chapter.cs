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

namespace Tales_Of_Rizal
{
    public partial class Chapter : Form
    {
        public Chapter()
        {
            InitializeComponent();

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
                        string imagePath1 = @"C:\Users\Samricseilyn\OneDrive\Desktop\Tales-of-Rizal-main\Tales-of-Rizal-main\Tales-of-Rizal-main\Tales-of-Rizal-main\Tales_Rizal\Tales_Of_Rizal\Tales_Of_Rizal\nolipics\N1.jpg";
                        string path1 = @"C:\Users\Samricseilyn\OneDrive\Desktop\Tales-of-Rizal-main\Tales-of-Rizal-main\Tales-of-Rizal-main\Tales-of-Rizal-main\Tales_Rizal\Tales_Of_Rizal\Tales_Of_Rizal\nolichapters\N1.txt";
                        var str1 = File.ReadAllText(path1);
                        richTextBox1.Text = str1;
                        Image image1 = Image.FromFile(imagePath1);
                        pictureBox2.Image = image1;
                        label3.Text = "1";
                        // Perform actions specific to "Item 1" selection
                        break;
                    case 1:
                        string imagePath2 = @"C:\Users\Samricseilyn\OneDrive\Desktop\Tales-of-Rizal-main\Tales-of-Rizal-main\Tales-of-Rizal-main\Tales-of-Rizal-main\Tales_Rizal\Tales_Of_Rizal\Tales_Of_Rizal\nolipics\N2.jpg";
                        string path2 = @"C:\Users\Samricseilyn\OneDrive\Desktop\Tales-of-Rizal-main\Tales-of-Rizal-main\Tales-of-Rizal-main\Tales-of-Rizal-main\Tales_Rizal\Tales_Of_Rizal\Tales_Of_Rizal\nolichapters\N2.txt";
                        var str2 = File.ReadAllText(path2);
                        richTextBox1.Text = str2;
                        Image image2 = Image.FromFile(imagePath2);
                        pictureBox2.Image = image2;
                        label3.Text = "2";
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
