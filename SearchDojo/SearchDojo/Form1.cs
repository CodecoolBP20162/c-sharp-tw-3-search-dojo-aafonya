using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchDojo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string results = string.Join(@"\s", searching().ToArray());

            MatchesListBox.Text = results;
            //Console.WriteLine("Found '{0}' at position {1}",
            //match.Value, match.Index);
        }

        public List<string> searching()
        {
            List<string> matchList = new List<string>();

            string patternInput = PatternInputTextBox.Text;
            string pattern = "@" + '"' + patternInput + '"';
            string sentence = InputTextBox.Text;

            foreach (Match match in Regex.Matches(sentence, pattern))
            {
                matchList.Add(match.Value);
                matchList.Add(match.Index.ToString());
            }
            return matchList;              
        }
    }   
}
