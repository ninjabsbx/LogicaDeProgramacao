int i,  Alcool = 0, Gasolina = 0, Diesel = 0;
Console.WriteLine("Entre com o codigo do combustivel utilizado (1 - alcool, 2 - gasolina, 3 - diesel) ou 4 para sair");

while (true)
{
    i = int.Parse(Console.ReadLine());
    if (i == 1)
    {
        Alcool++;
    }
    else if (i == 2)
    {
        Gasolina++;
    }
    else if (i == 3)
    {
        Diesel++;
    }
    else if (i == 4) break;
}
Console.WriteLine();
Console.WriteLine("MUITO OBRIGADO");
Console.WriteLine("Alcool: " + Alcool);
Console.WriteLine("Gasolina: " + Gasolina);
Console.WriteLine("Diesel: " + Diesel);
 