using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmDesign.Forms
{
    public partial class SubSet : BaseForm
    {
        public SubSet()
        {
            InitializeComponent();
        }

        //------------------------------   Calculate SubSet Function   ---------------------------------//
        private String CalculateAllSubSet(string rawtxt)                                                //
        {
            // Initilizment
            string set = rawtxt;
            var subsets = new List<string>();

            // Loop over individual elements
            for (int i = 1; i < set.Length; i++)
            {
                subsets.Add(set[i - 1].ToString());
                
                var innerSubsets = subsets.Select(t => t + "," + set[i]).ToList();
                // Loop over existing subsets

                subsets.AddRange(innerSubsets);
            }

            // Add last element of set then sort subset
            subsets.Add(set[set.Length - 1].ToString());
            subsets.Sort();


            return string.Join("\n", subsets);
        }                                                                                               //
        //------------------------------   Calculate SubSet Function   ---------------------------------//

        //--------------------------------------   for timer   -----------------------------------------//
        static int _index;
        private const string Authortxt = 
            "This application created with out recursive algorithm by Javad Evazzadeh (87134100028)     ";
        private void AnimatedtimerTick(object sender, EventArgs e)
        {
            AuthorNote.Text = Authortxt.Substring(0, _index) + @"_";
            _index++;
            //Animatedtimer.Interval += 1;
            if (_index == Authortxt.Length + 1)
            {
                _index = 0;
                //Animatedtimer.Interval = 100;
                //timer1.Enabled = false;
            }
        }
        //--------------------------------------   for timer   -----------------------------------------//

        private void TextBox1TextChanged(object sender, EventArgs e)
        {
            if(txtset.Text.Length > 0 )
                richTextBox1.Text = CalculateAllSubSet(txtset.Text);
            else
                richTextBox1.Text = Environment.NewLine + Environment.NewLine + Environment.NewLine
                                  + Environment.NewLine + Environment.NewLine 
                                  + @"This RichTextbox show the subset of input sting";
        }
    }
}
