using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PDC60_MOD04
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void Open_Page1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
        private async void Open_Page2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }

}
