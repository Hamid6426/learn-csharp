﻿using System;

namespace PersonalInfoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 25;
            string name = "Hamid";
            double height = 6;
            bool isStudent = false;
            char grade = 'B';

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Height: " + height + " feet");
            Console.WriteLine("Is Student: " + isStudent);
            Console.WriteLine("Grade: " + grade);
        }
    }
}