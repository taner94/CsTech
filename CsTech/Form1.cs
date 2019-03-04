using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsTech
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int sayi { get; set; }

        private string RandomSayi()
        {
            int x; int y; int z; int t;
            Random rastgele = new Random();
            do
            {
                x = rastgele.Next(0, 9);

                y = rastgele.Next(0, 9);

                z = rastgele.Next(0, 9);

                t = rastgele.Next(0, 9);

            } while ((x != 0) && (x != y) && (x != z) && (x != t) && (y != z) && (y != t) && (z != t));
             sayi =Convert.ToInt32( Convert.ToString(x) + Convert.ToString(y) + Convert.ToString(z) + Convert.ToString(t));

            return Convert.ToString(sayi);
        }


        private void RandomSayiB()

        {
            int j = 0;
            int x; int y; int z; int t;
            Random rastgele = new Random();
            do
            {
                x = rastgele.Next(0, 9);

                y = rastgele.Next(0, 9);

                z = rastgele.Next(0, 9);

                t = rastgele.Next(0, 9);

            } while ((x != 0) && (x != y) && (x != z) && (x != t) && (y != z) && (y != t) && (z != t));
            string sayib =Convert.ToString(x) + Convert.ToString(y) + Convert.ToString(z) + Convert.ToString(t);
         
            string sayi2 = sayi.ToString();
            char[] array = sayi2.ToCharArray();

            char[] girilensayi = sayib.ToCharArray();

            for (int i = 0; i < array.Length; i++)
            {
                char array2 = array[i];
                char girilensayi2 = girilensayi[i];

                if (array[i] == girilensayi[i])
                {
                    listBox2.Items.Add((i + 1) + ". Harf Kontrol : +");

                    j++;
                    if (j == 4)
                    {
                        listBox2.Items.Add("Doğru Bildiniz");
                    }

                }
                else
                {
                    listBox2.Items.Add((i + 1) + ". Harf Kontrol : -");
                }
            }
            listBox2.Items.Add("--------------------");
        }

    
        

        private void button1_Click(object sender, EventArgs e)
        {
            int j = 0;


            if (textBox1.Text.Length != 4)
            { MessageBox.Show("4 Basamaklı Sayı Giriş Yapınız!"); }
            else
            {

                if (sayi == 0)
                { var randomSayi = RandomSayi(); }
                else
                { var randomSayi = sayi; }

                string sayi2 = sayi.ToString();
                char[] array = sayi2.ToCharArray();

                char[] girilensayi = textBox1.Text.ToCharArray();

                for (int i = 0; i < array.Length; i++)
                {
                    char array2 = array[i];
                    char girilensayi2 = girilensayi[i];

                    if (array[i] == girilensayi[i])
                    {
                        listBox1.Items.Add((i + 1) + ". Harf Kontrol : +");

                        j++;
                        if (j == 4)
                        {
                            listBox1.Items.Add("Doğru Bildiniz");
                        }

                    }
                    else
                    {
                        listBox1.Items.Add((i + 1) + ". Harf Kontrol : -");
                    }
                }
                listBox1.Items.Add("--------------------");
            }




            RandomSayiB();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
            {
                MessageBox.Show("Numerik değer giriniz.");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }
    }
}
