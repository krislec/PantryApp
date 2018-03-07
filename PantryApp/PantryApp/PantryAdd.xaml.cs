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
	public partial class PantryAdd : ContentPage
	{
        int count2 = 100;
		public PantryAdd ()
		{
			InitializeComponent ();
		}
        public void ClickedButton(object sender, EventArgs args)
        {
            count2++;
            ((Button)sender).Text =
                String.Format("{0} click{1}", count2, count2 == 1 ? "" : "s");

        }
        public async void ToManualAdd(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new ManualAdd());
            }
            catch (Exception EX)
            {
                ((Button)sender).Text = EX.Message;
            }

        }
    }
}