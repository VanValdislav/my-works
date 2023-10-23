using System.Net;
using System.Text.RegularExpressions;
using System.Numerics;
using System;
using System.Linq;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public bool Zamena = false;
        public bool SizeForm = false;
        public string D = "";
        public string D_Buff = "";
        public string N1;
        public string N3;
        public bool N2;
        public string Function;
        public double result;
        public double BuffMod;
        public double BuffSt;
        public Form1()
        {
            N2 = false;
            InitializeComponent();
            Size_Form();
        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button22_Click_1(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            string textBox2Text = textBox2.Text;
            textBox2Text = textBox2Text.Replace("+", "");
            textBox2Text = textBox2Text.Replace("-", "");
            textBox2Text = textBox2Text.Replace("*", "");
            textBox2Text = textBox2Text.Replace("%", "");
            textBox2Text = textBox2Text.Replace("mod", "");
            textBox2Text = textBox2Text.Replace("^", "");

            if (textBox1.Text.Contains('='))
            {
                textBox1.Text = "";
                //D = "";
                N3 = "";
                D_Buff = "";
            }
            if (textBox2.Text.Contains("mod"))
            {
                string[] str = textBox2.Text.Split("mod");

                if (str[1] == "0")
                {
                    return;
                }
                textBox2.Text += B.Text;
                return;
            }
            if (textBox2.Text.Contains("^"))
            {
                string[] str = textBox2.Text.Split("^");
                if (str[1] == "0")
                {
                    return;
                }
                textBox2.Text += B.Text;
                return;
            }
            if (N2)
            {
                N2 = false;
                textBox2.Text = "0";
                Zamena = false;
                //startNewNumber = false;
                //textBox1.Text += D;
            }

            if (textBox2.Text == "0")
            {
                textBox2.Text = B.Text;
                //textBox1.Text = "";
                N3 = textBox2.Text;
                //textBox1.Text += B.Text;
            }
            else
            {
                textBox2.Text += B.Text;
                N3 = textBox2.Text;
                //textBox1.Text += B.Text;
                //startNewNumber = false;
            }
        }

        private void button20_Click_1(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            //////////////ERROR?????????????????
            ///
            if (textBox2.Text.EndsWith(","))
            {
                textBox2.Text = textBox2.Text.TrimEnd(',');
            }
            if (textBox2.Text.Contains("mod"))
            {
                //textBox2.Text = textBox2.Text.Replace("mod", "");

                string[] str = textBox2.Text.Split("mod");
                if (str[1] == "")
                {
                    textBox2.Text = textBox2.Text.Replace("mod", "");
                }
                else
                {
                    button24_Click(sender, e);
                }
            }
            if (textBox2.Text.Contains("^"))
            {
                //textBox2.Text = textBox2.Text.Replace("^", "");

                string[] str = textBox2.Text.Split("^");
                if (str[1] == "")
                {
                    textBox2.Text = textBox2.Text.Replace("^", "");
                }
                else
                {
                    button24_Click(sender, e);
                }
            }
            textBox1.Text = textBox2.Text;
            if (Zamena)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length);
            }
            D = B.Text;
            D_Buff = "";
            N1 = textBox1.Text.Substring(0, textBox1.Text.Length);
            //

            //

            N2 = true;
            textBox1.Text += D;
            Zamena = true;

        }

        private void button24_Click(object sender, EventArgs e)
        {
            try
            {
                if ((D == "" || N3 == null) && ((!textBox2.Text.Contains("mod") || BuffMod != 0) || (!textBox2.Text.Contains("^") || BuffSt != 0)))
                {
                    if (textBox2.Text.EndsWith(","))
                    {
                        textBox2.Text = textBox2.Text.TrimEnd(',');
                    }
                    textBox1.Text = textBox2.Text + "=";
                    textBox2.Text = "0";
                    return;
                }

                if (textBox2.Text.Contains("mod"))
                {

                    string[] str = textBox2.Text.Split("mod");
                    if (str[1] == "")
                    {
                        BuffMod = Convert.ToDouble(str[0]);
                        N3 = (Convert.ToDouble(str[0]) % Convert.ToDouble(str[0])).ToString();
                        if ((Convert.ToDouble(str[0]) == 0))
                        {
                            textBox1.Text = "";
                            textBox2.Text = "0";
                            D = "";
                            D_Buff = "";
                            throw new Exception("Неверный ввод");
                        }
                        if (CheckNeChislo(N3))
                        {
                            textBox2.Text = N3;
                            textBox2.Text = N3;
                            D = D_Buff;
                        }
                        //D = "";
                        return;
                    }
                    BuffMod = Convert.ToDouble(str[1]);
                    N3 = (Convert.ToDouble(str[0]) % Convert.ToDouble(str[1])).ToString();
                    if ((Convert.ToDouble(str[1]) == 0))
                    {
                        textBox1.Text = "";
                        textBox2.Text = "0";
                        D = "";
                        D_Buff = "";
                        throw new Exception("Неверный ввод");
                    }
                    if (CheckNeChislo(N3))
                    {
                        textBox2.Text = N3;
                        D = D_Buff;
                        D_Buff = "mod";
                    }
                    //D = "";
                    return;
                }
                if (textBox2.Text.Contains("^"))
                {

                    string[] str = textBox2.Text.Split("^");
                    if (str[1] == "")
                    {
                        BuffSt = Convert.ToDouble(str[0]);
                        N3 = (Math.Pow(Convert.ToDouble(str[0]), Convert.ToDouble(str[0]))).ToString();
                        if (double.IsNaN(Convert.ToDouble(N3)))
                        {
                            textBox1.Text = "";
                            textBox2.Text = "0";
                            D = "";
                            D_Buff = "";
                            throw new Exception("Неверный ввод");
                        }
                        //N3 = (Convert.ToDouble(str[0]) % Convert.ToDouble(str[0])).ToString();
                        if (CheckNeChislo(N3))
                        {
                            textBox2.Text = N3;
                            D = D_Buff;

                        }
                        //D = "";
                        return;
                    }
                    BuffSt = Convert.ToDouble(str[1]);
                    N3 = (Math.Pow(Convert.ToDouble(str[0]), Convert.ToDouble(str[1]))).ToString();
                    if (double.IsNaN(Convert.ToDouble(N3)))
                    {
                        textBox1.Text = "";
                        textBox2.Text = "0";
                        D = "";
                        D_Buff = "";
                        throw new Exception("Неверный ввод");
                    }
                    //N3 = (Convert.ToDouble(str[0]) % Convert.ToDouble(str[1])).ToString();
                    if (CheckNeChislo(N3))
                    {
                        textBox2.Text = N3;
                        D = D_Buff;
                        D_Buff = "mod";

                    }
                    //D = "";
                    return;
                }
                var excludes = new[] { "÷", "×", "-", "+", "%" };
                //if (BuffMod != 0)
                if (!excludes.Any(x => textBox1.Text.Contains(x)))
                {
                    N3 = (Convert.ToDouble(N3) % BuffMod).ToString();
                    if (CheckNeChislo(N3))
                    {
                        textBox2.Text = N3;

                    }
                    return;
                }
                if (!excludes.Any(x => textBox1.Text.Contains(x)))
                {
                    N3 = (Math.Pow(Convert.ToDouble(N3), BuffSt)).ToString();
                    //N3 = (Convert.ToDouble(N3) % BuffSt).ToString();
                    if (CheckNeChislo(N3))
                    {
                        textBox2.Text = N3;

                    }
                    return;
                }

                if (textBox1.Text.Contains('='))
                {
                    textBox1.Text = textBox2.Text;
                    textBox1.Text += D;
                    textBox1.Text += N3 + "=";

                    double td1, td2;
                    double res1 = 0;
                    td1 = Convert.ToDouble(textBox2.Text);
                    td2 = Convert.ToDouble(N3);
                    if (D == "+")
                    {
                        res1 = td1 + td2;
                    }
                    if (D == "-")
                    {
                        res1 = td1 - td2;
                    }
                    if (D == "×" || D == "*")
                    {
                        res1 = td1 * td2;
                    }
                    if (D == "÷" || D == "/")
                    {
                        if (td2 == 0)
                        {
                            textBox1.Text = "";
                            textBox2.Text = "0";
                            D = "";
                            D_Buff = "";
                            throw new Exception("Деление на ноль");
                        }
                        res1 = td1 / td2;
                    }
                    if (D == "%")
                    {
                        res1 = td1 * td2 / 100;
                    }
                    //D = "=";
                    N2 = true;
                    if (CheckNeChislo(res1.ToString()))
                    {
                        textBox2.Text = res1.ToString();

                    }
                }
                else
                {

                    textBox1.Text += textBox2.Text;
                    textBox1.Text += "=";
                    double dn1, dn2;
                    double res = 0;
                    dn1 = Convert.ToDouble(N1);
                    dn2 = Convert.ToDouble(textBox2.Text);
                    if (D == "+")
                    {
                        res = dn1 + dn2;
                    }
                    if (D == "-")
                    {
                        res = dn1 - dn2;
                    }
                    if (D == "×" || D == "*")
                    {
                        res = dn1 * dn2;
                    }
                    if (D == "÷" || D == "/")
                    {
                        if (dn2 == 0)
                        {
                            textBox1.Text = "";
                            textBox2.Text = "0";
                            D = "";
                            D_Buff = "";
                            throw new Exception("Деление на ноль");
                        }
                        res = dn1 / dn2;
                    }
                    if (D == "%")
                    {
                        res = dn1 * dn2 / 100;
                    }
                    //D = "=";
                    N2 = true;
                    if (CheckNeChislo(res.ToString()))
                    {
                        textBox2.Text = res.ToString();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool CheckNeChislo(string N3)
        {
            bool check__ = true;
            if (!double.TryParse(N3.ToString(), out _))
            {
                MessageBox.Show("Не верный ввод");
                D = "";
                D_Buff = "";
                textBox1.Text = "";
                textBox2.Text = "0";
                check__ = false;
            }
            if (double.TryParse(N3, out double n3))
            {
                if (double.IsInfinity(n3))
                {
                    MessageBox.Show("Не получаеться подсчитать");
                    D = "";
                    D_Buff = "";
                    textBox1.Text = "";
                    textBox2.Text = "0";
                    check__ = false;
                }
                if (double.IsNaN(n3))
                {
                    MessageBox.Show("Не верный ввод");
                    D = "";
                    D_Buff = "";
                    textBox1.Text = "";
                    textBox2.Text = "0";
                    check__ = false;
                }
            }
            return check__;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text.Contains("mod"))
                {
                    //textBox2.Text = textBox2.Text.Replace("mod", "");

                    string[] str = textBox2.Text.Split("mod");
                    if (str[1] == "")
                    {
                        textBox2.Text = textBox2.Text.Replace("mod", "");
                    }
                    else
                    {
                        button24_Click(sender, e);
                    }
                }
                if (textBox2.Text.Contains("^"))
                {
                    //textBox2.Text = textBox2.Text.Replace("^", "");

                    string[] str = textBox2.Text.Split("^");
                    if (str[1] == "")
                    {
                        textBox2.Text = textBox2.Text.Replace("^", "");
                    }
                    else
                    {
                        button24_Click(sender, e);
                    }
                }
                textBox1.Text += textBox2.Text;
                textBox1.Text += "=";
                double dn, res;
                dn = Convert.ToDouble(textBox2.Text);
                if (dn == 0)
                {
                    textBox1.Text = "";
                    textBox2.Text = "0";
                    D = "";
                    D_Buff = "";
                    throw new Exception("Деление на ноль");
                }
                res = 1 / dn;
                if (CheckNeChislo(res.ToString()))
                {
                    textBox2.Text = res.ToString();
                    textBox1.Text = res.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += textBox2.Text;
            textBox1.Text += "=";
            double dn, res;
            dn = Convert.ToDouble(textBox2.Text);
            res = Math.Pow(dn, 2);
            if (CheckNeChislo(res.ToString()))
            {
                textBox2.Text = res.ToString();
                textBox1.Text = res.ToString();

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text.Contains("mod"))
                {
                    //textBox2.Text = textBox2.Text.Replace("mod", "");

                    string[] str = textBox2.Text.Split("mod");
                    if (str[1] == "")
                    {
                        textBox2.Text = textBox2.Text.Replace("mod", "");
                    }
                    else
                    {
                        button24_Click(sender, e);
                    }
                }
                if (textBox2.Text.Contains("^"))
                {
                    //textBox2.Text = textBox2.Text.Replace("^", "");

                    string[] str = textBox2.Text.Split("^");
                    if (str[1] == "")
                    {
                        textBox2.Text = textBox2.Text.Replace("^", "");
                    }
                    else
                    {
                        button24_Click(sender, e);
                    }
                }
                textBox1.Text += textBox2.Text;
                textBox1.Text += "=";
                double dn, res;
                dn = Convert.ToDouble(textBox2.Text);
                if (dn < 0)
                {
                    textBox1.Text = "";
                    textBox2.Text = "0";
                    D = "";
                    D_Buff = "";
                    throw new Exception("Подкоренное выражение отрицательно");
                }
                res = Math.Sqrt(dn);
                if (CheckNeChislo(res.ToString()))
                {
                    textBox2.Text = res.ToString();
                    textBox1.Text = res.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Text = "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = "0";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Contains("mod"))
            {
                string[] str = textBox2.Text.Split("mod");
                if (str[1] == "")
                {
                    textBox2.Text = textBox2.Text.Replace("mod", "");
                    D_Buff = "";
                    D = "";

                    return;
                }

            }
            if (textBox2.Text.Contains("^"))
            {
                string[] str = textBox2.Text.Split("^");
                if (str[1] == "")
                {
                    textBox2.Text = textBox2.Text.Replace("^", "");
                    D_Buff = "";
                    D = "";

                    return;
                }
            }
            textBox2.Text = textBox2.Text.Substring(0, textBox2.Text.Length - 1);
            if (textBox2.Text == "")
            {
                textBox2.Text = "0";
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {

            var excludes = new[] { "mod", "^" };
            var x = excludes.FirstOrDefault(x => textBox2.Text.Contains(x));
            if (x != null)
            {
                string[] str = textBox2.Text.Split(x);
                if (str[1].Contains("-"))
                {

                    textBox2.Text = textBox2.Text.Replace(str[1], str[1].Replace("-", ""));
                }
                else
                {
                    if (str[1] != "0")
                    {
                        textBox2.Text = textBox2.Text.Insert(str[0].Length + x.Length, "-");
                    }

                }

                return;
            }
            if (Convert.ToDouble(textBox2.Text) == 0)
            {
                return;
            }

            //textBox1.Text += textBox2.Text;
            //textBox1.Text += "=";
            double dn, res;
            dn = Convert.ToDouble(textBox2.Text);
            /*if (dn > 0)
            {
                D = "+";
            }
            else
            {
                D = "-";
            }*/

            res = -dn;
            if (CheckNeChislo(res.ToString()))
            {
                textBox2.Text = res.ToString();

            }
            //textBox1.Text = res.ToString();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            //var excludes = new[] { "mod", "^"};
            if (textBox2.Text.Contains("mod"))
            {
                string[] str = textBox2.Text.Split("mod");
                if (!str[0].Contains(","))
                {
                    textBox2.Text += ",";
                }
                else if (!str[1].Contains(","))
                {
                    textBox2.Text += ",";
                }
                if (str[1] == "")
                {
                    return;
                }
            }
            else if (textBox2.Text.Contains("^"))
            {
                string[] str = textBox2.Text.Split("^");
                if (!str[0].Contains(","))
                {
                    textBox2.Text += ",";
                }
                if (!str[1].Contains(","))
                {
                    textBox2.Text += ",";
                }
                if (str[1] == "")
                {
                    return;
                }
            }
            else if (!textBox2.Text.Contains(","))
            {
                textBox2.Text += ",";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            result = 0;
            switch (Function)
            {
                case "sin":
                    if (textBox1.Text.Contains("="))
                    {
                        result = Math.Sin(Convert.ToDouble(textBox2.Text) * (Math.PI / 180));
                        if (CheckNeChislo(result.ToString()))
                        {
                            textBox2.Text = result.ToString();
                        }
                        return;
                    }
                    if (D != string.Empty)
                    {
                        result = Math.Sin(Convert.ToDouble(textBox2.Text) * (Math.PI / 180));
                        if (CheckNeChislo(result.ToString()))
                        {
                            textBox2.Text = result.ToString();
                            N3 = result.ToString();
                        }
                    }
                    else
                    {
                        result = Math.Sin(Convert.ToDouble(textBox2.Text) * (Math.PI / 180));
                        //textBox1.Text += "sin(" + textBox2.Text + ") ";
                        if (CheckNeChislo(result.ToString()))
                        {
                            textBox2.Text = result.ToString();
                        }
                    }
                    textBox1.Text = textBox2.Text;
                    N2 = true;
                    Zamena = true;
                    break;
                case "cos":
                    if (textBox1.Text.Contains("="))
                    {
                        result = Math.Cos(Convert.ToDouble(textBox2.Text) * (Math.PI / 180));
                        if (CheckNeChislo(result.ToString()))
                        {
                            textBox2.Text = result.ToString();
                        }
                        return;
                    }
                    if (D != string.Empty)
                    {
                        result = Math.Cos(Convert.ToDouble(textBox2.Text) * (Math.PI / 180));
                        if (CheckNeChislo(result.ToString()))
                        {
                            textBox2.Text = result.ToString();
                            N3 = result.ToString();
                        }
                    }
                    else
                    {
                        result = Math.Cos(Convert.ToDouble(textBox2.Text) * (Math.PI / 180));
                        if (CheckNeChislo(result.ToString()))
                        {
                            textBox2.Text = result.ToString();
                        }
                        //textBox1.Text += "sin(" + textBox2.Text + ") ";

                    }
                    textBox1.Text = textBox2.Text;
                    N2 = true;
                    Zamena = true;
                    break;
                case "tan":
                    if (textBox1.Text.Contains("="))
                    {
                        result = Math.Tan(Convert.ToDouble(textBox2.Text) * (Math.PI / 180));
                        if (CheckNeChislo(result.ToString()))
                        {
                            textBox2.Text = result.ToString();
                        }
                        return;
                    }
                    if (D != string.Empty)
                    {
                        if (((Convert.ToDouble(textBox2.Text) % 90 == 0) && (Convert.ToDouble(textBox2.Text) % 180 != 0)) ||
                            ((Convert.ToDouble(textBox2.Text) % 270 == 0) && (Convert.ToDouble(textBox2.Text) % 360 != 0)))
                        {
                            MessageBox.Show("Тангенс не существует");
                            D = "";
                            D_Buff = "";
                            textBox2.Text = "0";
                            textBox1.Text = "";
                        }
                        result = Math.Tan(Convert.ToDouble(textBox2.Text) * (Math.PI / 180));
                        if (CheckNeChislo(result.ToString()))
                        {
                            textBox2.Text = result.ToString();
                        }
                        N3 = result.ToString();
                    }
                    else
                    {
                        if (((Convert.ToDouble(textBox2.Text) % 90 == 0) && (Convert.ToDouble(textBox2.Text) % 180 != 0)) ||
                            ((Convert.ToDouble(textBox2.Text) % 270 == 0) && (Convert.ToDouble(textBox2.Text) % 360 != 0)))
                        {
                            MessageBox.Show("Тангенс не существует");
                            D = "";
                            D_Buff = "";
                            textBox2.Text = "0";
                            textBox1.Text = "";
                        }
                        else
                        {
                            result = Math.Tan(Convert.ToDouble(textBox2.Text) * (Math.PI / 180));
                            if (CheckNeChislo(result.ToString()))
                            {
                                textBox2.Text = result.ToString();
                            }
                        }
                    }
                    break;
                case "x²":

                    if (textBox1.Text.Contains("="))
                    {
                        result = Math.Pow(Convert.ToDouble(textBox2.Text), 2);
                        if (CheckNeChislo(result.ToString()))
                        {
                            textBox2.Text = result.ToString();
                        }
                        return;
                    }
                    if (D != string.Empty)
                    {
                        result = Math.Pow(Convert.ToDouble(textBox2.Text), 2);
                        if (CheckNeChislo(result.ToString()))
                        {
                            textBox2.Text = result.ToString();
                            N3 = result.ToString();
                        }
                    }
                    else
                    {
                        result = Math.Pow(Convert.ToDouble(textBox2.Text), 2);
                        if (CheckNeChislo(result.ToString()))
                        {
                            textBox2.Text = result.ToString();
                        }
                    }
                    textBox1.Text = textBox2.Text;
                    N2 = true;
                    Zamena = true;
                    break;
                case "x³":
                    if (textBox1.Text.Contains("="))
                    {
                        result = Math.Pow(Convert.ToDouble(textBox2.Text), 3);
                        if (CheckNeChislo(result.ToString()))
                        {
                            textBox2.Text = result.ToString();
                        }
                        return;
                    }
                    if (D != string.Empty)
                    {
                        result = Math.Pow(Convert.ToDouble(textBox2.Text), 3);
                        if (CheckNeChislo(result.ToString()))
                        {
                            textBox2.Text = result.ToString();
                            N3 = result.ToString();
                        }
                    }
                    else
                    {
                        result = Math.Pow(Convert.ToDouble(textBox2.Text), 3);
                        if (CheckNeChislo(result.ToString()))
                        {
                            textBox2.Text = result.ToString();
                        }
                    }
                    textBox1.Text = textBox2.Text;
                    N2 = true;
                    Zamena = true;
                    break;
                case "10^x":
                    if (textBox1.Text.Contains("="))
                    {
                        result = Math.Pow(10, Convert.ToDouble(textBox2.Text));
                        if (CheckNeChislo(result.ToString()))
                        {
                            textBox2.Text = result.ToString();
                            textBox1.Text = textBox2.Text;
                        }
                        return;
                    }
                    if (D != string.Empty)
                    {
                        result = Math.Pow(10, Convert.ToDouble(textBox2.Text));
                        if (CheckNeChislo(result.ToString()))
                        {
                            textBox2.Text = result.ToString();
                            N3 = result.ToString();
                            textBox1.Text = textBox2.Text;
                        }
                    }
                    else
                    {
                        result = Math.Pow(10, Convert.ToDouble(textBox2.Text));
                        if (CheckNeChislo(result.ToString()))
                        {
                            textBox2.Text = result.ToString();
                            textBox1.Text = textBox2.Text;
                        }
                    }
                    N2 = true;
                    Zamena = true;
                    break;
                case "Log":
                    if (Convert.ToDouble(textBox2.Text) <= 0)
                    {
                        MessageBox.Show("Аргумент не может быть отрицательным ");
                        textBox2.Text = "0";
                        D = "";
                        N3 = "0";
                        return;
                    }
                    if (textBox1.Text.Contains("="))
                    {
                        result = Math.Log10(Convert.ToDouble(textBox2.Text));
                        if (CheckNeChislo(result.ToString()))
                        {
                            textBox2.Text = result.ToString();
                        }
                        return;
                    }
                    if (D != string.Empty)
                    {
                        result = Math.Log10(Convert.ToDouble(textBox2.Text));
                        if (CheckNeChislo(result.ToString()))
                        {
                            textBox2.Text = result.ToString();
                            N3 = result.ToString();
                        }
                    }
                    else
                    {
                        result = Math.Log10(Convert.ToDouble(textBox2.Text));
                        //textBox1.Text += "sin(" + textBox2.Text + ") ";
                        if (CheckNeChislo(result.ToString()))
                        {
                            textBox2.Text = result.ToString();
                        }
                    }
                    textBox1.Text = textBox2.Text;
                    N2 = true;
                    Zamena = true;
                    break;
                case "Ln":
                    if (Convert.ToDouble(textBox2.Text) <= 0)
                    {
                        MessageBox.Show("Аргумент не может быть отрицательным ");
                        textBox2.Text = "0";
                        D = "";
                        N3 = "0";
                        return;
                    }
                    if (textBox1.Text.Contains("="))
                    {
                        result = Math.Log(Convert.ToDouble(textBox2.Text));
                        if (CheckNeChislo(result.ToString()))
                        {
                            textBox2.Text = result.ToString();
                        }
                        return;
                    }
                    if (D != string.Empty)
                    {
                        result = Math.Log(Convert.ToDouble(textBox2.Text));
                        if (CheckNeChislo(result.ToString()))
                        {
                            textBox2.Text = result.ToString();
                            N3 = result.ToString();
                        }
                    }
                    else
                    {
                        result = Math.Log(Convert.ToDouble(textBox2.Text));
                        if (CheckNeChislo(result.ToString()))
                        {
                            textBox2.Text = result.ToString();
                        }
                    }
                    textBox1.Text = textBox2.Text;
                    N2 = true;
                    Zamena = true;
                    break;
                default:
                    break;
            }
            //return result;

        }
        public BigInteger Factorial(int n)
        {
            var factorial = new BigInteger(1);
            for (int i = 1; i <= n; i++)
                factorial *= i;

            return factorial;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            var excludes = new[] { "mod", "^" };
            if (excludes.Any(x => textBox2.Text.Contains(x)))
            {
                button24_Click(sender, e);
            }
            if (B != null)
            {
                D_Buff = "";
                Function = B.Text;
                textBox2_TextChanged(sender, e);
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            var excludes = new[] { "mod", "^" };
            if (excludes.Any(x => textBox2.Text.Contains(x)))
            {
                button24_Click(sender, e);
            }
            if (textBox2.Text.Contains(",") || Convert.ToDouble(textBox2.Text) <= 0)
            {
                MessageBox.Show("Не целое число или отрицательное");
                textBox2.Text = "0";
                return;
            }
            N3 = Factorial(Convert.ToInt32(textBox2.Text)).ToString();
            textBox2.Text = N3;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            var excludes = new[] { "mod", "^" };
            if (excludes.Any(x => textBox2.Text.Contains(x)))
            {
                button24_Click(sender, e);
            }
            N3 = Math.Abs(Convert.ToDouble(textBox2.Text)).ToString();
            textBox2.Text = N3;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            var excludes = new[] { "mod", "^" };
            if (excludes.Any(x => textBox2.Text.Contains(x)))
            {
                N3 = $"{Math.PI}";
                textBox2.Text += N3;
                return;
            }
            N3 = $"{Math.PI}";
            textBox2.Text = N3;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            var excludes = new[] { "mod", "^" };
            if (excludes.Any(x => textBox2.Text.Contains(x)))
            {
                N3 = $"{Math.E}";
                textBox2.Text += N3;
                return;
            }
            N3 = $"{Math.E}";
            textBox2.Text = N3;
        }

        private void button35_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Contains("mod"))
            {
                return;
            }
            if (textBox2.Text.Contains("^"))
            {
                string[] strings = textBox2.Text.Split("^");
                if (strings[1] == "")
                {
                    textBox2.Text = textBox2.Text.Replace("^", "");
                }
                else
                {
                    button24_Click(sender, e);
                }
            }
            var excludes = new[] { "÷", "×", "-", "+", "%" };
            string[] str = textBox2.Text.Split("mod");
            string[] prov = textBox1.Text.Split(D);
            if (D_Buff == "")
            {
                D_Buff = D;
            }

            if (prov[0] == textBox2.Text)
            {
                if (excludes.Any(x => textBox1.Text.Contains(x)))
                {
                    textBox1.Text = "";
                }
            }
            textBox2.Text += "mod";
            D = "mod";
        }

        private void button36_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Contains("^"))
            {
                return;
            }
            if (textBox2.Text.Contains("mod"))
            {
                string[] strings = textBox2.Text.Split("mod");
                if (strings[1] == "")
                {
                    textBox2.Text = textBox2.Text.Replace("mod", "");
                }
                else
                {
                    button24_Click(sender, e);
                }

            }
            var excludes = new[] { "÷", "×", "-", "+", "%" };
            string[] str = textBox2.Text.Split("^");
            string[] prov = textBox1.Text.Split(D);
            if (D_Buff == "")
            {
                D_Buff = D;
            }
            if (prov[0] == textBox2.Text)
            {
                if (excludes.Any(x => textBox1.Text.Contains(x)))
                {
                    textBox1.Text = "";
                }
            }
            textBox2.Text += "^";
            D = "^";
        }

        private void button28_Click(object sender, EventArgs e)
        {
            button25.Visible = !button25.Visible;
            button26.Visible = !button26.Visible;
            button27.Visible = !button27.Visible;
            button29.Visible = !button29.Visible;
            button30.Visible = !button30.Visible;
            button31.Visible = !button31.Visible;
            button32.Visible = !button32.Visible;
            button33.Visible = !button33.Visible;
            button34.Visible = !button34.Visible;
            button35.Visible = !button35.Visible;
            button36.Visible = !button36.Visible;
            button37.Visible = !button37.Visible;
            button38.Visible = !button38.Visible;
            button39.Visible = !button39.Visible;
            Size_Form();
        }

        private void Size_Form()
        {
            if (!SizeForm)
            {
                this.Width = 304;
                this.Height = 563;
                textBox2.Width = 282;
                textBox2.Height = 53;
                textBox1.Width = 282;
                textBox1.Height = 43;
            }
            else
            {
                this.Width = 764;
                this.Height = 563;
                textBox2.Width = 742;
                textBox2.Height = 53;
                textBox1.Width = 742;
                textBox1.Height = 43;
            }
            SizeForm = !SizeForm;
        }
    }
}