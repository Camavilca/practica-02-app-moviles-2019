using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Practica02
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class View05 : ContentPage
	{
		public View05 ()
		{
			InitializeComponent ();
		}

        async private void item01(object sender, EventArgs e)
        {
            var mm = nombre.Text;
            await DisplayAlert("INFORMACION", "Nombre:"+ mm, "Ok");
        }
    }
}