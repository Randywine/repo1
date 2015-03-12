using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using HtmlAgilityPack;

namespace PaulsURLPageReader
{
    public partial class Web_Text_Parser : Form
    {
        private const string URL = "http://en.wikipedia.org/wiki/List_of_sovereign_states";

        public Web_Text_Parser()
        {
            InitializeComponent();
            tbURL.Text = URL;
        }

        private void btnGetPage_Click(object sender, EventArgs e)
        {
            PageParser pp = new PageParser();
            
            HtmlAgilityPack.HtmlDocument newDoc = pp.readPage(URL);

            //Saves the HTML docuemnt as a single string for simple display in text box
            String pageAsString = newDoc.DocumentNode.OuterHtml;
            
            // save string to file
            File.WriteAllText(@"PageText.txt", pageAsString);
            
            // send to form
            Display(pageAsString);

            //Now we have displayed the string we can work on parsing the text, we still have
            //the newDoc in memory so we call this and it should return a list object of
            //country names, without the HTML. 
           
            List<string> countryNames = new List<string>();
            countryNames = pp.parseCountryName(newDoc);

            Display(countryNames);
        }
        
        //Original display method which will take a string parameter and display it in the top box
        void Display(string s)
        {
            tbURLText.Text = s;
        }

        // Overlaod of display method which will take a List parameter and display in the bottom box
        void Display(List<string> cleanedCountryNames)
        {

            String countryNames ="";
            
            //Create sting and newlines from country names
            foreach (string item in cleanedCountryNames)
            {
                countryNames = countryNames + "\r\n" + item;

            }

            //Save to file
            File.WriteAllText(@"ParsedPageText.txt", countryNames);

            //display to bottom text box
            tbCountryNames.Text = countryNames;
        }



     
    }
}
