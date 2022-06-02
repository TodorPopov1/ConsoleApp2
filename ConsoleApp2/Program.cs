﻿namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nlines = int.Parse(Console.ReadLine());

            double biggestKeg = double.MinValue;

            string biggestKegName = "";

            for (int i = 0; i < nlines; i++)
            {
                string model = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volumeOfTheCurrentKeg = Math.PI * Math.Pow(radius, 2) * height;

                if (volumeOfTheCurrentKeg > biggestKeg)
                {
                    biggestKeg = volumeOfTheCurrentKeg;
                    biggestKegName = model;
                }

                
            }

            Console.WriteLine(biggestKegName);
        }
    }
}