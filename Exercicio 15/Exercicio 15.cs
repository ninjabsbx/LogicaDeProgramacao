using System.ComponentModel.Design;
using System.Globalization;

int i , par = 0, impar = 0, positivo = 0, negativo = 0;
Console.WriteLine("Entre com 5 valores:");

for (int n = 0; n < 5; n++)
{
    i = int.Parse(Console.ReadLine());
    if (i > 0)
    {
        positivo++;
    }
    else if (i < 0)
    {
        negativo++;
    }

    if (i % 2 == 0)
    {
        par++;
    }
    else
    {
        impar++;
    }
}
Console.WriteLine(par + (" valor(es) par(es)."));
Console.WriteLine(impar + (" valor(es) impar(es)."));
Console.WriteLine(positivo + (" valor(es) positivo(s)."));
Console.WriteLine(negativo + (" valor(es) negativo(s)."));
