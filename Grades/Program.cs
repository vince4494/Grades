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
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            //computing stats on the gradebook
            GradeStatistics stats = book.ComputeStatistics();

            Console.WriteLine("This is the average grade: " + stats.AverageGrade);
            Console.WriteLine("This is the highest grade: " + stats.HighestGrade);
            Console.WriteLine("This is the lowest grade: " + stats.LowestGrade);

           

        }
    }

    
}
