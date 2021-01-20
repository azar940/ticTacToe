using System;

namespace tictoctay
{
    class Program
    {
        static void Main(string[] args)
        {
            string parx = "+-------";
            string parv = "|       ";
            char playeronline = 'X';
            int devesionPlayer = 1;
            char[] p = { '1','2','3','4','5','6','7','8','9' };
            bool weHaveWiner = false;


            do
            {
                
                if (devesionPlayer == 1)
                {
                    Console.WriteLine(parx + parx + parx + "+");
                    Console.WriteLine("|       "+"Player : 1"+"      |");
                    Console.WriteLine(parx + parx + parx + "+");
                    playeronline = 'X';
                }
                else
                {
                    Console.WriteLine(parx + parx + parx + "+");
                    Console.WriteLine("|       " + "Player : 2" + "      |");
                    Console.WriteLine(parx + parx + parx + "+");
                    playeronline = 'O';
                }
                
                reprintGame(p, parx, parv);
                Console.WriteLine("writing your choise :");
                Int32 id = Convert.ToInt32(Console.ReadLine());

                p[id - 1] = playeronline;

                Console.Clear();

                devesionPlayer *= -1;

                weHaveWiner = checkWiners(p);


            } while (! weHaveWiner);
            
        }

        static void reprintGame(char[] p,string parx,string parv) 
        {
            Console.WriteLine(parx + parx + parx + "+");
            Console.WriteLine(parv + parv + parv + "|");
            Console.WriteLine("|   " + p[0] + "   |   " + p[1] + "   |   " + p[2] + "   |");
            Console.WriteLine(parv + parv + parv + "|");
            Console.WriteLine(parx + parx + parx + "+");


            Console.WriteLine(parv + parv + parv + "|");
            Console.WriteLine("|   " + p[3] + "   |   " + p[4] + "   |   " + p[5] + "   |");
            Console.WriteLine(parv + parv + parv + "|");
            Console.WriteLine(parx + parx + parx + "+");


            Console.WriteLine(parv + parv + parv + "|");
            Console.WriteLine("|   " + p[6] + "   |   " + p[7] + "   |   " + p[8] + "   |");
            Console.WriteLine(parv + parv + parv + "|");
            Console.WriteLine(parx + parx + parx + "+");

        }
        static bool checkWiners(char[] p)
        {
            bool wHW = false;
            //player1
            if (p[0] == 'X' && p[1] == 'X' && p[2] == 'X')
            {
                wHW = true;
                printWiner("1");
            }
            if (p[3] == 'X' && p[4] == 'X' && p[5] == 'X')
            {
                wHW = true;
                printWiner("1");
            }
            if (p[6] == 'X' && p[7] == 'X' && p[8] == 'X')
            {
                wHW = true;
                printWiner("1");
            }

            if (p[0] == 'X' && p[3] == 'X' && p[6] == 'X')
            {
                wHW = true;
                printWiner("1");
            }
            if (p[1] == 'X' && p[4] == 'X' && p[7] == 'X')
            {
                wHW = true;
                printWiner("1");
            }
            if (p[2] == 'X' && p[5] == 'X' && p[8] == 'X')
            {
                wHW = true;
                printWiner("1");
            }

            if (p[0] == 'X' && p[4] == 'X' && p[8] == 'X')
            {
                wHW = true;
                printWiner("1");
            }
            if (p[2] == 'X' && p[4] == 'X' && p[6] == 'X')
            {
                wHW = true;
                printWiner("1");
            }


            //player2

            if (p[0] == 'O' && p[1] == 'O' && p[2] == 'O')
            {
                wHW = true;
                printWiner("2");
            }
            if (p[3] == 'O' && p[4] == 'O' && p[5] == 'O')
            {
                wHW = true;
                printWiner("2");
            }
            if (p[6] == 'O' && p[7] == 'O' && p[8] == 'O')
            {
                wHW = true;
                printWiner("2");
            }

            if (p[0] == 'O' && p[3] == 'O' && p[6] == 'O')
            {
                wHW = true;
                printWiner("2");
            }
            if (p[1] == 'O' && p[4] == 'O' && p[7] == 'O')
            {
                wHW = true;
                printWiner("2");
            }
            if (p[2] == 'O' && p[5] == 'O' && p[8] == 'O')
            {
                wHW = true;
                printWiner("2");
            }

            if (p[0] == 'O' && p[4] == 'O' && p[8] == 'O')
            {
                wHW = true;
                printWiner("2");
            }
            if (p[2] == 'O' && p[4] == 'O' && p[6] == 'O')
            {
                wHW = true;
                printWiner("2");
            }




            if (p[0] != '1' && p[1] != '2' && p[2] != '3' && p[3] != '4' && p[4] != '5' && p[5] != '6' && p[6] != '7' && p[7] != '8' && p[8] != '9')
            {
                wHW = true;
                printWiner("0");

            }


            return wHW;

        }
        static void printWiner(string i)
        {
            Console.Clear();
            Console.WriteLine("+----------------------+");
            Console.WriteLine("+-----♣ Player ► " + i+ "♣----+");
            Console.WriteLine("+-----♣--is win---♣----+");
            Console.WriteLine("+----------------------+");
                
        }
    
    }
}