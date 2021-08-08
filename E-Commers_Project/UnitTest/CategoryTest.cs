using Business.Concrete;
using DataAccess.Concrete.NpgSql;
using Entities.Concrete;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTest
{
    [TestFixture]
    public class CategoryTest
    {
        CategoryManager categoryManager = new CategoryManager(new NSCategoryDal());
        Category category = new Category() {  category_name= "Foto & Kamera" };

        [Test]
        public void CategoryList()
        {

            var result = categoryManager.List();
            Assert.AreEqual(result.Success, true, "Kategoriler listelenemedi");
        }


        [Test]
        public void CategoryAdd()
        {
           
            var result = categoryManager.Add(category);
            Assert.AreEqual(result.Success, true, result.Message);
        }

        [Test]
        public void CategoryUpdate()
        {
            category.category_id = 6;
            category.category_name = "Yazıcı";
            var result = categoryManager.Update(category);
            Assert.AreEqual(result.Success, true, result.Message);
        }

/*
        [Test]
        public void CategoryDelete()
        {

            var result = categoryManager.Delete(category);
            Assert.AreEqual(result.Success, true, result.Message);
        }*/
    }
}
