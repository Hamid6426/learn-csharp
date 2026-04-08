/*
 * File: StudentGrade.cs
 * Purpose: Calculates final grades and converts numeric scores to letter grades
 * Author: Hanid
 * Created: 2025-04-08
 * 
 * Description: Implements standard academic grading calculations with
 * weighted assignment categories and institutional letter grade scale.
 */
using System;
namespace StudentGrade
{
    public class StudentGrade
    {
        /// <summary>
        /// Calculates the final weighted grade based on homework, midterm, and final exam scores.
        /// Uses the standard 30/30/40 weighting system where homework and midterm each count
        /// for 30% and the final exam counts for 40% of the total grade.
        /// </summary>
        /// <param name="homework">Homework average (0-100)</param>
        /// <param name="midterm">Midterm exam score (0-100)</param>
        /// <param name="final">Final exam score (0-100)</param>
        /// <returns>The calculated final grade as a weighted average</returns>
        public double CalculateFinalGrade(double homework, double midterm, double final)
        {
            // Apply institutional weighting: 30% homework, 30% midterm, 40% final
            double weightedHomework = homework * 0.30;
            double weightedMidterm = midterm * 0.30;
            double weightedFinal = final * 0.40;

            return weightedHomework + weightedMidterm + weightedFinal;
        }

        /// <summary>
        /// Converts a numeric grade to a letter grade using the standard academic scale.
        /// Follows the institution's 4.0 GPA scale with plus/minus designations.
        /// </summary>
        /// <param name="numericGrade">The numeric grade to convert (typically 0-100)</param>
        /// <returns>Letter grade string (A+ through F)</returns>
        public string GetLetterGrade(double numericGrade)
        {
            // Standard academic letter grade scale with plus/minus system
            if (numericGrade >= 97) return "A+";
            if (numericGrade >= 93) return "A";
            if (numericGrade >= 90) return "A-";
            if (numericGrade >= 87) return "B+";
            if (numericGrade >= 83) return "B";
            if (numericGrade >= 80) return "B-";
            if (numericGrade >= 77) return "C+";
            if (numericGrade >= 73) return "C";
            if (numericGrade >= 70) return "C-";
            if (numericGrade >= 67) return "D+";
            if (numericGrade >= 63) return "D";
            if (numericGrade >= 60) return "D-";
            return "F";
        }
    }
}