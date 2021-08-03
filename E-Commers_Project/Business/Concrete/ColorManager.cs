using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;
        DataSet dataSet;
        string query;


        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }
        public void Add(Color color)
        {
            //query = "insert into public.colors(color_name) values ('" + color.ColorName + "')";
            //_colorDal.Add(query);
        }

        public void Delete(Color color)
        {
            //query = @"delete from public.colors where color_id=" + color.ColorId;
            //_colorDal.Delete(query);
        }

        public List<Color> List()
        { 
            return _colorDal.List();
        }

        public void Update(Color color)
        {
        //    query = @"update public.colors set color_name='" + color.ColorName + "' where color_id=" + color.ColorId;
        //    _colorDal.Update(query);
        }
    }



}
