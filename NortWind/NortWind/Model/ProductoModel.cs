using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace NortWind.Model
{
    [Table("Producto")]
       public class ProductoModel
    {
        [PrimaryKey,AutoIncrement]
        public int ID { get; set; }
        public int IDProducto { get; set; }
        public string Nombre { get; set; }
        public int IdCategoria { get; set; }


    }
}
