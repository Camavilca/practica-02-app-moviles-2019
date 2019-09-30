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
	public partial class View03Form02 : ContentPage
	{
		public View03Form02 ()
		{

            var stack = new StackLayout();

            var btn = new Button();
            btn.Text = "Atras";
            btn.Clicked += principal;
		}

        async private void principal(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new View03());                
        }
    }
}