using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {

            //adding grades to gradebook
            GradeBook book = new GradeBook();

           

            //ignored since our property accounts for this condition
            book.Name = null;

            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            //computing stats on the gradebook
            GradeStatistics stats = book.ComputeStatistics();

            Console.WriteLine(book.Name);
            WriteResults("This is the average grade: ", stats.AverageGrade);
            WriteResults("This is the highest grade: ", stats.HighestGrade);
            WriteResults("This is the lowest grade: ", stats.LowestGrade);
            WriteResults("Grade: ", stats.LetterGrade);

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
