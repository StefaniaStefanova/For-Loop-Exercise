﻿namespace For_Loop_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 10 == 7)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}