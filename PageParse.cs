using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace PaulsURLPageReader
{
   class PageParse
    {
    
        public string readPage(String url)
        {
                            
            //Set up request
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            Stream pageStream = response.GetResponseStream();
            
            // read stream
            StreamReader sr = new StreamReader(pageStream);

            // save stream to single string
            string pageStr = sr.ReadToEnd();
            
            //send string back to form
            return pageStr;
    
        }

      }


}
