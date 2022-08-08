using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        static int WinsPlayer1 = 0;
        static int WinsPlayer2=0;
        LinkedList list = new LinkedList();
        public static int turn = 1;
        public bool checkFull()
        {
            if (list.NumberOfNodes == 9)
                return true;
            else
                return false;
        }
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = " Turn : player " + turn.ToString();
            label3.Text = " Player 1 : " + WinsPlayer1.ToString();
            label4.Text = " Player 2 : " + WinsPlayer2.ToString();
            label5.Text = " JR.Y De.Coder(); ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            {
                list.insertInFirst(1);
                button1.Text = "X";
            }
            else
            {
                list.insertInLast(1);
                button1.Text = "O";
            }
            if (Win())
            {
                label1.Text = "Winner : player " + turn.ToString();
                label3.Text = " Player 1 : " + WinsPlayer1.ToString();
                label4.Text = " Player 2 : " + WinsPlayer2.ToString();
            }
            else
            {
                if (checkFull())
                    label1.Text = " No Winner !!";
                else
                {
                    changeTurn();
                    label1.Text = " Turn : player " + turn.ToString();
                }
                
            }
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            {
                list.insertInFirst(2);
                button2.Text = "X";
            }
            else
            {
                list.insertInLast(2);
                button2.Text = "O";
            }
            if (Win())
            {
                label1.Text = "Winner : player " + turn.ToString();
                label3.Text = " Player 1 : " + WinsPlayer1.ToString();
                label4.Text = " Player 2 : " + WinsPlayer2.ToString();
            }
            else
            {
                if (checkFull())
                    label1.Text = " No Winner !!";
                else
                {
                    changeTurn();
                    label1.Text = " Turn : player " + turn.ToString();
                }

            }
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            {
                list.insertInFirst(3);
                button3.Text = "X";
            }
            else
            {
                list.insertInLast(3);
                button3.Text = "O";
            }
            if (Win())
            {
                label1.Text = "Winner : player " + turn.ToString();
                label3.Text = " Player 1 : " + WinsPlayer1.ToString();
                label4.Text = " Player 2 : " + WinsPlayer2.ToString();
            }
            else
            {
                if (checkFull())
                    label1.Text = " No Winner !!";
                else
                {
                    changeTurn();
                    label1.Text = " Turn : player " + turn.ToString();
                }

            }
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            {
                list.insertInFirst(4);
                button4.Text = "X";
            }
            else
            {
                list.insertInLast(4);
                button4.Text = "O";
            }
            if (Win())
            {
                label1.Text = "Winner : player " + turn.ToString();
                label3.Text = " Player 1 : " + WinsPlayer1.ToString();
                label4.Text = " Player 2 : " + WinsPlayer2.ToString();
            }
            else
            {
                if (checkFull())
                    label1.Text = " No Winner !!";
                else
                {
                    changeTurn();
                    label1.Text = " Turn : player " + turn.ToString();
                }

            }
            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            {
                list.insertInFirst(5);
                button5.Text = "X";
            }
            else
            {
                list.insertInLast(5);
                button5.Text = "O";
            }
            if (Win())
            {
                label1.Text = "Winner : player " + turn.ToString();
                label3.Text = " Player 1 : " + WinsPlayer1.ToString();
                label4.Text = " Player 2 : " + WinsPlayer2.ToString();
            }
            else
            {
                if (checkFull())
                    label1.Text = " No Winner !!";
                else
                {
                    changeTurn();
                    label1.Text = " Turn : player " + turn.ToString();
                }

            }
            button5.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            {
                list.insertInFirst(6);
                button6.Text = "X";
            }
            else
            {
                list.insertInLast(6);
                button6.Text = "O";
            }
            if (Win())
            {
                label1.Text = "Winner : player " + turn.ToString();
                label3.Text = " Player 1 : " + WinsPlayer1.ToString();
                label4.Text = " Player 2 : " + WinsPlayer2.ToString();
            }
            else
            {
                if (checkFull())
                    label1.Text = " No Winner !!";
                else
                {
                    changeTurn();
                    label1.Text = " Turn : player " + turn.ToString();
                }

            }
            button6.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            {
                list.insertInFirst(7);
                button7.Text = "X";
            }
            else
            {
                list.insertInLast(7);
                button7.Text = "O";
            }
            if (Win())
            {
                label1.Text = "Winner : player " + turn.ToString();
                label3.Text = " Player 1 : " + WinsPlayer1.ToString();
                label4.Text = " Player 2 : " + WinsPlayer2.ToString();
            }
            else
            {
                if (checkFull())
                    label1.Text = " No Winner !!";
                else
                {
                    changeTurn();
                    label1.Text = " Turn : player " + turn.ToString();
                }

            }
            button7.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            {
                list.insertInFirst(8);
                button8.Text = "X";
            }
            else
            {
                list.insertInLast(8);
                button8.Text = "O";
            }
            if (Win())
            {
                label1.Text = "Winner : player " + turn.ToString();
                label3.Text = " Player 1 : " + WinsPlayer1.ToString();
                label4.Text = " Player 2 : " + WinsPlayer2.ToString();
            }
            else
            {
                if (checkFull())
                    label1.Text = " No Winner !!";
                else
                {
                    changeTurn();
                    label1.Text = " Turn : player " + turn.ToString();
                }

            }
            button8.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            {
                list.insertInFirst(9);
                button9.Text = "X";
            }
            else
            {
                list.insertInLast(9);
                button9.Text = "O";
            }
            if (Win())
            {
                label1.Text = "Winner : player " + turn.ToString();
                label3.Text = " Player 1 : " + WinsPlayer1.ToString();
                label4.Text = " Player 2 : " + WinsPlayer2.ToString();
            }
            else
            {
                if (checkFull())
                    label1.Text = " No Winner !!";
                else
                {
                    changeTurn();
                    label1.Text = " Turn : player " + turn.ToString();
                }

            }
            button9.Enabled = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            newGame();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            newGame();
            WinsPlayer1 = 0;
            WinsPlayer2 = 0;
            label3.Text = "Player 1 : " + Convert.ToString(WinsPlayer1);
            label4.Text = "Player 2 : " + Convert.ToString(WinsPlayer2);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void changeTurn()
        {
            if (turn == 1)
                turn = 2;
            else if (turn == 2)
                turn = 1;
        }
        public bool checkConditions(LinkedList.Node x)
        {
            if (list.find(x, 1) && list.find(x, 2) && list.find(x, 3))
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button1.BackColor = Color.MediumPurple;
                button2.BackColor = Color.MediumPurple;
                button3.BackColor = Color.MediumPurple;
                finish();
                return true;
            }
            else if (list.find(x, 4) && list.find(x, 5) && list.find(x, 6))
            {
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button4.BackColor = Color.MediumPurple;
                button5.BackColor = Color.MediumPurple;
                button6.BackColor = Color.MediumPurple;
                finish();
                return true;
            }
            else if (list.find(x, 7) && list.find(x, 8) && list.find(x, 9))
            {
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                button7.BackColor = Color.MediumPurple;
                button8.BackColor = Color.MediumPurple;
                button9.BackColor = Color.MediumPurple;
                finish();
                return true;
            }
            else if (list.find(x, 1) && list.find(x, 4) && list.find(x, 7))
            {
                button1.Enabled = true;
                button4.Enabled = true;
                button7.Enabled = true;
                button1.BackColor = Color.MediumPurple;
                button4.BackColor = Color.MediumPurple;
                button7.BackColor = Color.MediumPurple;
                finish();
                return true;
            }

            else if (list.find(x, 2) && list.find(x, 5) && list.find(x, 8))
            {
                button2.Enabled = true;
                button5.Enabled = true;
                button8.Enabled = true;
                button2.BackColor = Color.MediumPurple;
                button5.BackColor = Color.MediumPurple;
                button8.BackColor = Color.MediumPurple;
                finish();
                return true;
            }
            else if (list.find(x, 3) && list.find(x, 6) && list.find(x, 9))
            {
                button3.Enabled = true;
                button6.Enabled = true;
                button9.Enabled = true;
                button3.BackColor = Color.MediumPurple;
                button6.BackColor = Color.MediumPurple;
                button9.BackColor = Color.MediumPurple;
                finish();
                return true;
            }
            else if (list.find(x, 1) && list.find(x, 5) && list.find(x, 9))
            {
                button1.Enabled = true;
                button5.Enabled = true;
                button9.Enabled = true;
                button1.BackColor = Color.MediumPurple;
                button5.BackColor = Color.MediumPurple;
                button9.BackColor = Color.MediumPurple;
                finish();
                return true;
            }
            else if (list.find(x, 3) && list.find(x, 5) && list.find(x, 7))
            {
                button3.Enabled = true;
                button5.Enabled = true;
                button7.Enabled = true;
                button3.BackColor = Color.MediumPurple;
                button5.BackColor = Color.MediumPurple;
                button7.BackColor = Color.MediumPurple;
                finish();
                return true;
            }
            else
                return false;
        }
        public bool Win()
        {
            if (turn == 1)
            {
                if (checkConditions(list.l))
                {
                    WinsPlayer1++;
                    return true;
                }
                else
                    return false;
            }
            else
            {
                if (checkConditions(list.middle))
                {
                    WinsPlayer2++;
                    return true;
                }
                else
                    return false;
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
        public void newGame()
        {
            turn = 1;
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            for (int i = 1; i <= 9; i++)
                list.delete();
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
    }
}
