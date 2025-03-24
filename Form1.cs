using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeProg
{
    public partial class Form1 : Form
    {
        string turn = "O";
        int moves = 0;
        int score_O = 0;
        int score_X = 0;
        string win = "";
        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Reset();
            button12.Text = $"O score :{score_O}\n X score:{score_X}";
        }

        private void Button_OorX(object sender, EventArgs e)
        {
            Button btnObj = (Button)sender;

            if (btnObj.Text == "")
            {
                if (turn == "O")
                {
                    turn = "X";

                }
                else
                {
                    turn = "O";


                }
                btnObj.Text = turn;
                moves++;
            }
            winner();
            tie();

        }
        void tie()
        {
            if (moves >= 9)
            {
                MessageBox.Show("Match Tie take place");
                turn = "O";
                Reset();
            }
        }
        void Reset()
        {
            foreach (var item in this.Controls)
            {
                Button button = (Button)item;
                if (button.Tag == null)
                {
                    button.Text = "";
                }

            }
            turn = "O";
            moves = 0;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            score_X = 0;
            score_O = 0;
            Reset();
            button12.Text = $"O score: {score_O}\n X score :{score_X}";
        }
        void scoreCalculate(string player)
        {
            if (player == "X")
            {
                score_X++;
                button12.Text = $"O score:{score_O}\n X score:{score_X}";
            }
            else
            {
                score_O++;
                button12.Text = $"O score:{score_O}\n X score:{score_X}";
            }
        }
        void winner()
        {
            if (button1.Text != "")
            {

                if ((button1.Text == button2.Text) && (button1.Text == button3.Text))
                {
                    win = button1.Text;
                    MessageBox.Show(win + "is winner");
                    scoreCalculate(win);
                    moves = 0;
                    turn = "O";
                    Reset();

                }
                else if ((button1.Text == button5.Text) && (button1.Text == button9.Text))
                {
                    win = button1.Text;
                    MessageBox.Show(win + "is winner");
                    scoreCalculate(win);
                    moves = 0;
                    turn = "O";
                    Reset();

                }
                else if ((button1.Text == button4.Text) && (button1.Text == button7.Text))
                {
                    win = button1.Text;
                    MessageBox.Show(win + "is winner");
                    scoreCalculate(win);
                    moves = 0;
                    turn = "O";
                    Reset();

                }

            }
            if (button2.Text != "")
            {

                if ((button2.Text == button5.Text) && (button2.Text == button8.Text))
                {
                    win = button2.Text;
                    MessageBox.Show(win + "is winner");
                    scoreCalculate(win);
                    moves = 0;
                    turn = "O";
                    Reset();

                }
            }
            if (button3.Text != "")
            {

                if ((button3.Text == button6.Text) && (button3.Text == button9.Text))
                {
                    win = button3.Text;
                    MessageBox.Show(win + "is winner");
                    scoreCalculate(win);
                    moves = 0;
                    turn = "O";
                    Reset();

                }
                else if ((button3.Text == button5.Text) && (button3.Text == button7.Text))
                {
                    win = button3.Text;
                    MessageBox.Show(win + "is winner");
                    scoreCalculate(win);
                    moves = 0;
                    turn = "O";
                    Reset();

                }
            }
            if (button4.Text != "")
            {

                if ((button4.Text == button5.Text) && (button4.Text == button6.Text))
                {
                    win = button4.Text;
                    MessageBox.Show(win + "is winner");
                    scoreCalculate(win);
                    moves = 0;
                    turn = "O";
                    Reset();

                }
            }
        }
    }
}
