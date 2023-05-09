String line;
StreamReader sr = new StreamReader("notas.txt");
line = sr.ReadLine();
decimal soma = 0;
int quantidade = 0;
while (line != null)
{
    decimal nota = decimal.Parse(line);
    if (nota < 0 || nota > 10 || decimal.Round(nota, 1) != nota)
    {
        Console.WriteLine("Nota Invalida");
    }
    else
    {
        soma += nota;
        quantidade += 1;
    }
    line = sr.ReadLine();
}
decimal media = soma / quantidade;
Console.WriteLine("MEDIA = " + media.ToString("F2")); 
sr.Close();

