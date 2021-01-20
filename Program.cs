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
            Int32 id = 0;
            Random rnd = new Random();
            

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
                
                if (playeronline == 'X')
                {
                    Console.WriteLine("writing your choise :");
                    id = Convert.ToInt32(Console.ReadLine()) ;
                    id--;
                }
                else
                {
                    id = Convert.ToInt32(rnd.Next(0, p.Length));
                }
                

                p[id] = playeronline;

                Console.Clear();

                devesionPlayer *= -1;

                weHaveWiner = checkWiners(p);


            } while (! weHaveWiner);
            
        }
        static void reprintGame(char[] p,string parx,string parv) 
        {
            Console.WriteLine(parx + parx + parx + "+");

            for (int j=0;j<7;j+=3)
            {
                Console.WriteLine(parv + parv + parv + "|");
                Console.WriteLine("|   " + p[0+j] + "   |   " + p[1 + j] + "   |   " + p[2 + j] + "   |");
                Console.WriteLine(parv + parv + parv + "|");
                Console.WriteLine(parx + parx + parx + "+");
            }
        }
        static bool checkWiners(char[] p)
        {
            bool wHW = false;
            //player1
            for (int j=0;j<7;j+=3)
            {
                if (p[j] == 'X' && p[j+1] == 'X' && p[j+2] == 'X')
                {
                    wHW = true;
                    printWiner("1");
                }
            }
            for (int j=0;j<3;j+=1)
            {
                if (p[j] == 'X' && p[j + 3] == 'X' && p[j + 6] == 'X')
                {
                    wHW = true;
                    printWiner("1");
                }
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
            for (int j = 0; j < 7; j += 3)
            {
                if (p[j] == 'O' && p[j + 1] == 'O' && p[j + 2] == 'O')
                {
                    wHW = true;
                    printWiner("1");
                }
            }
            for (int j = 0; j < 3; j += 1)
            {
                if (p[j] == 'O' && p[j + 3] == 'O' && p[j + 6] == 'O')
                {
                    wHW = true;
                    printWiner("1");
                }
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

            //ta3adol

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