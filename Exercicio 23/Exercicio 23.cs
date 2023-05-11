int X = int.Parse(Console.ReadLine());
int Y = int.Parse(Console.ReadLine());
int m, n;
if (X <= Y)
{
    m = X + 1;
    n = Y;
}
else
{
    m = Y + 1;
    n = X;
}
for (; m < n; m += 1)
{
    if (m % 5 == 2 || m % 5 == 3) 
        Console.WriteLine(m);
}
