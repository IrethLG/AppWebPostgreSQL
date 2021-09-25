using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AppWebPostgreSQL.Models
{
    [Table("tabla",Schema="public")]

    public class Producto
    {
        [Key]
        public Int32 idproducto
        {
            get; set;
        }
        public string nombre
        {
            get; set;
        }
        public string marca
        {
            get; set;
        }
        public string color
        {
            get; set;
        }
    }
}