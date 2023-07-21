using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Degiskennedir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FAKTORİYEL");
            Console.WriteLine("Faktoriyelini Almak İstediğiniz Sayıyı Giriniz:");
            int sayı = Convert.ToInt32(Console.ReadLine());
            int faktoriyel = 1;

                while (sayı>1)
            {   
                faktoriyel *= sayı;

                sayı--;

            }
            Console.WriteLine("Cevap:{0} Faktöriyeldir.", faktoriyel);
            Console.ReadKey();
        }  
      
    }

}

