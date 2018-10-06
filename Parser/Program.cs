using HtmlAgilityPack;
using Parser.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser
{
    class Program
    {
        public static void Secim()
        {
            Console.WriteLine("######Seçim Ekranı######");
            Console.WriteLine("Dolar için 1'e  basınız");
            Console.WriteLine("Euro  için 2'ye basınız");
            Console.WriteLine("Çıkış için 3'e  basınız");
            Console.WriteLine();
            var deger = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();
            if (deger == 1)
            {
                Dolar();
            }
           else if (deger == 2)
            {
                Euro();
            }
           else if (deger == 3)
            {
                Environment.Exit(0); 
            }
            else
            {
                Console.WriteLine("1'e 2'ye veya 3'e basınız.");
            }
           
            
          
        }
        public static void Dolar()
        {
            Parse getir = new Parse();
            string[] gelenler = new string[3];
            gelenler = getir.Dolar();
            Console.WriteLine("Dolar alış:" + gelenler[0]);
            Console.WriteLine("Dolar satış:" + gelenler[1]);
            Console.WriteLine("Dolar önceki kapanış:" + gelenler[2]);
            Console.WriteLine();
            
        }
        public static void Euro()
        {
            Parse getir = new Parse();
            string[] gelenler = new string[3];
            gelenler = getir.Euro();
            Console.WriteLine("Euro alış:" + gelenler[0]);
            Console.WriteLine("Euro satış:" + gelenler[1]);
            Console.WriteLine("Euro önceki kapanış:" + gelenler[2]);
            Console.WriteLine();

        }
        public static void Main(string[] args)
        {
            while (true)
            {
                Secim();
            }
            
           
        }
        
    }
}