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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mm = new MainMenu();
            mm.ShowDialog();
            this.Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            float fontSize = (float)numericUpDown1.Value;
            label1.Font = new Font(label1.Font.FontFamily, fontSize, label1.Font.Style);
            soundCheckBox.Font = new Font(soundCheckBox.Font.FontFamily, fontSize, label1.Font.Style);
            checkBox2.Font = new Font(checkBox2.Font.FontFamily, fontSize, label1.Font.Style);
        }

    }
}
