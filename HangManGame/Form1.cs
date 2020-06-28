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
    public partial class Form1 : Form
    {
        public string[] wordsList;
        string word2Guess = "";
        int lengthOfGuessWord = 0;
        int numberOfLives = 6;
        Pen myPen = new Pen(Color.Black);
        Pen redPen = new Pen(Color.Red);
        string multiplayerWord2Guess = " ";
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Welcome to Hangman!\nPlease Enter the Amount of Players You Would Like to Play with below.\nHave Fun!", "Hangman Game");
            btGuess.Enabled = false;
            btRestart.Enabled = false;
            txbLettersGuessed.Enabled = false;
            txbPhrase.Enabled = false;
            txbLetterEntered.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)  {  }
        private void btRestart_Click(object sender, EventArgs e)
        {
            numberOfLives = 6;
            if (MessageBox.Show("Are you sure you want to proceed?\nAll Your Progress Will be lost!", "HangMan Game Change Phrase?", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                txbLettersGuessed.Clear();
                txbLetterEntered.Clear();
                txbPhrase.Clear();
                pnHangmanBox.Refresh();
                int randomNumber = 0;
                txbPhrase.Text = "";
                Random wordsListgenerator = new Random();
                wordsList = new string[10] { "hangman", "csharpgame", "treetop", "minecraft", "television", "computer", "keyboard", "mouse", "jeb", "vince" };
                randomNumber = wordsListgenerator.Next(0, 9);
                word2Guess = wordsList[randomNumber];
                MessageBox.Show("Your new random word has been created!\nStart Guessing on the Right. =>", "Hangman Game New Word");
                lengthOfGuessWord = word2Guess.Length;
                for (int i = 0; i < lengthOfGuessWord; i++)
                {
                    txbPhrase.Text = txbPhrase.Text + "?";
                }                
            }           
        }
        private void btSinglePlayer_Click(object sender, EventArgs e)
        {
            numberOfLives = 6;
            int randomNumber = 0;
            txbPhrase.Text = "";
            Random wordsListgenerator = new Random();
            wordsList = new string[10] { "hangman", "csharpgame", "treetop", "minecraft", "television", "computer", "keyboard", "mouse", "jeb", "vince" };
            randomNumber = wordsListgenerator.Next(0, 9);
            word2Guess =  wordsList[randomNumber];
            MessageBox.Show("Your random word has been created!\nStart Guessing on the Right. =>", "Hangman Game Start");
            lengthOfGuessWord = word2Guess.Length;
            for(int i = 0; i < lengthOfGuessWord; i++)
            {
                txbPhrase.Text = txbPhrase.Text + "?";
            }
            btSinglePlayer.Enabled = false;
            btMultiPlayer.Enabled = false;
            btGuess.Enabled = true;
            btRestart.Enabled = true;
            txbLetterEntered.Enabled = true;
        }
        private void pnHangmanBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics hanger = e.Graphics;
            myPen.Width = 3;
            hanger.DrawLine(myPen, 76, 15, 76, 40);
            hanger.DrawLine(myPen, 76, 15, 260, 15);
            hanger.DrawLine(myPen, 260, 15, 260, 260);
            hanger.DrawLine(myPen, 200, 260, 320, 260);
            if(numberOfLives < 6)
            {//Head
                Graphics g = e.Graphics;
                myPen.Width = 4;
                g.DrawEllipse(myPen, 40, 40, 76, 76);
            }
            if (numberOfLives < 5)
            {//body
                int x1 = 78;
                int y1 = 116;
                int x2 = 78;
                int y2 = 196;
                Graphics l = e.Graphics;
                myPen.Width = 5;
                l.DrawLine(myPen, x1, y1, x2, y2);
            }
            if(numberOfLives < 4)
            {//arm left
                Graphics j = e.Graphics;
                myPen.Width = 5;
                j.DrawLine(myPen, 78, 131, 28, 176);
            }
            if (numberOfLives < 3)
            {//arm right
                Graphics i = e.Graphics;
                myPen.Width = 5;
                i.DrawLine(myPen, 78, 131, 128, 176);
            }
            if (numberOfLives < 2)
            {//leg left
                Graphics k = e.Graphics;
                myPen.Width = 5;
                k.DrawLine(myPen, 78, 196, 43, 241);
            }
            if (numberOfLives < 1)
            {//leg right
                Graphics q = e.Graphics;
                myPen.Width = 5;
                q.DrawLine(myPen, 78, 196, 113, 241);
                redPen.Width = 15;
                q.DrawLine(redPen, 30, 50, 135, 230);
                q.DrawLine(redPen, 135, 50, 30, 230);
            }
        }
        private void txbLetterEntered_TextChanged(object sender, EventArgs e)  {  }
        private void btGuess_Click(object sender, EventArgs e)
        {
            string phrase = txbPhrase.Text;
                char letterpicked = ' ';
                string s = " ";
                string t = " ";
                s = txbLetterEntered.Text;
                t = txbLetterEntered.Text;
                try
                {
                    letterpicked = char.Parse(s);
                }
            catch (FormatException)
                {
                    MessageBox.Show("Invaild Input " + s, "Check");
                    txbLetterEntered.Clear();
                    return;
                }
                if (char.IsUpper(letterpicked))
                {
                    MessageBox.Show("UpperCase Letters will not be accepted.\nPlease try the letter in a LowerCase form.\nSorry For the Inconvience.", "Hangman Game Check");
                    return;
                }
                txbLettersGuessed.Text = txbLettersGuessed.Text + t + ", ";
                txbLetterEntered.Text = "";
                string str = txbPhrase.Text;
                string isCorrect = txbPhrase.Text;
                for (int i = 0; i < word2Guess.Length; i++)
                {
                     if (word2Guess[i] == letterpicked)
                     {
                        char phraseFixer = txbPhrase.Text[i]; 
                        int pos = i;
                        char replacement = letterpicked;
                        
                        StringBuilder sb = new StringBuilder(str);
                        sb[pos] = replacement;
                        str = sb.ToString();
                        txbPhrase.Text = str;
                     }
                }                
                    if (word2Guess == txbPhrase.Text)
                    {
                        MessageBox.Show("Congradulations!!!\nYou Have Won!!!\nClick Play Again to Start A New Game", "HangMan Game Win");
                        btRestart.Enabled = false;
                        btGuess.Enabled = false;
                    }
                    if(txbPhrase.Text == isCorrect)
                    {
                        numberOfLives = numberOfLives - 1;
                        MessageBox.Show("Whoops! That was Incorrect.\nKeep guessing before you get hung", "Hangman Wrong Guess");
                        pnHangmanBox.Invalidate();
                    }
                    if(numberOfLives == 0)
                    {
                        MessageBox.Show(String.Format("Oh No! You got hung!\nGame Over.\nClick Below to Play Again"), "Hangman Game Lost");
                        MessageBox.Show(word2Guess, "Correct Phrase");
                        btGuess.Enabled = false;
                        btRestart.Enabled = false;
                    }
        }
        private void btPlayAgain_Click(object sender, EventArgs e)
        {
            numberOfLives = 6;
            if (MessageBox.Show("Are you sure you want to proceed?\nAll Your Existing Progress Will be lost!", "HangMan Game New Game?", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                txbLettersGuessed.Clear();
                txbLetterEntered.Clear();
                txbPhrase.Clear();
                pnHangmanBox.Refresh();
                MessageBox.Show("Welcome to Hangman!\nPlease Enter the Amount of Players You Would Like to Play with below.", "Hangman Game New Game");
                btSinglePlayer.Enabled = true;
                btMultiPlayer.Enabled = true;
                btGuess.Enabled = false;
                btRestart.Enabled = false;
                txbLetterEntered.Enabled = false;
            }
        }
        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btMultiPlayer_Click(object sender, EventArgs e)
        {
            numberOfLives = 6;
            HangManMultiPlayer form2 = new HangManMultiPlayer();
            form2.ShowDialog();
            multiplayerWord2Guess = form2.phraseEntered;
            btSinglePlayer.Enabled = false;
            btMultiPlayer.Enabled = false;
            btGuess.Enabled = true;
            txbLetterEntered.Enabled = true;
            for (int i = 0; i < multiplayerWord2Guess.Length; i++)
            {
                txbPhrase.Text = txbPhrase.Text + "?";
            }
            word2Guess = multiplayerWord2Guess;
        }
        private void label5_Click(object sender, EventArgs e) {        }
    }
}
