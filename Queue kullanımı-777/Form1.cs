using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Queue_kullanımı_777
{
    public partial class Form1 : Form
    {
        Queue<string> musteri = new Queue<string>();
        public Form1()
        {
            InitializeComponent();
        }
        private void musteriCagir(Label lbl)
        {
            if (musteri.Count > 0)
            {
                lblSira1.Text = musteri.Dequeue();
            }
            else
            {
                MessageBox.Show("işin çok hızlı bitti aferim :)");
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            musteri.Enqueue(txtAd.Text);
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            musteriCagir(lblSira1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            musteri.Enqueue("Ufuk");
            musteri.Enqueue("Rabia");
            musteri.Enqueue("Kübra");
            musteri.Enqueue("Hayrunnisa");
            musteri.Enqueue("Melisa");
        }

        private void btnGetir2_Click(object sender, EventArgs e)
        {
            musteriCagir(lblSira2);
        }

        private void btnGetir3_Click(object sender, EventArgs e)
        {
            musteriCagir(lblSira3);
        }
    }
}
