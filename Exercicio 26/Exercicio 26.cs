int x ;


x = int.Parse(Console.ReadLine());
if (x > 0 )
{
    
    for (int i = 1; i <= x; i++)
    {

        if (x % i == 0)
        {
            Console.WriteLine(i);

        }
    }
}