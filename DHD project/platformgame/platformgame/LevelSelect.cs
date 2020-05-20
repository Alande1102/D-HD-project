using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace platformgame
{
    public partial class LevelSelect : Form
    {
        Level1 Level_1 = new Level1();
        Level2 Level_2 = new Level2();
        public LevelSelect()
        {
            InitializeComponent();
        }

        private void Select1(object sender, EventArgs e)
        {
            Level_1.Show();
            Level_1.Location = this.Location;
            Level_1.TopMost = true;
            this.Hide();
        }

        private void Select2(object sender, EventArgs e)
        {
            Level_2.Show();
            Level_2.Location = this.Location;
            Level_2.TopMost = true;
            this.Hide();
        }

        private void Select3(object sender, EventArgs e)
        {
            //Level 3
        }

        private void Select4(object sender, EventArgs e)
        {
            //Level 4
        }

        private void Select5(object sender, EventArgs e)
        {
            //Level 5
        }
    }
}
