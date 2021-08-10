
using Business.Concrete;
using DataAccess.Concrete.NpgSql;
using Entities.Concrete;
using NUnit.Framework;

namespace UnitTest
{
    [TestFixture]
    public class ProductTest
    {
        ProductManager productManager = new ProductManager(new NSProductDal());
        Product product = new Product() {product_name= "deneme",
        brand_id=6,
        category_id=5,
        product_price=1699,
        stock_quantity=5,
        color_id=3,
        description="Ýþletim Sistemi Tabaný : Android , 64GB Hafýza"
        }; 

        [Test]
        public void ProductList()
        {
          
            var result = productManager.ProductList();
            Assert.AreEqual(result.Success,true,"Ürün listelenemedi");
        }

        [Test]
        public void ProductAdd()
        {

            var result = productManager.ProductAdd(product);
            Assert.AreEqual(result.Success, true, "Ürün Ekleme Baþarýsýz");
        }
        [Test]
        public void ProductUpdate()
        {
             product.product_id = 10;
            product.product_name = "Casper L20 64GB 10.1 FHD 4.5G Tablet";
            var result = productManager.ProductUpdate(product);
            Assert.AreEqual(result.Success, true, "Ürün Güncelleme Baþarýsýz");
        }

        /*  [Test]
          public void ProductDelete()
          {

              var result = productManager.ProductDelete(product);
              Assert.AreEqual(result.Success, true, "Ürün Silme Baþarýsýz");
          }
        */

    }
}