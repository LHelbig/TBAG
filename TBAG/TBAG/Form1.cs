using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TBAG
{
    public partial class MainMenu : Form
    {
        //These names are like this because something was going wrong. Feel free to rename to something else
        GameScreen gs = new GameScreen();
        Settings set = new Settings();
        Help hlp = new Help();
        //MainMenu mm = new MainMenu();
        public MainMenu()
        {
            InitializeComponent();
        }

        private void ExitGame(object sender, EventArgs e)
        {
            //closes application
            Close();
        }

        private void startNewGame(object sender, EventArgs e)
        {
            //loads game screen
            gs.Show();
        }

        private void loadGame(object sender, EventArgs e)
        {
            //loads game screen
            gs.Show();
        }

        private void editSettings(object sender, EventArgs e)
        {
            //loads settings screen
            set.Show();
        }

        private void loadHelp(object sender, EventArgs e)
        {
            //loads help screen
            hlp.Show();
        }
    }
}
