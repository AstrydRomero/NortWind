using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NortWind.Model;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NortWind.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ProseView : ContentPage
	{
        BaseDeDatos DB = new BaseDeDatos();
		public ProseView ()
		{
			InitializeComponent ();
            List<CategoriaModel> categoria = new List<CategoriaModel>();
            categoria = DB.LeerCategoria();
            Cat.ItemsSource = categoria;
		}

        private void Cat_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            CategoriaModel categoriaelegida = new CategoriaModel();
            categoriaelegida = (CategoriaModel)e.SelectedItem;
            int IdCategoria = categoriaelegida.IdCategoria;
            List<ProductoModel> productosmostrar = new List<ProductoModel>();
            productosmostrar = DB.LeerProductoyCategoria(IdCategoria);

            ProductosListView.ItemsSource = productosmostrar;
            Cat.IsVisible = false;
            ProductosListView.IsVisible = true;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Cat.IsVisible = true;
            ProductosListView.IsVisible = false;
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CategView());
        }
    }
}