using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FaizHesaplamalari2
{
    public partial class FrmKredi : Form
    {
        public FrmKredi()
        {
            InitializeComponent();
        }

        private void button_hesapla_Click(object sender, EventArgs e)
        {
            double faiztutari;
            double kreditutari = Convert.ToDouble(txtBoxKrediTutari.Text);
            double faiz = Convert.ToDouble(txtBoxFaiz.Text) / 100;
            double taksitsayisi = Convert.ToInt32(txtBoxTaksit.Text);
            double us = Math.Pow(1 + faiz, taksitsayisi);
            double taksittutari = kreditutari * ((faiz * us) / (us - 1));
            double odenenanapara;
            double kalananaparaborcu;
            
            for (int i = 1; i <=taksitsayisi; i++)
            {
                ListViewItem kayit = new ListViewItem("" + kreditutari);
                //us = Math.Pow(1 + faiz, taksitsayisi);
                //taksittutari = kreditutari * ((faiz * us) / (us - 1));
                    faiztutari = kreditutari * faiz;
                    odenenanapara = taksittutari - faiztutari;
                    kalananaparaborcu = kreditutari - odenenanapara;
                    kreditutari = kalananaparaborcu;
                    listView1.Items.Add(kayit);
                    kayit.SubItems.Add("" + taksittutari.ToString("C2"));
                    kayit.SubItems.Add("" + faiztutari.ToString("C2"));
                    kayit.SubItems.Add("" + odenenanapara.ToString("C2"));
                    kayit.SubItems.Add("" + kalananaparaborcu.ToString("C2"));
                    kayit.SubItems.Add(i + ".Ay");       
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtBoxFaiz.Clear();
            txtBoxKrediTutari.Clear();
            txtBoxTaksit.Clear();
            listView1.Items.Clear();
        }

        private void txtBoxKrediTutari_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtBoxFaiz_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtBoxTaksit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
