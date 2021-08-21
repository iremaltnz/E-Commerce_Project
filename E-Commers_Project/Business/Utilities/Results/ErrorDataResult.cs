using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Utilities.Results
{
    public class ErrorDataResult<T>:DataResult<T>
    {
        public ErrorDataResult(T data,string message):base(data, false, message)
        {

        }

        public ErrorDataResult(string message) : base( false, message)
        {

        }
    }
}
