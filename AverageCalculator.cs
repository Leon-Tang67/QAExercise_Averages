
internal class AverageCalculator
{
    internal void AveragesWithDoWhile()
    {
        
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
            Console.WriteLine($"The average of those numbers is {total / count}");
        }

    }
}