namespace E_OKUL
{
    partial class Form3
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
            this.isim = new System.Windows.Forms.TextBox();
            this.soyisim = new System.Windows.Forms.TextBox();
            this.ekle = new System.Windows.Forms.Button();
            this.ogrecibolum = new System.Windows.Forms.TextBox();
            this.ogrencisinif = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.ogrno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dogumtrh = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // isim
            // 
            this.isim.Location = new System.Drawing.Point(119, 55);
            this.isim.Name = "isim";
            this.isim.Size = new System.Drawing.Size(125, 27);
            this.isim.TabIndex = 0;
            // 
            // soyisim
            // 
            this.soyisim.Location = new System.Drawing.Point(119, 116);
            this.soyisim.Name = "soyisim";
            this.soyisim.Size = new System.Drawing.Size(125, 27);
            this.soyisim.TabIndex = 0;
            // 
            // ekle
            // 
            this.ekle.Location = new System.Drawing.Point(141, 350);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(94, 29);
            this.ekle.TabIndex = 1;
            this.ekle.Text = "Ekle";
            this.ekle.UseVisualStyleBackColor = true;
            this.ekle.Click += new System.EventHandler(this.button1_Click);
            // 
            // ogrecibolum
            // 
            this.ogrecibolum.Location = new System.Drawing.Point(119, 215);
            this.ogrecibolum.Name = "ogrecibolum";
            this.ogrecibolum.Size = new System.Drawing.Size(125, 27);
            this.ogrecibolum.TabIndex = 2;
            // 
            // ogrencisinif
            // 
            this.ogrencisinif.Location = new System.Drawing.Point(119, 276);
            this.ogrencisinif.Name = "ogrencisinif";
            this.ogrencisinif.Size = new System.Drawing.Size(125, 27);
            this.ogrencisinif.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ad..:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Soyad..:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bölüm..:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ögrenci Sinif..:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(284, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(362, 426);
            this.dataGridView1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(141, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ogrno
            // 
            this.ogrno.Location = new System.Drawing.Point(119, 165);
            this.ogrno.Name = "ogrno";
            this.ogrno.Size = new System.Drawing.Size(125, 27);
            this.ogrno.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ögrenci NO..:";
            // 
            // dogumtrh
            // 
            this.dogumtrh.Location = new System.Drawing.Point(119, 316);
            this.dogumtrh.Name = "dogumtrh";
            this.dogumtrh.Size = new System.Drawing.Size(125, 27);
            this.dogumtrh.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "dogum trh..:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 450);
            this.Controls.Add(this.dogumtrh);
            this.Controls.Add(this.ogrno);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ogrencisinif);
            this.Controls.Add(this.ogrecibolum);
            this.Controls.Add(this.ekle);
            this.Controls.Add(this.soyisim);
            this.Controls.Add(this.isim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox isim;
        private TextBox soyisim;
        private Button ekle;
        private TextBox ogrecibolum;
        private TextBox ogrencisinif;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dataGridView1;
        private Button button1;
        private TextBox ogrno;
        private Label label5;
        private TextBox dogumtrh;
        private Label label6;
    }
}