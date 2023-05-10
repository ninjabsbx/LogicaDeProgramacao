using System;
using System.Globalization;
using System.Xml.Schema;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
           

            int coelhos = 0 ;
            int ratos = 0;
            int sapos = 0;

            for (int i = 0; i < n; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                int quantia = int.Parse(valores[0]);
                char tipo = char.Parse(valores[1]);

                if (tipo == 'C')
                {
                    coelhos += quantia;
                }
                else if (tipo == 'R')
                {
                    ratos += quantia;
                }
                else if (tipo == 'S')
                {
                    sapos += quantia;
                }
            }

            int total = ratos + sapos + coelhos ;
            //ultimas linhas de valores
            Console.WriteLine("Total: " + total +" cobaias");
            Console.WriteLine("Total de coelhos: " + coelhos);
            Console.WriteLine("Total de ratos: " + ratos);
            Console.WriteLine("Total de sapos: " + sapos); 
            double porcetagemCoelhos = (double)coelhos / total * 100.0;
            double porcetagemRatos = (double)ratos / total * 100.0;
            double porcetagemSapos = (double)sapos / total * 100.0;
            
           

            //ultimas linhas da porcentagens
            Console.WriteLine("Percentual dos coelhos: " + porcetagemCoelhos.ToString("F2") + " % ");
            Console.WriteLine("Percentual dos ratos: " + porcetagemRatos.ToString("F2") + " % ");
            Console.WriteLine("Percentual dos sapos: " + porcetagemSapos.ToString("F2") + " % ");
        }
    }
}
