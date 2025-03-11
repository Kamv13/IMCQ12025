using IMCQ12025.ViewModels;

namespace IMCQ12025.Views;

public partial class IMCView : ContentPage
{
	IMCViewModel viewModel = new IMCViewModel();
	public IMCView()
	{
		InitializeComponent();

		viewModel = new IMCViewModel();
		this.BindingContext = viewModel;
	}
}