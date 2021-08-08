using NUnit.Framework;
using Business.Concrete;
using Entities.Concrete;
using DataAccess.Concrete.NpgSql;
using NUnit.Framework.Internal;

namespace UnitTest
{
    [TestFixture]
    public class BrandTest
    {
        BrandManager brandManager = new BrandManager(new NSBrandDal());
        Brand brand = new Brand() { brand_name = "Nike" };
        [Test]
        public void BrandList()
        {
            var result = brandManager.List();
            Assert.AreEqual(result.Success, true, "Markalar Listelenemedi");
        }

        [Test]
        public void BrandAdd()
        {
            var result = brandManager.Add(brand);
            Assert.AreEqual(result.Success, true, "Markalar Eklenemedi");
        }
        [Test]
        public void BrandUpdate()
        {
            var result = brandManager.Update(brand);
            Assert.AreEqual(result.Success, true, "Markalar Güncellenemedi");
        }
        [Test]
        /*
        public void BrandDelete()
        {
            var result = brandManager.Delete(brand);
            Assert.AreEqual(result.Success, true, "Markalar Silinemedi");
        }
        */

    }
}
