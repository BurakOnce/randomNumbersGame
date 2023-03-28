using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Burak Önce @burakonce9.gmail.com

namespace randomNumbersGame

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cash=5;         
            int howMany=0;
            int[] numbers = new int[50];        
            Random rnd = new Random();

            

            Console.WriteLine("Welcome to Random Numbers Game");
            Console.WriteLine("Cash is " + cash + " $");
            Console.WriteLine("\nThe game begins where you will find a number in a randomly generated sequence containing numbers up to 50");
            Console.WriteLine("There are some rules");
            Console.WriteLine("if the number you guess is not in our numbers you lost your bet ");
            Console.WriteLine("if the number you guess is 1 time for our numbers you save your cash ");
            Console.WriteLine("if the number you guess is 1 more time for our numbers you earn 3x your bet");

            while (cash > 0) 
            {
                for (int i = 0; i < numbers.Length; i++) //random values for array elements
                {
                    int randomNumber = rnd.Next(0, 50);
                    numbers[i] = randomNumber;
                }


                Console.WriteLine("\ndecide your bet");
                int bet = Convert.ToInt32(Console.ReadLine()); //decide bet
                if(bet > cash) { Console.WriteLine("You don't have that cash "); } 

                else 
                { 

            
                    Console.WriteLine("\nWhat is your guess? ");
                    int guess=Convert.ToInt32(Console.ReadLine());    //for guess

                    for (int i = 0; i < numbers.Length; i++) //search for guess from array
                    {
                        if(numbers[i] == guess)
                        howMany++;             
                    }

                        if (howMany == 0) 
                        {
                        Console.WriteLine("Your guess is not in our numbers");
                        cash = cash-bet;
                        Console.WriteLine("New cash "+cash+" $");
               
                        }
                        else if(howMany == 1)
                        { 
                            Console.WriteLine("Your guess is in our numbers for " + howMany + " time");
                            Console.WriteLine("Cash is note changed");
                        } 

                        else if (howMany > 1)
                        {
                            Console.WriteLine("Your guess is in our numbers for " + howMany + " time");
                            cash=cash+3*bet;
                            Console.WriteLine("New cash " + cash+" $");              
                        }

                            if (cash <= 0) 
                            { 
                                Console.WriteLine("\nYou have no cash\nbyeee");
                                Console.ReadLine();
                            }
                }

                howMany= 0;
            }
        }
    }
}
