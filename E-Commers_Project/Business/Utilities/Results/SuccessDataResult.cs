using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Utilities.Results
{
    public class SuccessDataResult<T>:DataResult<T>
    {
        public SuccessDataResult(T data,string message):base(data,true,message)
        {

        }
      
     
    }
}
