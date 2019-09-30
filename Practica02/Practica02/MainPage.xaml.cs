using Xamarin.Forms;

namespace Practica02
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async private void btn01(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new View01());
        }
         async private void btn02(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new View02());
        }
         async private void btn03(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new View03());
        }
         async private void btn04(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new View04());
        }
       async private void btn05(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new View05());
        }
       async private void btn06(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new View06());
        }
      
        
    }
}
