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
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmFaiz f1=new FrmFaiz();
            f1.ShowDialog();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmKredi frmkredi=new FrmKredi();
            frmkredi.ShowDialog();
        }
    }
}
