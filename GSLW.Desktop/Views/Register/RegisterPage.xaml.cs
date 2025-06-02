using Microsoft.Maui.Controls;

namespace GSLW.Desktop.Views.Register
{
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private async void OnRegisterClicked(object sender, EventArgs e)
        {

            if (NewUserEntry.Text != null && NewPasswordEntry.Text != null)
            {
                await DisplayAlert("Sucesso", "Cadastro realizado!", "OK");
                // Aqui pode navegar para a tela principal, exemplo:
                // Application.Current.MainPage = new MainPage();

                // Troca para a tela de 12 palavras
                Microsoft.Maui.Controls.Application.Current.MainPage = new GSLW.Desktop.Views.Words.WordsPage();
            }
            else
            {
                await DisplayAlert("Erro", "Por gentileza digite um usuário e senha", "OK");
            }
        }
    }
}
