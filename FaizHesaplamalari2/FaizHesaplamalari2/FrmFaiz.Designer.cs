namespace FaizHesaplamalari2
{
    partial class FrmFaiz
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
            this.checkBoxBasit = new System.Windows.Forms.CheckBox();
            this.checkBoxBilesik = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxAnapara = new System.Windows.Forms.TextBox();
            this.txtBoxFaiz = new System.Windows.Forms.TextBox();
            this.txtBoxHesapla = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtBoxSure = new System.Windows.Forms.TextBox();
            this.butonHesapla = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxBasit
            // 
            this.checkBoxBasit.AutoSize = true;
            this.checkBoxBasit.Checked = true;
            this.checkBoxBasit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBasit.Location = new System.Drawing.Point(6, 14);
            this.checkBoxBasit.Name = "checkBoxBasit";
            this.checkBoxBasit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBoxBasit.Size = new System.Drawing.Size(81, 17);
            this.checkBoxBasit.TabIndex = 0;
            this.checkBoxBasit.Text = "Basit Faiz";
            this.checkBoxBasit.UseVisualStyleBackColor = true;
            this.checkBoxBasit.CheckedChanged += new System.EventHandler(this.checkBoxBasit_CheckedChanged);
            // 
            // checkBoxBilesik
            // 
            this.checkBoxBilesik.AutoSize = true;
            this.checkBoxBilesik.Location = new System.Drawing.Point(94, 14);
            this.checkBoxBilesik.Name = "checkBoxBilesik";
            this.checkBoxBilesik.Size = new System.Drawing.Size(90, 17);
            this.checkBoxBilesik.TabIndex = 1;
            this.checkBoxBilesik.Text = "Bileşik Faiz";
            this.checkBoxBilesik.UseVisualStyleBackColor = true;
            this.checkBoxBilesik.CheckedChanged += new System.EventHandler(this.checkBoxBilesik_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ana para :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Faiz Oranı (%) :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Vade sonu toplamı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Vade :";
            // 
            // txtBoxAnapara
            // 
            this.txtBoxAnapara.Location = new System.Drawing.Point(203, 19);
            this.txtBoxAnapara.Name = "txtBoxAnapara";
            this.txtBoxAnapara.Size = new System.Drawing.Size(116, 20);
            this.txtBoxAnapara.TabIndex = 6;
            this.txtBoxAnapara.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxAnapara_KeyPress);
            // 
            // txtBoxFaiz
            // 
            this.txtBoxFaiz.Location = new System.Drawing.Point(203, 45);
            this.txtBoxFaiz.Name = "txtBoxFaiz";
            this.txtBoxFaiz.Size = new System.Drawing.Size(116, 20);
            this.txtBoxFaiz.TabIndex = 7;
            this.txtBoxFaiz.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxFaiz_KeyPress);
            // 
            // txtBoxHesapla
            // 
            this.txtBoxHesapla.Location = new System.Drawing.Point(203, 127);
            this.txtBoxHesapla.Name = "txtBoxHesapla";
            this.txtBoxHesapla.Size = new System.Drawing.Size(116, 20);
            this.txtBoxHesapla.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Günlük",
            "Aylık",
            "Yıllık"});
            this.comboBox1.Location = new System.Drawing.Point(203, 72);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(81, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // txtBoxSure
            // 
            this.txtBoxSure.Location = new System.Drawing.Point(292, 71);
            this.txtBoxSure.Name = "txtBoxSure";
            this.txtBoxSure.Size = new System.Drawing.Size(26, 20);
            this.txtBoxSure.TabIndex = 11;
            this.txtBoxSure.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxSure_KeyPress);
            // 
            // butonHesapla
            // 
            this.butonHesapla.Location = new System.Drawing.Point(36, 163);
            this.butonHesapla.Name = "butonHesapla";
            this.butonHesapla.Size = new System.Drawing.Size(160, 52);
            this.butonHesapla.TabIndex = 12;
            this.butonHesapla.Text = "HESAPLA";
            this.butonHesapla.UseVisualStyleBackColor = true;
            this.butonHesapla.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(215, 163);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 52);
            this.button2.TabIndex = 13;
            this.button2.Text = "Temizle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.ColumnHeader5});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(5, 273);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(705, 217);
            this.listView1.TabIndex = 14;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ana Para";
            this.columnHeader1.Width = 107;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Faiz Oranı";
            this.columnHeader2.Width = 125;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Faiz Tutarı";
            this.columnHeader3.Width = 161;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Faiz+Anapara";
            this.columnHeader4.Width = 218;
            // 
            // ColumnHeader5
            // 
            this.ColumnHeader5.Text = "Dönem";
            this.ColumnHeader5.Width = 88;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBoxAnapara);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.butonHesapla);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txtBoxFaiz);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBoxHesapla);
            this.groupBox1.Controls.Add(this.txtBoxSure);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(5, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(706, 221);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Faiz Hesaplaması";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxBasit);
            this.groupBox2.Controls.Add(this.checkBoxBilesik);
            this.groupBox2.Location = new System.Drawing.Point(13, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(208, 37);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Faizler";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(724, 502);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxBasit;
        private System.Windows.Forms.CheckBox checkBoxBilesik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxAnapara;
        private System.Windows.Forms.TextBox txtBoxFaiz;
        private System.Windows.Forms.TextBox txtBoxHesapla;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtBoxSure;
        private System.Windows.Forms.Button butonHesapla;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader ColumnHeader5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

