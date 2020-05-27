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
    public partial class MainMenu : Form
    {


        public MainMenu()
        {
            InitializeComponent();
        }

        private void Play_Game(object sender, EventArgs e)
        {
            //creates a new level 1 form when you press play game
            Level1 Level_1 = new Level1();
            Level_1.Show();
            Level_1.Location = this.Location;
            Level_1.TopMost = true;
            this.Hide();
        }

        private void Continue_Game(object sender, EventArgs e)
        {
            //creates a new level selection form when you pless select level
            LevelSelect select = new LevelSelect();
            select.Show();
            select.Location = this.Location;
            select.TopMost = true;
            this.Hide();
        }

        private void Exit_Game(object sender, EventArgs e)
        {
            //closes the form when you press exit
            this.Close();
        }
    }
}
