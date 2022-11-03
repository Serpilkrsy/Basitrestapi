using WebApplication7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication7.Yardım;

namespace WebApplication7.Controllers
{
    public class UrunlerController : ApiController
    {
        public IHttpActionResult getUrunler()
        {

            urun[] urun = new urun[]
            {
                new urun{kod=1,ad="test ürün 1",fiyat=10},
                new urun{kod=2,ad="test ürün 2",fiyat=20},
                new urun{kod=3,ad="test ürün 3",fiyat=15},
            };

            işlem<List<urun>> sonuc = new işlem<List<urun>>()
            {
                action = "getUrunler",
                controller = "Urunler",
                hata = false,
                mesaj = "açık kaynak yazılım geliştirme ödev",
                sonuc=urun.ToList()
            };
            return Ok(sonuc);
            
        }
    }
}
