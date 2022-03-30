// Created by: Kenny Le
// Created on: Mar 2022
//
// This program does finds the area of a trapezoid

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function calculates the area of a triangle
        double baseAOfTrapezoid;
        double baseBOfTrapezoid;
        double heightOfTrapezoid;
        double area;

        // input
        Console.WriteLine("This program calculates the area of a trapezoid.");
        Console.WriteLine("");
        Console.WriteLine("The formula is: A = [(a + b) / 2] x h");
        Console.WriteLine("");
        Console.WriteLine("Please enter the measurements (cm).");

        Console.WriteLine("");
        Console.Write("Input the measurement for base a: ");
        baseAOfTrapezoid = Convert.ToDouble(Console.ReadLine());
        Console.Write("Input the measurement for base b: ");
        baseBOfTrapezoid = Convert.ToDouble(Console.ReadLine());
        Console.Write("Input the measurement for the height: ");
        heightOfTrapezoid = Convert.ToDouble(Console.ReadLine());

        // process
        Console.WriteLine("");
        area = ((baseAOfTrapezoid + baseBOfTrapezoid) / 2) * heightOfTrapezoid;

        // output
        Console.WriteLine("The area is of the trapezoid is: " + area.ToString("0.00") + " " + "cm².");

        Console.WriteLine("\nDone.");
    }
}