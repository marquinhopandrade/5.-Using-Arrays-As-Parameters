﻿using System;

namespace _5._Using_Arrays_As_Parameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] studentsGrades = new int[] { 15, 13, 8, 12, 6 };
            double averageResult = GetAverage(studentsGrades);
            Console.WriteLine("The average is: {0}", averageResult);
            Console.ReadKey();
        }


        static double GetAverage(int[] gradesArray)
        {
            int size = gradesArray.Length;
            double average;
            int sum = 0;
            for (int i = 0; i < size; i++)
            {
                sum += gradesArray[i];
            }
            average = (double)sum / size;
            return average;
        }
    }
}
