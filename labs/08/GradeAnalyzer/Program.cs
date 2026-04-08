/*
 * File: Program.cs
 * Purpose: Provides statistical analysis tools for student grade data
 * Author: Hamid
 * Created: 2025-04-08
 * Last Modified: 2025-04-08
 * 
 * Description: Provides statistical analysis tools for student grade data using System.Collections.Generic and System.Linq
 * 
 * Dependencies: 
 * - System.Collections.Generic for managing grade data
 * - System.Linq for statistical calculations
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace GradeAnalyzer
{
    /// <summary>
    /// Calculates statistical analysis tools for student grade data
    /// </summary>
    public class GradeStatistics
    {
        private List<double> grades;

        /// <summary>
        /// Initializes a new instance of the GradeStatistics class
        /// </summary>
        /// <returns>A new instance of the GradeStatistics class</returns>
        public GradeStatistics()
        {
            grades = new List<double>();
        }

        /// <summary>
        /// Adds a grade to the list of grades
        /// </summary>
        /// <param name="grade">The grade to add</param>
        /// <returns>The grade to add</returns>
        public void AddGrade(double grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                grades.Add(grade);
            }
        }

        /// <summary>
        /// Calculates the average of the grades
        /// </summary>
        /// <returns>The average of the grades</returns>
        public double CalculateAverage()
        {
            if (grades.Count == 0) return 0;
            return grades.Sum() / grades.Count;
        }

        /// <summary>
        /// Calculates the standard deviation of the grades
        /// </summary>
        /// <returns>The standard deviation of the grades</returns>
        /// <remarks>
        /// Uses the formula: sqrt(Σ(x-μ)²/(n-1))
        /// where:
        /// - x is the grade
        /// - μ is the average of the grades
        /// - n is the number of grades
        /// - Σ is the sum of the squared deviations
        /// </remarks>
        public double CalculateStandardDeviation()
        {
            if (grades.Count <= 1) return 0;

            double average = CalculateAverage();
            double sumOfSquaredDeviations = 0;

            foreach (double grade in grades)
            {
                double deviation = grade - average;
                sumOfSquaredDeviations += deviation * deviation;
            }

            return Math.Sqrt(sumOfSquaredDeviations / (grades.Count - 1));
        }

        /// <summary>
        /// Generates a grade distribution report
        /// </summary>
        /// <returns>A grade distribution report</returns>
        public string GenerateGradeDistribution()
        {
            if (grades.Count == 0) return "No grades available";

            int aCount = grades.Count(g => g >= 90);
            int bCount = grades.Count(g => g >= 80 && g < 90);
            int cCount = grades.Count(g => g >= 70 && g < 80);
            int dCount = grades.Count(g => g >= 60 && g < 70);
            int fCount = grades.Count(g => g < 60);

            return $"Grade Distribution:\nA: {aCount}\nB: {bCount}\nC: {cCount}\nD: {dCount}\nF: {fCount}";
        }

        /// <summary>
        /// Gets the grades above the average
        /// </summary>
        /// <returns>A list of grades above the average</returns>
        public List<double> GetGradesAboveAverage()
        {
            double average = CalculateAverage();
            return grades.Where(g => g > average).ToList();
        }
    }

    /// <summary>
    /// Main class for the GradeAnalyzer program
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Entry point: builds sample grade data, prints statistics, distribution, and grades above average.
        /// </summary>
        /// <param name="args">Unused command-line arguments.</param>
        public static void Main(string[] args)
        {
            GradeStatistics stats = new GradeStatistics();

            stats.AddGrade(95);
            stats.AddGrade(87);
            stats.AddGrade(92);
            stats.AddGrade(78);
            stats.AddGrade(85);
            stats.AddGrade(91);
            stats.AddGrade(88);

            Console.WriteLine($"Average: {stats.CalculateAverage():F2}");
            Console.WriteLine($"Standard Deviation: {stats.CalculateStandardDeviation():F2}");
            Console.WriteLine(stats.GenerateGradeDistribution());

            var aboveAverage = stats.GetGradesAboveAverage();
            Console.WriteLine($"Grades above average: {string.Join(", ", aboveAverage)}");
        }
    }
}