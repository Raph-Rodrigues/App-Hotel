using HotelApplication.Models;
namespace HotelApplication.Views;

public partial class ContratacaoHospedagem : ContentPage {
	App PropriedadesApp;

	public ContratacaoHospedagem() {
		InitializeComponent();

		PropriedadesApp = (App)Application.Current;
		pckQuarto.ItemsSource = PropriedadesApp.listaQuartos;

		dtpckCheckIn.MinimumDate = DateTime.Now;
		dtpckCheckIn.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);

		dtpckCheckOut.MinimumDate = dtpckCheckIn.Date.AddDays(1);
		dtpckCheckOut.MaximumDate = dtpckCheckIn.Date.AddMonths(6);
	}

	private async void Button_Clicked(object sender, EventArgs e)
    {
		try {
			Hospedagem h = new Hospedagem{
				QuartoSelecionado = (Quarto)pckQuarto.SelectedItem,
				QtdAdultos = Convert.ToInt32(stpAdultos.Value),
				QtdCriancas = Convert.ToInt32(stpCriancas.Value),
				DataCheckIn = dtpckCheckIn.Date,
				DataCheckOut = dtpckCheckOut.Date
			};

			await Navigation.PushAsync(new HospedagemContratada() {
				BindingContext = h
			});
		} catch(Exception ex) {
			await DisplayAlert("Ops", ex.Message, "OK");
		}
    }

    private void dtpckCheckIn_DateSelected(object sender, DateChangedEventArgs e)
    {
		DatePicker elemento = sender as DatePicker;

		DateTime dataSelecionadaCheckIn = elemento.Date;

		dtpckCheckOut.MinimumDate = dataSelecionadaCheckIn.AddDays(1);
		dtpckCheckOut.MaximumDate = dataSelecionadaCheckIn.AddMonths(6);
    }
}