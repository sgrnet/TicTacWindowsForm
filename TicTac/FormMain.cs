using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTac
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        public int player = 2;
        public int turns = 0;
        public int s1 = 0;
        public int s2 = 0;
        public int sd = 0;

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            NewGame();
        }


        private void buttonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Text == "")
            {
                if (player % 2 == 0)
                {
                    button.Text = "X";
                    player++;
                    turns++;
                }
                else
                {
                    button.Text = "O";
                    player++;
                    turns++;
                }
                if(CheckDraw()== true)
                {
                    MessageBox.Show("Tie Game!");
                    sd++;
                    NewGame();
                }
                if(CheckWinner())
                    if (button.Text == "X")
                    {
                        MessageBox.Show("X Won!");
                        s1++;
                        NewGame();
                    }
                else
                    {
                        MessageBox.Show("O Won!");
                        s2++;
                        NewGame();
                    }
            }

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            XWin.Text = "X: " + s1;
            OWin.Text = "O: " + s2;
            Draws.Text = "Draws: " + sd;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void NewGame()
        {
            player = 2;
            turns = 0;
            A00.Text = A01.Text = A02.Text = A10.Text = A11.Text = A12.Text = A20.Text = A21.Text = A22.Text = "";
            XWin.Text = "X: " + s1;
            OWin.Text = "O: " + s2;
            Draws.Text = "Draws: " + sd;
        }
        private bool CheckDraw()
        {
            if ((turns == 9)&& (CheckWinner() == false))
                return true;
            else
                return false;
        }
        private bool CheckWinner()
        {
            if ((A00.Text == A01.Text) && (A01.Text == A02.Text) && (A00.Text != "")) return true;
            else
            if ((A10.Text == A11.Text) && (A11.Text == A12.Text) && (A10.Text != "")) return true;
            else
            if ((A20.Text == A21.Text) && (A21.Text == A22.Text) && (A20.Text != "")) return true;

            if ((A00.Text == A10.Text) && (A10.Text == A20.Text) && (A00.Text != "")) return true;
            else
            if ((A01.Text == A11.Text) && (A11.Text == A21.Text) && (A01.Text != "")) return true;
            else
            if ((A02.Text == A12.Text) && (A12.Text == A22.Text) && (A02.Text != "")) return true;

            if ((A00.Text == A11.Text) && (A11.Text == A22.Text) && (A00.Text != "")) return true;
            else
            if ((A02.Text == A11.Text) && (A11.Text == A20.Text) && (A02.Text != "")) return true;
            else
                return false;




        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            s1 = s2 = sd = 0;
            NewGame();
        }
    }
}
