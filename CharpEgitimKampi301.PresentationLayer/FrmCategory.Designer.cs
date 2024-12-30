
namespace CharpEgitimKampi301.PresentationLayer
{
    partial class FrmCategory
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
            this.txt_CategoryId = new System.Windows.Forms.TextBox();
            this.txt_CategoryName = new System.Windows.Forms.TextBox();
            this.radio_Aktif = new System.Windows.Forms.RadioButton();
            this.radio_Pasif = new System.Windows.Forms.RadioButton();
            this.lbl_categoryId = new System.Windows.Forms.Label();
            this.lbl_categoryName = new System.Windows.Forms.Label();
            this.btn_GetAll = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_GetById = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_categoryState = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_CategoryId
            // 
            this.txt_CategoryId.Location = new System.Drawing.Point(148, 30);
            this.txt_CategoryId.Name = "txt_CategoryId";
            this.txt_CategoryId.Size = new System.Drawing.Size(237, 22);
            this.txt_CategoryId.TabIndex = 0;
            // 
            // txt_CategoryName
            // 
            this.txt_CategoryName.Location = new System.Drawing.Point(148, 68);
            this.txt_CategoryName.Name = "txt_CategoryName";
            this.txt_CategoryName.Size = new System.Drawing.Size(237, 22);
            this.txt_CategoryName.TabIndex = 1;
            // 
            // radio_Aktif
            // 
            this.radio_Aktif.AutoSize = true;
            this.radio_Aktif.Location = new System.Drawing.Point(180, 111);
            this.radio_Aktif.Name = "radio_Aktif";
            this.radio_Aktif.Size = new System.Drawing.Size(56, 21);
            this.radio_Aktif.TabIndex = 2;
            this.radio_Aktif.TabStop = true;
            this.radio_Aktif.Text = "Aktif";
            this.radio_Aktif.UseVisualStyleBackColor = true;
            // 
            // radio_Pasif
            // 
            this.radio_Pasif.AutoSize = true;
            this.radio_Pasif.Location = new System.Drawing.Point(275, 111);
            this.radio_Pasif.Name = "radio_Pasif";
            this.radio_Pasif.Size = new System.Drawing.Size(60, 21);
            this.radio_Pasif.TabIndex = 3;
            this.radio_Pasif.TabStop = true;
            this.radio_Pasif.Text = "Pasif";
            this.radio_Pasif.UseVisualStyleBackColor = true;
            // 
            // lbl_categoryId
            // 
            this.lbl_categoryId.AutoSize = true;
            this.lbl_categoryId.Location = new System.Drawing.Point(40, 30);
            this.lbl_categoryId.Name = "lbl_categoryId";
            this.lbl_categoryId.Size = new System.Drawing.Size(82, 17);
            this.lbl_categoryId.TabIndex = 4;
            this.lbl_categoryId.Text = "Kategori ID:";
            // 
            // lbl_categoryName
            // 
            this.lbl_categoryName.AutoSize = true;
            this.lbl_categoryName.Location = new System.Drawing.Point(33, 71);
            this.lbl_categoryName.Name = "lbl_categoryName";
            this.lbl_categoryName.Size = new System.Drawing.Size(89, 17);
            this.lbl_categoryName.TabIndex = 5;
            this.lbl_categoryName.Text = "Kategori Adı:";
            // 
            // btn_GetAll
            // 
            this.btn_GetAll.Location = new System.Drawing.Point(148, 154);
            this.btn_GetAll.Name = "btn_GetAll";
            this.btn_GetAll.Size = new System.Drawing.Size(237, 42);
            this.btn_GetAll.TabIndex = 6;
            this.btn_GetAll.Text = "Listele";
            this.btn_GetAll.UseVisualStyleBackColor = true;
            this.btn_GetAll.Click += new System.EventHandler(this.btn_GetAll_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(148, 211);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(237, 42);
            this.btn_Add.TabIndex = 7;
            this.btn_Add.Text = "Ekle";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(148, 273);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(237, 42);
            this.btn_Delete.TabIndex = 8;
            this.btn_Delete.Text = "Sil";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(148, 330);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(237, 42);
            this.btn_Update.TabIndex = 9;
            this.btn_Update.Text = "Güncelle";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_GetById
            // 
            this.btn_GetById.Location = new System.Drawing.Point(148, 393);
            this.btn_GetById.Name = "btn_GetById";
            this.btn_GetById.Size = new System.Drawing.Size(237, 42);
            this.btn_GetById.TabIndex = 10;
            this.btn_GetById.Text = "Id\'ye Göre Getir";
            this.btn_GetById.UseVisualStyleBackColor = true;
            this.btn_GetById.Click += new System.EventHandler(this.btn_GetById_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Location = new System.Drawing.Point(489, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(654, 405);
            this.dataGridView1.TabIndex = 11;
            // 
            // lbl_categoryState
            // 
            this.lbl_categoryState.AutoSize = true;
            this.lbl_categoryState.Location = new System.Drawing.Point(11, 113);
            this.lbl_categoryState.Name = "lbl_categoryState";
            this.lbl_categoryState.Size = new System.Drawing.Size(111, 17);
            this.lbl_categoryState.TabIndex = 12;
            this.lbl_categoryState.Text = "Kategori Durum:";
            // 
            // FrmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 453);
            this.Controls.Add(this.lbl_categoryState);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_GetById);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_GetAll);
            this.Controls.Add(this.lbl_categoryName);
            this.Controls.Add(this.lbl_categoryId);
            this.Controls.Add(this.radio_Pasif);
            this.Controls.Add(this.radio_Aktif);
            this.Controls.Add(this.txt_CategoryName);
            this.Controls.Add(this.txt_CategoryId);
            this.Name = "FrmCategory";
            this.Text = "FrmCategory";
            this.Load += new System.EventHandler(this.FrmCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_CategoryId;
        private System.Windows.Forms.TextBox txt_CategoryName;
        private System.Windows.Forms.RadioButton radio_Aktif;
        private System.Windows.Forms.RadioButton radio_Pasif;
        private System.Windows.Forms.Label lbl_categoryId;
        private System.Windows.Forms.Label lbl_categoryName;
        private System.Windows.Forms.Button btn_GetAll;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_GetById;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_categoryState;
    }
}