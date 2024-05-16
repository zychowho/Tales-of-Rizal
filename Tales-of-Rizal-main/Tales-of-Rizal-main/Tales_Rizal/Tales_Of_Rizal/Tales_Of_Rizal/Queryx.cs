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
    public partial class Queryx : Form
    {
        public Queryx()
        {
            InitializeComponent();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }

        private void Queryx_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CharX charX = new CharX();
            charX.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            ChapterX chapterX = new ChapterX();
            chapterX.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
