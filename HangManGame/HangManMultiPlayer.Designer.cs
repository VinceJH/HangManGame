namespace HangManGame
{
    partial class HangManMultiPlayer
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbEnterPhrase = new System.Windows.Forms.TextBox();
            this.btStartGameMulti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please Enter your Phrase Below:";
            // 
            // txbEnterPhrase
            // 
            this.txbEnterPhrase.Location = new System.Drawing.Point(15, 44);
            this.txbEnterPhrase.Name = "txbEnterPhrase";
            this.txbEnterPhrase.Size = new System.Drawing.Size(259, 20);
            this.txbEnterPhrase.TabIndex = 1;
            this.txbEnterPhrase.TextChanged += new System.EventHandler(this.txbEnterPhrase_TextChanged);
            this.txbEnterPhrase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbEnterPhrase_KeyPress);
            // 
            // btStartGameMulti
            // 
            this.btStartGameMulti.Location = new System.Drawing.Point(15, 83);
            this.btStartGameMulti.Name = "btStartGameMulti";
            this.btStartGameMulti.Size = new System.Drawing.Size(254, 71);
            this.btStartGameMulti.TabIndex = 2;
            this.btStartGameMulti.Text = "Start Game";
            this.btStartGameMulti.UseVisualStyleBackColor = true;
            this.btStartGameMulti.Click += new System.EventHandler(this.btStartGameMulti_Click);
            // 
            // HangManMultiPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 174);
            this.Controls.Add(this.btStartGameMulti);
            this.Controls.Add(this.txbEnterPhrase);
            this.Controls.Add(this.label1);
            this.Name = "HangManMultiPlayer";
            this.Text = "HangManMultiPlayer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbEnterPhrase;
        private System.Windows.Forms.Button btStartGameMulti;
    }
}