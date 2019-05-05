using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Denuncie
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Denuncia : ContentPage
	{
		public Denuncia ()
		{
			InitializeComponent ();
		}

        private async void BtImageLocation_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Mensagem!", "Localização obtida com sucesso!", "OK");
        }

        private async void BtEscolherImagem_Clicked(object sender, EventArgs e)
        {
            string action = await DisplayActionSheet("Anexar uma imagem!", "Cancel", null, "Tirar foto", "Imagem da Galeria");
        }

        private async void BtEnviar_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Mensagem!", "Denúncia enviada com sucesso!", "OK");
            await Navigation.PopToRootAsync();
        }
    }
}