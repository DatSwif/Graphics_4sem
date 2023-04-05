using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Movement
{
    class Square
    {
        public float realX;
        public float realY;
        public float nextX;
        public float nextY;
        public int number;
        public bool moving = true;
        public const int size = 50;
        public const int maxSpeed = 5;
        public const int maxX = 678;
        public const int maxY = 381;

        public bool playerAcceleration = false;
        public float accelerationX = 0;
        public float accelerationY = 0;

        public float speedX = 0;
        public float speedY = 0;

        public static bool intersects(float x1, float y1, float x2, float y2, int size)
        {
            if ((x1 - x2 < size) & 
                (x2 - x1 < size) & 
                (y1 - y2 < size) & 
                (y2 - y1 < size))
            {
                return true;
            }
            else return false;
        }

        public Square(List<Square> squares)
        {
            this.realX = 0;
            this.realX = 0;
            bool plausible = false;
            while (!plausible)
            {
                bool maybePlausible = true;
                foreach(Square square in squares)
                {
                    if (intersects(this.realX, this.realY, square.realX, square.realY, size))
                    {
                        maybePlausible = false;
                    }
                }
                if (maybePlausible)
                {
                    plausible = true;
                }
                else
                {
                    if (this.realX > 640)
                    {
                        this.realX = 0;
                        this.realY += 55;
                    }
                    else
                    {
                        this.realX += 55;
                    }
                }
            }
            number = squares.Count + 1;
        }
        public void estimateMovement(bool input, double accX, double accY)
        {
            if (input)
            {
                double factor = Math.Sqrt(1 / Math.Pow((accX + accY), 2));
                this.accelerationX = (float)(accX * factor);
                this.accelerationY = (float)(accY * factor);

                this.speedX += this.accelerationX;
                this.speedY += this.accelerationY;

                double speed = Math.Sqrt(Math.Pow(speedX, 2) + Math.Pow(speedY, 2));
                if (speed > 5)
                {
                    factor = speed / 5;
                    this.speedX = this.speedX / (float)factor;
                    this.speedY = this.speedY / (float)factor;
                }
            }
            else if ((this.speedX == 0) & (this.speedY == 0))
            {
                this.accelerationX = 0;
                this.accelerationY = 0;
            }
            else
            {
                double factor = Math.Sqrt(Math.Pow(this.speedX, 2) + Math.Pow(this.speedY, 2));
                this.accelerationX = -(this.speedX / (float)factor);
                this.accelerationY = -(this.speedY / (float)factor);

                if (speedX * (speedX + accelerationX) < 0)
                {
                    this.speedX = 0;
                }
                else
                {
                    this.speedX += this.accelerationX;
                }
                if (speedY * (speedY + accelerationY) < 0)
                {
                    this.speedY = 0;
                }
                else
                {
                    this.speedY += this.accelerationY;
                }
            }
            nextX = realX + speedX;
            nextY = realY + speedY;
        }
        public static void resolveCollisions(List<Square> squares, List<(int, int, bool)> collisions)
        {
            foreach((int, int, bool) collision in collisions)
            {
                if (collision.Item3) //vertical
                {
                    squares[collision.Item1].speedY = -squares[collision.Item1].speedY;
                    squares[collision.Item2].speedY = -squares[collision.Item2].speedY; 
                    float midpoint = (squares[collision.Item1].nextY + squares[collision.Item2].nextY + Square.size) / 2;
                    if (squares[collision.Item1].realY > squares[collision.Item2].realY)
                    {
                        squares[collision.Item1].nextY = midpoint;
                        squares[collision.Item2].nextY = midpoint - Square.size;
                    }
                    else
                    {
                        squares[collision.Item1].nextY = midpoint - Square.size;
                        squares[collision.Item2].nextY = midpoint;
                    }
                }
                else //horizontal
                {
                    squares[collision.Item1].speedX = -squares[collision.Item1].speedX;
                    squares[collision.Item2].speedX = -squares[collision.Item2].speedX;
                    float midpoint = (squares[collision.Item1].nextX + squares[collision.Item2].nextX + Square.size) / 2;
                    if (squares[collision.Item1].realX > squares[collision.Item2].realX)
                    {
                        squares[collision.Item1].nextX = midpoint;
                        squares[collision.Item2].nextX = midpoint - Square.size;
                    }
                    else
                    {
                        squares[collision.Item1].nextX = midpoint - Square.size;
                        squares[collision.Item2].nextX = midpoint;
                    }
                }
            }
        }
        public static void move(List<Square> squares)
        {
            List<(int, int, bool)> collisions = new List<(int, int, bool)>();
            for(int i = 0; i < squares.Count() - 1; i++)
            {
                for(int j = i + 1; j < squares.Count(); j++)
                {
                    if (intersects(squares[i].nextX, squares[i].nextY, squares[j].nextX, squares[j].nextY, size))
                    {
                        if ((squares[i].nextX + squares[i].nextY > squares[j].nextX + squares[j].nextY) ^ (squares[i].nextX - squares[i].nextY > squares[j].nextX - squares[j].nextY))
                        {
                            collisions.Add((i, j, true)); //vertical
                        }
                        else
                        {
                            collisions.Add((i, j, false)); //horizontal
                        }
                    }
                }
            }
            resolveCollisions(squares, collisions);
            foreach(Square square in squares)
            {
                if (square.nextX > maxX)
                {
                    square.nextX = maxX;
                    square.speedX = -square.speedX;
                }
                if (square.nextX < 0)
                {
                    square.nextX = 0;
                    square.speedX = -square.speedX;
                }
                if (square.nextY > maxY)
                {
                    square.nextY = maxY;
                    square.speedY = -square.speedY;
                }
                if(square.nextY < 0)
                {
                    square.nextY = 0;
                    square.speedY = -square.speedY;
                }
                square.realX = square.nextX;
                square.realY = square.nextY;
            }
        }
    }
}
