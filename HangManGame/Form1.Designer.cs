namespace HangManGame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnHangmanBox = new System.Windows.Forms.Panel();
            this.btSinglePlayer = new System.Windows.Forms.Button();
            this.btMultiPlayer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbLetterEntered = new System.Windows.Forms.TextBox();
            this.txbPhrase = new System.Windows.Forms.TextBox();
            this.btGuess = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txbLettersGuessed = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btRestart = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.btPlayAgain = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnHangmanBox
            // 
            this.pnHangmanBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnHangmanBox.Location = new System.Drawing.Point(4, 171);
            this.pnHangmanBox.Name = "pnHangmanBox";
            this.pnHangmanBox.Size = new System.Drawing.Size(338, 278);
            this.pnHangmanBox.TabIndex = 0;
            this.pnHangmanBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pnHangmanBox_Paint);
            // 
            // btSinglePlayer
            // 
            this.btSinglePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSinglePlayer.Location = new System.Drawing.Point(13, 53);
            this.btSinglePlayer.Name = "btSinglePlayer";
            this.btSinglePlayer.Size = new System.Drawing.Size(123, 73);
            this.btSinglePlayer.TabIndex = 1;
            this.btSinglePlayer.Text = "Single Player";
            this.btSinglePlayer.UseVisualStyleBackColor = true;
            this.btSinglePlayer.Click += new System.EventHandler(this.btSinglePlayer_Click);
            // 
            // btMultiPlayer
            // 
            this.btMultiPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMultiPlayer.Location = new System.Drawing.Point(142, 53);
            this.btMultiPlayer.Name = "btMultiPlayer";
            this.btMultiPlayer.Size = new System.Drawing.Size(123, 73);
            this.btMultiPlayer.TabIndex = 2;
            this.btMultiPlayer.Text = "Multi- Player";
            this.btMultiPlayer.UseVisualStyleBackColor = true;
            this.btMultiPlayer.Click += new System.EventHandler(this.btMultiPlayer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Your Game Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(294, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pick a Letter:";
            // 
            // txbLetterEntered
            // 
            this.txbLetterEntered.Location = new System.Drawing.Point(450, 27);
            this.txbLetterEntered.Name = "txbLetterEntered";
            this.txbLetterEntered.Size = new System.Drawing.Size(254, 20);
            this.txbLetterEntered.TabIndex = 5;
            this.txbLetterEntered.TextChanged += new System.EventHandler(this.txbLetterEntered_TextChanged);
            // 
            // txbPhrase
            // 
            this.txbPhrase.Location = new System.Drawing.Point(450, 106);
            this.txbPhrase.Name = "txbPhrase";
            this.txbPhrase.Size = new System.Drawing.Size(338, 20);
            this.txbPhrase.TabIndex = 6;
            // 
            // btGuess
            // 
            this.btGuess.Location = new System.Drawing.Point(710, 9);
            this.btGuess.Name = "btGuess";
            this.btGuess.Size = new System.Drawing.Size(82, 62);
            this.btGuess.TabIndex = 7;
            this.btGuess.Text = "Check";
            this.btGuess.UseVisualStyleBackColor = true;
            this.btGuess.Click += new System.EventHandler(this.btGuess_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(294, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sentence:";
            // 
            // txbLettersGuessed
            // 
            this.txbLettersGuessed.Location = new System.Drawing.Point(448, 150);
            this.txbLettersGuessed.Name = "txbLettersGuessed";
            this.txbLettersGuessed.Size = new System.Drawing.Size(339, 20);
            this.txbLettersGuessed.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(294, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Letters Guessed:";
            // 
            // btRestart
            // 
            this.btRestart.Location = new System.Drawing.Point(579, 260);
            this.btRestart.Name = "btRestart";
            this.btRestart.Size = new System.Drawing.Size(208, 86);
            this.btRestart.TabIndex = 11;
            this.btRestart.Text = "Change Phrase (Single Player Only)";
            this.btRestart.UseVisualStyleBackColor = true;
            this.btRestart.Click += new System.EventHandler(this.btRestart_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(591, 352);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(196, 86);
            this.btExit.TabIndex = 12;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btPlayAgain
            // 
            this.btPlayAgain.Location = new System.Drawing.Point(357, 332);
            this.btPlayAgain.Name = "btPlayAgain";
            this.btPlayAgain.Size = new System.Drawing.Size(208, 106);
            this.btPlayAgain.TabIndex = 13;
            this.btPlayAgain.Text = "Play Again";
            this.btPlayAgain.UseVisualStyleBackColor = true;
            this.btPlayAgain.Click += new System.EventHandler(this.btPlayAgain_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(490, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Only Use Lower Case Letters!";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btPlayAgain);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btRestart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbLettersGuessed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btGuess);
            this.Controls.Add(this.txbPhrase);
            this.Controls.Add(this.txbLetterEntered);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btMultiPlayer);
            this.Controls.Add(this.btSinglePlayer);
            this.Controls.Add(this.pnHangmanBox);
            this.Name = "Form1";
            this.Text = "Hangman Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnHangmanBox;
        private System.Windows.Forms.Button btSinglePlayer;
        private System.Windows.Forms.Button btMultiPlayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbLetterEntered;
        private System.Windows.Forms.TextBox txbPhrase;
        private System.Windows.Forms.Button btGuess;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbLettersGuessed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btRestart;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btPlayAgain;
        private System.Windows.Forms.Label label5;
    }
}

