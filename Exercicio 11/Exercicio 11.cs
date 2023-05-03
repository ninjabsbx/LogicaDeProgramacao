string[] valores = Console.ReadLine().Split(' ');
int inicio = int.Parse(valores[0]);
int final = int.Parse(valores[1]);
int duracao = 0;

if (inicio >= final)
{
    duracao = (24 + final) - inicio;
}

else
{
    duracao = (final - inicio);
}
Console.WriteLine("O JOGO DUROU  " + duracao +   "HORA(S)");