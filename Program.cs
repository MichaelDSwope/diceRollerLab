using System;
using System.Net.Security;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;

using System;

namespace diceRollTwo
{
    class Program
    {
        static void Main(string[] args)
        {

            string playerName;

            Console.WriteLine(" Hello welcome to the Grand Circus Casino! \n");
            Console.WriteLine(" What is your name player? \n\t ");
            playerName = Console.ReadLine();


            Console.WriteLine($"  {playerName}  Please choose how many sides for a pair dice you would like. \n \n");
            int numberOfSides = 0;
            string userInput = Console.ReadLine();
            int.TryParse(userInput, out numberOfSides);


            //enter message if needed.
            Random random = new Random();
            Console.WriteLine($"{playerName} Please press any key to roll {playerName}! \n");
            Console.ReadKey();


            int diceRoll;

            int playerNum_1;
            int playerNum_2;

            int dice_1 = 0;
            int dice_2 = 0;

            string userInput1;

            string wantCrapsReroll;
            string KeepRunningDiceRoller;


            for (int i = 0; i <= numberOfSides; i++)
            {
                int firstRoll = random.Next(1, numberOfSides);
                int secondRoll = random.Next(1, numberOfSides);



                int playerRandNum;
                Random rand = new Random();

                int dice1 = rand.Next(1, numberOfSides);
                int dice2 = rand.Next(1, numberOfSides);

                dice_1 = firstRoll;
                dice_2 = secondRoll;

                Console.WriteLine($"\n {playerName} you rolled a {firstRoll} and {secondRoll}.");

                if (dice_1 == 1 && dice_2 == 1)
                {
                    Console.WriteLine("Snake Eyes:");//Snake Eyes: Two 1s
                    break;
                }
                if (dice_1 == 1 && dice_1 == 2 || dice_2 == 2 && dice_2 == 1)
                {
                    Console.WriteLine("Ace Deuce:");//Ace Deuce: A 1 and 2
                    break;
                }
                if (dice_1 == 5 && dice_2 == 5 || dice_1 == 6 && dice_2 == 4 || dice_1 == 4 && dice_2 == 6)
                {
                    Console.WriteLine("Dragon Eggs:");
                    break;
                }
                if (dice_1 == 2 && dice_2 == 2)
                {
                    Console.WriteLine("Killer Rabbit:");
                    break;
                }
                if (dice_1 == 3 && dice_2 == 3)
                {
                    Console.WriteLine("Triforce:");
                    break;
                }
                if (dice_1 == 4 && dice_2 == 4 || dice_1 == 6 && dice_2 == 2 || dice_1 == 2 && dice_2 == 6 || dice_1 == 5 && dice_2 == 3 || dice_1 == 3 && dice_2 == 5 || dice_1 == 7 && dice_2 == 1 || dice_1 == 1 && dice_2 == 7)
                {
                    Console.WriteLine("Tanks:");
                    break;
                }
                if (dice_1 == 6 && dice_2 == 6)
                {
                    Console.WriteLine("Box Cars:");//Box Cars: Two 6s
                    break;
                }
                if (dice_1 == 5 && dice_2 == 2 || dice_1 == 2 && dice_2 == 5 || dice_1 == 6 && dice_2 == 1 || dice_1 == 1 && dice_2 == 6)
                {
                    Console.WriteLine(" ");
                }
                if (dice_1 == 5 && dice_2 == 2 || dice_1 == 2 && dice_2 == 5 || dice_1 == 7 && dice_2 == 4 || dice_1 == 4 && dice_2 == 7)
                {
                    Console.WriteLine("Win:");  //Win: A total of 7 or 11
                    break;
                }
                if (dice_1 == 2 && dice_1 == 1 || dice_1 == 2 && dice_2 == 1 || dice_1 == 1 && dice_2 == 1 || dice_1 == 6 && dice_2 == 5 || dice_1 == 5 && dice_2 == 6)
                {
                    Console.WriteLine("Craps:");
                    {

                        Console.Write($"{playerName} You hit Craps! Would you like to reroll? :   y / n   \n");
                        userInput1 = Console.ReadLine();

                        if (userInput1 == "y")
                        {
                            Console.WriteLine("reroll. ");

                        }
                        if (userInput1 == "n")
                        {
                            Console.WriteLine("Good Bye!");

                        }
                        else
                        {
                            Console.WriteLine("invalid entry. please confirm reroll. y or n ");
                            break;
                        }
                    }

                }
                else
                {
                    Console.WriteLine(" ");
                }

            }




        }


    }


}
