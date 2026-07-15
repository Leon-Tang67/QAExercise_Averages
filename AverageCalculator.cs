
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