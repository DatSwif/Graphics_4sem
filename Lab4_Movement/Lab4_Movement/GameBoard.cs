using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Lab4_Movement
{
    class GameBoard
    {
        List<Square> squares = new List<Square>();
        List<Image> squareImages = new List<Image>()
        {
            Lab4_Movement.Properties.Resources.num1,
            Lab4_Movement.Properties.Resources.num2,
            Lab4_Movement.Properties.Resources.num3,
            Lab4_Movement.Properties.Resources.num4,
            Lab4_Movement.Properties.Resources.num5,
            Lab4_Movement.Properties.Resources.num6,
            Lab4_Movement.Properties.Resources.num7,
            Lab4_Movement.Properties.Resources.num8,
            Lab4_Movement.Properties.Resources.num9
        };
        int squaresCount = 0;
        int selectedSquare = -1;

        public void update(Panel DrawingPanel, bool[] events, int mouseX, int mouseY)
        {
            bool error = false;
            Graphics graphics = DrawingPanel.CreateGraphics();
            if (DrawingPanel.BorderStyle != BorderStyle.None)
            {
                DrawingPanel.BorderStyle = BorderStyle.None;
            }
            if (events[0] == true) //space
            {
                if (squaresCount == 9)
                {
                    error = true;
                }
                else
                {
                    squares.Add(new Square(squares));
                    squaresCount += 1;
                }
            }
            else if (events[1] == true) //del
            {
                if (squaresCount == 0)
                {
                    error = true;
                }
                else
                {
                    squares.RemoveAt(squaresCount - 1);
                    squaresCount -= 1;
                    if (selectedSquare == squaresCount - 1)
                    {
                        selectedSquare = -1;
                    }
                }
            }
            else if (events[3] == true) //"RMB"
            {
                int oldSelectedSquare = selectedSquare;
                foreach(Square square in squares)
                {
                    if ((mouseX > square.realX) & 
                        (mouseY > square.realY) & 
                        (mouseX < square.realX + Square.size) & 
                        (mouseY < square.realY + Square.size))
                    {
                        selectedSquare = square.number - 1;
                    }
                }
                if (selectedSquare == oldSelectedSquare)
                {
                    error = true;
                }
            }
            #region select with numbers
                else if (events[9])//1
                {
                    if (squares.Count() < 1)
                    {
                        error = true;
                    }
                    else
                    {
                        selectedSquare = 0;
                    }
                }
                else if (events[10])//2
                {
                    if (squares.Count() < 2)
                    {
                        error = true;
                    }
                    else
                    {
                        selectedSquare = 1;
                    }
                }
                else if (events[11])//3
                {
                    if (squares.Count() < 3)
                    {
                        error = true;
                    }
                    else
                    {
                        selectedSquare = 2;
                    }
                }
                else if (events[12])//4
                {
                    if (squares.Count() < 4)
                    {
                        error = true;
                    }
                    else
                    {
                        selectedSquare = 3;
                    }
                }
                else if (events[13])//5
                {
                    if (squares.Count() < 5)
                    {
                        error = true;
                    }
                    else
                    {
                        selectedSquare = 4;
                    }
                }
                else if (events[14])//6
                {
                    if (squares.Count() < 6)
                    {
                        error = true;
                    }
                    else
                    {
                        selectedSquare = 5;
                    }
                }
                else if (events[15])//7
                {
                    if (squares.Count() < 7)
                    {
                        error = true;
                    }
                    else
                    {
                        selectedSquare = 6;
                    }
                }
                else if (events[16])//8
                {
                    if (squares.Count() < 8)
                    {
                        error = true;
                    }
                    else
                    {
                        selectedSquare = 7;
                    }
                }
                else if (events[17]) //9
                {
                    if (squares.Count() < 9)
                    {
                        error = true;
                    }
                    else
                    {
                        selectedSquare = 8;
                    }
                }
                #endregion
            else if (events[8]) //"T"
            {
                if (selectedSquare == -1)
                {
                    error = true;
                }
                else
                {
                    bool plausible = true;
                    foreach (Square square in squares)
                    {
                        if ((square.number != selectedSquare + 1) &
                            (mouseX > square.realX - Square.size / 2) &
                            (mouseY > square.realY - Square.size / 2) &
                            (mouseX < square.realY + Square.size / 2) &
                            (mouseY < square.realY + Square.size / 2))
                        {
                            plausible = false;
                        }
                    }
                    if (!plausible)
                    {
                        error = true;
                    }
                    else
                    {
                        squares[selectedSquare].realX = mouseX - 25;
                        squares[selectedSquare].realY = mouseY - 25;
                    }
                }
            }
            #region movement inputs
            bool movingInput = false;
            double accX = 0;
            double accY = 0;

            if (events[2])//"LMB"
            {
                if (selectedSquare == -1)
                {
                    error = true;
                }
                else
                {
                    accX = mouseX - (squares[selectedSquare].realX + 25);
                    accY = mouseY - (squares[selectedSquare].realY + 25);
                    movingInput = true;
                }
            }
            if (events[4])//"W"
            {
                if (selectedSquare == -1)
                {
                    error = true;
                }
                else
                {
                    accY -= 1;
                    movingInput = true;
                }
            }
            if (events[5])//"A"
            {
                if (selectedSquare == -1)
                {
                    error = true;
                }
                else
                {
                    accX -= 1;
                    movingInput = true;
                }
            }
            if (events[6])//"S"
            {
                if (selectedSquare == -1)
                {
                    error = true;
                }
                else
                {
                    accY += 1;
                    movingInput = true;
                }
            }
            if (events[7])//"D"
            {
                if (selectedSquare == -1)
                {
                    error = true;
                }
                else
                {
                    accX += 1;
                    movingInput = true;
                }
            }
            #endregion
            #region calculating movement
            foreach(Square square in squares)
            {
                if ((square.number == selectedSquare + 1) & (movingInput))
                {
                    square.estimateMovement(true, accX, accY);
                }
                else
                {
                    square.estimateMovement(false, accX, accY);
                }
            }
            Square.move(squares);
            #endregion
            #region rendering
            Pen greenPen = new Pen(Color.Green, 2);
            foreach (Square square in squares)
            {
                graphics.DrawImage(squareImages[square.number - 1], square.realX, square.realY);
                if (square.number == selectedSquare + 1)
                {
                    graphics.DrawRectangle(greenPen, square.realX, square.realY, Square.size, Square.size);
                }
            }
            #endregion
            for (int i = 1; i < 3; i++)
            {
                graphics.DrawRectangle(greenPen, 0, 0, 728, 431);
            }
            if (error)
            {
                ControlPaint.DrawBorder(graphics, DrawingPanel.DisplayRectangle, Color.Red, ButtonBorderStyle.Solid);
            }
        }
    }
}
