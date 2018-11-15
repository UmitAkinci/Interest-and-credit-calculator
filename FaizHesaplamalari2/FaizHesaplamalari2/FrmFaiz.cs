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
    public partial class FrmFaiz : Form
    {
        public FrmFaiz()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "Seçiniz";
            txtBoxHesapla.Enabled = false;
            txtBoxAnapara.MaxLength = 11;
            txtBoxSure.MaxLength = 11;
            txtBoxFaiz.MaxLength = 11;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtBoxHesapla.Clear();
            txtBoxFaiz.Clear();
            txtBoxAnapara.Clear();
            listView1.Items.Clear();
            txtBoxSure.Clear();
            comboBox1.Text = "Seçiniz";
            checkBoxBasit.Checked = false;
            checkBoxBilesik.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            if (txtBoxAnapara.Text == "" && txtBoxFaiz.Text == "" && txtBoxSure.Text == "")
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz!" , "HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                double a = Convert.ToDouble(txtBoxAnapara.Text);
                double n = Convert.ToDouble(txtBoxFaiz.Text);
                int t = Convert.ToInt32(txtBoxSure.Text);
                double toplam;
                double faiztutari;

                for (int i = 1; i <= t; i++)
                {
                    if (checkBoxBasit.Checked)
                    {
                        ListViewItem kayit = new ListViewItem("" + a);
                        if (comboBox1.Text == "Yıllık")
                        {
                            faiztutari = (a * n * i) / 100;
                            toplam = (faiztutari) + a;
                            listView1.Items.Add(kayit);
                            kayit.SubItems.Add("%" + txtBoxFaiz.Text);
                            kayit.SubItems.Add("" + faiztutari);
                            kayit.SubItems.Add("" + toplam);
                            kayit.SubItems.Add(i + ".Yıl");
                            txtBoxHesapla.Text = toplam.ToString();
                        }
                        else if (comboBox1.Text == "Aylık")
                        {
                            faiztutari = (a * n * i) / 1200;
                            toplam = faiztutari + a;
                            listView1.Items.Add(kayit);
                            kayit.SubItems.Add("%" + txtBoxFaiz.Text);
                            kayit.SubItems.Add("" + faiztutari);
                            kayit.SubItems.Add("" + toplam);
                            kayit.SubItems.Add(i + ".Ay");
                            txtBoxHesapla.Text = toplam.ToString();
                        }
                        else if (comboBox1.Text == "Günlük")
                        {
                            faiztutari = (a * n * i) / 36000;
                            toplam = faiztutari + a;
                            listView1.Items.Add(kayit);
                            kayit.SubItems.Add("%" + txtBoxFaiz.Text);
                            kayit.SubItems.Add("" + faiztutari);
                            kayit.SubItems.Add("" + toplam);
                            kayit.SubItems.Add(i + ".Gün");
                            txtBoxHesapla.Text = toplam.ToString();
                        }

                    }
                    //(Bileşik Faiz) Faiz Tutarı = (Anapara x (1 + (Dönem Sayısı x Faiz Oranı)) - Anapara*/
                    else if (checkBoxBilesik.Checked)
                    {
                        ListViewItem kayit = new ListViewItem("" + a);
                        if (comboBox1.Text == "Yıllık")
                        {
                            faiztutari = ((a * (1 + (1 * n))) - a) / 100;
                            toplam = faiztutari + a;
                            a = a + faiztutari;
                            txtBoxHesapla.Text = a.ToString();
                            listView1.Items.Add(kayit);
                            kayit.SubItems.Add("%" + txtBoxFaiz.Text);
                            kayit.SubItems.Add("" + faiztutari);
                            kayit.SubItems.Add("" + toplam);
                            kayit.SubItems.Add(i + ".Yıl");
                        }
                        else if (comboBox1.Text == "Aylık")
                        {
                            faiztutari = ((a * (1 + (1 * n))) - a) / 1200;
                            toplam = faiztutari + a;
                            a = a + faiztutari;
                            txtBoxHesapla.Text = a.ToString();
                            listView1.Items.Add(kayit);
                            kayit.SubItems.Add("%" + txtBoxFaiz.Text);
                            kayit.SubItems.Add("" + faiztutari);
                            kayit.SubItems.Add("" + toplam);
                            kayit.SubItems.Add(i + ".Ay");
                        }
                        else if (comboBox1.Text == "Günlük")
                        {
                            faiztutari = ((a * (1 + (1 * n))) - a) / 36000;
                            toplam = faiztutari + a;
                            a = a + faiztutari;
                            txtBoxHesapla.Text = a.ToString();
                            listView1.Items.Add(kayit);
                            kayit.SubItems.Add("%" + txtBoxFaiz.Text);
                            kayit.SubItems.Add("" + faiztutari);
                            kayit.SubItems.Add("" + toplam);
                            kayit.SubItems.Add(i + ".Gün");
                        }

                    }
                }
            }
        }

        private void checkBoxBasit_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBasit.Checked)
            {
                checkBoxBilesik.Checked = false;
            }
        }

        private void checkBoxBilesik_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBilesik.Checked)
            {
                checkBoxBasit.Checked = false;
            }
        }

        private void txtBoxAnapara_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtBoxFaiz_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtBoxSure_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
