/******************************************************************************************************************
 * ******************************************                 SAKARYA ÜNİVERSİTESİ 
 * ***********************                         BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
 * **********************                               BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
 * ********************                       NESNEYE DAYALI PROGRAMLAMA DERSİ 2019-2020 BAHAR DÖNEMİ
 * ******************         
 * ******************                                                  ÖDEV NO:2
 * ********************                                                AD: ŞEYMA
 * ***********************                                             SOYAD: GÖL
 * ***************************                                         NUMARA: B191210029
 * *****************************                                       SINIF: 1C
 * *********************************************
 * 
 * ********************************************************************************************************************/








using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B191210029
{
    public partial class Form1 : Form
    {
        public void add()
        {

            //Arkadaş mı butonuna tıklandığında label,label1,label2,listBox1,listBox2,textbox,textbox1 formun belirtilen lokasyonlarında,belirlenen boyutlarda oluşur.
            //label oluşturuldu,oluşma durumu kontrol edildi.İçine "X" yazıldı.
            Label label = new Label();
            label.Top = 34;
            label.Left = 235;
            label.Width = 50;
            label.Text = "X";
            this.Controls.Add(label);
            //label1 oluşturuldu,oluşma durumu kontrol edildi.İçine "Y" yazıldı.
            Label label1 = new Label();
            label1.Top = 34;
            label1.Left = 335;
            label1.Width = 50;
            label1.Text = "Y";
        //    this.Controls.Add(label1);
            //label2 oluşturuldu,oluşma durumu kontrol edildi.İçine "TOPLAMLAR" yazıldı.
            Label label2 = new Label();
            label2.Top = 280;
            label2.Left = 120;
            label2.Width = 80;
            label2.Text = "TOPLAMLAR";
            this.Controls.Add(label2);
            //listBox1 oluşturuldu,oluşma durumu kontrol edildi.
            ListBox listBox1 = new ListBox();
            listBox1.Size = new System.Drawing.Size(100, 200);
            listBox1.Location = new System.Drawing.Point(205, 56);
            this.Controls.Add(listBox1);
            //listBox2 oluşturuldu,oluşma durumu kontrol edildi.
            ListBox listBox2 = new ListBox();
            listBox2.Size = new System.Drawing.Size(100, 200);
            listBox2.Location = new System.Drawing.Point(306, 56);
            this.Controls.Add(listBox2);
            //textbox oluşturuldu,oluşma durumu kontrol edildi.
            TextBox textbox = new TextBox();
            textbox.Location = new System.Drawing.Point(200, 278);
            textbox.Size = new System.Drawing.Size(100, 450);
            textbox.Name = "txt_";
            this.Controls.Add(textbox);
            //textbox1 oluşturuldu,oluşma durumu kontrol edildi.
            TextBox textbox1 = new TextBox();
            textbox1.Location = new System.Drawing.Point(305, 278);
            textbox1.Size = new System.Drawing.Size(100, 450);
            textbox1.Name = "txt_";
            this.Controls.Add(textbox1);
            //Kullanıcının textBox1,textBox2 ' ye girdiği sayılar x ve y değişkenlerine atandı.
            int x = Convert.ToInt32(textBox1.Text);
            int y = Convert.ToInt32(textBox2.Text);
            //for döngüsüyle 1'den başlayarak girilen sayıya(x) kadar kontroller sağlandı.
            for (int i = 1; i < x; i++)
            {//if ile x'i tam bölen sayılar listBox1'e yazdırıldı.
                if (x % i == 0)
                {
                    listBox1.Items.Add(i + "  ");
                }
            }
            //for döngüsüyle 1'den başlayarak girilen sayıya(y) kadar kontroller sağlandı.
            for (int i = 1; i < y; i++)
            {//if ile y'yi tam bölen sayılar listBox2'ye yazdırıldı.
                if (y % i == 0)
                {
                    listBox2.Items.Add(i + "  ");
                }
            }

            //listBox1 ' deki çarpanlar toplanıp textbox'a yazdırıldı.
            int toplam = 0, sayi = 0, eleman = 0;
            eleman = listBox1.Items.Count;
            while (sayi <= eleman - 1)
            {
                toplam += Int32.Parse(listBox1.Items[sayi].ToString());

                sayi++;
            }

            textbox.Text = toplam.ToString();

            //listBox2 ' deki çarpanlar toplanıp textbox1'e yazdırıldı.
            int sum = 0, num = 0, comp = 0;
            comp = listBox2.Items.Count;
            while (num <= comp - 1)
            {
                sum += Int32.Parse(listBox2.Items[num].ToString());

                num++;
            }

            textbox1.Text = sum.ToString();


        }

        public void clear()
        {

            foreach (Control item in this.Controls)
            {

                if (item is TextBox)
                {

                    TextBox tbox = (TextBox)item;
                    {
                        tbox.Clear();
                    }

                }
          
            }
            foreach (Control item in this.Controls)
            {
                if (item is ListBox)
                {
                    ListBox listBox = (ListBox)item;
                    {
                        listBox.Items.Clear();
                    }
                }
            }
            
            
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {//ARKADAŞ MI butonuyla eklemeler yapılması için add() fonksiyonu çağırıldı.
            add();
        }

      

        private void button2_Click(object sender, EventArgs e)
        {//SON butonuyla temizleme işlemi için clear() fonksiyonu çağırıldı.
            clear();
            add();
        }
    }
}
