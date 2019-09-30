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
	public partial class View03 : ContentPage
	{
		public View03 ()
		{
			InitializeComponent ();

		}

        async private void form01(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new View03Form01());
        }

        async private void form02(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new View03Form02());
        }
    }
}