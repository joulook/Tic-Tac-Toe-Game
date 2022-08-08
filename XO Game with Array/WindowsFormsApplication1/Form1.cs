using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        static bool flag = false;
        static char [,]a = new char[3,3];
        static int turn = 1;
        static int winsPlayer1 = 0;
        static int winsPlayer2 = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
                label1.Text = "Turn :Player " + turn.ToString();
                label4.Text ="Player 1 : "+Convert.ToString(winsPlayer1);
                label5.Text = "Player 2 : "+Convert.ToString(winsPlayer2);
                label6.Text="  JR.Y  De.Coder(); <<-- ";
        }
        public static void changeTurn()
        {
            if (turn == 1)
                turn = 2;
            else
                turn = 1;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            {
                button1.Text = "X";
                a[0,0] ='X';
            }

            else
            {
                button1.Text = "O";
                a[0, 0] = 'O';
            }
            check();
            if (flag)
            {
                label1.Text = "Winner : Player " + turn.ToString();
                label4.Text = "Player 1 : " + Convert.ToString(winsPlayer1);
                label5.Text = "Player 2 : " + Convert.ToString(winsPlayer2);
            }
            else if (checkFull())
            {
                label1.Text = "NO WINNER!!";
            }
            else
            {
                changeTurn();
                label1.Text = "Turn : Player " + turn.ToString();
            }
            button1.Enabled = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            {
                button2.Text = "X";
                a[0, 1] = 'X';
            }
            else
            {
                button2.Text = "O";
                a[0, 1] = 'O';
            }
            check();
            if (flag)
            {
                label1.Text = "Winner : Player " + turn.ToString();
                label4.Text = "Player 1 : " + Convert.ToString(winsPlayer1);
                label5.Text = "Player 2 : " + Convert.ToString(winsPlayer2);
            }
                
            else if (checkFull())
            {
                label1.Text = "NO WINNER!!";
            }
            else
            {
                changeTurn();
                label1.Text = "Turn : Player " + turn.ToString();
            }
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            {
                button3.Text = "X";
                a[0, 2] = 'X';
            }
            else
            {
                button3.Text = "O";
                a[0, 2] = 'O';
            }
            check();
            if (flag)
            {
                label1.Text = "Winner : Player " + turn.ToString();
                label4.Text = "Player 1 : " + Convert.ToString(winsPlayer1);
                label5.Text = "Player 2 : " + Convert.ToString(winsPlayer2);
            }
                
            else if (checkFull())
            {
                label1.Text = "NO WINNER!!";
            }
            else
            {
                changeTurn();
                label1.Text = "Turn : Player " + turn.ToString();
            }
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            {
                button4.Text = "X";
                a[1, 0] = 'X';
            }

            else
            {
                button4.Text = "O";
                a[1, 0] = 'O';
            }
            check();
            if (flag)
            {
                label1.Text = "Winner : Player " + turn.ToString();
                label4.Text = "Player 1 : " + Convert.ToString(winsPlayer1);
                label5.Text = "Player 2 : " + Convert.ToString(winsPlayer2);
            }
               
            else if (checkFull())
            {
                label1.Text = "NO WINNER!!";
            }
            else
            {
                changeTurn();
                label1.Text = "Turn : Player " + turn.ToString();

            }
            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            {
                button5.Text = "X";
                a[1, 1] = 'X';
            }
            else
            {
                button5.Text = "O";
                a[1, 1] = 'O';
            }
            check();
            if (flag)
            {
                label1.Text = "Winner : Player " + turn.ToString();
                label4.Text = "Player 1 : " + Convert.ToString(winsPlayer1);
                label5.Text = "Player 2 : " + Convert.ToString(winsPlayer2);
            }
               
            else if (checkFull())
            {
                label1.Text = "NO WINNER!!";
            }
            else
            {
                changeTurn();
                label1.Text = "Turn : Player " + turn.ToString();

            }
            button5.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            {
                button6.Text = "X";
                a[1, 2] = 'X';
            }
            else
            {
                button6.Text = "O";
                a[1, 2] = 'O';
            }
            check();
            if (flag)
            {
                label1.Text = "Winner : Player " + turn.ToString();
                label4.Text = "Player 1 : " + Convert.ToString(winsPlayer1);
                label5.Text = "Player 2 : " + Convert.ToString(winsPlayer2);
            }
                
            else if (checkFull())
            {
                label1.Text = "NO WINNER!!";
            }
            else
            {
                changeTurn();
                label1.Text = "Turn : Player " + turn.ToString();

            }
            button6.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            {
                button7.Text = "X";
                a[2, 0] = 'X';
            }
            else
            {
                button7.Text = "O";
                a[2, 0] = 'O';
            }
            check();
            if (flag)
            {
                label1.Text = "Winner : Player " + turn.ToString();
                label4.Text = "Player 1 : " + Convert.ToString(winsPlayer1);
                label5.Text = "Player 2 : " + Convert.ToString(winsPlayer2);
            }
                
            else if (checkFull())
            {
                label1.Text = "NO WINNER!!";
            }
            else
            {
                changeTurn();
                label1.Text = "Turn : Player " + turn.ToString();

            }
            button7.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            {
                button8.Text = "X";
                a[2, 1] = 'X';
            }
            else
            {
                button8.Text = "O";
                a[2, 1] = 'O';
            }
            check();
            if (flag)
            {
                label1.Text = "Winner : Player " + turn.ToString();
                label4.Text = "Player 1 : " + Convert.ToString(winsPlayer1);
                label5.Text = "Player 2 : " + Convert.ToString(winsPlayer2);
            }
               
            else if (checkFull())
            {
                label1.Text = "NO WINNER!!";
            }
            else
            {
                changeTurn();
                label1.Text = "Turn : Player " + turn.ToString();

            }
            button8.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            {
                button9.Text = "X";
                a[2, 2] = 'X';
            }
            else
            {
                button9.Text = "O";
                a[2, 2] = 'O';
            }
            check();
            if (flag)
            {
                label1.Text = "Winner : Player " + turn.ToString();
                label4.Text ="Player 1 : "+Convert.ToString(winsPlayer1);
                label5.Text = "Player 2 : "+Convert.ToString(winsPlayer2);
            }
                
            else if (checkFull())
            {
                label1.Text = "NO WINNER!!";
            }
            else
            {
                changeTurn();
                label1.Text = "Turn : Player " + turn.ToString();

            }
            button9.Enabled = false;
        }
        public void check()
        {
            if ((a[0, 0] == a[0, 1]) && (a[0, 1] == a[0, 2]) && (a[0, 0] == 'X' || a[0, 0] == 'O' || a[0, 1] == 'X' || a[0, 1] == 'O' || a[0, 2] == 'X' || a[0, 2] == 'O'))
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button1.BackColor = Color.CornflowerBlue;
                button2.BackColor = Color.CornflowerBlue;
                button3.BackColor = Color.CornflowerBlue;
                flag = true;
                win(turn);
                finish();
            }
            else if ((a[1, 0] == a[1, 1]) && (a[1, 1] == a[1, 2]) && (a[1, 0] == 'X' || a[1, 0] == 'O' || a[1, 1] == 'X' || a[1, 1] == 'O' || a[1, 2] == 'X' || a[1, 2] == 'O'))
            {
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button4.BackColor = Color.CornflowerBlue;
                button5.BackColor = Color.CornflowerBlue;
                button6.BackColor = Color.CornflowerBlue;
                flag = true;
                win(turn);
                finish();
            }
            else if ((a[2, 0] == a[2, 1]) && (a[2, 1] == a[2, 2]) && (a[2, 0] == 'X' || a[2, 0] == 'O' || a[2, 1] == 'X' || a[2, 1] == 'O' || a[2, 2] == 'X' || a[2, 2] == 'O'))
            {
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                button7.BackColor = Color.CornflowerBlue;
                button8.BackColor = Color.CornflowerBlue;
                button9.BackColor = Color.CornflowerBlue;
                flag = true;
                win(turn);
                finish();
            }
            else if ((a[0, 0] == a[1, 0]) && (a[1, 0] == a[2, 0]) && (a[0, 0] == 'X' || a[0, 0] == 'O' || a[1, 0] == 'X' || a[1, 0] == 'O' || a[2, 0] == 'X' || a[2, 0] == 'O'))
            {
                button1.Enabled = true;
                button4.Enabled = true;
                button7.Enabled = true;
                button1.BackColor = Color.CornflowerBlue;
                button4.BackColor = Color.CornflowerBlue;
                button7.BackColor = Color.CornflowerBlue;
                flag = true;
                win(turn);
                finish();
            }
            else if ((a[0, 1] == a[1, 1]) && (a[1, 1] == a[2, 1]) && (a[0, 1] == 'X' || a[0, 1] == 'O' || a[1, 1] == 'X' || a[1, 1] == 'O' || a[2, 1] == 'X' || a[2, 1] == 'O'))
            {
                button2.Enabled = true;
                button5.Enabled = true;
                button8.Enabled = true;
                button2.BackColor = Color.CornflowerBlue;
                button5.BackColor = Color.CornflowerBlue;
                button8.BackColor = Color.CornflowerBlue;
                flag = true;
                win(turn);
                finish();
            }
            else if ((a[0, 2] == a[1, 2]) && (a[1, 2] == a[2, 2]) && (a[0, 2] == 'X' || a[0, 2] == 'O' || a[1, 2] == 'X' || a[1, 2] == 'O' || a[2, 2] == 'X' || a[2, 2] == 'O'))
            {
                button3.Enabled = true;
                button6.Enabled = true;
                button9.Enabled = true;
                button3.BackColor = Color.CornflowerBlue;
                button6.BackColor= Color.CornflowerBlue;
                button9.BackColor = Color.CornflowerBlue;
                flag = true;
                win(turn);
                finish();
            }
            else if ((a[0, 0] == a[1, 1]) && (a[1, 1] == a[2, 2]) && (a[0, 0] == 'X' || a[0, 0] == 'O' || a[1, 1] == 'X' || a[1, 1] == 'O' || a[2, 2] == 'X' || a[2, 2] == 'O'))
            {
                button1.Enabled = true;
                button5.Enabled = true;
                button9.Enabled = true;
                button1.BackColor = Color.CornflowerBlue;
                button5.BackColor = Color.CornflowerBlue;
                button9.BackColor = Color.CornflowerBlue;
                flag = true;
                win(turn);
                finish();
            }
            else if ((a[0, 2] == a[1, 1]) && (a[1, 1] == a[2, 0]) && (a[0, 2] == 'X' || a[0, 2] == 'O' || a[1, 1] == 'X' || a[1, 1] == 'O' || a[2, 0] == 'X' || a[2, 0] == 'O'))
            {
                button3.Enabled = true;
                button5.Enabled = true;
                button7.Enabled = true;
                button3.BackColor = Color.CornflowerBlue;
                button5.BackColor = Color.CornflowerBlue;
                button7.BackColor = Color.CornflowerBlue;
                flag = true;
                win(turn);
                finish();
            }
           
                
                
        }
        public void finish()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }
        public  bool checkFull()
        {
            if ((a[0, 0] == 'X' || a[0, 0] == 'O') && (a[0, 1] == 'X' || a[0, 1] == 'O') && (a[0, 2] == 'X' || a[0, 2] == 'O') &&
                (a[1, 0] == 'X' || a[1, 0] == 'O') && (a[1, 1] == 'X' || a[1, 1] == 'O') && (a[1, 2] == 'X' || a[1, 2] == 'O') &&
                (a[2, 0] == 'X' || a[2, 0] == 'O') && (a[2, 1] == 'X' || a[2, 1] == 'O') && (a[2, 2] == 'X' || a[2, 2] == 'O'))
                return true;
            else
                return false;
        }
        public void newGame()
        {
            turn = 1;
            flag = false;
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    a[i, j] = ' ';
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button1.BackColor = SystemColors.Control;
            button1.UseVisualStyleBackColor = true;
            button2.BackColor = SystemColors.Control;
            button2.UseVisualStyleBackColor = true;
            button3.BackColor = SystemColors.Control;
            button3.UseVisualStyleBackColor = true;
            button4.BackColor = SystemColors.Control;
            button4.UseVisualStyleBackColor = true;
            button5.BackColor = SystemColors.Control;
            button5.UseVisualStyleBackColor = true;
            button6.BackColor = SystemColors.Control;
            button6.UseVisualStyleBackColor = true;
            button7.BackColor = SystemColors.Control;
            button7.UseVisualStyleBackColor = true;
            button8.BackColor = SystemColors.Control;
            button8.UseVisualStyleBackColor = true;
            button9.BackColor = SystemColors.Control;
            button9.UseVisualStyleBackColor = true;

            label1.Text = "player " + turn.ToString();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        public void win(int turn)
        {
            if (turn == 1)
                 winsPlayer1++;
            else
                 winsPlayer2++;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            newGame();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            newGame();
            winsPlayer1 = 0;
            winsPlayer2 = 0;
            label4.Text = "Player 1 : " + Convert.ToString(winsPlayer1);
            label5.Text = "Player 2 : " + Convert.ToString(winsPlayer2);

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
    }

