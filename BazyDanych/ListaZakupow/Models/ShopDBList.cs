using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ListaZakupow.Models
{
    public class ShopDBList
    {

        public int Id { get; set; }
        public string Nazwa { get; set; }
        public int Ilosc { get; set; }
        public int cena { get; set; }
        public DateTime data { get; set; }
        public DateTime dataModyfikacji { get; set; }
        
    }
}