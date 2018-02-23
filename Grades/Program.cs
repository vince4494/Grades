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

            book.NameChanged += OnNameChanged;
         
            

            book.Name = "Vince's Gradebook";
            book.Name = "Grade book";

            //ignored since our property accounts for this condition
            book.Name = null;

            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            //computing stats on the gradebook
            GradeStatistics stats = book.ComputeStatistics();

            Console.WriteLine(book.Name);
            WriteResults("This is the average grade: ", stats.AverageGrade);
            WriteResults("This is the highest grade: ", (int)stats.HighestGrade);
            WriteResults("This is the lowest grade: ", stats.LowestGrade); 

        }

        static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine($"Grade book changing name from {args.ExistingName} to {args.NewName}");
        }


        //method overloading
        //one method takes an int while other takes a float
        static void WriteResults(string description, int result)
        {
            Console.WriteLine(description + result);
        }

        static void WriteResults(string description, float result)
        {
            Console.WriteLine("{0}{1}", description, result);
        }

    }

    
}
