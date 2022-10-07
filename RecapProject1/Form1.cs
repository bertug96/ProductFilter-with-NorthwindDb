using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapProject1
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void form1_Load(object sender, EventArgs e)
        {
            ListCategories();
            ListProducts();
        }

        private void ListProducts()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                dgw_product.DataSource = context.Products.ToList();  // DataGrid'e Product class'ın daki tüm field'ları listeler
            }
        }
        private void ListCategories()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                cmb_category.DataSource = context.Categories.ToList();
                cmb_category.DisplayMember = "CategoryName";
                cmb_category.ValueMember = "CategoryId";
            }
        }
        private void ListProductsByCategory(int categoryId)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                dgw_product.DataSource = context.Products.Where(p => p.CategoryId==categoryId).ToList();
            }
        }
        private void ListProductsByProductName(string key)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                dgw_product.DataSource = context.Products.Where(p => p.ProductName.ToLower().Contains(key.ToLower())).ToList();
            }
        }

        private void cmb_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ListProductsByCategory(Convert.ToInt32(cmb_category.SelectedValue));
            }
            catch
            {
                
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string key = txt_search.Text;
            if (string.IsNullOrEmpty(key))
            {
                ListProducts();
            }
            else
            {
                ListProductsByProductName(txt_search.Text);
            }
        }
    }
}
