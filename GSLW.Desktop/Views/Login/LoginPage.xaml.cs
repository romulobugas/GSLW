using Microsoft.Maui.Controls;

namespace GSLW.Desktop.Views.Login
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            if (UserEntry.Text == "admin" && PasswordEntry.Text == "1234")
            {
                await DisplayAlert("Sucesso", "Login realizado!", "OK");
                // Aqui pode navegar para a tela principal, exemplo:
                // Application.Current.MainPage = new MainPage();
            }
            else
            {
                await DisplayAlert("Erro", "Usuário ou senha inválidos", "OK");
            }
        }

        private async void OnRegisterClicked(object sender, EventArgs e)
        {
            // Troca para a tela de Cadastro
            Microsoft.Maui.Controls.Application.Current.MainPage = new GSLW.Desktop.Views.Register.RegisterPage();
        }
    }
}
