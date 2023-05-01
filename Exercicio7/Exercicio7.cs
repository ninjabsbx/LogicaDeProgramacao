Console.WriteLine("Calcule a area da circuferencia");
double pi = 3.14159, R, A;
R = Double.Parse(Console.ReadLine());
A = pi * R * R;
Console.WriteLine("A = " + A.ToString("F4"));