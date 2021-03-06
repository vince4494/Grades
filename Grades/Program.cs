﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            IGradeTracker book = CreateGradeBook();

            GetBookName(book);
            AddGrades(book);
            SaveGradesToTxtFile(book);
            WriteAllResults(book);

        }

        private static IGradeTracker CreateGradeBook()
        {

            //adding grades to gradebook
            return new ThrowAwayGradeBook();
        }

        private static void WriteAllResults(IGradeTracker book)
        {
            //computing stats on the gradebook
            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine("\n");

            foreach(float grade in book)
            {
                Console.WriteLine(grade);
            }
      
            WriteResults("This is the average grade: ", stats.AverageGrade);
            WriteResults("This is the highest grade: ", stats.HighestGrade);
            WriteResults("This is the lowest grade: ", stats.LowestGrade);
            WriteResults(stats.Description, stats.LetterGrade);
        }

        private static void SaveGradesToTxtFile(IGradeTracker book)
        {
            //a using statement sets up a try/finally when compiled
            using (StreamWriter outputFile = File.CreateText("Grades.txt"))
            {
                book.WriteGrades(outputFile);
                outputFile.Close();
            }
        }

        private static void AddGrades(IGradeTracker book)
        {
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);
        }

        private static void GetBookName(IGradeTracker book)
        {
            try
            {
                Console.WriteLine("Enter a name: ");
                book.Name = Console.ReadLine();

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //method overloading since we want to return stats.LetterGrade and it is a string
        //C# compiler is smart enough to chose the correct method
        static void WriteResults(string description, string result)
        {
            Console.WriteLine("{0}{1}", description, result);
        }

        //method to print out results
        static void WriteResults(string description, float result)
        {
            Console.WriteLine("{0}{1}", description, result);
        }

    }

    
}
