using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int CONSUMED_BY_WORKERS = 26;
            const int MINIMUM_SPICES_TO_GATHERE = 100;
            const int DAYLY_DECRESE = 10;
            


            
            int countOfSpices = int.Parse(Console.ReadLine());
            int totalConsumed = 0;
            int daysCounter = 0;

            while (countOfSpices >= MINIMUM_SPICES_TO_GATHERE)
            {
                totalConsumed += countOfSpices - CONSUMED_BY_WORKERS;
                countOfSpices -= DAYLY_DECRESE;
                daysCounter++;
                if (countOfSpices < MINIMUM_SPICES_TO_GATHERE)
                {
                    totalConsumed -= CONSUMED_BY_WORKERS;
                }
            }

            Console.WriteLine(daysCounter);
            Console.WriteLine(totalConsumed);
        }
    }
}