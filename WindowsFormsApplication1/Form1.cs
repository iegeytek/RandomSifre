using System;   //iegeytek
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;   //iegeytek
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form   //iegeytek
    {
        public Form1()
        {
            InitializeComponent();  //iegeytek
        }
        Random rnd = new Random();
        private string karakteruret(bool sayimi)
        {
            string[] harfler = { "a", "b", "c", "d", "e", "f", "g", //iegeytek
                "h", "i", "j", "k", "l", "m", "n", "o", "p",
                "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            string[] harfler2 = { "a", "b", "c", "d", "e", "f", "g",    //iegeytek
                "h", "i", "j", "k", "l", "m", "n", "o", "p",
                "q", "r", "s", "t", "u", "v", "w", "x", "y", "z",
                "0","1","2","3","4","5","6","7","8","9"
            };
            int sayi = 0;
            if (sayimi)
            {
                sayi = rnd.Next(0, 35);
                return harfler2[sayi];  //iegeytek
            }
            else
            {
                sayi = rnd.Next(0, 25);
                return harfler[sayi];   //iegeytek
            }



        }
        private string uret (int ksayisi, string kucukbuyukharf)
        {
            string str = "";    //iegeytek
            for (int i = 0; i<ksayisi; i++)
            {
                str += karakteruret(checkBox1.Checked); //iegeytek

            }
            if (kucukbuyukharf == "buyuk")  //iegeytek
                str = str.ToUpper();
            return str; 
        }
        
        
        private void Form1_Load(object sender, EventArgs e) //iegeytek
        {
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedDialog; //iegeytek
        }

        private void button1_Click(object sender, EventArgs e)  //iegeytek
        {
            int karakter = 0;
            string sifre = "";
            try
            {
                karakter = Convert.ToInt32(textBox1.Text);  //iegeytek

            }
            catch (Exception)
            {
                MessageBox.Show("Sayı giriniz");    //iegeytek
                textBox1.Focus();
                return;
            }
            if (karakter<4 || karakter > 10)
            {
                MessageBox.Show("4-10 arası sayi giriniz!");
                textBox1.Focus();
                textBox1.Clear();       //iegeytek
                return;
            }
            if (radioButton1.Checked)
                sifre = uret(karakter, "küçük");
            else
                sifre = uret(karakter, "buyuk");  //iegeytek
            textBox2.Text = sifre;
            




        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
    }
}
//iegeytek