using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BirthdayApp.Models
{
    public static class Veritabani
    {
        private static Dictionary<string, DavetiyeModel> davetiyeler;
        static Veritabani()
        {
            davetiyeler = new Dictionary<string, DavetiyeModel>() {
                {"Osman", new DavetiyeModel() { Ad = "Osman", Eposta = "osman@osman.com", KatilmaDurumu = false } },
                {"Hacer", new DavetiyeModel() { Ad = "Hacer", Eposta = "hacer@hacer.com", KatilmaDurumu = true } },
                {"Merve", new DavetiyeModel() { Ad = "Merve", Eposta = "Merve@Merve.com", KatilmaDurumu = true } },
                {"Ayşe", new DavetiyeModel() { Ad = "Ayşe", Eposta = "Ayşe@Ayşe.com", KatilmaDurumu = true } },
                {"Murat", new DavetiyeModel() { Ad = "Murat", Eposta = "Murat@Murat.com", KatilmaDurumu = true } },
                {"Fatma", new DavetiyeModel() { Ad = "Fatma", Eposta = "Fatma@Fatma.com", KatilmaDurumu = true } },
                {"Rıdvan", new DavetiyeModel() { Ad = "Rıdvan", Eposta = "Rıdvan@Rıdvan.com", KatilmaDurumu = true } },
                {"Kübra", new DavetiyeModel() { Ad = "Kübra", Eposta = "Kübra@Kübra.com", KatilmaDurumu = true } }
            };
        }

        public static void Add(DavetiyeModel davetiyeModel)
        {
            string key = davetiyeModel.Ad.ToLower();
            if (davetiyeler.ContainsKey(key))
            {
                davetiyeler[key] = davetiyeModel;
            }
            else
            {
                davetiyeler.Add(key, davetiyeModel);
            }
        }
        public static IEnumerable<DavetiyeModel> Liste
        {
            get { return davetiyeler.Values; }
        }
    }
}