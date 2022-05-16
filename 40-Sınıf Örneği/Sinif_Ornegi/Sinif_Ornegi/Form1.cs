using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinif_Ornegi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        araba ford = new araba();
        araba opel = new araba();
        araba volkswagen = new araba();
        private void Form1_Load(object sender, EventArgs e)
        {
            ford.marka = "Ford";
            ford.model = "Focus";
            ford.km = 12000;
            ford.renk = "Kırmızı";
            ford.vites = "Otomatik";
            ford.yil = 2022;

            opel.marka = "Opel";
            opel.model = "Insignia";
            opel.km = 70000;
            opel.renk = "Mavi";
            opel.vites = "Manuel";
            opel.yil = 2015;

            volkswagen.marka = "Volkswagen";
            volkswagen.model = "Passat";
            volkswagen.km = 150000;
            volkswagen.renk = "Siyah";
            volkswagen.vites = "Otomatik";
            volkswagen.yil = 2010;

            //Groupbox1 nesneleri
            groupBox1.Text = ford.marka;
            lbl1Km.Text = ford.km.ToString();
            lbl1Model.Text = ford.model;
            lbl1Renk.Text = ford.renk;
            lbl1Vites.Text = ford.vites;
            lbl1Yil.Text = ford.yil.ToString();

            //Groupbox2 nesneleri
            groupBox2.Text = opel.marka;
            lbl2Km.Text = opel.km.ToString();
            lbl2Model.Text = opel.model;
            lbl2Renk.Text = opel.renk;
            lbl2Vites.Text = opel.vites;
            lbl2Yil.Text = opel.yil.ToString();

            //Groupbox3 nesneleri
            groupBox3.Text = volkswagen.marka;
            lbl3Km.Text = volkswagen.km.ToString();
            lbl3Model.Text = volkswagen.model;
            lbl3Renk.Text = volkswagen.renk;
            lbl3Vites.Text = volkswagen.vites;
            lbl3Yil.Text = volkswagen.yil.ToString();

        }

        
    }
}
