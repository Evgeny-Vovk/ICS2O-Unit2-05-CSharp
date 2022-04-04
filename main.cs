// Created by: Evgeny
// Created on: Mar 2022
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        //input
        float hours;
        float rate;
      
        Console.WriteLine("This program finds the payment you should get.");
        Console.WriteLine("");

        Console.Write("Enter the hours worked: ");
        hours = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the hourly rate: 2");
        rate = Convert.ToInt32(Console.ReadLine());

        //process
        double pay  = (hours * rate) * (1 - 0.18) ;
        double taxes = ((hours * rate) * 0.18);

        //output
        Console.WriteLine("");
        Console.WriteLine("your pay will be: $" + pay.ToString("0.00") + ".");
        Console.WriteLine("The gevernment will take: $" + taxes.ToString("0.00") + ".");

        Console.WriteLine("\nDone.");
    }
}