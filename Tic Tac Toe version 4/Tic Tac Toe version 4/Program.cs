using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_version_4
{
    class Program
    {
        static void Main(string[] args)
        {
            { 
                char[] array = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
                int player = 1;   
                int input;   
                int logic = 0;
                do
                {
                    Console.Clear();
                    Console.WriteLine("\n");
                    Console.Title = ("Iyke's Tic Tac Toe Game Version 4");
                    Console.WriteLine("Welcome To Iyke's Tic Tac Toe Game");
                    Console.WriteLine("\n");
                    Console.WriteLine("1st Player = X and 2nd Player = O");
                    Console.WriteLine("\n");
                    if (player % 2 == 0)
                    {
                        Console.WriteLine("Player 2 : Input a number");
                    }
                    else
                    {
                        Console.WriteLine("Player 1 : Input a number");
                    }
                    Console.WriteLine("\n");
                    Board(array);  
                    input = int.Parse(Console.ReadLine());

                    if (array[input] != 'X' && array[input] != 'O')
                    {
                        if (player % 2 == 0) 
                        {
                            array[input] = 'O';
                            player++;
                        }
                        else
                        {
                            array[input] = 'X';
                            player++;
                        }
                    }
                    else 
                    {
                        Console.WriteLine("Sorry the row {0} is already marked with {1}", input, array[input]);
                        Console.WriteLine("\n");
                        Console.WriteLine("Please wait a second, while we load another board.....");
                        System.Threading.Thread.Sleep(5000);
                    }
                    logic = inquireWin(array);
                } while (logic != 1 && logic != -1);

                Console.Clear();
                Board(array); 

                if (logic == 1) 
                {
                    Console.WriteLine("Player {0} wins", (player % 2) + 1);
                }
                else 
                {
                    Console.WriteLine("This was a tie");
                }
                Console.ReadLine();
            }
        }
        static void Board(char[] array)
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", array[1], array[2], array[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", array[4], array[5], array[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", array[7], array[8], array[9]);
            Console.WriteLine("     |     |      ");
        }
 
        static int inquireWin(char[] array)
        {
            #region Horzontal Condtions
            if (array[1] == array[2] && array[2] == array[3])
            {
                return 1;
            }  
            else if (array[4] == array[5] && array[5] == array[6])
            {
                return 1;
            }
            else if (array[6] == array[7] && array[7] == array[8])
            {
                return 1;
            }
            #endregion

            #region vertical Condtions     
            else if (array[1] == array[4] && array[4] == array[7])
            {
                return 1;
            }
            else if (array[2] == array[5] && array[5] == array[8])
            {
                return 1;
            }
            else if (array[3] == array[6] && array[6] == array[9])
            {
                return 1;
            }
            #endregion

            #region Diagonal Condition
            else if (array[1] == array[5] && array[5] == array[9])
            {
                return 1;
            }
            else if (array[3] == array[5] && array[5] == array[7])
            {
                return 1;
            }
            #endregion

            #region Tie Conditions
            else if (array[1] != '1' && array[2] != '2' && array[3] != '3' && array[4] != '4' && array[5] != '5' && array[6] != '6' && array[7] != '7' && array[8] != '8' && array[9] != '9')
            {
                return -1;
            }
            #endregion

            else
            {
                return 0;
            }
        }
    }
}