namespace GuessingGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Answer = new TextBox();
            CheckButton = new Button();
            Guess = new TextBox();
            SuspendLayout();
            // 
            // Answer
            // 
            Answer.Enabled = false;
            Answer.Location = new Point(142, 41);
            Answer.Multiline = true;
            Answer.Name = "Answer";
            Answer.Size = new Size(108, 37);
            Answer.TabIndex = 0;
            Answer.Text = "Guess a number between 0 and 10";
            // 
            // CheckButton
            // 
            CheckButton.BackColor = SystemColors.Control;
            CheckButton.Location = new Point(12, 41);
            CheckButton.Name = "CheckButton";
            CheckButton.Size = new Size(108, 66);
            CheckButton.TabIndex = 1;
            CheckButton.Text = "Check Guess";
            CheckButton.UseVisualStyleBackColor = false;
            CheckButton.Click += Check_Click;
            // 
            // Guess
            // 
            Guess.BackColor = Color.White;
            Guess.Location = new Point(12, 12);
            Guess.Name = "Guess";
            Guess.Size = new Size(108, 23);
            Guess.TabIndex = 2;
            Guess.Text = "-";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(263, 141);
            Controls.Add(Guess);
            Controls.Add(CheckButton);
            Controls.Add(Answer);
            Name = "Form1";
            Text = "Guessing Game!";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Answer;
        private Button CheckButton;
        private TextBox Guess;
    }
}
