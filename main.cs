// Created by: Evgeny
// Created on: Mar 2022
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        const float TAX_RATE = 0.18F;
        float hours;
        float rate;
        double pay;
        double taxes;

        // input
        Console.WriteLine("This program finds the payment you should get.");
        Console.WriteLine("");

        Console.Write("Enter the hours worked: ");
        hours = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the hourly rate: ");
        rate = Convert.ToInt32(Console.ReadLine());

        // process
        pay = (hours * rate) * (1 - TAX_RATE);
        taxes = ((hours * rate) * TAX_RATE);

        //output
        Console.WriteLine("");
        Console.WriteLine("your pay will be: $" + pay.ToString("0.00") + ".");
        Console.WriteLine("The gevernment will take: $" + taxes.ToString("0.00") + ".");

        Console.WriteLine("\nDone.");
    }
}