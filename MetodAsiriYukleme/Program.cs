using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodAsiriYukleme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ToplamaIslemi ti  = new ToplamaIslemi();
            Console.WriteLine(ti.Topla(2,5));
            Console.WriteLine("♥♥♥♥♥♥♥♥♥♥♥");
            Console.WriteLine(ti.Topla(3.3,5.1));
            Console.WriteLine("♥♥♥♥♥♥♥♥♥♥♥");
            Console.WriteLine(ti.Topla("Başla yavrm ",  "loo"));
            Console.WriteLine("♥♥♥♥♥♥♥♥♥♥♥");
            Console.WriteLine(ti.Topla(3, 8, 3, 7, 12, 33, 11, 4));

        }
    }
    class ToplamaIslemi
    {
        public int Topla(int a,int b)
        {
            Console.WriteLine("int parametreli metot çağırılıyor");
            return a + b;
        }
        public int Topla(params int[] sayilar) 
        {
            Console.WriteLine("params parametreli metot gel la buraya");
            int toplam  = 0;
            foreach(var s in sayilar)
            {
                toplam+=s;
            }
            return toplam;
        }
        public double Topla(double a,double b)
        {
            Console.WriteLine("double parametreli gel la buraya");
            return a + b;
        }
        public string Topla(string a,string b) 
        {
            Console.WriteLine("string parametreli gel la buraya");
            return a + b;
        }
    }
}
