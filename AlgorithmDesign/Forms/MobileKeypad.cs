using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmDesign.Forms
{
    public partial class MobileKeypad : BaseForm
    {
        /// <summary>
        /// declare variable
        /// </summary>
        private readonly Dictionary<char, int> _alphabetList = new Dictionary<char, int>();
        readonly List<char> _nineTop = new List<char>(9);
        readonly List<char> _result = new List<char>(35);
        int _uniqueCount;
        static readonly char[] Alphabet = { 'A', 'B', 'C', 'D', 'E', 'F',
                                                 'G', 'H', 'I', 'J', 'K',
                                                 'L', 'M', 'N', 'O', 'P', 
                                                 'Q', 'R', 'S', 'T', 'U',
                                                 'V', 'W', 'X', 'Y', 'Z'}; 

        public MobileKeypad()
        {
            InitializeComponent();
            FillAlphaList();
        }

        /// <summary>
        /// fill alphabetList with keys and corresponding values
        /// and fill other variable
        /// </summary>
        private void FillAlphaList()
        {
            foreach (char c in Alphabet)
                _alphabetList.Add(c, 0);

            for (int i = 0; i < _nineTop.Capacity; i++)
            {
                _nineTop.Add('0');
            }
            for (int i = 0; i < _result.Capacity; i++)
            {
                _result.Add('0');
            }
        }

        private void TxtInputTextChanged(object sender, EventArgs e)
        {
            if (txtInput.Text.Length > 0)
            {
                label7.Text = txtInput.TextLength.ToString();
                txtAlphabetize.Text = Alphabetize(txtInput.Text);
                UpdateAlphabetList(txtInput.Text);
                label1.Text = CountUnique().ToString();

                richTextBox1.Text = ShowAlphaList();

                Createkeypad();
                label3.Text = CalcTypingMethode(txtInput.Text);
                FillKeyPad();
            }
            else
                richTextBox1.Text = @"Keypad Counter";
        }

        /// <summary>
        /// show list of alphabetic dictionary with pressed count
        /// </summary>
        /// <returns></returns>
        private string ShowAlphaList()
        {
            return _alphabetList.Aggregate<KeyValuePair<char, int>, string>(null, 
                    (current, variable) => current + (variable.Key 
                    + "\t" + variable.Value + Environment.NewLine));
        }

        /// <summary>
        /// sort dictionary descending and return only sorted characters
        /// </summary>
        /// <returns></returns>
        private IEnumerable<char> SortDescByValue()
        {
            var items = from k in _alphabetList.Keys
                        orderby _alphabetList[k] descending
                        select k;
            return items;
        }

        /// <summary>
        /// create shortest keypad
        /// </summary>
        private void Createkeypad()
        {
            try
            {
                string result = null;
                var sortbyvalue = SortDescByValue().ToList();
                int counter = 0;

                switch (comboBox1.SelectedIndex)
                {
                    case 0:   // this algorithm create simple keypad
                        {
                            foreach (char c in sortbyvalue)
                            {
                                if (counter >= 9) break;
                                _nineTop[counter] = c;
                                counter++;
                            }
                        }
                        break;

                    case 1:   // in this algorithm create user friendly keypad for less than 9 unique
                        {
                            foreach (char c in sortbyvalue)
                            {
                                if (counter >= 9 || counter >= _uniqueCount) break;
                                _nineTop[counter] = c;
                                counter++;
                            }

                            if (_uniqueCount < 9)
                            {
                                int ratio = (sortbyvalue.Count + 1 - counter)/(9 - counter);
                                for (int i = counter + 1; counter < 9; i += ratio, counter++)
                                {
                                    _nineTop[counter] = sortbyvalue[i];
                                }
                            }
                        }
                        break;
                }
                _nineTop.Sort();

                counter = 0;
                foreach (char c in Alphabet)
                {
                    bool isTop = false;
                    for (int i = 0; i < _nineTop.Capacity; i++) // _nineTop.Capacity
                        if (_nineTop[i] == c)
                        {
                            isTop = true;
                            break;
                        }

                    if (isTop)
                    {
                        result += "\n" + c;
                        _result[counter] = '-';
                        counter++;
                    }
                    else
                        result += c;

                    _result[counter] = c;
                    counter++;
                }

                richTextBox2.Text = result;
                /*
                            string result2 = null;
                            foreach (char c in _result)
                            {
                                if (c == '-')
                                    result2 += Environment.NewLine;
                                else
                                    result2 += c.ToString() ;
                            }
                            richTextBox1.Text = result2;
                */
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show(@"خطا در ساختن کیبورد", @"خطا");
                return;
            }
        }
        /// <summary>
        /// fill 9 button with reltade keys
        /// </summary>
        private void FillKeyPad()
        {
            try
            {
                button1.Text = richTextBox2.Lines[0];
                button2.Text = richTextBox2.Lines[1];
                button3.Text = richTextBox2.Lines[2];
                button4.Text = richTextBox2.Lines[3];
                button5.Text = richTextBox2.Lines[4];
                button6.Text = richTextBox2.Lines[5];
                button7.Text = richTextBox2.Lines[6];
                button8.Text = richTextBox2.Lines[7];
                button9.Text = richTextBox2.Lines[8];
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show(@"خطا در پر کردن کیبورد", @"خطا");
                return;
            }
            
        }

        /// <summary>
        /// Alphabetize the characters in the string.
        /// </summary>
        public static string Alphabetize(string rawtxt)
        {
            // 1. Convert to char array.
            char[] a = rawtxt.ToUpper().ToCharArray();
            // 2. Sort letters.
            Array.Sort(a);
            // 3.Return modified string.
            return new string(a);
        }

        /// <summary>
        /// update alphabet dictionary
        /// </summary>
        /// <param name="rawtxt"></param>
        private void UpdateAlphabetList(string rawtxt)
        {
            foreach (char c in Alphabet)
                _alphabetList[c] = 0;

            foreach (char c in rawtxt.ToUpper())
            {
                if(_alphabetList.ContainsKey(c))
                    _alphabetList[c] += 1;
            }
        }

        /// <summary>
        /// calculate how user can press input srting
        /// </summary>
        /// <param name="rawtxt"></param>
        /// <returns>result</returns>
        private string CalcTypingMethode(string rawtxt)
        {
            try
            {
                string result = null;
                int totalpressCount = 0;
                foreach (char i in rawtxt.ToUpper())
                {
                    int lineCounter = 0;
                    int colCounter = 0;
                    foreach (char c in _result)
                    {
                        if (c == '-')
                        {
                            lineCounter++;
                            colCounter = 0;
                        }

                        if (i == c)
                        {
                            result += lineCounter + "(" + colCounter + "), ";
                            totalpressCount += colCounter;
                            break;
                        }
                        colCounter++;
                    }
                }
                label6.Text = @"for typing entered text by pressing the button you require " 
                    + totalpressCount +@" times";
                return result;
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show(@"خطا در محاسبه روش فشردن", @"خطا");
                return null;
            }
        }

        /// <summary>
        /// count unique input character in string
        /// </summary>
        /// <returns></returns>
        private int CountUnique()
        {
            _uniqueCount = Alphabet.Count(c => _alphabetList[c] > 0);
            return _uniqueCount;
        }

        /// <summary>
        /// remove first line of control if is blank
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RichTextBox2TextChanged(object sender, EventArgs e)
        {
            if (richTextBox2.Lines[0].Length == 0) richTextBox2.Text = richTextBox2.Text.Remove(0, 1);
        }

        private void RichTextBox1TextChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = txtInput.Text.Length > 0 ? ShowAlphaList() : @"Keypad Counter";
            if (txtInput.TextLength > 0)
            {
                if (_alphabetize)
                    richTextBox1.Text = ShowAlphaList();
                else
                {
                    var tmp = Sortbyvaluedesc();
                    string result = null;
                    int counter = 1;
                    foreach (KeyValuePair<char, int> pair in tmp)
                    {
                        result += counter + ".   " + pair.Key + "\t" + pair.Value + Environment.NewLine;
                        counter++;
                    }
                    richTextBox1.Text = result;
                }
            }
            else
                richTextBox1.Text = @"Keypad Counter";

        }

        /// <summary>
        /// sort dictionary descending
        /// </summary>
        /// <returns></returns>
        private IEnumerable<KeyValuePair<char, int>> Sortbyvaluedesc()
        {
            return _alphabetList.OrderByDescending(x => x.Value);
        }

        private bool _alphabetize = true;
        private void Label2Click(object sender, EventArgs e)
        {
            _alphabetize = !_alphabetize;
            RichTextBox1TextChanged(null, null);
        }

        private void MobileKeypadLoad(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 1;
        }

        private void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtInput.Text.Length > 0)
            {
                Createkeypad();
                label3.Text = CalcTypingMethode(txtInput.Text);
                FillKeyPad();
            }
        }
        
        //static int _keypadTick;
        private void KeypadtimerTick(object sender, EventArgs e)
        {

        }

        //----------------------------------   for timer   -------------------------------------//
        static int _index;
        private const string Authortxt =
            "This application created for algorithm Design by Javad Evazzadeh (87134100028)     ";
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
        //----------------------------------   for timer   -------------------------------------//

        private void PictureBox1Click(object sender, EventArgs e)
        {
            var strauthor = @"در ابتدا لازم به ذکر است که این برنامه پس از نوشتن الگوریتم اولیه"
                            + Environment.NewLine
                            + @"در حال ارتقاء می باشد که می توانید نسخه الگوریتم آن را از طریق"
                            + Environment.NewLine
                            + @"کمبو باکس پایین انتخاب نمایید"
                            + Environment.NewLine
                            + @"با مکس موس روی هر کنترل می توانید توضیح کوچکی درباره آن بخوانید"
                            + Environment.NewLine
                            + Environment.NewLine
                            + "در انتها درصورت هر گونه سوال با شماره 09357269759 و یا"
                            + Environment.NewLine
                            + "تماس برقرار نمایید J.Evazzadeh@gmail.com"
                            + Environment.NewLine
                            + "با تشکر، جواد عوض زاده کاکرودی";
            System.Windows.Forms.MessageBox.Show(strauthor, @"Javad Evazzadeh");
        }
    }
}
