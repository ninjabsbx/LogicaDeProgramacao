using System.Globalization;

double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 
int percentual;
int reajuste;

if (salario > 0.00 && salario <= 400.00)
{
    percentual = 15;
}
else if (salario > 400.00 && salario <= 800.00)
{
    percentual = 12;
}
else if (salario > 800.00 && salario <= 1200.00)
{
    percentual = 10;
}
else if (salario > 1200.00 && salario <= 1800.00)
{
    percentual = 7;
}
else 
{
    percentual = 4;
}
reajuste = (int)(salario * percentual / 100.00);
Console.WriteLine("Novo salario:" + (salario + reajuste).ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("Reajuste ganho:" + reajuste.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("Em percentual: " + percentual + "%");




