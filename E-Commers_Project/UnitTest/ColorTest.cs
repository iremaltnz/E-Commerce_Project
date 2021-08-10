using NUnit.Framework;
using Business.Concrete;
using Entities.Concrete;
using DataAccess.Concrete.NpgSql;
using NUnit.Framework.Internal;

namespace UnitTest
{
    [TestFixture]
    class ColorTest
    {
        ColorManager colorManager = new ColorManager(new NSColorDal());
        Color color = new Color() { color_name = "Turkuaz" };
        [Test]
        public void ColorList()
        {
            var result = colorManager.ColorList();
            Assert.AreEqual(result.Success, true, "Renkler Listelenemedi");
        }

        [Test]
        public void ColorAdd()
        {
            var result = colorManager.ColorAdd(color);
            Assert.AreEqual(result.Success, true, "Renkler Eklenemedi");
        }
        [Test]
        public void ColorUpdate()
        {
            var result = colorManager.ColorUpdate(color);
            Assert.AreEqual(result.Success, true, "Renkler Güncellenemedi");
        }

        /*
        [Test]
        public void ColorDelete()
        {
            var result = colorManager.ColorDelete(color);
            Assert.AreEqual(result.Success, true, "Renkler Silinemedi");
        }
        */


    }
}
