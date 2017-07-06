using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo.Controllers
{
    public class JsonData<T>
    {
        public bool IsSucess { set; get; }
        public T Data { set; get; }

        public string Message { set; get; }
    }
}