using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestRubikCube
{


    public partial class Form1 : Form
    {
        GameGrid gg = new GameGrid();


        const int UP = 1;
        const int DOWN = 2;
        const int LEFT = 3;
        const int RIGHT = 4;

        int[,] winGrid = {
            {1,1,2,2},
            {1,1,2,2},
            {3,3,4,4},
            {3,3,4,4}
        };

        int[,] currentGrid = {
            {1,1,2,2},
            {1,1,2,2},
            {3,3,4,4},
            {3,3,4,4}
        };

        public Form1()
        {
            InitializeComponent();
            gg.InitGameGrid();

            redraw();
            remix();

        }

        void remix()
        {
            rotateHorizontal(0, RIGHT);
            rotateHorizontal(1, RIGHT);
            rotateHorizontal(1, RIGHT);
            rotateHorizontal(2, RIGHT);
            rotateHorizontal(2, RIGHT);
            rotateHorizontal(2, RIGHT);

            rotateVertical(1, DOWN);
            rotateVertical(2, DOWN);
            rotateVertical(2, DOWN);

            rotateHorizontal(3, RIGHT);
            rotateHorizontal(0, LEFT);
            //Random rnd = new Random(DateTime.Now.Millisecond);

            //for (int loop = 0; loop < 20; loop++)
            //{
            //    int x1 = rnd.Next(4);
            //    int y1 = rnd.Next(4);

            //    int x2 = rnd.Next(4);
            //    int y2 = rnd.Next(4);

            //    int temp = currentGrid[x1, y1];
            //    currentGrid[x1, y1] = currentGrid[x2, y2];
            //    currentGrid[x2, y2] = temp;

            //    redraw();
            //}
        }

        bool isWinner()
        {
            int correct = 0;
            for (int x = 0; x < 4; x++)
                for (int y = 0; y < 4; y++)
                    if (currentGrid[x, y] == winGrid[x, y])
                        correct++;
            return (correct == 16);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void redraw()
        {
            for (int y = 0; y < 4; y++)
                for (int x = 0; x < 4; x++)
                {
                    gg.SetPixel(x, y, currentGrid[x, y]);
                }
            this.pictureBoxGameGrid.Image = gg.GetGameGrid();
            this.textBox1.Text = (isWinner() ? "Winner" : "Try again");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        void rotateVertical(int col, int dir)
        {
            if (dir == UP)
            {
                int temp = currentGrid[col, 0];
                for (int i = 1; i < 4; i++)
                    currentGrid[col, i - 1] = currentGrid[col, i];
                currentGrid[col, 3] = temp;
            }
            else
            {
                if (dir == DOWN)
                {
                    int temp = currentGrid[col, 3];
                    for (int i = 3; i > 0; i--)
                        currentGrid[col, i] = currentGrid[col, i - 1];
                    currentGrid[col, 0] = temp;
                }
            }
            redraw();
        }

        void rotateHorizontal(int row, int dir)
        {
            if (dir == RIGHT)
            {
                int temp = currentGrid[3, row];
                for (int i = 3; i > 0; i--)
                    currentGrid[i, row] = currentGrid[i - 1, row];
                currentGrid[0, row] = temp;
            }
            else
            {
                if (dir == LEFT)
                {
                    int temp = currentGrid[0, row];
                    for (int i = 1; i < 4; i++)
                        currentGrid[i - 1, row] = currentGrid[i, row];
                    currentGrid[3, row] = temp;
                }
            }
            redraw();
        }

        private void buttonT1_Click(object sender, EventArgs e)
        {
            rotateVertical(0, UP);
        }

        private void buttonT2_Click(object sender, EventArgs e)
        {
            rotateVertical(1, UP);
        }

        private void buttonT3_Click(object sender, EventArgs e)
        {
            rotateVertical(2, UP);
        }

        private void buttonT4_Click(object sender, EventArgs e)
        {
            rotateVertical(3, UP);
        }




        private void buttonB1_Click(object sender, EventArgs e)
        {
            rotateVertical(0, DOWN);
        }

        private void buttonB2_Click(object sender, EventArgs e)
        {
            rotateVertical(1, DOWN);
        }

        private void buttonB3_Click(object sender, EventArgs e)
        {
            rotateVertical(2, DOWN);
        }

        private void buttonB4_Click(object sender, EventArgs e)
        {
            rotateVertical(3, DOWN);
        }




        private void buttonL1_Click(object sender, EventArgs e)
        {
            rotateHorizontal(0, LEFT);
        }
        private void buttonL2_Click(object sender, EventArgs e)
        {
            rotateHorizontal(1, LEFT);
        }
        private void buttonL3_Click(object sender, EventArgs e)
        {
            rotateHorizontal(2, LEFT);
        }
        private void buttonL4_Click(object sender, EventArgs e)
        {
            rotateHorizontal(3, LEFT);
        }




        private void buttonR1_Click(object sender, EventArgs e)
        {
            rotateHorizontal(0, RIGHT);
        }
        private void buttonR2_Click(object sender, EventArgs e)
        {
            rotateHorizontal(1, RIGHT);
        }
        private void buttonR3_Click(object sender, EventArgs e)
        {
            rotateHorizontal(2, RIGHT);
        }
        private void buttonR4_Click(object sender, EventArgs e)
        {
            rotateHorizontal(3, RIGHT);
        }
    }
}
