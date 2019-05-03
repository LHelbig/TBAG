using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace TBAG
{
    public partial class MainMenu : Form
    {
        static System.IO.Stream menuMusic = Properties.Resources.xenoblade_music;
        System.Media.SoundPlayer s_player = new System.Media.SoundPlayer(menuMusic);
        
        //private AdventureInformation adventure = AdventureInformation.Instance();

        //These names are like this because something was going wrong. Feel free to rename to something else
        GameScreen gs = new GameScreen();
        Settings set = new Settings();
        //alertForm af = new alertForm();
        Help hlp = new Help();
        //MainMenu mm = new MainMenu();
        public MainMenu()
        {
            InitializeComponent();
           // adventure.Load();
        }

        private void ExitGame(object sender, EventArgs e)
        {
            //closes application
            /*adventure.setCurrent("one", false);
            adventure.setCurrent("two", false);
            adventure.setCurrent("three", false);
            adventure.Save();*/
            Close();
        }

        public void startNewGame(object sender, EventArgs e)
        {
            //loads game screen
            /*if (!adventure.getFull("one"))
                adventure.setCurrent("one", true);
            else if (!adventure.getFull("two"))
                adventure.setCurrent("two", true);
            else if (!adventure.getFull("three"))
                adventure.setCurrent("three", true);
            else
            {
                bool found = false;
                while (!found)
                {
                    if (!adventure.getReset("one"))
                    {
                        adventure.resetAdventure("one");
                        found = true;
                    }
                    else if (!adventure.getReset("two"))
                    {
                        adventure.resetAdventure("two");
                        found = true;
                    }
                    else if (!adventure.getReset("three"))
                    {
                        adventure.resetAdventure("three");
                        found = true;
                    }
                    else
                    {
                        adventure.setReset("one", false);
                        adventure.setReset("two", false);
                        adventure.setReset("three", false);
                    }
                }
            }
            adventure.Save();*/
            this.Hide();
            gs.ShowDialog(); //using ShowDialog allows the form to be reopened if closed. use the Dispose command if you want to close.
            this.Close();
        }

        

        public void loadGame(object sender, EventArgs e)
        {
            //loads game screen
            this.Hide();
            gs.ShowDialog();
            this.Close();//using ShowDialog allows the form to be reopened if closed. use the Dispose command if you want to close.
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
            this.Hide();
            hlp.ShowDialog();
            this.Close();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            
            //s_player.Play();
        }
    }
}
