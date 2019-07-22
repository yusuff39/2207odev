using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Donguler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //DONGULER - LOOPS
        //Bir baslangic degeri olan, belirli bir kosul gerceklesene dek suren ve bu surec icerisinde bir takim islemleri tekrarli olarak gerceklestiren nesnelere "dongu" adini vermekteyiz.
        //FOR - FOREACH - WHILE - DOWHILE
        private void BtnOrnekBir_Click(object sender, EventArgs e)
        {
            //Donguye ilk giris aninda derleyici baslangic degerine bakar ve bir daha asla bu bloga ugramaz. 
            //Bundan sonraki islemler once arttir, daha sonra kosula bak, kosul uygunsa dongunun kod blogunu harekete gecir, uygun degilse donguden cik...

            //for(BaslangicDegeri; BitisKosulu; Artis-AzalisMiktari)
            for (int deger = 1; deger <= 1000; deger++)
            {
                listBox1.Items.Add(deger);
            }
        }

        private void BtnOrnekIki_Click(object sender, EventArgs e)
        {
            for (int i = 1000; i >= 1; i--)
            {
                listBox1.Items.Add(i);
            }
        }

        private void BtnOrnekUc_Click(object sender, EventArgs e)
        {
            for (int i = 1000; i >= 1; i--)
            {
                while (i % 2 == 0)
                {
                    listBox1.Items.Add(i);
                    break;
                }
            }



        }

        private void BtnOrnekDort_Click(object sender, EventArgs e)
        {
            for (char i = 'A'; i <= 'Z'; i++)
            {
                listBox1.Items.Add(i);
            }
        }

        private void BtnOrnekBes_Click(object sender, EventArgs e)
        {
            //1-100 arasındaki sayilarin toplamini ekrana yazdiriniz..
            int toplam = 0;
            for (int i = 1; i <= 100; i++)
            {
                toplam += i;
            }
            listBox1.Items.Add(toplam);

        }

        private void BtnOrnekAlti_Click(object sender, EventArgs e)
        {
            //1-100 arasindaki cift sayilarin toplami ile, tek sayilarin toplaminin farklari karesi kactir?
            int cift = 0;
            int tek = 0;
            for (int i = 1; i >= 100; i++)
            {
                while (i % 2 == 0)
                {
                    cift += i;
                    break;
                }
                while (i % 2 != 0)
                {
                    tek += i;
                    break;

                }

            }

            listBox1.Items.Add(cift - tek);


        }


        private void BtnOrnekYedi_Click(object sender, EventArgs e)
        {
            //1945 - günümüz yılı arasındaki yıllar Listbox'a eklensin ancak 1990 ve 1992 yılları eklenmeyecek...
            for (int i = 1945; i < 2019; i++)
            {
                while ((i != 1990) && (i != 1992))
                {
                    listBox1.Items.Add(i);
                    break;
                }
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            //Asagidaki dizide yer alan her bir elemani, listbox icerisine ekleyiniz...
            string[] takimlar = { "Galatasaray", "Fenerbahce", "Besiktas", "Trabzonspor", "Bursaspor", "Ankaragücü" };
            for (int i = 0; i <= takimlar.Length - 1; i++)
            {
                listBox2.Items.Add(takimlar[i]);

            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            //Sayisal bir dizi tanimlayin ve Array sınıfını kullanmadan o dizinin en buyuk elemanini gosterin...
            int[] sayisal = { 12, 45, 23, 76, 119, 85, 46, 223, 4, 6 };
            int buyuk = sayisal[0];
            for (int i = 1; i < sayisal.Length - 1; i++)
            {
                if (sayisal[i] > sayisal[i - 1]) { buyuk = sayisal[i]; }
            }
            listBox2.Items.Add(buyuk);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            //Asagidaki dizide kac tane cift kac tane tek sayi vardir kullaniciyi bilgilendiriniz..
            int[] sayisal = { 12, 45, 23, 76, 119, 85, 46, 223, 4, 6, 25 };
            int tek = 0;
            int cift = 0;
            for (int i = 0; i < sayisal.Length; i++)
            {
                while (sayisal[i] % 2 == 0)
                {
                    cift += 1;
                    break;
                }
                while (sayisal[i] % 2 != 0)
                {
                    tek += 1;
                    break;

                }



            }




            listBox2.Items.Add("tekler" + tek.ToString());
            listBox2.Items.Add("ciftler" + cift.ToString());

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            //asagidaki "adim" degiskeninde yer alan metni tersten isterseniz formun tepesine, isterseniz MessageBox'la yazdiriniz...

            //NOT => STRING'LER BİRER CHAR DİZİSİDİR...
            string adim = "bilgeadam";
            char[] mida = new char[adim.Length];


            int u = adim.Length;
            for (int i = 0; i < adim.Length; i++)
            {
                if (u <= adim.Length - 1)
                {
                    mida[i] = adim[u];
                    u--;
                }
            }
            string metin = new string(mida);
            MessageBox.Show(metin);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //Karmasik 10 adet sayiyi listbox icerisine ekleyiniz...
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                listBox2.Items.Add(rnd.Next(0, 5));
            }


        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //Form uzerinde yer alan tum butonlarin arkaplan renkleri kırmızı, yazi renkleri ise sarı olsun...
            //   foreach (var item in Array.IndexOf()) {  }


        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Disaridan girilen sayisal ifadenin rakam degerleri toplamini gosteriniz...
            //Ornegin 123 girilirse 1+2+3 = 6 sonucu donmelidir...

            int toplam = 0;
            string sayi = txtGirisAlani.Text;
            for (int i = 0; i < sayi.Length; i++)
            {
                toplam += Convert.ToInt32(sayi[i]);
            }
            MessageBox.Show(toplam.ToString());
        }



        /*
   FOREACH
   1) Kesinlikle index mantigi yoktur!
   2) Tip bagimli dongulerdir...
   3) Cogu zaman elimizdeki bir koleksiyonun her bir elemanini tek tek ele almak icin kullanilir...
*/


        private void Button16_Click(object sender, EventArgs e)
        {
            //İlgili dizi icerisindeki her bir elemana gecici olarak "str" takma adi verilir ve dongunun her bir adiminda size dizinin her bir elemani teslim edilir...
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            //İkiye bolunenleri listbox1'e bolunemeyenleri listbox2 ye atın... Hem ikiye hem uce bolunenlerin kac tane oldugunu da messagebox'la gosterin...
            int[] dizi = { 123, 54, 76, 876, 4532, 23, 77, 734, 83, 45, 190 };
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            //Listbox1'deki secili tum elemanlari (birden fazla secim sansi olmali!) listbox2'ye ekleyelim...
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            //Form uzerindeki tum butonlarin arkaplanlari ve yazi renklerini degistiriniz...
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button12_Click(object sender, EventArgs e)
        {
            int x = 5;
            string sonuc = "";
            for (int i = 0; i < x; i++)
            {
                sonuc += "x";

            }
            listBox3.Items.Add(sonuc);
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            int y = 5;
            for (int i = 0; i < y; i++)
            {
                listBox3.Items.Add("x");
            }
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            int y = 7;
            string sonuc = "";
            for (int j = 0; j < y; j++)
            {

                sonuc = "";
                for (int i = 0; i < y; i++)
                {
                    sonuc += "x";

                }
                listBox3.Items.Add(sonuc);
            }


        }

        private void Button8_Click(object sender, EventArgs e)
        {
            int x = 10;
            int y = 10;
            for (int i = 1; i <= x; i++)
            {
                for (int j = 1; j <= y; j++)
                {
                    listBox3.Items.Add((i).ToString() + " " + "X" + " " + (j).ToString() + " " + "=" + " " + (i * j).ToString());

                    // (i).ToString() + " " + "X" + " " + (j).ToString() + " " + "=" + " " + (i*j).ToString()

                }
                listBox3.Items.Add("------------");
            }
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            int y = 5;
            string toplam = "";
            for (int i = 1; i <= y; i++)
            {
                toplam = "";
                for (int j = 1; j <= i; j++)
                {
                    toplam += "X";
                }
                listBox3.Items.Add(toplam);
            }
        }

        private void Button17_Click(object sender, EventArgs e)
        {

        }
    }
}
