
namespace CharpEgitimKampi301.PresentationLayer
{
    partial class FrmProduct
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_GetById = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_GetAll = new System.Windows.Forms.Button();
            this.lbl_ProductName = new System.Windows.Forms.Label();
            this.lbl_productId = new System.Windows.Forms.Label();
            this.txt_ProductName = new System.Windows.Forms.TextBox();
            this.txt_ProductId = new System.Windows.Forms.TextBox();
            this.lbl_UrunStock = new System.Windows.Forms.Label();
            this.txt_ProductStock = new System.Windows.Forms.TextBox();
            this.lbl_ProductPrice = new System.Windows.Forms.Label();
            this.txt_ProductPrice = new System.Windows.Forms.TextBox();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.cmb_Category = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.btn_Temizle = new System.Windows.Forms.Button();
            this.btnExit_Click = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Location = new System.Drawing.Point(401, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1120, 551);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_GetById
            // 
            this.btn_GetById.Enabled = false;
            this.btn_GetById.Location = new System.Drawing.Point(26, 373);
            this.btn_GetById.Name = "btn_GetById";
            this.btn_GetById.Size = new System.Drawing.Size(175, 42);
            this.btn_GetById.TabIndex = 23;
            this.btn_GetById.Text = "Id\'ye Göre Getir";
            this.btn_GetById.UseVisualStyleBackColor = true;
            this.btn_GetById.Click += new System.EventHandler(this.btn_GetById_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(207, 421);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(175, 42);
            this.btn_Update.TabIndex = 22;
            this.btn_Update.Text = "Güncelle";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(26, 421);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(175, 42);
            this.btn_Delete.TabIndex = 21;
            this.btn_Delete.Text = "Sil";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(207, 373);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(175, 42);
            this.btn_Add.TabIndex = 20;
            this.btn_Add.Text = "Ekle";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_GetAll
            // 
            this.btn_GetAll.Location = new System.Drawing.Point(26, 517);
            this.btn_GetAll.Name = "btn_GetAll";
            this.btn_GetAll.Size = new System.Drawing.Size(356, 42);
            this.btn_GetAll.TabIndex = 19;
            this.btn_GetAll.Text = "Listele";
            this.btn_GetAll.UseVisualStyleBackColor = true;
            this.btn_GetAll.Click += new System.EventHandler(this.btn_GetAll_Click);
            // 
            // lbl_ProductName
            // 
            this.lbl_ProductName.AutoSize = true;
            this.lbl_ProductName.Location = new System.Drawing.Point(23, 68);
            this.lbl_ProductName.Name = "lbl_ProductName";
            this.lbl_ProductName.Size = new System.Drawing.Size(67, 17);
            this.lbl_ProductName.TabIndex = 18;
            this.lbl_ProductName.Text = "Ürün Adı:";
            // 
            // lbl_productId
            // 
            this.lbl_productId.AutoSize = true;
            this.lbl_productId.Location = new System.Drawing.Point(27, 27);
            this.lbl_productId.Name = "lbl_productId";
            this.lbl_productId.Size = new System.Drawing.Size(63, 17);
            this.lbl_productId.TabIndex = 17;
            this.lbl_productId.Text = "Ürüm ID:";
            // 
            // txt_ProductName
            // 
            this.txt_ProductName.Location = new System.Drawing.Point(116, 65);
            this.txt_ProductName.Name = "txt_ProductName";
            this.txt_ProductName.Size = new System.Drawing.Size(237, 22);
            this.txt_ProductName.TabIndex = 14;
            // 
            // txt_ProductId
            // 
            this.txt_ProductId.Enabled = false;
            this.txt_ProductId.Location = new System.Drawing.Point(116, 27);
            this.txt_ProductId.Name = "txt_ProductId";
            this.txt_ProductId.Size = new System.Drawing.Size(237, 22);
            this.txt_ProductId.TabIndex = 13;
            // 
            // lbl_UrunStock
            // 
            this.lbl_UrunStock.AutoSize = true;
            this.lbl_UrunStock.Location = new System.Drawing.Point(15, 109);
            this.lbl_UrunStock.Name = "lbl_UrunStock";
            this.lbl_UrunStock.Size = new System.Drawing.Size(75, 17);
            this.lbl_UrunStock.TabIndex = 27;
            this.lbl_UrunStock.Text = "Ürün Stok:";
            // 
            // txt_ProductStock
            // 
            this.txt_ProductStock.Location = new System.Drawing.Point(116, 106);
            this.txt_ProductStock.Name = "txt_ProductStock";
            this.txt_ProductStock.Size = new System.Drawing.Size(237, 22);
            this.txt_ProductStock.TabIndex = 26;
            // 
            // lbl_ProductPrice
            // 
            this.lbl_ProductPrice.AutoSize = true;
            this.lbl_ProductPrice.Location = new System.Drawing.Point(13, 147);
            this.lbl_ProductPrice.Name = "lbl_ProductPrice";
            this.lbl_ProductPrice.Size = new System.Drawing.Size(77, 17);
            this.lbl_ProductPrice.TabIndex = 29;
            this.lbl_ProductPrice.Text = "Ürün Fiyat:";
            // 
            // txt_ProductPrice
            // 
            this.txt_ProductPrice.Location = new System.Drawing.Point(116, 147);
            this.txt_ProductPrice.Name = "txt_ProductPrice";
            this.txt_ProductPrice.Size = new System.Drawing.Size(237, 22);
            this.txt_ProductPrice.TabIndex = 28;
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Location = new System.Drawing.Point(25, 192);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(65, 17);
            this.lbl_Category.TabIndex = 31;
            this.lbl_Category.Text = "Kategori:";
            // 
            // cmb_Category
            // 
            this.cmb_Category.FormattingEnabled = true;
            this.cmb_Category.Location = new System.Drawing.Point(119, 189);
            this.cmb_Category.Name = "cmb_Category";
            this.cmb_Category.Size = new System.Drawing.Size(234, 24);
            this.cmb_Category.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Açıklama:";
            // 
            // txt_Description
            // 
            this.txt_Description.Location = new System.Drawing.Point(119, 232);
            this.txt_Description.Multiline = true;
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(237, 123);
            this.txt_Description.TabIndex = 34;
            // 
            // btn_Temizle
            // 
            this.btn_Temizle.Location = new System.Drawing.Point(26, 469);
            this.btn_Temizle.Name = "btn_Temizle";
            this.btn_Temizle.Size = new System.Drawing.Size(175, 42);
            this.btn_Temizle.TabIndex = 35;
            this.btn_Temizle.Text = "Temizle";
            this.btn_Temizle.UseVisualStyleBackColor = true;
            this.btn_Temizle.Click += new System.EventHandler(this.btn_Temizle_Click);
            // 
            // btnExit_Click
            // 
            this.btnExit_Click.Location = new System.Drawing.Point(207, 469);
            this.btnExit_Click.Name = "btnExit_Click";
            this.btnExit_Click.Size = new System.Drawing.Size(175, 42);
            this.btnExit_Click.TabIndex = 36;
            this.btnExit_Click.Text = "Çıkış";
            this.btnExit_Click.UseVisualStyleBackColor = true;
            this.btnExit_Click.Click += new System.EventHandler(this.btnExit_Click_Click);
            // 
            // FrmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1539, 596);
            this.Controls.Add(this.btnExit_Click);
            this.Controls.Add(this.btn_Temizle);
            this.Controls.Add(this.txt_Description);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_Category);
            this.Controls.Add(this.lbl_Category);
            this.Controls.Add(this.lbl_ProductPrice);
            this.Controls.Add(this.txt_ProductPrice);
            this.Controls.Add(this.lbl_UrunStock);
            this.Controls.Add(this.txt_ProductStock);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_GetById);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_GetAll);
            this.Controls.Add(this.lbl_ProductName);
            this.Controls.Add(this.lbl_productId);
            this.Controls.Add(this.txt_ProductName);
            this.Controls.Add(this.txt_ProductId);
            this.Name = "FrmProduct";
            this.Text = "FrmProduct";
            this.Load += new System.EventHandler(this.FrmProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_GetById;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_GetAll;
        private System.Windows.Forms.Label lbl_ProductName;
        private System.Windows.Forms.Label lbl_productId;
        private System.Windows.Forms.TextBox txt_ProductName;
        private System.Windows.Forms.TextBox txt_ProductId;
        private System.Windows.Forms.Label lbl_UrunStock;
        private System.Windows.Forms.TextBox txt_ProductStock;
        private System.Windows.Forms.Label lbl_ProductPrice;
        private System.Windows.Forms.TextBox txt_ProductPrice;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.ComboBox cmb_Category;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Description;
        private System.Windows.Forms.Button btn_Temizle;
        private System.Windows.Forms.Button btnExit_Click;
    }
}