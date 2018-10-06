using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser.Tools
{
   public class Parse
   {
        private HtmlWeb web;
        private string siteadi;
        public Parse()
        {
            web = new HtmlWeb();
        }
        public string[] Dolar()
        {
            siteadi = @"http://bigpara.hurriyet.com.tr/doviz/dolar/";
            string[] dizi = new string[3];
            var site = web.Load(siteadi);
            var documenta = site.DocumentNode.SelectSingleNode("//span[@class='value dw']").InnerText;
            dizi[0] = documenta;
            var documents = site.DocumentNode.SelectSingleNode("//span[@class='value up']").InnerText;
            dizi[1] = documents;
            var documentk = site.DocumentNode.SelectSingleNode("//span[@class='text2']").InnerText;
            dizi[2] = documentk;
            return dizi;
           
        }
        public string[] Euro()
        {
            siteadi = @"http://bigpara.hurriyet.com.tr/doviz/euro/";
            string[] dizi = new string[3];
            var site = web.Load(siteadi);
            var documenta = site.DocumentNode.SelectSingleNode("//span[@class='value dw']").InnerText;
            dizi[0] = documenta;
            var documents = site.DocumentNode.SelectSingleNode("//span[@class='value up']").InnerText;
            dizi[1] = documents;
            var documentk = site.DocumentNode.SelectSingleNode("//span[@class='text2']").InnerText;
            dizi[2] = documentk;
            return dizi;

        }
   }
}
