// Created by: Timothy Manwell
// Created on: Nov 2022
//
// This program check calculates the cost of a cake order
using System;

class Program
{
    public static void Main(string[] args)
    {
        double price = 10.98;
        double tax = 1.13;
        double message = 3.99;
        double deliver = 15;
        string messageAnswer = null;
        string methodAnswer = null;

        Console.WriteLine("Welcome to the Yummy Yummy Bakery Calculator");
        Console.WriteLine("\nAnswer the following questions to find out the cost of your small chocolate cake.");
        Console.Write("\nDo you want a special message ('Yes' or 'No')? ");
        messageAnswer = Console.ReadLine();
        Console.Write("\nPick up or Delivery ('Pick Up' or 'Delivery')? ");
        methodAnswer = Console.ReadLine();

        if (messageAnswer == "Yes" && methodAnswer == "Delivery")
        {
            Console.Write("\nThe cost of your small chocolate cake is $" + ((price + message + deliver) * tax).ToString("0.00") + ".");
        }
        else if (messageAnswer == "No" && methodAnswer == "Delivery")
        {
            Console.Write("\nThe cost of your small chocolate cake is $" + ((price + deliver) * tax).ToString("0.00") + ".");
        }
        else if (messageAnswer == "Yes" && methodAnswer == "Pick Up")
        {
            Console.Write("\nThe cost of your small chocolate cake is $" + ((price + message) * tax).ToString("0.00") + ".");
        }
        else if (messageAnswer == "No" && methodAnswer == "Pick Up")
        {
            Console.Write("\nThe cost of your small chocolate cake is $" + (price * tax).ToString("0.00") + ".");
        }
        Console.Write("\nDone");
    }
}