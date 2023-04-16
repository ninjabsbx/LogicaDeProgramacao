Console.WriteLine("Cálculo da área do círculo. Entre com o raio:");
double pi = 3.14159, R, A;
R = Double.Parse(Console.ReadLine());
A = pi * R * R;
Console.WriteLine("A = " + A.ToString("F4"));
// referência: https://learn.microsoft.com/pt-br/dotnet/api/system.double.tostring?view=net-7.0
