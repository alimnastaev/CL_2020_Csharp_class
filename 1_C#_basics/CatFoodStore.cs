using System;

public static class CatFoodStore
{
    static string Ask(string question)
    {
        Console.Write(question + " ");
        return Console.ReadLine();
    }

    static double Price(int quantity)
    {
        double pricePerUnite;
        if (quantity >= 100)
        {
            pricePerUnite = 1.5;
        }
        else if (quantity >= 50)
        {
            pricePerUnite = 1.55;
        }
        else
        {
            pricePerUnite = 2;
        }
        return quantity * pricePerUnite;
    }

    public static void Execute()
    {
        Console.WriteLine("Welcome to the cat food store!");
        string entry = Ask("How many cans are you ordering?");
        int number = int.Parse(entry);
        double total = Price(number);
        Console.WriteLine($"For {number} cans, your total is: ${total}");
    }
}
