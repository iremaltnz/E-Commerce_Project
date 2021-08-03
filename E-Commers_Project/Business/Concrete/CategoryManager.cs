using Business.Abstract;
using DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        DataSet dataSet;
        string query;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Add(Category category)
        {
            //query = "insert into public.categories(category_name) values ('" + category.CategoryName + "')";
            //_categoryDal.Add(query);
        }

        public void Delete(Category category)
        {
        //    query = @"delete from public.categories where category_id=" + category.CategoryId ;
        //    _categoryDal.Delete(query);
        }

        public List<Category> List()
        {
            
            return _categoryDal.List();
        }

        public void Update(Category category)
        {
            //query = @"update public.categories set category_name='" + category.CategoryName + "' where category_id=" + category.CategoryId ;
            //_categoryDal.Update(query);
        }
    }
}
