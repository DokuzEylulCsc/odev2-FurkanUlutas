using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int yuzler = 0, onlar = 0, birler = 0, girilen;
            string sonuc = "";
            girilen = Convert.ToInt32(textBox1.Text);
            if (girilen <= 1 || girilen >= 3999)
            {
                MessageBox.Show("Lutfen 0-4000 arasi bir sayi giriniz!!");
            }
            if (girilen > 99)
            {
                yuzler = girilen / 100;
                if (girilen - (yuzler * 100) == 0)
                {
                    goto ifSonu;
                }
                onlar = (girilen - (yuzler * 100)) / 10;
                birler = girilen - ((yuzler * 100) + (onlar * 10));

            }
            else if (girilen > 9)
            {
                onlar = girilen / 10;
                birler = girilen - (onlar * 10);
            }
            else
            {
                birler = girilen;
            }

        ifSonu:

            if (yuzler > 0)
            {
                switch (yuzler)
                {
                    case 1:
                        sonuc = "C";
                        break;

                    case 2:
                        sonuc = "CC";
                        break;

                    case 3:
                        sonuc = "CCC";
                        break;

                    case 4:
                        sonuc = "CD";
                        break;

                    case 5:
                        sonuc = "D";
                        break;

                    case 6:
                        sonuc = "DC";
                        break;

                    case 7:
                        sonuc = "DCC";
                        break;

                    case 8:
                        sonuc = "DCC";
                        break;

                    case 9:
                        sonuc = "CM";
                        break;
                }
            }
            if (onlar > 0)
            {
                switch (onlar)
                {
                    case 1:
                        sonuc = sonuc + "X";
                        break;

                    case 2:
                        sonuc = sonuc + "XX";
                        break;

                    case 3:
                        sonuc = sonuc + "XXX";
                        break;

                    case 4:
                        sonuc = sonuc + "XL";
                        break;

                    case 5:
                        sonuc = sonuc + "L";
                        break;

                    case 6:
                        sonuc = sonuc + "LX";
                        break;

                    case 7:
                        sonuc = sonuc + "LXX";
                        break;

                    case 8:
                        sonuc = sonuc + "LXXX";
                        break;

                    case 9:
                        sonuc = sonuc + "XC";
                        break;
                }
            }

            if (birler > 0)
            {
                switch (birler)
                {
                    case 1:
                        sonuc = sonuc + "I";
                        break;

                    case 2:
                        sonuc = sonuc + "II";
                        break;

                    case 3:
                        sonuc = sonuc + "III";
                        break;

                    case 4:
                        sonuc = sonuc + "IV";
                        break;

                    case 5:
                        sonuc = sonuc + "V";
                        break;

                    case 6:
                        sonuc = sonuc + "VI";
                        break;

                    case 7:
                        sonuc = sonuc + "VII";
                        break;

                    case 8:
                        sonuc = sonuc + "VIII";
                        break;

                    case 9:
                        sonuc = sonuc + "IX";
                        break;
                }
            }
            textBox2.Text = sonuc;
        
    }

        private void button2_Click(object sender, EventArgs e)
        {
            string rs = textBox3.Text;
            int sayi = 0, k1 = 0, k2, k3;
            for (int i = 0; i < rs.Length; i++)
            {
                k2 = k1;
                switch (rs[i])
                {
                    case 'I': k1 = 1; break;
                    case 'V': k1 = 5; break;
                    case 'X': k1 = 10; break;
                    case 'L': k1 = 50; break;
                    case 'C': k1 = 100; break;
                    case 'D': k1 = 500; break;
                    case 'M': k1 = 1000; break;
                }
                if (k1 > k2)
                {
                    k3 = -2 * k2;
                }
                else
                {
                    k3 = 0;
                }
                sayi = sayi + k1 + k3;
            }
            if (sayi <= 1 || sayi >= 3999)
            {
                MessageBox.Show("Lutfen 0-4000 arasi bir sayi giriniz!!");
            }
            else
            {
                textBox4.Text = sayi.ToString();
            }
        }

     
    }
}
