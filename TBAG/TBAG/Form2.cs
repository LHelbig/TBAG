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
        //AdventureOne a1;
        //AdventureTwo a2;
        //AdventureThree a3;
        LoadGame lg;
        Player thePlayer;
        Room roomA;
        Room roomB;
        Room roomC;
        Room roomD;


        //theRoom.setNorth(roomA);

        public GameScreen()
        {
            InitializeComponent();
            //a1 = new AdventureOne();
            //a2 = new AdventureTwo();
            //a3 = new AdventureThree();
            lg = new LoadGame();
            thePlayer = new Player();
            roomA = new Room();
            roomB = new Room();
            roomC = new Room();
            roomD = new Room();

            roomA.setAdjacent(null, null, null, roomD);


           /* if (a1.getCurrent() == true)
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
            }*/
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
        

        public void userInputted(object sender, EventArgs e)
        {
          
            storyText.SelectionLength = storyText.Text.Length + 1;
            string command = inputBox.Text;
            thePlayer.parseCommand(command);
       
            textBoxText[currentIndex] = "\r\n > " + command;
            currentIndex++;
            storyText.Text = string.Join(" ", textBoxText);
            inputBox.ResetText();

            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void inputBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
