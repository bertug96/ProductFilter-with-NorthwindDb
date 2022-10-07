namespace RecapProject1
{
    partial class form1
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
            this.gbx_category = new System.Windows.Forms.GroupBox();
            this.cmb_category = new System.Windows.Forms.ComboBox();
            this.lbl_kategori = new System.Windows.Forms.Label();
            this.gbx_search = new System.Windows.Forms.GroupBox();
            this.lbl_search = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.dgw_product = new System.Windows.Forms.DataGridView();
            this.gbx_category.SuspendLayout();
            this.gbx_search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_product)).BeginInit();
            this.SuspendLayout();
            // 
            // gbx_category
            // 
            this.gbx_category.Controls.Add(this.lbl_kategori);
            this.gbx_category.Controls.Add(this.cmb_category);
            this.gbx_category.Location = new System.Drawing.Point(13, 13);
            this.gbx_category.Name = "gbx_category";
            this.gbx_category.Size = new System.Drawing.Size(775, 61);
            this.gbx_category.TabIndex = 0;
            this.gbx_category.TabStop = false;
            this.gbx_category.Text = "Kategoriye Göre Listele";
            // 
            // cmb_category
            // 
            this.cmb_category.FormattingEnabled = true;
            this.cmb_category.Location = new System.Drawing.Point(69, 24);
            this.cmb_category.Name = "cmb_category";
            this.cmb_category.Size = new System.Drawing.Size(184, 21);
            this.cmb_category.TabIndex = 0;
            this.cmb_category.SelectedIndexChanged += new System.EventHandler(this.cmb_category_SelectedIndexChanged);
            // 
            // lbl_kategori
            // 
            this.lbl_kategori.AutoSize = true;
            this.lbl_kategori.Location = new System.Drawing.Point(6, 27);
            this.lbl_kategori.Name = "lbl_kategori";
            this.lbl_kategori.Size = new System.Drawing.Size(49, 13);
            this.lbl_kategori.TabIndex = 1;
            this.lbl_kategori.Text = "Kategori:";
            // 
            // gbx_search
            // 
            this.gbx_search.Controls.Add(this.txt_search);
            this.gbx_search.Controls.Add(this.lbl_search);
            this.gbx_search.Location = new System.Drawing.Point(13, 92);
            this.gbx_search.Name = "gbx_search";
            this.gbx_search.Size = new System.Drawing.Size(775, 67);
            this.gbx_search.TabIndex = 1;
            this.gbx_search.TabStop = false;
            this.gbx_search.Text = "Ürün İsmine Göre Ara";
            // 
            // lbl_search
            // 
            this.lbl_search.AutoSize = true;
            this.lbl_search.Location = new System.Drawing.Point(9, 33);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(26, 13);
            this.lbl_search.TabIndex = 0;
            this.lbl_search.Text = "Ara:";
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(69, 30);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(184, 20);
            this.txt_search.TabIndex = 1;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // dgw_product
            // 
            this.dgw_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_product.Location = new System.Drawing.Point(13, 183);
            this.dgw_product.Name = "dgw_product";
            this.dgw_product.Size = new System.Drawing.Size(775, 157);
            this.dgw_product.TabIndex = 2;
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgw_product);
            this.Controls.Add(this.gbx_search);
            this.Controls.Add(this.gbx_category);
            this.Name = "form1";
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.form1_Load);
            this.gbx_category.ResumeLayout(false);
            this.gbx_category.PerformLayout();
            this.gbx_search.ResumeLayout(false);
            this.gbx_search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_product)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_category;
        private System.Windows.Forms.Label lbl_kategori;
        private System.Windows.Forms.ComboBox cmb_category;
        private System.Windows.Forms.GroupBox gbx_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label lbl_search;
        private System.Windows.Forms.DataGridView dgw_product;
    }
}

