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
            throw new NotImplementedException();
        }

        public void Delete(Color color)
        {
            throw new NotImplementedException();
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


                colors.Add(color);
            }

            return colors;
        }

        public void Update(Color color)
        {
            throw new NotImplementedException();
        }
    }



}
