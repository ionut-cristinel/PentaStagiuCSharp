using System;
using System.Windows.Forms;

namespace GuessTheNumberWF
{
    public partial class MainForm : Form
    {
        // proprietatea randomNumber va retine numarul generat aleator
        private int randomNumber;

        public MainForm()
        {
            InitializeComponent();

            // aplicatia va porni cu butonul de restart game ne afisat
            restart.Hide();

            // se seteaza valoarea proprietatii randomNumber
            SetRandomNumber();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            // daca numarul de incercari din jocul curent este altul decat 1, adica nu este ultima incercare de a ghici nr
            if (counter.Text != "1")
            {
                // daca numarul este ghicit este apelata metoda YouWon(), altfel Play()
                if (this.randomNumber == int.Parse(userNumber.Text))
                    this.YouWon();
                else
                    this.Play();
            }
            else
            {
                // daca este ultima incercare si numarul este ghicit se apeleaza metoda YouWon() altfel YouLose()
                if (this.randomNumber == int.Parse(userNumber.Text))
                    this.YouWon();
                else
                    this.YouLose();
            }
        }

        // set de instructiuni care se folosesc atunci cand este apasat butonul restart
        private void restart_Click(object sender, EventArgs e)
        {
            // se ascunde butonul pentru restart
            restart.Hide();
            // este afisat butonul pentru verificarea numarului
            btnCheck.Show();
            // este golit de continut label-lul care afiseaza istoricul cu numere incercate de user pt jocul curent
            triedNumbers.Text = null;
            // este resetat numarul de incercari pe care userul le are la dispozitie pt a ghici numarul
            counter.Text = "5";
            // se genereaza un nou numar aleator
            SetRandomNumber();
            status.Text = "Enter a number between 1 and 100.";
        }

        // set de instructiuni care sunt executate atunci cand numarul nu este ghicit
        private void Play()
        {
            if (this.randomNumber > int.Parse(userNumber.Text))
                status.Text = "The number is too small.";
            else
                status.Text = "The number is too big.";
            int numar = int.Parse(counter.Text);
            --numar;
            counter.Text = Convert.ToString(numar);
            triedNumbers.Text += userNumber.Text + ", ";
            userNumber.Text = null;
        }

        // set de instructiuni care sunt executate atunci cand numarul este ghicit
        private void YouWon()
        {
            status.Text = "You guessed the number, that's " + this.randomNumber + ".";
            btnCheck.Hide();
            restart.Show();
            int numar = int.Parse(youScore.Text);
            ++numar;
            youScore.Text = Convert.ToString(numar);
        }

        // set de instructiuni care sunt executate atunci cand numarul de incercari pt a ghici numarul este epuizat
        private void YouLose()
        {
            triedNumbers.Text = "You lost the game, the number was " + this.randomNumber + ".";
            btnCheck.Hide();
            restart.Show();
            counter.Text = "0";
            int numar = int.Parse(opponentScore.Text);
            ++numar;
            opponentScore.Text = Convert.ToString(numar);
            userNumber.Text = null;
        }

        // metoda care seteaza ca valoare un numar aleator proprietatii randomNumber
        private void SetRandomNumber()
        {
            Random numar = new Random();
            this.randomNumber = numar.Next(1, 100);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
