using Android.App;
using Android.Content;
using Android.OS;
using System.Threading.Tasks;

namespace SplashScreen.Droid
{
    [Activity(Theme = "@style/MyTheme.Splash", MainLauncher = true, NoHistory = true)]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            Task startupWork = new Task(() => { SimulateStartup(); });
            startupWork.Start();
        }

        async void SimulateStartup()
        {
            await Task.Delay(8000);
            StartActivity(new Intent(Application.Context, typeof(MainActivity)));
        }
    }
}