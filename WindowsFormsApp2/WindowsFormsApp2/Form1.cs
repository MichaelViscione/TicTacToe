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
        bool turn = true; //true = X's turn and false = O's turn
        int turnCount = 1;
        

        public TicTacToe()
        {
            InitializeComponent();
        }

        private void buttonClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";

            b.Enabled = false;
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
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))   
                win = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                win = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                win = true;

            //vertical wins
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))   
                win = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                win = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                win = true;

            //diagonal wins
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))  
                win = true;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!A3.Enabled))
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
    }


}
