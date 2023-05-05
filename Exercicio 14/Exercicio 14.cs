using System.Globalization;

int count = 0;

for (int i = 0; i < 6; i++)
{
    double N = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    if(N > 0)
    {
        count++;
    }

}
Console.WriteLine(count + " valores positivos");