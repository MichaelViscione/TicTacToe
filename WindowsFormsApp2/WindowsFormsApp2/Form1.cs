using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class TicTacToe : Form
    {
        private bool turn = true; //true = X's turn and false = O's turn
        private bool xScenario1;
        private int turnCount = 1, row, col;
        private Button prevButton;
        private Button[,] Board;

        public TicTacToe()
        {
            InitializeComponent();
            Board = new Button[3, 3] { { A0, A1, A2 }, 
                                       { B0, B1, B2 }, 
                                       { C0, C1, C2 } };
        }

        public TicTacToe(bool playerGoesFirst)
        {
            InitializeComponent();
            Board = new Button[3, 3] { { A0, A1, A2 },
                                       { B0, B1, B2 },
                                       { C0, C1, C2 } };

            if (playerGoesFirst == false)
                AIturn_X();
        }

        private void buttonClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            printLetter(turnCount, b);

            if (checkWinner())
                disableButtons();
            else
            {
                turnCount++;
                turn = !turn;
            }

        }

        private bool checkWinner()
        {
            bool win = false;

            //horizontal wins
            if ((A0.Text == A1.Text) && (A1.Text == A2.Text) && (!A0.Enabled))   
                win = true;
            else if ((B0.Text == B1.Text) && (B1.Text == B2.Text) && (!B0.Enabled))
                win = true;
            else if ((C0.Text == C1.Text) && (C1.Text == C2.Text) && (!C0.Enabled))
                win = true;

            //vertical wins
            else if ((A0.Text == B0.Text) && (B0.Text == C0.Text) && (!A0.Enabled))   
                win = true;
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                win = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                win = true;

            //diagonal wins
            else if ((A0.Text == B1.Text) && (B1.Text == C2.Text) && (!A0.Enabled))  
                win = true;
            else if ((A2.Text == B1.Text) && (B1.Text == C0.Text) && (!A2.Enabled))
                win = true;

            if (win)
            {
                if (turn)
                    MessageBox.Show("X Wins!");
                else
                    MessageBox.Show("O Wins!");
            }
            else if (turnCount == 9)
                MessageBox.Show("Draw.");

            return win;
        }

        private void disableButtons()
        {
            foreach(Control c in Controls)
            {
                Button b = (Button)c;
                b.Enabled = false;
            }

            reset.Enabled = true;
        }

        private void reset_Click(object sender, EventArgs e)
        {
            turnCount = 1;
            turn = true;

            foreach (Control c in Controls)
            {
                Button b = (Button)c;
                b.Enabled = true;
                b.Text = "";
            }

            reset.Text = "reset";
        }

        private void TicTacToe_Load(object sender, EventArgs e)
        {

        }

        private void printLetter(int turnCount, Button b)
        {
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";

            b.Enabled = false;
            SetPrevButton(b);
        }

        private void SetPrevButton(Button b)        //sets row and col for AI calculations
        {
            prevButton = b;

            if (b == A0 || b == A1 || b == A2)
                row = 0;
            else if (b == B0 || b == B1 || b == B2)
                row = 1;
            else if (b == C0 || b == C1 || b == C2)
                row = 2;

            if (b == A0 || b == B0 || b == C0)
                col = 0;
            else if (b == A1 || b == B1 || b == C1)
                col = 1;
            else if (b == A2 || b == B2 || b == C2)
                col = 2;


        }

        private void AIturn_X()         //plays AI's turn if AI is X
        {
            if (turnCount == 1)         //if 1st turn, pick middle
            {
                printLetter(turnCount, B1);
                SetPrevButton(B1);
            }
            else if (turnCount == 3)    //if 3rd turn
            {
                if (prevButton != Board[0, 0] &&
                    prevButton != Board[0, 2] &&
                    prevButton != Board[2, 0] &&
                    prevButton != Board[2, 2])        //if player didn't pick a corner last turn
                {
                    printLetter(turnCount, Board[(row % 2), (col % 2)]); //pick opposite corner
                    xScenario1 = true;
                }
                else                                //else if player picked a corner 
                {
                    if (col == 1)
                        printLetter(turnCount, Board[row, 0]);
                    else
                        printLetter(turnCount, Board[0, col]);

                    xScenario1 = false;     
                }
              
            }

            if (checkWinner())
                disableButtons();
            else
            {
                turnCount++;
                turn = !turn;
            }
            
        }


    }

 
}
