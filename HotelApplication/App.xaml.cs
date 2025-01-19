using HotelApplication.Models;
namespace HotelApplication;

public partial class App : Application
{
	public List<Quarto> listaQuartos = new List<Quarto>{
		new Quarto() {
			Descricao = "Suíte Super Luxo",
			ValorDiariaAdulto = 110.0,
			ValorDiariaCrianca = 55.0
		},
		new Quarto() {
			Descricao = "Suíte Luxo",
			ValorDiariaAdulto = 90.0,
			ValorDiariaCrianca = 45.0
		},
		new Quarto() {
			Descricao = "Suíte Single",
			ValorDiariaAdulto = 60.0,
			ValorDiariaCrianca = 30.0
		},
		new Quarto() {
			Descricao = "Suíte Crise",
			ValorDiariaAdulto = 40.0,
			ValorDiariaCrianca = 20.0
		}
	};

	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new Views.ContratacaoHospedagem());
	}

	protected override Window CreateWindow(IActivationState? activationState){
		var window = base.CreateWindow(activationState);

		window.Width = 400;
		window.Height = 700;

		return window;	
	}
}
