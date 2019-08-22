using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.IO;
using NortWind.Model;

namespace NortWind.Model
{
    public class BaseDeDatos
    {
        public SQLiteConnection Connection { get; set; }

        public BaseDeDatos()
        {
            Connection = new SQLiteConnection(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Datos.db3"));
            Connection.CreateTable<CategoriaModel>();
            Connection.CreateTable<ProductoModel>();
        }


        public int InsertarCategoria(CategoriaModel Category)
        {
            return Connection.Insert(Category);
        }

        public int InsertProducto(ProductoModel Product)
        {
            return Connection.Insert(Product);
        }


        //categoria
        public CategoriaModel LeerCategoria(int IdCategoria)
        {
            return Connection.Table<CategoriaModel>().Where(N => N.IdCategoria == IdCategoria).FirstOrDefault();
        }

        public List<CategoriaModel> LeerCategoria()
        {
            return Connection.Table<CategoriaModel>().ToList();
        }


        //Producto
        public ProductoModel LeerProducto(int IdProducto)
        {
            return Connection.Table<ProductoModel>().Where(n => n.IDProducto == IdProducto).FirstOrDefault();
        }
        public List<ProductoModel> LeerProducto()
        {
            return Connection.Table<ProductoModel>().ToList();
        }

        public List<ProductoModel> LeerProductoyCategoria(int idcategoria)
        {
            return Connection.Table<ProductoModel>().Where(n => n.IdCategoria == idcategoria).ToList();
        }
    }
}
