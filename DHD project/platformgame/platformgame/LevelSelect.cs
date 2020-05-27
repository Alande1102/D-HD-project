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
        public LevelSelect()
        {
            InitializeComponent();
        }

        private void Select1(object sender, EventArgs e)
        {
            //creates a new level 1 form when you select level 1 then closes the level select form
            Level1 Level_1 = new Level1();
            Level_1.Show();
            Level_1.Location = this.Location;
            Level_1.TopMost = true;
            this.Close();
        }

        private void Select2(object sender, EventArgs e)
        {
            //creates a new level 2 form when you select level 2 then closes the level select form
            Level2 Level_2 = new Level2();
            Level_2.Show();
            Level_2.Location = this.Location;
            Level_2.TopMost = true;
            this.Close();
        }

        private void Select3(object sender, EventArgs e)
        {
            //creates a new level 3 form when you select level 3 then closes the level select form
            Level3 Level_3 = new Level3();
            Level_3.Show();
            Level_3.Location = this.Location;
            Level_3.TopMost = true;
            this.Close();
        }

        private void Select4(object sender, EventArgs e)
        {
            //creates a new level 4 form when you select level 4 then closes the level select form
            Level4 Level_4 = new Level4();
            Level_4.Show();
            Level_4.Location = this.Location;
            Level_4.TopMost = true;
            this.Close();
        }

        private void Select5(object sender, EventArgs e)
        {//creates a new level 5 form when you select level 5 then closes the level select form
            Level5 Level_5 = new Level5();
            Level_5.Show();
            Level_5.Location = this.Location;
            Level_5.TopMost = true;
            this.Close();
        }
    }
}
