namespace FaizHesaplamalari2
{
    partial class FrmKredi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtBoxKrediTutari = new System.Windows.Forms.TextBox();
            this.txtBoxFaiz = new System.Windows.Forms.TextBox();
            this.txtBoxTaksit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_hesapla = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 261);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(749, 230);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "KrediTutarı";
            this.columnHeader7.Width = 65;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "TaksitTutarı";
            this.columnHeader8.Width = 108;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "ÖdenenFaizTutarı";
            this.columnHeader9.Width = 138;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "ÖdenenAnaParaTutarı";
            this.columnHeader10.Width = 130;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "KalanAnaParaBorcu";
            this.columnHeader11.Width = 118;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Dönem";
            this.columnHeader12.Width = 80;
            // 
            // txtBoxKrediTutari
            // 
            this.txtBoxKrediTutari.Location = new System.Drawing.Point(190, 13);
            this.txtBoxKrediTutari.Name = "txtBoxKrediTutari";
            this.txtBoxKrediTutari.Size = new System.Drawing.Size(116, 20);
            this.txtBoxKrediTutari.TabIndex = 1;
            this.txtBoxKrediTutari.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxKrediTutari_KeyPress);
            // 
            // txtBoxFaiz
            // 
            this.txtBoxFaiz.Location = new System.Drawing.Point(190, 51);
            this.txtBoxFaiz.Name = "txtBoxFaiz";
            this.txtBoxFaiz.Size = new System.Drawing.Size(116, 20);
            this.txtBoxFaiz.TabIndex = 2;
            this.txtBoxFaiz.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxFaiz_KeyPress);
            // 
            // txtBoxTaksit
            // 
            this.txtBoxTaksit.Location = new System.Drawing.Point(190, 88);
            this.txtBoxTaksit.Name = "txtBoxTaksit";
            this.txtBoxTaksit.Size = new System.Drawing.Size(116, 20);
            this.txtBoxTaksit.TabIndex = 3;
            this.txtBoxTaksit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxTaksit_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kredi Tutarı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Faiz Oranı(%) :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Taksit Sayısı :";
            // 
            // button_hesapla
            // 
            this.button_hesapla.Location = new System.Drawing.Point(55, 140);
            this.button_hesapla.Name = "button_hesapla";
            this.button_hesapla.Size = new System.Drawing.Size(252, 63);
            this.button_hesapla.TabIndex = 8;
            this.button_hesapla.Text = "HESAPLA";
            this.button_hesapla.UseVisualStyleBackColor = true;
            this.button_hesapla.Click += new System.EventHandler(this.button_hesapla_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(351, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 63);
            this.button1.TabIndex = 9;
            this.button1.Text = "Temizle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmKredi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(772, 503);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_hesapla);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxTaksit);
            this.Controls.Add(this.txtBoxFaiz);
            this.Controls.Add(this.txtBoxKrediTutari);
            this.Controls.Add(this.listView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "FrmKredi";
            this.Text = "FrmKredi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox txtBoxKrediTutari;
        private System.Windows.Forms.TextBox txtBoxFaiz;
        private System.Windows.Forms.TextBox txtBoxTaksit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_hesapla;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.Button button1;
    }
}