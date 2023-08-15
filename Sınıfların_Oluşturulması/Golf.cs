using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sınıfların_Oluşturulması
{
    public partial class Golf : Form
    {
        public Golf()
        {
            InitializeComponent();
        }

        private void Golf_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = true;

            // Wolksvagen golf için sınıftaki toplu olan özellikleri kullanarak buraya tanım sonrasında işlem yapacağız.
            // öncelikle sınıfı çekerken nesne eklemek için new kodunu kullanmalıyız.

            Wolksvagen golficinsınıfınismi = new Wolksvagen();

            // burda özellik eklenirken artık belirlediğimiz sınıfı kullanıyoruz.

            golficinsınıfınismi.özllkmodel = 2022;
            golficinsınıfınismi.özllkfiyat = 1700;
            golficinsınıfınismi.özllkmotorps = 1999;
            golficinsınıfınismi.özllkdurum = 'S';
            golficinsınıfınismi.özllkyakıt = "Benzin";
            golficinsınıfınismi.özllksanzuman = "Manuel 6 İleri";

            // Şimdi Sınıftan Çekip Yeni Nesne Belirleyip İçine Özellikleri ve Özelliklerin Tanımını Yazdırma Vaktimiz Geldi.

            textBox1.Text = golficinsınıfınismi.özllkmodel.ToString() + " Model";
            textBox2.Text = golficinsınıfınismi.özllkfiyat.ToString("N3") + " TL";
            textBox3.Text = golficinsınıfınismi.özllkmotorps.ToString() + " cc";
            textBox4.Text = golficinsınıfınismi.özllkdurum.ToString() + "ıfır";
            textBox5.Text = golficinsınıfınismi.özllkyakıt.ToString();
            textBox6.Text = golficinsınıfınismi.özllksanzuman.ToString();



        }
    }
}
