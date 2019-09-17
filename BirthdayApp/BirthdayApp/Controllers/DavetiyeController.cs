using BirthdayApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BirthdayApp.Controllers
{
    public class DavetiyeController : ApiController
    {
        [Route("Katilanlar")]
        [HttpGet]
        public IEnumerable<DavetiyeModel> Katilanlar()
        {
            return Veritabani.Liste.Where(i => i.KatilmaDurumu == true);
        }
        [Route("Katilmayanlar")]
        [HttpGet]
        public IEnumerable<DavetiyeModel> Katilmayanlar()
        {
            return Veritabani.Liste.Where(i => i.KatilmaDurumu == false);
        }

        [HttpPost]
        public void Ekle(DavetiyeModel model)
        {
            if (ModelState.IsValid)
            {
                Veritabani.Add(model);
            }
        }
    }

    
}
