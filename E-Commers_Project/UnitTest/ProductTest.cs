
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
        description="��letim Sistemi Taban� : Android , 64GB Haf�za"
        }; 

        [Test]
        public void ProductList()
        {
          
            var result = productManager.List();
            Assert.AreEqual(result.Success,true,"�r�n listelenemedi");
        }

        [Test]
        public void ProductAdd()
        {

            var result = productManager.Add(product);
            Assert.AreEqual(result.Success, true, "�r�n Ekleme Ba�ar�s�z");
        }
        [Test]
        public void ProductUpdate()
        {
             product.product_id = 10;
            product.product_name = "Casper L20 64GB 10.1 FHD 4.5G Tablet";
            var result = productManager.Update(product);
            Assert.AreEqual(result.Success, true, "�r�n G�ncelleme Ba�ar�s�z");
        }

      /*  [Test]
        public void ProductDelete()
        {

            var result = productManager.Delete(product);
            Assert.AreEqual(result.Success, true, "�r�n Silme Ba�ar�s�z");
        }
      */
     
    }
}