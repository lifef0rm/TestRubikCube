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
    class GameGrid
    {
        //my changes 2-1

        public Bitmap bmpImage = null;
        public int gridWidth = 128;
        public int gridHeight = 64;
        public int xFactor = 32;
        public int yFactor = 32;

        public void SetPixel(int x, int y,  Color c)
        {
            Graphics g = Graphics.FromImage(bmpImage);
 
            SolidBrush aBrush = new SolidBrush(c); 

            g.FillRectangle(aBrush, x * xFactor, y * yFactor, xFactor, yFactor);
        }


        public void SetPixel(int x, int y, int c)
        {
            Graphics g = Graphics.FromImage(bmpImage);
            Brush aBrush;
            switch (c)
            {
                case 4:
                    aBrush = Brushes.Yellow;
                    break;
                case 3:
                    aBrush = Brushes.Green;
                    break;
                case 1:
                    aBrush = Brushes.Red;
                    break;
                case 2:
                    aBrush = Brushes.Blue;
                    break;
                default:
                    aBrush = Brushes.Black;
                    break;
            }
            g.FillRectangle(aBrush, x * xFactor, y * yFactor, xFactor, yFactor);
        }

        //public void DrawSprite(GameSprite sprite)
        //{
        //    for (int i = 0; i < 8; i++)
        //    {
        //        for (int j = 0; j < 8; j++)
        //        {
        //            SetPixel(sprite.x + i, sprite.y + j, sprite.data[sprite.spriteStep, j, i]);
        //        }
        //    }
        //}

        //public void EraseSprite(GameSprite sprite)
        //{
        //    for (int i = 0; i < 8; i++)
        //    {
        //        for (int j = 0; j < 8; j++)
        //        {
        //            SetPixel(sprite.x + i, sprite.y + j, 0);
        //        }
        //    }
        //}

        public Bitmap GetGameGrid()
        {
            return bmpImage;
        }

        public void InitGameGrid()
        {
            bmpImage = new Bitmap(gridWidth * xFactor, gridHeight * yFactor);
            Graphics g = Graphics.FromImage(bmpImage);
            g.Clear(Color.Black);
        }

    }
}
