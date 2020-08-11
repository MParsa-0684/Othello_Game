using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Othello
{
    public partial class Form1 : Form
    {
        public int[,] Board = new int[10, 10];
        public int[,] Board_C = new int[10, 10];
        public int Turn = 1;
        public int Not_Turn = 2;
        public int counter = 1;
        public int Zarf;
        public string Button = "";
        public Boolean f = false;
        public int wh = 2;
        public int bl = 2;
        public bool isplayedW = true;
        public bool isplayedB = true;
        
        

        public Form1()
        {
            InitializeComponent();
            for (int m = 0; m < 10; m++)
            {
                for (int n = 0; n < 10; n++)
                {
                    Board[m, n] = 0;
                }
            }
            Board[4, 4] = 1;
            Board[5, 5] = 1;
            Board[4, 5] = 2;
            Board[5, 4] = 2;
            Board_C = Board;
            WhiteBlack.Text = "White's Turn";
            label9.Text = "60";
            timer1.Enabled = true;

        }
        private void Othello(object sender, EventArgs e)
        {
            Button Gamer = (Button)sender;
            
        }

        private void button34_Click(object sender, EventArgs e)
        {

        }

        private void button35_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void Button_Click(object sender, EventArgs e)
        {
            var parts = ((Button)sender).Name.Split('_');
            int i = -1;
            int j = -1;
            int ctr = 0;
                
            int.TryParse(parts[1], out i);
            int.TryParse(parts[2], out j);
            //up_Vertical
            for (int x = i - 1; x >= 0; x--)
            {
                if (Board[x, j] == 0)
                    break;
                else if (Board[x, j] == Turn)
                {
                    for (int p = x + 1; p < i; p++)
                    {
                        Board_C[p, j] = Turn;
                        ctr++;
                        f = true;
                    }
                    break;
                }
            }
            if (f == true)
            {
                Board_C[i, j] = Turn;
            }
            //down_Vertical
            for (int x = i + 1; x <= 9; x++)
            {
                if (Board[x, j] == 0)
                    break;
                else if (Board[x, j] == Turn)
                {
                    for (int p = x - 1; p > i; p--)
                    {
                        Board_C[p, j] = Turn;
                        ctr++;
                        f = true;
                    }
                    break;
                }
            }
            if (f == true)
            {
                Board_C[i, j] = Turn;
            }
            //Horizontally-right
            for (int y = j + 1; y <= 9; y++)
            {
                if (Board[i, y] == 0)
                    break;
                else if (Board[i, y] == Turn)
                {
                    for (int p = y - 1; p > j; p--)
                    {
                        Board_C[i, p] = Turn;
                        ctr++;
                        f = true;
                    }
                    break;
                }
            }
            if (f == true)
            {
                Board_C[i, j] = Turn;
            }
            //Horizontally-left
            for (int y = j - 1; y >= 0; y--)
            {
                if (Board[i, y] == 0)
                    break;
                else if (Board[i, y] == Turn)
                {
                    for (int p = y + 1; p < j; p++)
                    {
                        Board_C[i, p] = Turn;
                        ctr++;
                        f = true;
                    }
                    break;
                }
            }
            if (f == true)
            {
                Board_C[i, j] = Turn;
            }
            //movarrab-NW-1
            int u =i + 1;
            int z = j + 1;
            while(u <= 9 && z <= 9)
            {
                if (Board[u, z] == 0)
                { 
                    break;
                }
                else if (Board[u,z] == Turn)
                {
                    int w = u - 1;
                    int q = z - 1;
                    while(w>i && q>j )
                    {
                        Board_C[w, q] = Turn;
                        ctr++;
                        f = true;
                        w--;
                        q--;
                    }
                    break;
                }
                u++;
                z++;
            }
            if (f == true)
            {
                Board_C[i, j] = Turn;

            }
            //movarrab-NW-2
            u = i - 1;
            z = j - 1;
            while (u >= 0 && z >= 0)
            {
                if (Board[u, z] == 0)
                {
                    break;
                }
                else if (Board[u, z] == Turn)
                {
                    int w = u + 1;
                    int q = z + 1;
                    while (w < i && q < j)
                    {
                        Board_C[w, q] = Turn;
                        ctr++;
                        f = true;
                        w++;
                        q++;
                    }
                    break;
                }
                u--;
                z--;
            }
            if (f == true)
            {
                Board_C[i, j] = Turn;

            }
            //movarrab-NE-1
            u = i + 1;
            z = j - 1;
            while (u <= 9 && z >= 0)
            {
                if (Board[u, z] == 0)
                {
                    break;
                }
                else if (Board[u, z] == Turn)
                {
                    int w = u - 1;
                    int q = z + 1;
                    while (w > i && q < j)
                    {
                        Board_C[w, q] = Turn;
                        ctr++;
                        f = true;
                        w--;
                        q++;
                    }
                    break;
                }
                u++;
                z--;
            }
            if (f == true)
            {
                Board_C[i, j] = Turn;
            }
            //movarrab-NE-2
            u = i - 1;
            z = j + 1;
            while (z <= 9 && u >= 0)
            {
                if (Board[u, z] == 0)
                {
                    break;
                }
                else if (Board[u, z] == Turn)
                {
                    int w = u + 1;
                    int q = z - 1;
                    while (w < i && q > j)
                    {
                        Board_C[w, q] = Turn;
                        ctr++;
                        f = true;
                        w++;
                        q--;
                    }
                    break;
                }
                z++;
                u--;
            }
            if (f == true)
            {
                Board_C[i, j] = Turn;
                ctr++;
                f = false;
            }



            if (Board_C[i, j] != Turn)
            {
                MessageBox.Show("    The bead doesn't have change color ability !", "Ooops...");
            }
            else
            {
                Board = Board_C;
                Align(Board);
                Zarf = Turn;
                isplayedW = true;
                isplayedB = true;
                warW.Text = "";
                warB.Text = "";
                if (Turn == 1)
                {
                    W.Text = (wh + ctr).ToString();
                    B.Text = (bl - ctr + 1).ToString();
                    wh += ctr;
                    bl -= ctr - 1;
                }
                else
                {
                    W.Text = (wh - ctr + 1).ToString();
                    B.Text = (bl + ctr).ToString();
                    wh -= ctr - 1;
                    bl += ctr;
                }

                Turn = Not_Turn;
                counter++;
                Not_Turn = Zarf;
                label9.Text = "60";
                if(Turn == 1)
                {
                    WhiteBlack.Text = "White's Turn";
                }
                if (Turn == 2)
                {
                    WhiteBlack.Text = "Black's Turn";
                }
                if(counter == 97)
                {
                    Winner(Board_C);
                }
            }

        }
        private void Winner(int[,] Win)
        {
            int Black = 0;
            int White = 0;

            for(int W = 0; W<10; W++)
            {
                for(int Z = 0; Z<10; Z++)
                { 
                    if(Win[W,Z] == 1)
                    {
                        White++;
                    }
                    if(Win[W,Z] == 2)
                    {
                        Black++;
                    }
                }
            }
            if(Black > White)
            {
                MessageBox.Show("     Black Player Won !!", " ! Congratulations ! ");
            }
            if (Black < White)
            {
                MessageBox.Show("     White Player Won !!", " ! Congratulations ! ");
            }
            if (Black == White)
            {
                MessageBox.Show("   ! The game equalised !", " ! The game equalised ! ");
            }
            timer1.Enabled = false;
            Black = 0;
            White = 0;
        }
        private void Align(int[,] arr)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Button = "b_" + i + "_" + j;
                    if (arr[i, j] == 0)
                    {
                        this.Controls[Button].BackColor = Color.Green;

                    }
                    else if (arr[i, j] == 1)
                    {
                        this.Controls[Button].BackColor = Color.White;
                        this.Controls[Button].Enabled = false;
                    }
                    else if (arr[i, j] == 2)
                    {
                        this.Controls[Button].BackColor = Color.Black;
                        this.Controls[Button].Enabled = false;
                    }
                }
            }
        }

        private void startNewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int m = 0; m < 10; m++)
            {
                for (int n = 0; n < 10; n++)
                {
                    Board[m, n] = 0;
                    Button = "b_" + m + "_" + n;
                    this.Controls[Button].Enabled = true;
                }
            }
            Board[4, 4] = 1;
            Board[5, 5] = 1;
            Board[4, 5] = 2;
            Board[5, 4] = 2;
            Board_C = Board;
                 Turn = 1;
             Not_Turn = 2;
            counter = 0;
            wh = 2;
            bl = 2;
            W.Text = wh.ToString();
            B.Text = bl.ToString();
            Align(Board);
            WhiteBlack.Text = "White's Turn";
            label9.Text = "60";
            warW.Text = "";
            warB.Text = "";
            timer1.Enabled = true;


        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("    By Parsa Arani", "Information");

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int second = Convert.ToInt32(label9.Text);
            if(second > 0)
            {
                second--;
                if (second < 10)
                    label9.Text = "0" + second.ToString();
                else
                    label9.Text = second.ToString();
            }
            else
            {
                if (Turn == 1)
                {
                    isplayedW = false;
                    warW.Text = "!";
                }
                else
                {
                    isplayedB = false;
                    warB.Text = "!";
                }
            
                label9.Text = "60";
                if(isplayedB == false && isplayedW == false)
                {
                    timer1.Enabled = false;
                    if (bl > wh)
                    {
                        MessageBox.Show("     Black Player Won !!", " ! Congratulations ! ");
                    }
                    if (bl < wh)
                    {
                        MessageBox.Show("     White Player Won !!", " ! Congratulations ! ");
                    }
                    if (bl == wh)
                    {
                        MessageBox.Show("   ! The game equalised !", " ! The game equalised ! ");
                    }
                }
                else
                {
                    Board = Board_C;
                    Align(Board);
                    Zarf = Turn;
                    Turn = Not_Turn;
                    counter++;
                    Not_Turn = Zarf;
                    if (Turn == 1)
                    {
                        WhiteBlack.Text = "White's Turn";
                    }
                    if (Turn == 2)
                    {
                        WhiteBlack.Text = "Black's Turn";
                    }
                    if (counter == 97)
                    {
                        Winner(Board_C);
                    }

                }
                

                
            }

        }
    }
}
