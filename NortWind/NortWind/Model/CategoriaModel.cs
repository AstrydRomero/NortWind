using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace NortWind.Model
{ 
    [Table("Categoria")]
       public class CategoriaModel
       {
        [PrimaryKey,AutoIncrement]
        public int IdCategoria { get; set; }
        public string Categoria { get; set; }
        public string Descrpcion { get; set; }
    }
}
