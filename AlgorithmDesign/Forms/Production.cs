using System;

namespace AlgorithmDesign.Forms
{
    public partial class FrmProduction : BaseForm
    {
        public FrmProduction()
        {
            InitializeComponent();
        }

        private void Checktxt(object sender, EventArgs e)
        {
            txtNum1.Text = txtNum1.Text.Trim();
            txtNum2.Text = txtNum2.Text.Trim();
            if (txtNum1.Text == "" || txtNum2.Text == "") return;
            txtResult.Text = Production(txtNum1.Text, txtNum2.Text);
        }

        private string Production(string u , string v)
        {
            try
            {
                if (u == "0" || v == "0") return "0";
                int m = Math.Max(u.Length, v.Length)/2;
                if (Math.Max(u.Length, v.Length) <= 1) return (Int32.Parse(u)*Int32.Parse(v)).ToString();

                string x = m >= u.Length ? "0" : (u.Substring(0, (u.Length - m)));
                string y = m >= u.Length ? u : u.Substring(u.Length - m);
                string z = m >= v.Length ? "0" : (v.Substring(0, (v.Length - m)));
                string w = m >= v.Length ? v : v.Substring(v.Length - m);

                return Sum2(Sum2(ProdString(Production(x, z), 2*m), Production(y, w)),
                                 ProdString(Sum2(Production(x, w), Production(y, z)), m));
            }
            catch (Exception)
            {
                txtNum1.Text = "";
                txtNum2.Text = "";
                return "Error! Please input correct number";
            }
        }

        private string Sum(string u, string v)
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

        private string ProdString(string num, int m )
        {
            if (num == "0") return "0";
            for (int i = 0; i < m; i++) num += "0";
            return num;
        }

        public string Sum2(string number1, string number2) //this sum by mohamad
        { 
            var str1 = ""; var str2 = ""; var str3 = ""; var str4 = ""; var x = 0;
            for (var i = number1.Length - 1; i >= 0; i--) str1 += number1.Substring(i, 1);
            for (var i = number2.Length - 1; i >= 0; i--) str2 += number2.Substring(i, 1);
            var j = str1.Length - str2.Length;
            if (j > 0) for (; j > 0; j--) str2 += "0"; if (j < 0) for (; j < 0; j++) str1 += "0";
            for (var i = 0; i < str1.Length; i++){
                var sum = Int32.Parse(str1.Substring(i, 1)) + Int32.Parse(str2.Substring(i, 1)) + x;
                if (sum >= 10) {x = 1;str3 += (sum % 10).ToString();} else {x = 0;str3 += sum.ToString();}
            }
            if (x == 1) str3 += x.ToString();
            for (var i = str3.Length - 1; i >= 0; i--) str4 += str3.Substring(i, 1);
            return str4;
        }
    }
}