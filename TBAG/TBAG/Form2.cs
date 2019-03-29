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
        public GameScreen()
        {
            InitializeComponent();
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
            storyText.Text.Insert(storyText.SelectionLength, "\n > " + input);
            
            inputBox.ResetText();
        }
    }
}
