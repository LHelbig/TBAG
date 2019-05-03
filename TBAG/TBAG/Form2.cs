using System;
using System.Collections;
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
        String[]screenOut = new String[100];
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
            roomA = new Room("R_A");
            roomB = new Room("R_B");
            roomC = new Room("R_C");
            roomD = new Room("R_D");

            thePlayer.setLocation(roomA);
            roomA.setAdjacent(null, roomC, roomB, null);
            roomB.setAdjacent(null, roomD, null, roomA);
            roomC.setAdjacent(roomA, null, roomD, null);
            roomD.setAdjacent(roomB, null, null, roomC);


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
            thePlayer.parseCommand(command).CopyTo(screenOut, 0);
            textBoxText[currentIndex] = "\r\n > " + command;
            currentIndex++;

            for (int i = 0; i < screenOut.Length; i++)
            {
                try
                {
                    storyText.AppendText(screenOut[i]);
                    textBoxText[currentIndex] = "\r\n " + screenOut[i];
                    currentIndex++;
                    //storyText.Text = string.Join(" ", textBoxText);
                    //inputBox.ResetText();
                }
                catch (NullReferenceException n)
                {
                    break;
                }

            }

            storyText.Text = string.Join(" ", textBoxText);
            inputBox.ResetText();
            for (int i = 0; i < screenOut.Length; i++)
            {
                screenOut[i] = null;

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void inputBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
