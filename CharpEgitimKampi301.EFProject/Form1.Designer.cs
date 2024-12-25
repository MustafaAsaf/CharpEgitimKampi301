
namespace CharpEgitimKampi301.EFProject
{
    partial class form_rehberIslemleri
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
            this.lbl_RehberId = new System.Windows.Forms.Label();
            this.lbl_RehberAdi = new System.Windows.Forms.Label();
            this.lbl_RehberSoyadi = new System.Windows.Forms.Label();
            this.txt_RehberId = new System.Windows.Forms.TextBox();
            this.txt_RehberAdi = new System.Windows.Forms.TextBox();
            this.txt_RehberSoyadi = new System.Windows.Forms.TextBox();
            this.btn_listele = new System.Windows.Forms.Button();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.btn_Id_ye_Gore_Getir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_RehberId
            // 
            this.lbl_RehberId.AutoSize = true;
            this.lbl_RehberId.Location = new System.Drawing.Point(35, 26);
            this.lbl_RehberId.Name = "lbl_RehberId";
            this.lbl_RehberId.Size = new System.Drawing.Size(57, 13);
            this.lbl_RehberId.TabIndex = 0;
            this.lbl_RehberId.Text = "Rehber Id:";
            // 
            // lbl_RehberAdi
            // 
            this.lbl_RehberAdi.AutoSize = true;
            this.lbl_RehberAdi.Location = new System.Drawing.Point(29, 68);
            this.lbl_RehberAdi.Name = "lbl_RehberAdi";
            this.lbl_RehberAdi.Size = new System.Drawing.Size(63, 13);
            this.lbl_RehberAdi.TabIndex = 1;
            this.lbl_RehberAdi.Text = "Rehber Adı:";
            // 
            // lbl_RehberSoyadi
            // 
            this.lbl_RehberSoyadi.AutoSize = true;
            this.lbl_RehberSoyadi.Location = new System.Drawing.Point(12, 108);
            this.lbl_RehberSoyadi.Name = "lbl_RehberSoyadi";
            this.lbl_RehberSoyadi.Size = new System.Drawing.Size(80, 13);
            this.lbl_RehberSoyadi.TabIndex = 2;
            this.lbl_RehberSoyadi.Text = "Rehber Soyadı:";
            // 
            // txt_RehberId
            // 
            this.txt_RehberId.Location = new System.Drawing.Point(103, 23);
            this.txt_RehberId.Name = "txt_RehberId";
            this.txt_RehberId.Size = new System.Drawing.Size(213, 20);
            this.txt_RehberId.TabIndex = 3;
            // 
            // txt_RehberAdi
            // 
            this.txt_RehberAdi.Location = new System.Drawing.Point(103, 65);
            this.txt_RehberAdi.Name = "txt_RehberAdi";
            this.txt_RehberAdi.Size = new System.Drawing.Size(213, 20);
            this.txt_RehberAdi.TabIndex = 4;
            // 
            // txt_RehberSoyadi
            // 
            this.txt_RehberSoyadi.Location = new System.Drawing.Point(103, 105);
            this.txt_RehberSoyadi.Name = "txt_RehberSoyadi";
            this.txt_RehberSoyadi.Size = new System.Drawing.Size(213, 20);
            this.txt_RehberSoyadi.TabIndex = 5;
            // 
            // btn_listele
            // 
            this.btn_listele.Location = new System.Drawing.Point(103, 150);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(213, 28);
            this.btn_listele.TabIndex = 6;
            this.btn_listele.Text = "Listele";
            this.btn_listele.UseVisualStyleBackColor = true;
            this.btn_listele.Click += new System.EventHandler(this.btn_listele_Click);
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Location = new System.Drawing.Point(103, 184);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(213, 28);
            this.btn_Ekle.TabIndex = 7;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.Location = new System.Drawing.Point(103, 218);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(213, 28);
            this.btn_Sil.TabIndex = 8;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Location = new System.Drawing.Point(103, 252);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(213, 28);
            this.btn_Guncelle.TabIndex = 9;
            this.btn_Guncelle.Text = "Güncelle";
            this.btn_Guncelle.UseVisualStyleBackColor = true;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // btn_Id_ye_Gore_Getir
            // 
            this.btn_Id_ye_Gore_Getir.Location = new System.Drawing.Point(103, 286);
            this.btn_Id_ye_Gore_Getir.Name = "btn_Id_ye_Gore_Getir";
            this.btn_Id_ye_Gore_Getir.Size = new System.Drawing.Size(213, 28);
            this.btn_Id_ye_Gore_Getir.TabIndex = 10;
            this.btn_Id_ye_Gore_Getir.Text = "Id\'ye Göre Getir";
            this.btn_Id_ye_Gore_Getir.UseVisualStyleBackColor = true;
            this.btn_Id_ye_Gore_Getir.Click += new System.EventHandler(this.btn_Id_ye_Gore_Getir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(351, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(437, 291);
            this.dataGridView1.TabIndex = 11;
            // 
            // form_rehberIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 341);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Id_ye_Gore_Getir);
            this.Controls.Add(this.btn_Guncelle);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.btn_listele);
            this.Controls.Add(this.txt_RehberSoyadi);
            this.Controls.Add(this.txt_RehberAdi);
            this.Controls.Add(this.txt_RehberId);
            this.Controls.Add(this.lbl_RehberSoyadi);
            this.Controls.Add(this.lbl_RehberAdi);
            this.Controls.Add(this.lbl_RehberId);
            this.Name = "form_rehberIslemleri";
            this.Text = "Rehber İşlemleri";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_RehberId;
        private System.Windows.Forms.Label lbl_RehberAdi;
        private System.Windows.Forms.Label lbl_RehberSoyadi;
        private System.Windows.Forms.TextBox txt_RehberId;
        private System.Windows.Forms.TextBox txt_RehberAdi;
        private System.Windows.Forms.TextBox txt_RehberSoyadi;
        private System.Windows.Forms.Button btn_listele;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.Button btn_Id_ye_Gore_Getir;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

