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
	public partial class View06 : ContentPage
	{
		public View06 ()
		{
			InitializeComponent ();
            fecha.MinimumDate = new DateTime(2019, 1, 1);
            fecha.MaximumDate = new DateTime(2019, 9, 30);
		}
	}
}