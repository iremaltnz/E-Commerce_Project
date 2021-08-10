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
            var result = brandManager.BrandList();
            Assert.AreEqual(result.Success, true, "Markalar Listelenemedi");
        }

        [Test]
        public void BrandAdd()
        {
            var result = brandManager.BrandAdd(brand);
            Assert.AreEqual(result.Success, true, "Markalar Eklenemedi");
        }
        [Test]
        public void BrandUpdate()
        {
            var result = brandManager.BrandUpdate(brand);
            Assert.AreEqual(result.Success, true, "Markalar Güncellenemedi");
        }

        /*
        [Test]
        public void BrandDelete()
        {
            var result = brandManager.BrandDelete(brand);
            Assert.AreEqual(result.Success, true, "Markalar Silinemedi");
        }
        */

    }
}
