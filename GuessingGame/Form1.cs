namespace GuessingGame
{
    public partial class Form1 : Form
    {
        private int _setNumber = 0;
        public Form1()
        {
            InitializeComponent();
            Random rnd = new Random();
            _setNumber = rnd.Next(10);
        }
        
        private void Check_Click(object sender, EventArgs e)
        {
            try
            {
                int GuessResult = Int32.Parse(Guess.Text);
                if (GuessResult == _setNumber)
                {
                    Answer.Text = "YAY";
                }
                else
                {
                    Answer.Text = "BOO";
                }
            }
            catch
            {
                Answer.Text = "Not a number";
            }

        }

    }
}
