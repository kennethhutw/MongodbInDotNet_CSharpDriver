using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;  


namespace MongoCSharpDriver
{
    public partial class Product : System.Web.UI.Page
    {
       
        MongoDatabase myDB;
        protected void Page_Load(object sender, EventArgs e)
        {
            List<MongoProduct> Products = new List<MongoProduct>();
            // 產生 MongoClient 物件
            MongoClient _client = new MongoClient("Server=localhost:27017");
            // 取得 MongoServer 物件
            MongoServer server = _client.GetServer();
            // 取得 MongoDatabase 物件
            myDB = server.GetDatabase("test");
            // 取得 Collection
            MongoCollection<MongoProduct> _Products = myDB.GetCollection<MongoProduct>("Products");

            foreach (MongoProduct product in _Products.FindAll())
            {

                Products.Add(product);
            }
            gvProducts.DataSource = Products;
            gvProducts.DataBind();
        }

        protected void btnNewProduct_Click(object sender, EventArgs e)
        {
            MongoCollection<MongoProduct> _Products = myDB.GetCollection<MongoProduct>("Products");
            var newProduct = new MongoProduct();
            newProduct.ID = DateTime.Now.ToString("yyyyMMddHHmmss");
            newProduct.ProductName = txtProductName.Text;
            newProduct.Quantity = txtQuantity.Text;

            _Products.Insert(newProduct);

            MongoCollection<MongoProduct> _NewProducts = myDB.GetCollection<MongoProduct>("Products");
            List<MongoProduct> Products = new List<MongoProduct>();
            foreach (MongoProduct product in _NewProducts.FindAll())
            {

                Products.Add(product);
            }
            txtProductName.Text = "";
            txtQuantity.Text = "";
            gvProducts.DataSource = Products;
            gvProducts.DataBind();

        }

        protected void btnDeleteById_Click(object sender, EventArgs e)
        {
            MongoCollection<MongoProduct> _Products = myDB.GetCollection<MongoProduct>("Products");


            if (!String.IsNullOrEmpty(txtDeleteById.Text))
            {
                _Products.Remove(Query.EQ("ID", txtDeleteById.Text));
            }
            List<MongoProduct> Products = new List<MongoProduct>();
            foreach (MongoProduct product in _Products.FindAll())
            {

                Products.Add(product);
            }
            txtDeleteById.Text = string.Empty;
            gvProducts.DataSource = Products;
            gvProducts.DataBind();
        }

        protected void btnUpdateByID_Click(object sender, EventArgs e)
        {
            List<MongoProduct> Products = new List<MongoProduct>();
            MongoCollection<MongoProduct> _Products = myDB.GetCollection<MongoProduct>("Products");

            var _product = _Products.FindOne(Query.EQ("ID", txtUpdateByID.Text));
            if (_product != null)
            {
            
                _product.Quantity = txtUpdateQuantity.Text;
                _Products.Save(_product);
            }
            foreach (MongoProduct product in _Products.FindAll())
            {

                Products.Add(product);
            }
            gvProducts.DataSource = Products;
            gvProducts.DataBind();

        }

        protected void btnQueryAll_Click(object sender, EventArgs e)
        {
            List<MongoProduct> Products = new List<MongoProduct>();
            MongoCollection<MongoProduct> _Products = myDB.GetCollection<MongoProduct>("Products");

            foreach (MongoProduct product in _Products.FindAll())
            {

                Products.Add(product);
            }
            gvProducts.DataSource = Products;
            gvProducts.DataBind();
        }

        protected void btnQueryById_Click(object sender, EventArgs e)
        {
            List<MongoProduct> Products = new List<MongoProduct>();
            MongoCollection<MongoProduct> _Products = myDB.GetCollection<MongoProduct>("Products");

            var _product = _Products.FindOne(Query.EQ("ID", txtQueryById.Text));

            Products.Add(_product);
            txtQueryById.Text = string.Empty;
            gvProducts.DataSource = Products;
            gvProducts.DataBind();
        }
    }
}