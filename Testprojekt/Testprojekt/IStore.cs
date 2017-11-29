using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testprojekt
{
    interface IStore
    {
        string Godis_Snacks { get; }
        string Bröd { get; }
        string Mejeri_Ägg_Ost { get; }
        string Drycker { get; }
        string Skafferi { get; }
        string Frukt_Grönt { get; }
        string Färdigmat { get; }
        string Hem_Hushåll { get; }
        string Hygien { get; }
        string Kryddor_Smaksättning { get; }
        string Städ { get; }
        string Kött_Chark { get; }

    }
    class Maxi : IStore
    {
        public string Hygien { get; }
        public string Hem_Hushåll { get; }
        public string Städ { get; }
        public string Frukt_Grönt { get; }
        public string Mejeri_Ägg_Ost { get; }
        public string Skafferi { get; }
        public string Kryddor_Smaksättning { get; }
        public string Kött_Chark { get; }
        public string Bröd { get; }
        public string Färdigmat { get; }
        public string Drycker { get; }
        public string Godis_Snacks { get; }
        
        public Maxi (string[] category)
        {
            Hygien = category[0].ToString();
            Hem_Hushåll = category[1].ToString();
            Städ = category[2].ToString();
            Frukt_Grönt = category[3].ToString();
            Mejeri_Ägg_Ost = category[4].ToString();
            Skafferi = category[5].ToString();
            Kryddor_Smaksättning = category[6].ToString();
            Kött_Chark = category[7].ToString();
            Bröd = category[8].ToString();
            Färdigmat = category[9].ToString();
            Drycker = category[10].ToString();
            Godis_Snacks = category[11].ToString();            
        }
        //Maxi.Hem_Hushåll,Maxi .Bröd, Maxi.Drycker,Maxi.Frukt_Grönt, Maxi.Godis_Snacks, Maxi.Kryddor_Smaksättning,Maxi.Kött_Chark,Maxi.Mejeri_Ägg_Ost,Maxi.Skafferi,Maxi.Färdigmat,Maxi.Städ
    }
    class CityGross : IStore
    {
        public string Hygien { get; }
        public string Hem_Hushåll { get; }
        public string Städ { get; }    
        public string Kött_Chark { get; }
        public string Bröd { get; }
        public string Färdigmat { get; }
        public string Drycker { get; }
        public string Godis_Snacks { get; }
        public string Frukt_Grönt { get; }
        public string Mejeri_Ägg_Ost { get; }
        public string Skafferi { get; }
        public string Kryddor_Smaksättning { get; }
    }
    class Willys : IStore
    {
        
        public string Frukt_Grönt { get; }
        public string Mejeri_Ägg_Ost { get; }
        public string Skafferi { get; }
        public string Kryddor_Smaksättning { get; }
        public string Kött_Chark { get; }
        public string Bröd { get; }
        public string Färdigmat { get; }
        public string Drycker { get; }
        public string Godis_Snacks { get; }
        public string Hygien { get; }
        public string Hem_Hushåll { get; }
        public string Städ { get; }
    }

}
