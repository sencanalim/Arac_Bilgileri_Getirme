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
    public partial class Passat : Form
    {
        public Passat()
        {
            InitializeComponent();
        }
        
        
            
        private void Passat_Load(object sender, EventArgs e)
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

            // Wolksvagen Passat için sınıftaki toplu olan özellikleri kullanarak buraya tanım sonrasında işlem yapacağız.
            // öncelikle sınıfı çekerken nesne eklemek için new kodunu kullanmalıyız.

            Wolksvagen passaticinsınıfınismi = new Wolksvagen();

            // burda özellik eklenirken artık belirlediğimiz sınıfı kullanıyoruz.

            passaticinsınıfınismi.özllkmodel = 2017;
            passaticinsınıfınismi.özllkfiyat = 1227.984;
            passaticinsınıfınismi.özllkmotorps = 1499;
            passaticinsınıfınismi.özllkdurum = 'S';
            passaticinsınıfınismi.özllkyakıt = "Benzin";
            passaticinsınıfınismi.özllksanzuman = "Otomatik";

            // Şimdi Sınıftan Çekip Yeni Nesne Belirleyip İçine Özellikleri ve Özelliklerin Tanımını Yazdırma Vaktimiz Geldi.
                
            textBox1.Text = passaticinsınıfınismi.özllkmodel.ToString() +" Model";
            textBox2.Text = passaticinsınıfınismi.özllkfiyat.ToString("N3") + " TL";
            textBox3.Text = passaticinsınıfınismi.özllkmotorps.ToString() + " cc";
            textBox4.Text = passaticinsınıfınismi.özllkdurum.ToString() + "ıfır";
            textBox5.Text = passaticinsınıfınismi.özllkyakıt.ToString();
            textBox6.Text = passaticinsınıfınismi.özllksanzuman.ToString();

        }
    }
}
