using System.ComponentModel.Design;
using System.Net.Http.Headers;

int cont = 0;
int soma = 0;
int idade = 0;
while (true)
{
    idade = int.Parse(Console.ReadLine());

    if (idade >= 0)
    {
        soma += idade;
        cont++;
    }
    else break;

}
double media = (double) soma / cont;

Console.WriteLine( media.ToString("F2"));
