using System;

namespace DiceRollingSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the dice throwing simulator!");

            Console.Write("How many dice rolls would you like to simulate? ");
            int numberOfRolls = int.Parse(Console.ReadLine()); // Converts input to integer and stores it

            DiceRoller roller = new DiceRoller();
            int[] results = roller.RollDice(numberOfRolls); // Passes number of rolls wanted to second class, and returns results array back to first class

            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
            Console.WriteLine("Total number of rolls = " + numberOfRolls + ".");

            for (int i = 2; i <= 12; i++)
            {
                Console.Write(i + ": "); // Prints labels for each roll total (2-12)
                int percentage = (int)((double)results[i - 2] / numberOfRolls * 100); // Calculates a percentage for each roll total
                Console.WriteLine(new String('*', percentage)); // Prints a '*' next the label for each percent
            }

            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
        }
    }
}
