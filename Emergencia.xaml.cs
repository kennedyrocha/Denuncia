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
	public partial class Emergencia : ContentPage
	{
		public Emergencia ()
		{
			InitializeComponent ();
		}

        private async void BtdenunciaDetalhada_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Denuncia());
        }

        private async void ImageCircle_Clicked(object sender, EventArgs e)
        {
            bool answer = await DisplayAlert("Mensagem!", "Tem certeza que deseja enviar? \n\nObs: Sua localização será enviada!", "Sim", "Não");

            if (answer == true)
            {
                await DisplayAlert("Mensagem!", "Pedido enviado com sucesso!", "OK");
                await Navigation.PopToRootAsync();
            }
        }
    }
}