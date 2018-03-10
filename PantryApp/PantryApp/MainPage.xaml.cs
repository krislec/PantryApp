using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PantryApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        public void ClickedButton(object sender, EventArgs args)
        {
            count++;
            ((Button)sender).Text =
                String.Format("{0} click{1}", count, count == 1 ? "" : "s");

        }

        public async void OnPantryDetailPage(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new PantryDetailPage());
            }
            catch (Exception EX)
            {
                ((Button)sender).Text = EX.Message;
            }

        }

        public async void ToPantryAddPage(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new PantryAdd());
            }
            catch (Exception EX)
            {
                ((Button)sender).Text = EX.Message;
            }

        }
        public async void ToTestTabbedPage(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new TabbedMainPage());
            }
            catch (Exception EX)
            {
                ((Button)sender).Text = EX.Message;
            }

        }






    }
}