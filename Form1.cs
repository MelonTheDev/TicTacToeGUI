using System;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public int x; //defines the x variable
        public int y;
        public int playercount = 1; //shows, wich players turn is it
        private int spacecounter = 0; //counts the empty fields
        private char symb = 'X'; //X is standard
        public char[][] field = { 
            new char[] { ' ', ' ', ' ' },
            new char[] { ' ', ' ', ' ' },
            new char[] { ' ', ' ', ' ' }
        };
        public Form1()
        {
            InitializeComponent();
        }
        private void exitmenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void optionsmenu_Click(object sender, EventArgs e)
        {
            options options = new options();
            options.Show();
        }
        private void Button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            infotext.Text = "Player " + playercount + " ist am Zug mit Symbol " + symb;
            b.Text = symb.ToString();
            b.Enabled = false;
            x = int.Parse(b.Name.Split("_")[1]);
            y = int.Parse(b.Name.Split("_")[2]);
            field[x][y] = symb;
            WinnerSelector();
            Nextplayer();
        }
        public void WinnerSelector()
        {
            spacecounter++;
            if (spacecounter == 9)//if there is no empty field anymore
            {
                infotext.Text = "Es ist kein weiterer Zug möglich!";
                winnerausgabe.Text = "Winner: Tie";
                playagain.Visible = true;
            }
            for (int y = 0; y < field.Length; y++)
            {
                int row = 0;
                for (int i = 0; i < field[y].Length; i++)
                {
                    if (field[y][i] == symb)
                    {
                        row++;
                    }
                }
                int column = 0;
                for (int i = 0; i < field[y].Length; i++)
                {
                    if (field[i][y] == symb)
                    {
                        column++;
                    }
                }
                if (column == 3 || row == 3) //if 3 similar symbols in a row or column
                {
                    SetWinner();
                }
            }
            //diagonal
            if ((field[0][0] == symb && field[1][1] == symb && field[2][2] == symb) || (field[2][0] == symb && field[1][1] == symb && field[0][2] == symb))
            {
                SetWinner();
            }          
        }
        public void Nextplayer()
        {
            switch (playercount)
            {
                case 1:
                    playercount++;
                    symb = 'O';
                    break;
                case 2:
                    playercount--;
                    symb = 'X';
                    break;
            }
        }
        private void Newgame(object sender, EventArgs e)
        {
            for(int i = 0; i < field.Length; i++)
            {
                for(int y = 0; y < field[i].Length; y++)
                {
                    field[i][y] = ' ';
                }
            }
            foreach (Control c in fieldbox.Controls)
            {
                c.Enabled = true;
                c.Text = "";
            }
            winnerausgabe.Text = "";
            playagain.Visible = false;
            spacecounter = 0;
            Nextplayer();
        }
        public void SetWinner()
        {
            winnerausgabe.Text = "Winner: Player " + playercount;
            playagain.Visible = true;
        }
    }
}