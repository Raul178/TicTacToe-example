using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        int[,] matrice;
        int conta = 0;
        public Form1()
        {
            InitializeComponent();
        }

        void controlla()
        {
            string vincitore = "";
            for (int y = 0; y < 3; y++)
            {
                if (matrice[0, y] == matrice[1, y] && matrice[1, y] == matrice[2, y] && matrice[0, y] != 0)
                {
                    vincitore = ((char)matrice[0, y]).ToString();
                }
            }
            for (int x = 0; x < 3; x++)
            {
                if (matrice[x, 0] == matrice[x, 1] && matrice[x, 1] == matrice[x, 2] && matrice[x, 0] != 0)
                {
                    vincitore = ((char)matrice[x, 0]).ToString();
                }
            }
            if (matrice[0, 0] == matrice[1, 1] && matrice[1, 1] == matrice[2, 2] && matrice[0, 0] != 0)
            {
                vincitore = ((char)matrice[0, 0]).ToString();
            }
            else if (matrice[0, 2] == matrice[1, 1] && matrice[2, 0] == matrice[0, 2] && matrice[0, 2] != 0)
            {
                vincitore = ((char)matrice[0, 2]).ToString();
            }
            if (vincitore != "")
            {
                if (vincitore == "O")
                {
                    vincitore = "Player 2 (O)";
                }
                else
                {
                    vincitore = "Player 1 (X)";
                }
                MessageBox.Show("The winner is " + vincitore + "!");
                nuovaPartitaToolStripMenuItem_Click(new object(), EventArgs.Empty);
            }
            if (conta == 9 && vincitore == "")
            {
                MessageBox.Show("Draw!");
                nuovaPartitaToolStripMenuItem_Click(new object(), EventArgs.Empty);
            }
        }

        void click(int pos, int x, int y)
        {
            int y2 = 0, x2 = pos;
            while (x2 > 3)
            {
                x2 -= 3;
                y2++;
            }
            x2--;
            using (var graphics = Graphics.FromImage(griglia.Image))
            {
                graphics.CompositingMode = CompositingMode.SourceOver;
                graphics.DrawImage(griglia.Image, 0, 0);
                if (matrice[x2, y2] != 'O' && matrice[x2, y2] != 'X')
                {
                    conta++;
                    if (conta % 2 == 0)
                    {
                        matrice[x2, y2] = 'O';
                        graphics.DrawImage(new Bitmap(Properties.Resources.Nought), x, y);
                    }
                    else
                    {
                        matrice[x2, y2] = 'X';
                        graphics.DrawImage(new Bitmap(Properties.Resources.Cross), x, y);
                    }
                }
            }
            griglia.Refresh();
            controlla();
        }

        private void griglia_MouseUp(object sender, MouseEventArgs e)
        {
            int xCoordinate = e.X;
            int yCoordinate = e.Y;
            if (yCoordinate < 70)
            {
                if (xCoordinate < 70)
                {
                    click(1, 0, 0);
                }
                else if (xCoordinate >= 80 && xCoordinate <= 150)
                {
                    click(2, 80, 0);
                }
                else if (xCoordinate >= 160)
                {
                    click(3, 160, 0);
                }
            }
            else if (yCoordinate >= 80 && yCoordinate <= 150)
            {
                if (xCoordinate < 70)
                {
                    click(4, 0, 80);
                }
                else if (xCoordinate >= 80 && xCoordinate <= 150)
                {
                    click(5, 80, 80);
                }
                else if (xCoordinate >= 160)
                {
                    click(6, 160, 80);
                }
            }
            else if (yCoordinate >= 160)
            {
                if (xCoordinate < 70)
                {
                    click(7, 0, 160);
                }
                else if (xCoordinate >= 80 && xCoordinate <= 150)
                {
                    click(8, 80, 160);
                }
                else if (xCoordinate >= 160)
                {
                    click(9, 160, 160);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            matrice = new int[3, 3];
        }

        private void nuovaPartitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conta = 0;
            griglia.Image = Properties.Resources.Grid;
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    matrice[x, y] = 0;
                }
            }
        }
    }
}
