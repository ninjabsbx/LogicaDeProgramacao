int N = int.Parse(Console.ReadLine());
int fatorial = 1;
if (N < 0)
{
    Console.Write("Erro! Nao pode ter numero negativo");
}
 if (N == 0 || N == 1) {
     Console.WriteLine("Fatorial e 1. ");
}
else
{
    for (int i = N; i > 1; i--)
        fatorial = fatorial * i;
    Console.WriteLine("Fatorial e " + fatorial);
}


