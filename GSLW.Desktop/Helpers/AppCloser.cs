#if ANDROID
using Android.Widget;
using Android.App;
#endif
using Microsoft.Maui.Controls;

namespace GSLW.Desktop.Helpers
{
    public static class AppCloser
    {
        public static async Task CloseAsync(Page page)
        {
#if ANDROID
            Toast.MakeText(Android.App.Application.Context, "O app será fechado!", ToastLength.Short)?.Show();
            await Task.Delay(1500);
            Android.OS.Process.KillProcess(Android.OS.Process.MyPid());
#else
            await page.DisplayAlert("Fechando", "O app será fechado agora.", "OK");
            System.Diagnostics.Process.GetCurrentProcess().Kill();
#endif
        }
    }
}
