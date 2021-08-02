using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;
        DataSet dataSet;
        string query;


        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }
        public void Add(Brand brand)
        {
            query = "insert into public.brands(brand_name) values ('" + brand.BrandName + "')";
            _brandDal.Add(query);
        }

        public void Delete(Brand brand)
        {
            query = @"delete from public.brands where brand_id=" + brand.BrandId;
            _brandDal.Delete(query);
        }

        public List<Brand> List()
        {
            query = "select* from public.brands";
            dataSet = _brandDal.List(query);
            Brand brand = new Brand();
            List<Brand> brands = new List<Brand>();


            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                brand = new Brand();
                
                brand.BrandId = Convert.ToInt32(dataSet.Tables[0].Rows[i]["brand_id"]);
                brand.BrandName = dataSet.Tables[0].Rows[i]["brand_name"].ToString();

                brands.Add(brand);
            }

            return brands;
        }

        public void Update(Brand brand)
        {
            query = @"update public.brands set brand_name='" + brand.BrandName + "' where brand_id=" + brand.BrandId;
            _brandDal.Update(query);
        }
    }



}
