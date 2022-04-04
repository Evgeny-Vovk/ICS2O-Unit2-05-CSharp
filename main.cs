// Created by: Evgeny
// Created on: Mar 2022
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
      //input
        int length;
        int width;

        Console.WriteLine("This program finds the area and perimeter of a rectangle.");
        Console.WriteLine("");

        Console.Write("Enter the length(mm): ");
        length = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the width(mm): ");
        width = Convert.ToInt32(Console.ReadLine());

      //process
        int area = (length * width);
        int perimeter = 2 * (length + width);

      //output
        Console.WriteLine("");
        Console.WriteLine("The area is: " + area + "mm².");
        Console.WriteLine("The perimeter is: " + perimeter + "mm.");

        Console.WriteLine("\nDone.");
  }
}