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
    public partial class GameScreen : Form
    {
        public int adventureNumber;
        static string[] textBoxText = new string[500];
        static string[] clues = new string[10];
        int currentIndex = 0;
        public int clueNumber;
        AdventureOne a1;
        AdventureTwo a2;
        AdventureThree a3;
        LoadGame lg = new LoadGame();

        public GameScreen()
        {
            InitializeComponent();
            if(a1.getCurrent() == true)
            {
                currentIndex = a1.load(textBoxText, clues);
                textBoxText[currentIndex] = "Adventure One Loaded\r\n";
                storyText.Text = string.Join(" ", textBoxText);
                currentIndex++;
            }
            else if(a2.getCurrent() == true)
            {
                currentIndex = a2.load(textBoxText, clues);
                textBoxText[currentIndex] = "Adventure Two Loaded\r\n";
                storyText.Text = string.Join(" ", textBoxText);
                currentIndex++;
            }
            else if(a3.getCurrent() == true)
            {
                currentIndex = a3.load(textBoxText, clues);
                textBoxText[currentIndex] = "Adventure Three Loaded\r\n";
                storyText.Text = string.Join(" ", textBoxText);
                currentIndex++;
            }
            textBoxText[currentIndex] = "Please enter some text:";
            storyText.Text = string.Join(" ", textBoxText);
            currentIndex++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mm = new TBAG.MainMenu();
            mm.ShowDialog();
            this.Close();
        }
        

        private void userInputted(object sender, EventArgs e)
        {
            storyText.SelectionLength = storyText.Text.Length + 1;
            string input = inputBox.Text;
            textBoxText[currentIndex] = "\r\n > " + input;
            currentIndex++;
            storyText.Text = string.Join(" ", textBoxText);
            inputBox.ResetText();
        }

    }
}
