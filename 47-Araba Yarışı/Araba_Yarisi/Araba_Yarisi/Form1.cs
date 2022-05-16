using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Araba_Yarisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void btnSifirla_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            pbMotor.Location = new Point(594,71);
            pbAraba.Location = new Point(594,171);
            lblMotorHizi.Text = "Hız: 0 km/s";
            lblArabaHizi.Text = "Hız: 0 km/s";

        }
        int araba, motor;
        Random rastgele = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            araba = rastgele.Next(1, 20);
            motor = rastgele.Next(1, 20);
            pbMotor.Location = new Point(pbMotor.Location.X-motor,pbMotor.Location.Y);
            pbAraba.Location = new Point(pbAraba.Location.X - araba, pbAraba.Location.Y);
            lblMotorHizi.Text = "Hız: " + motor + " km/s";
            lblArabaHizi.Text = "Hız: " + araba + " km/s";

            if (pbMotor.Location.X<33)
            {
                timer1.Enabled = false;
                MessageBox.Show("Motor Kazandı");
                
            }
            else if (pbAraba.Location.X<33)
            {
                timer1.Enabled = false;
                MessageBox.Show("Araba Kazandı");
                
            }
        }
    }
}
