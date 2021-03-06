﻿using Grades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Grades.Tests
{
    [TestClass]
    public class GradeBookTests
    {
        [TestMethod]
        public void ComputesHighestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(10);
            book.AddGrade(90);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(90, result.HighestGrade);
          
        }

        [TestMethod]
        public void ComputeLowestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(25);
            book.AddGrade(85);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(25, result.LowestGrade);
        }

        [TestMethod]
        public void ComputeAverageGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(85.16, result.AverageGrade, 0.01);

        }

        [TestMethod]
        public void ComputeLetterGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual("B", result.LetterGrade);

        }

        [TestMethod]
        public void CorrectDescription()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual("Good: ", result.Description);

        }

        [TestMethod]
        public void GradeBookNameIsNotANumber()
        {  
            GradeBook book = new GradeBook();
            book.Name = "Vince";

            //checks to make sure the book name does not have any numbers in it
            Assert.IsTrue(Regex.IsMatch(book.Name, @"^[a-zA-Z]+$"));

        }
    }
}
