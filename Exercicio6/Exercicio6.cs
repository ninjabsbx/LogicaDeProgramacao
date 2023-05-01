using System.Net;

string line;
StreamReader sr = new StreamReader("compras.txt");
line = sr.ReadLine();
decimal total = 0;
while (line != null)
{
    string[] fields = line.Split(' ');
    int codigo = int.Parse(fields[0]), quantidade = int.Parse(fields[1]);
    decimal preco = decimal.Parse(fields[2]);
    total += quantidade * preco;
    //System.Console.WriteLine($"PRODUTO - codigo: {codigo} - quantidade: {quantidade} - preco: {preco} - total: {total}");
    line = sr.ReadLine();
}
sr.Close();
System.Console.WriteLine($"VALOR A PAGAR: R$ {total.ToString("F2")}");
