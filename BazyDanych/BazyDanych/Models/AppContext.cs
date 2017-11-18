using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BazyDanych.Models
{
    public class AppContext : DbContext
    {
        public AppContext() : base ("TestDB") /*wprowadzamy connection string do bazy danych - będziemy się z nią łączyć */
        {
        
        }
        
        public DbSet<TestDBmodel> TestDbmodels { get; set; }
        
       
    }
}