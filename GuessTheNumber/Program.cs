/*
Napisz grę typu zgadywanka.
Program losuje liczbę od 0-10 i trzeba ją zgadnąć.
Program informuje czy podana liczba jest za duża, czy za mała.
A na końcu daje info w ilu krokach udało się ją zgadnąć.
Jak potrafisz to wrzuć na githuba.
*/

using System;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int steps = 0;
            Random randomNum = new Random();
            int winningNum = randomNum.Next(0, 10);
            int guess = -1;

            Console.WriteLine("The Greatest Guess the Number Game of All Time.\nYour goal is to guess the number from 0 to 10.\nThe game will give you a hint if you fail to guess.");

            while (guess != winningNum)
            {
                if (steps > 0)
                {
                    if (guess > winningNum)
                    {
                        Console.WriteLine("Incorrect guess! Your number was too high! Try again.");
                    }
                    else if (guess < winningNum)
                    {
                        Console.WriteLine("Incorrect guess! Your number was too low! Try again.");
                    }
                }
                Console.Write("Guess the number: ");
                guess = Convert.ToInt32(Console.ReadLine());
                steps++;
            }
            Console.WriteLine("You won the game!\nIt took you " + steps + " guess(es) to win this time.");

            Console.ReadLine();
        }
    }
}