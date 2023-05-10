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
if (m % 2 == 0) m++; //X PAR ==> IMPAR SEGUINTE
int soma = 0;
for (; m < n; m += 2)
{
    soma += m+5;
}
Console.WriteLine(soma);



