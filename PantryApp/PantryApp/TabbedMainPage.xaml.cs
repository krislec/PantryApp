
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PantryApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabbedMainPage : TabbedPage
    {
        public TabbedMainPage()
        {
            InitializeComponent();
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






    }


}