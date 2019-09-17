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
                {"Hüseyin", new DavetiyeModel() { Ad = "Hüseyin", Eposta = "Hüseyin@Hüseyin.com", KatilmaDurumu = true } },
                {"Gökhan", new DavetiyeModel() { Ad = "Gökhan", Eposta = "Gökhan@Gökhan.com", KatilmaDurumu = true } },
                {"Eren", new DavetiyeModel() { Ad = "Eren", Eposta = "Eren@Eren.com", KatilmaDurumu = true } },
                {"Tuğba", new DavetiyeModel() { Ad = "Tuğba", Eposta = "Tuğba@Tuğba.com", KatilmaDurumu = true } },
                {"Büşra", new DavetiyeModel() { Ad = "Büşra", Eposta = "Büşra@Büşra.com", KatilmaDurumu = true } }
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