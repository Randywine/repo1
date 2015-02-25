using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaulsURLPageReader
{
    public partial class Web_Text_Parser : Form
    {
        private const string URL = "http://en.wikipedia.org/wiki/List_of_sovereign_states";

        public Web_Text_Parser()
        {
            InitializeComponent();
            URLLabel.Text = URL;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PageParse pp = new PageParse();

            String pageAsString = pp.pageReader(URL);
            Display(pageAsString);
        }
        
        void Display(string s)
        {
            ParsedWebStringBox.Text = s;
        }

     
    }
}
