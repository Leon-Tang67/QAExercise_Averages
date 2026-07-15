
internal class AverageCalculator
{
    internal void AveragesWithDoWhile()
    {
        double total = 0.0;
        int count = 0;
        Console.Write("Enter the first number, or Q to quit: ");
        string input = Console.ReadLine();
        do
        {
            total += double.Parse(input);
            count++;
            Console.Write("Enter another number, or Q to quit: ");
            input = Console.ReadLine();
        }
        while (input.ToUpper() != "Q") ;
        if (count == 0)
        {
            Console.WriteLine("You didn't enter any numbers");
        }
        else
        {
            Console.WriteLine($"The average of those numbers is {total / count}");
        }

    }

    internal void AveragesWithFor()
    {
        double total = 0.0;
        Console.WriteLine("How many numbers do you want to enter?");
        string input = Console.ReadLine();
        int number = int.Parse(input);
        for (int i = 0; i < number; i++)
        {
            Console.Write("Please input number you want to put into average calculation? ");
            string input2 = Console.ReadLine();
            total += double.Parse(input2);
        }
        Console.WriteLine($"The average of those numbers is {total / number}");
    }

    internal void AveragesWithWhile()
    {
        double total = 0.0;
        int count = 0;
        Console.Write("Enter the first number, or Q to quit: ");
        string input = Console.ReadLine();
        while (input.ToUpper() != "Q")
        {
            total += double.Parse(input);
            count++;
            Console.Write("Enter another number, or Q to quit: ");
            input = Console.ReadLine();
        }
        if (count == 0) 
        {
            Console.WriteLine("You didn't enter any numbers");
        }
        else
        {
            Console.WriteLine($"The average of those numbers is {total / count}");
        }
    }
}