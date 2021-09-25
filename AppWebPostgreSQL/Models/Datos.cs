using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;




namespace AppWebPostgreSQL.Models
{
    public class Datos : DbContext
    {
        public Datos():base(nameOrConnectionString:"ejemplo1")
        { }
        public DbSet<Producto> producto
        {
            get; set;
        }

   
    }
}