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

        public void startNewGame(object sender, EventArgs e)
        {
            //loads game screen
            this.Hide();
            gs.ShowDialog(); //using ShowDialog allows the form to be reopened if closed. use the Dispose command if you want to close.
            this.Close();
        }

        

        public void loadGame(object sender, EventArgs e)
        {
            //loads game screen
            gs.ShowDialog(); //using ShowDialog allows the form to be reopened if closed. use the Dispose command if you want to close.
        }

        private void editSettings(object sender, EventArgs e)
        {
            //loads settings screen
            this.Hide();
            set.ShowDialog();
            this.Close();
        }

        private void loadHelp(object sender, EventArgs e)
        {
            //loads help screen
            hlp.ShowDialog();
        }
    }
}
