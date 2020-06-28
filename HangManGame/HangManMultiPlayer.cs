using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangManGame
{
    public partial class HangManMultiPlayer : Form
    {
        public string phraseEntered = " ";
        public HangManMultiPlayer()
        {
            InitializeComponent();
        }
        private void btStartGameMulti_Click(object sender, EventArgs e)
        {
            phraseEntered = txbEnterPhrase.Text;
            for (int i = 0; i < phraseEntered.Length; i++)
            {
                if (char.IsUpper(phraseEntered[i]))
                {
                    MessageBox.Show("Sorry, UpperCase Letters aren't valid.\nPlease try again.\nSorry For the inconvience.", "Hangman Game Check");
                    return;
                }
            }
            this.Hide();
            MessageBox.Show("You Word has been added!\nStart Guessing on the right!\nGood Luck to Player 2!", "Hangman Game Start");
        }
        private void txbEnterPhrase_TextChanged(object sender, EventArgs e)  { }
        private void txbEnterPhrase_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}
