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
            query = "insert into public.colors(color_name) values ('" + color.ColorName + "')";
            _colorDal.Add(query);
        }

        public void Delete(Color color)
        {
            query = @"delete from public.colors where color_id=" + color.ColorId;
            _colorDal.Delete(query);
        }

        public List<Color> List()
        {
            query = "select* from public.colors";
            dataSet = _colorDal.List(query);
            Color color = new Color();
            List<Color> colors = new List<Color>();


            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                color = new Color();

                color.ColorId = Convert.ToInt32(dataSet.Tables[0].Rows[i]["color_id"]);
                color.ColorName = dataSet.Tables[0].Rows[i]["color_name"].ToString();

                colors.Add(color);
            }

            return colors;
        }

        public void Update(Color color)
        {
            query = @"update public.colors set color_name='" + color.ColorName + "' where color_id=" + color.ColorId;
            _colorDal.Update(query);
        }
    }



}
