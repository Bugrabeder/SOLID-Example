using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SingleResponsibility
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            // SRP: Her nesne kendi işini yapmalı(bir işten sorumlu olmalı)
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void paraEkleme_Click(object sender, EventArgs e)
        {
            string hesapadi = hesapAdi.Text;
            int paraMiktari = Convert.ToInt32(tutar.Text);
            Cevirici euro = new Cevirici { doviz= new Euro()};
            Cevirici dolar = new Cevirici { doviz = new Dolar() };
            MüsteriParaEkleme müsteri1 = new MüsteriParaEkleme { ceviricii=euro};
            MüsteriParaEkleme müsteri2 = new MüsteriParaEkleme { ceviricii=dolar};
            toplamPara.Text=Convert.ToString(müsteri1.paraEkleme(hesapadi,paraMiktari));
            Eurotextbox.Text = Convert.ToString(müsteri1.cevirici(paraMiktari));
            dolartextbox.Text = Convert.ToString(müsteri2.cevirici(paraMiktari));
            MessageBox.Show("Paranız başarıyla eklenmiştir.");
            

        }

       
    }
}
