using System;


namespace AlgorithmDesign.Forms
{
    public partial class Sum2String : BaseForm
    {
        public Sum2String()
        {
            InitializeComponent();
        }
        private void SumStrings(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = textBox1.Text.Trim();
                textBox2.Text = textBox2.Text.Trim();
                textBox3.Text = Addtwostring(textBox1.Text, textBox2.Text);
            }
            catch(Exception )  {System.Windows.Forms.MessageBox.Show(@"خطا");}
        }

        private string Addtwostring(string u, string v)
        {
            string total = "";
            int minLength = u.Length <= v.Length ? u.Length : v.Length;
            int maxLength = u.Length >= v.Length ? u.Length : v.Length;
            
            if (u.Length == minLength)
                for (int i = 0; i < maxLength - minLength; i++) u = "0" + u;
            else
                for (int i = 0; i < maxLength - minLength; i++) v = "0" + v;


            for (int i = 0; i < maxLength; i++)
                total = (int.Parse(u[u.Length - 1 - i].ToString()) + int.Parse(v[v.Length - 1 - i].ToString())) + total;

            return total;
        }

    }
}
