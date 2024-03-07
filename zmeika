using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
 
 
namespace ConsoleApp6
{
    enum EActiv
    {
        STOP = 0, LEFT, RIGHT, UP, DOWN
    };
 
    class Program
    {
        static int[] tailX = new int[360];
        static int[] tailY = new int[360];
        static int ntail;
        static bool gameOver;
        const int width=20;
        const int height = 20;
        static int x,y,fruitX,fruitY;
        static int score;
 
        static EActiv dir;
        static void setup()
        {
            Random rand = new Random();
            int marvel = rand.Next();
 
            gameOver = false;
            dir = EActiv.STOP;
            x = width / 2;
            y = height / 2;
            fruitX = marvel % (width - 2);
            fruitY = marvel % (height - 2);
            score = 0;
        }
        static void draw()
        {
            Console.Clear();
            for (int i=0;i<=width;i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("#");
            }
            Console.WriteLine();
 
            for (int i = 0; i < height;i ++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (j == 0 || j == (width - 1))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("#");
                    }
                    if (i == y && j == x)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("0");
                    }
                    else if (i == fruitY && j == fruitX)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("@");
                    }
                    else
                    {
                        bool print = false;
                        for (int k=0;k<ntail;k++)
                        {
                            if(tailX[k]==j && tailY[k] == i)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write("o");                              
                                print = true;
                            }
                        }
                        if(!print)
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
 
            for (int i = 0; i <= width; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("#");             
            }
            Console.WriteLine();
            Console.WriteLine(score);
        }
        static void input()
        {
            if (Console.KeyAvailable)
            {
                var keyInfo = Console.ReadKey();
                switch (keyInfo.KeyChar)
                {
                    case 'a':
                        dir = EActiv.LEFT;
                        break;
                    case 'd':
                        dir = EActiv.RIGHT;
                        break;
                    case 'w':
                        dir = EActiv.UP;
                        break;
                    case 's':
                        dir = EActiv.DOWN;
                        break;
                    case 'x':
                        gameOver = true;
                        break;
                }
            }
        }
        static void logicOfGame(int mode)
        {
            tailX[0] = x;
            tailY[0] = y;
            int prevx = tailX[0];
            int prevy = tailY[0];
            int prev2X, prev2Y;
            for (int i = 1; i < ntail; i++)
            {
                prev2X = tailX[i];
                prev2Y = tailY[i];
                tailX[i] = prevx;
                tailY[i] = prevy;
                prevx = prev2X;
                prevy = prev2Y;
            }
            switch (dir)
            {
                case EActiv.LEFT:
                    x--;
                    break;
                case EActiv.RIGHT:
                    x++; 
                    break;
                case EActiv.DOWN:
                    y++;
                    break;
                case EActiv.UP:
                    y--;
                    break;
              
            }
            if (mode == 2)
            {
                if (x == width || x == 0 || y == height || y == 0)
                {
                    gameOver = true;
                }
            }
            if (mode == 1 || mode == 0)
            {
                if (x >= width)
                    x = 0;
                else if (x < 0)
                    x = width - 1;
                if (y >= height)
                    y = 0;
                else if (y < 0)
                    y = height - 1;
            }
            for (int i = 0; i<ntail;i++)
            {
                if (tailX[i] == x && tailY[i] == y)
                {
                    gameOver = true;
                }
            }
            if(x==fruitX && y == fruitY)
            {
                    score += 10;      
                Random rand = new Random();
                int marvel = rand.Next();
                fruitX = marvel % (width - 2);
                fruitY = marvel % (height - 2);
                ntail++;
            }
        }
        static void Main(string[] args)
        {
            int q;
            do
            {
                
                Console.WriteLine("1-свободный режим\n2-аркада\n3-выход");
                q = Int32.Parse(Console.ReadLine());
                Console.Clear();
               
                if (q == 1 || q == 2 )
                {
                    setup();
                    while (!gameOver )
                    {
                        draw();
                        input();
                        logicOfGame(q);                                             
                            Thread.Sleep(350);                          
                        if ((q == 1 || q==2) && score == 3600)
                        {
                            Console.WriteLine("you won!");
                        }
                    }
                   
                }
            } while (q == '3');
 
        }
        
    }
}
