using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication7.Yardım
{
    public class işlem
    {
        public string controller { get; set; }
        public string action { get; set; }
        public bool hata { get; set; }
        public string mesaj { get; set; }
    }
    public class işlem<T> : işlem
    {
       public T sonuc { get; set; }
    }
}