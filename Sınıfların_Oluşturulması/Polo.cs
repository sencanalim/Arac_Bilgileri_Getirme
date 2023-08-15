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
    public partial class Polo : Form
    {
        public Polo()
        {
            InitializeComponent();
        }

        private void Polo_Load(object sender, EventArgs e)
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

            // Wolksvagen polo için sınıftaki toplu olan özellikleri kullanarak buraya tanım sonrasında işlem yapacağız.
            // öncelikle sınıfı çekerken nesne eklemek için new kodunu kullanmalıyız.

            Wolksvagen poloicinsınıfınismi = new Wolksvagen();

            // burda özellik eklenirken artık belirlediğimiz sınıfı kullanıyoruz.

            poloicinsınıfınismi.özllkmodel = 2021;
            poloicinsınıfınismi.özllkfiyat = 1100.000;
            poloicinsınıfınismi.özllkmotorps = 1599;
            poloicinsınıfınismi.özllkdurum = 'S';
            poloicinsınıfınismi.özllkyakıt = "Dizel";
            poloicinsınıfınismi.özllksanzuman = "Manuel 5 İleri";

            // Şimdi Sınıftan Çekip Yeni Nesne Belirleyip İçine Özellikleri ve Özelliklerin Tanımını Yazdırma Vaktimiz Geldi.

            textBox1.Text = poloicinsınıfınismi.özllkmodel.ToString() + " Model";
            textBox2.Text = poloicinsınıfınismi.özllkfiyat.ToString("N3") + " TL";
            textBox3.Text = poloicinsınıfınismi.özllkmotorps.ToString() + " cc";
            textBox4.Text = poloicinsınıfınismi.özllkdurum.ToString() + "ıfır";
            textBox5.Text = poloicinsınıfınismi.özllkyakıt.ToString();
            textBox6.Text = poloicinsınıfınismi.özllksanzuman.ToString();


        }
    }
}
