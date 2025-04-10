namespace HasapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonac()
        {
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
        }
        private void buttonkapa()
        {
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
        }
        int sayi1 = 0, sayi2 = 0;
        string sayi3 = "";
        string sayi4 = "";
        string hesap = "";
        string islem = "";
        int kacýncý = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            buttonac();
            if (kacýncý == 0)
            {
                sayi3 = sayi3 + "1";
            }
            else if (kacýncý == 1)
            {
                sayi4 = sayi4 + "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buttonac();
            if (kacýncý == 0)
            {
                sayi3 = sayi3 + "2";
            }
            else if (kacýncý == 1)
            {
                sayi4 = sayi4 + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            buttonac();
            if (kacýncý == 0)
            {
                sayi3 = sayi3 + "3";
            }
            else if (kacýncý == 1)
            {
                sayi4 = sayi4 + "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            buttonac();
            if (kacýncý == 0)
            {
                sayi3 = sayi3 + "4";
            }
            else if (kacýncý == 1)
            {
                sayi4 = sayi4 + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            buttonac();
            if (kacýncý == 0)
            {
                sayi3 = sayi3 + "5";
            }
            else if (kacýncý == 1)
            {
                sayi4 = sayi4 + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            buttonac();
            if (kacýncý == 0)
            {
                sayi3 = sayi3 + "6";
            }
            else if (kacýncý == 1)
            {
                sayi4 = sayi4 + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            buttonac();
            if (kacýncý == 0)
            {
                sayi3 = sayi3 + "7";
            }
            else if (kacýncý == 1)
            {
                sayi4 = sayi4 + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            buttonac();
            if (kacýncý == 0)
            {
                sayi3 = sayi3 + "8";
            }
            else if (kacýncý == 1)
            {
                sayi4 = sayi4 + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            buttonac();
            if (kacýncý == 0)
            {
                sayi3 = sayi3 + "9";
            }
            else if (kacýncý == 1)
            {
                sayi4 = sayi4 + "9";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            buttonac();
            if (kacýncý == 0)
            {
                sayi3 = sayi3 + "0";
            }
            else if (kacýncý == 1)
            {
                sayi4 = sayi4 + "0";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            buttonkapa();
            islem = "+";

            if (kacýncý == 0)
            {
                sayi1 = Convert.ToInt32((sayi3));
                kacýncý = 1;
            }
            else
            {
                kacýncý = 0;
            }

        }

        private void button14_Click(object sender, EventArgs e)
        {
            sayi2 = Convert.ToInt32((sayi4));
            int sonuc = 0;
            kacýncý = 0;
            if (islem == "+")
            {
                sonuc = sayi1 + sayi2;
            }
            else if (islem == "-")
            {
                sonuc = sayi1 - sayi2;
            }
            else if (islem == "*")
            {
                sonuc = sayi1 * sayi2;
            }
            else if (islem == "/")
            {
                sonuc = sayi1 / sayi2;
            }
            label2.Text = sonuc.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            buttonkapa();
            islem = "-";

            if (kacýncý == 0)
            {
                sayi1 = Convert.ToInt32((sayi3));
                kacýncý = 1;
            }
            else
            {
                kacýncý = 0;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            buttonkapa();
            islem = "*";

            if (kacýncý == 0)
            {
                sayi1 = Convert.ToInt32((sayi3));
                kacýncý = 1;
            }
            else
            {
                kacýncý = 0;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            buttonkapa();
            islem = "/";

            if (kacýncý == 0)
            {
                sayi1 = Convert.ToInt32((sayi3));
                kacýncý = 1;
            }
            else
            {
                kacýncý = 0;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            sayi1 = 0;
            sayi2 = 0;
            sayi3 = "";
            sayi4 = "";
            islem = "";
            label2.Text = "...";
        }
}
}
