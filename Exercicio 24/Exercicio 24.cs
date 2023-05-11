int X = int.Parse(Console.ReadLine());
if (X > 1000 || X < 1)
{
    Console.WriteLine("Erro valor deve entre 1 e 1000");
}
else
{
    for (int n = 1; n <= X; n += 1)
    {
        Console.WriteLine(n + " " + n * n + " " + n * n * n);
    }
} 