using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of lines to read (1 < N < 1000): ");
        int n = int.Parse(Console.ReadLine());

        if (n <= 1 || n >= 1000)
        {
            Console.WriteLine("Invalid input. N must be between 1 and 1000.");
            return;
        }

        Console.WriteLine("Enter the {0} lines:", n);

        for (int i = 0; i < n; i++)
        {
            string line = Console.ReadLine();
            Console.WriteLine("Line {0}: {1}", i + 1, line);
        }
    }
}