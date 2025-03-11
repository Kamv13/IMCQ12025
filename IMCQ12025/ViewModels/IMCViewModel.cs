
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace IMCQ12025.ViewModels
{
    public partial class IMCViewModel : ObservableObject

    {
        [ObservableProperty]
        private double peso;

        [ObservableProperty]
        private double estatura;

        [ObservableProperty]
        private double imc;

        [ObservableProperty]
        private string rango;

        private void Alerta(string Titulo, string Mensaje)
        {
            MainThread.BeginInvokeOnMainThread(async () => await App.Current!.MainPage!.DisplayAlert(Titulo, Mensaje, "Aceptar"));
        }

        [RelayCommand]
        private void Calcular()
        {
            try
            {
                if (!(Peso > 0))
                {

                    Alerta("ADVERTENCIA", "Valor del peso no valido");

                }
                else if (!(Estatura > 0))
                {
                    Alerta("ADVERTENCIA", "Valor de la estatura no valido");
                }
                else
                {
                    Imc = Math.Round( Peso / (Estatura * Estatura),2);
                    Rango = rangoImc(Imc);
                }
                 

            }
            catch (Exception ex)
            {
                Alerta("Error", ex.Message);

            }
        }

        private string rangoImc (double imc) 
        {
            string rango = "";
            if (!(imc > 18.5))
            {
                rango = "Bajo peso";
            }
            else if (imc != 18.5 && imc <= 24.9)
            {
                rango = "peso normal";
            }
            else if (imc != 25 && imc <= 29.9)
            {
                rango = "Sobre Peso";
            }
            else 
            {
                rango = "Obesidad";
            }
            return rango;  
        }
        [RelayCommand]
        private void Limpiar()
        { 
            Peso = 0;
            Estatura = 0;
            Imc = 0;
            Rango = string.Empty;
        
        }
    }
}