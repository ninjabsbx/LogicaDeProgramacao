using System;

decimal A, B, C, MEDIA;
Console.WriteLine("Entre com a primeira nota. Deve ser um numero entre 0,0 e 10,0, com uma casa decimal.");
A = Decimal.Parse(Console.ReadLine());
if (A < 0 || A > 10 || decimal.Round(A, 1) != A)
{
    Console.WriteLine("Erro do formato. Deve ser um numero entre 0,0 e 10,0, com uma casa decimal.");
}
else
{
    Console.WriteLine("Entre com a segunda nota. Deve ser um numero entre 0,0 e 10,0, com uma casa decimal.");
    B = decimal.Parse(Console.ReadLine());
    if (B < 0 || B > 10 || decimal.Round(B, 1) != B)
    {
        Console.WriteLine("Erro do formato. Deve ser um numero entre 0,0 e 10,0, com uma casa decimal.");
    }
    else
    {
        Console.WriteLine("Entre com a terceira nota. Deve ser um numero entre 0,0 e 10,0, com uma casa decimal.");
        C = Decimal.Parse(Console.ReadLine());
        if (C < 0 || C > 10 || decimal.Round(C, 1) != C)
        {
            Console.WriteLine("Erro do formato. Deve ser um numero entre 0,0 e 10,0, com uma casa decimal.");
        }
        else
        {
            MEDIA = (A * (decimal)2 + B * (decimal)3 + C * (decimal)+5) / 10;

            Console.WriteLine("MEDIA = " + MEDIA.ToString("F5"));
        }
    }
}

        
    

    

     