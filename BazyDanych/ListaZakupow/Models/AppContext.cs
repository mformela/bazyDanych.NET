using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ListaZakupow.Models
{
    public class AppContext : DbContext
    {
        public AppContext() : base("ShopListDB") /*wprowadzamy connection string do bazy danych - będziemy się z nią łączyć */
        {

        }

        public DbSet<ShopDBList> TestDbmodels { get; set; }
    }
}