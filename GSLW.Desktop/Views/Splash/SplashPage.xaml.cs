using System;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Dispatching;
using GSLW.Desktop.Helpers;


#if ANDROID
using Android.Widget;
using Android.App;
#endif

namespace GSLW.Desktop.Views.Splash
{
    public partial class SplashPage : ContentPage
    {
        public SplashPage()
        {
            InitializeComponent();

            // Executa a lógica após 5 segundos
            Task.Run(async () =>
            {
                await Task.Delay(5000);

                MainThread.BeginInvokeOnMainThread(async () =>
                {
                    // Troca para a tela de login
                    Microsoft.Maui.Controls.Application.Current.MainPage = new GSLW.Desktop.Views.Login.LoginPage();
                });
            });
        }
    }
}
