using System;

namespace DiceRollingSimulator
{
    public class DiceRoller
    {
        private Random random = new Random();

        public int[] RollDice(int numberOfRolls) // Number received from first class
        {
            int[] count = new int[11]; // Array to store roll totals (2-12)

            for (int i = 0; i < numberOfRolls; i++)
            {
                int rollOne = random.Next(1, 7); // Counts from 1-6
                int rollTwo = random.Next(1, 7);
                int sum = rollOne + rollTwo;
                count[sum - 2]++; // Keeps track of how many times a number is rolled
            }

            return count; // returns count back to first class
        }
    }
}
