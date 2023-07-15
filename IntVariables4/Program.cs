using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntVariables4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden girilen 2 sayiya aritmetik işlem uygulayan kodu yazınız.
            int sayi1, sayi2,toplam,fark,carpim,bolum;
            Console.WriteLine("Lütfen iki sayidan birincisini girin : ");
            Console.WriteLine();
            sayi1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Lütfen iki sayidan ikincisini girin : ");
            Console.WriteLine();
            sayi2 = Convert.ToInt16(Console.ReadLine());
            toplam = sayi1 + sayi2;
            fark = sayi1 - sayi2;
            carpim = sayi1 * sayi2;
            bolum = sayi1 / sayi2;
            Console.WriteLine();
            Console.WriteLine("Girmis oldugunuz sayilarin toplami : " + toplam);
            Console.WriteLine();
            Console.WriteLine("Girmis oldugunuz sayilarin farki : " + fark);
            Console.WriteLine();
            Console.WriteLine("Girmis oldugunuz sayilarin carpimi : " + carpim);
            Console.WriteLine();
            Console.WriteLine("Girmis oldugunuz sayilarin bolumu : " + bolum);

            Console.Read();
        }
    }
}
