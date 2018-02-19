using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MPlayer
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            //player.RegisterFailedAction(msg => DisplayAlert("Alert", "Hello " + msg, "OK"));
        }
        void OnButtonClicked(object sender, EventArgs e)
        { 
            play();
        }
        private void play(string url = null)
        {
            System.Diagnostics.Debug.WriteLine(String.Format("play({0})", url));
        }

    }
}
