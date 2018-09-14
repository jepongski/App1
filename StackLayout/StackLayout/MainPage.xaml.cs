using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace StackLayout
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void AboutClick(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new exercise2());

        }

        private async void CalcMe(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }

        private async void ShowDataBinding(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DataBinding());
        }
    }
}
