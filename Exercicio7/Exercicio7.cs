Console.WriteLine("Calcula a volume da esfera. Entre com o raio:");
double pi = 3.14159, R, A;
R = Double.Parse(Console.ReadLine());
A = pi * R * R * R * 4 / 3;
Console.WriteLine("A = " + A.ToString("F4"));
