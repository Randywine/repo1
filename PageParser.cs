using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using HtmlAgilityPack;
using System.Text.RegularExpressions;


namespace PaulsURLPageReader
{
   class PageParser
    {
    
        public HtmlDocument readPage(String url)
        {
                 
            //New code, this fetches the page and saves the stream as a HTML document
            HtmlWeb page = new HtmlWeb();
            HtmlDocument newDoc = page.Load(url);

           //Sends the HML page back
            return newDoc;
            
        }

        public List<string> parseCountryName(HtmlDocument doc)
        {
            //Parses out the country name using HTMLAgilityPack
            //Apparently

            List<string> countryNames = new List<string>();
            List<string> cleanCountryNames = new List<string>();
           
            HtmlNodeCollection allNodes = doc.DocumentNode.SelectNodes("//td/b/a/@title");

            if (allNodes != null)
            {
                //change all nodes into strings and then add them to 
                //the list countrynames
                foreach (HtmlNode thisNode in allNodes)
                {
                    //String s = thisNode.InnerText;
                    String s = thisNode.WriteTo();
                    countryNames.Add(s);
                }

                //quick parse throughthe string list to remove all the html crap

                foreach (string item in countryNames)
                {
                    Regex tagRemove = new Regex(@"<.+?>");

                    String cleanedItem;

                    cleanedItem = tagRemove.Replace(item, string.Empty);
                    cleanCountryNames.Add(cleanedItem);
                    Console.Out.WriteLine(cleanedItem);

                                     
                }
            }

            return cleanCountryNames;


        }

      }


}
