using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}
        private async void OnClick1(object sender, EventArgs e)
        {
            TranslatorService service = new TranslatorService();
            var translatedText = await service.TranslateString(FromEntry.Text, "ar");
            likecount.Text = translatedText;

        }
    }
}
