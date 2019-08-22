using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.ObjectModel;
using NortWind.Model;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NortWind.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CategView : ContentPage
	{
        
		public CategView ()
		{
			InitializeComponent ();
		}
        ObservableCollection<ProductoModel> Producto_ = new ObservableCollection<ProductoModel>();

        private void BtnADD_Clicked(object sender, EventArgs e)
        {
            ProductoModel ProductoAgregar = new ProductoModel
            {
                Nombre = EntryName.Text
            };
            EntryName.Text = "";
            Producto_.Add(ProductoAgregar);
            ProductosListView.ItemsSource = Producto_;
            //ProductosListView
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            BaseDeDatos Base_Datos = new BaseDeDatos();

            CategoriaModel newCategoria = new CategoriaModel();
            newCategoria.Categoria = EntryCategoria.Text;
            newCategoria.Descrpcion = EntryDescripcion.Text;

            int IdCategoria = Base_Datos.InsertarCategoria(newCategoria);
            if (IdCategoria != -1)
            {
                foreach (ProductoModel ProductoAinsertar in Producto_ )
                     
                {
                    ProductoAinsertar.IdCategoria = newCategoria.IdCategoria;
                    Base_Datos.InsertProducto(ProductoAinsertar);
                }
                Navigation.PushAsync(new ProseView());

            }
            else
            {
                DisplayAlert("Error", "No se logro Ingresar la Categoria", "Ok");
            }
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ProseView());
        }
    }
}