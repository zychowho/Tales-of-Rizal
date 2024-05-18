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
    public partial class Chapterr : Form
    {
        public Chapterr()
        {
            InitializeComponent();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Queryx queryx = new Queryx();
            queryx.Show();
        }

        private void HomeButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Queryx queryx = new Queryx();
            queryx.Show();
        }
    }
}
