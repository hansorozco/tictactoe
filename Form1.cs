using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoe_final
{
    public partial class Form1 : Form
    {
        bool turn = true;// true = x; false = y turn
        int turn_count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       
        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";

            turn = !turn;
            b.Enabled = false;
            turn_count++;

            CheckForWinner();
        }
        private void CheckForWinner()
        {
            bool there_is_a_Winner = false;

            // horizontal checks
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                there_is_a_Winner = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                there_is_a_Winner = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                there_is_a_Winner = true;

            // vertical checks
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                there_is_a_Winner = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                there_is_a_Winner = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                there_is_a_Winner = true;

            // diagonal checks
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                there_is_a_Winner = true;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
                there_is_a_Winner = true;

            if (there_is_a_Winner)
            {
                disableButtons();

                String winner = "";
                if (turn)
                    winner = "O";
                else
                    winner = "X";

                MessageBox.Show(winner + " Wins!", "You're Amazing Senpai!");
            }//end if
            else
            {
                if (turn_count == 9)
                    MessageBox.Show("                         Draw!", "You Suck, Better luck Next Time!");
            }
        }//end checkForWinner

        private void disableButtons(IContainer components)
        {
            disableButtons(components);
        }

        private void disableButtons()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }//end foreach
            }//end try
            catch { }
        }

   
        private void nEWGAMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;

            try
            {
                A1.Enabled = true;
                A2.Enabled = true;
                A3.Enabled = true;
                B1.Enabled = true;
                B2.Enabled = true;
                B3.Enabled = true;
                C1.Enabled = true;
                C2.Enabled = true;
                C3.Enabled = true;

                A1.Text = "";
                A2.Text = "";
                A3.Text = "";
                B1.Text = "";
                B2.Text = "";
                B3.Text = "";
                C1.Text = "";
                C2.Text = "";
                C3.Text = "";
            }

            catch { }
        }

        private void aBOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Hans Orozco from BSCOE 1-4. " +
               "This is a 2 Player game, developed to challenge one another. " +
                "Please enjoy the Game. " +
                " If you look closely at the menu strip you will see something.");
        }

        private void eXITToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}        



