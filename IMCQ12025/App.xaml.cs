using IMCQ12025.Views;

namespace IMCQ12025
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new IMCView();
        }
    }
}
