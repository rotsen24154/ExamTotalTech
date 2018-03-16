using Android.App;
using Android.Content.PM;
using Android.OS;
using ExamTotalTech.Droid.Platform;
using ExamTotalTech.Platform;
using ImageCircle.Forms.Plugin.Droid;
using Lottie.Forms.Droid;
using Prism;
using Prism.Ioc;

namespace ExamTotalTech.Droid
{
    [Activity(Label = "ExamTotalTech", Icon = "@drawable/icon", Theme = "@style/splashscreen", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;
            base.SetTheme(Resource.Style.MainTheme);
            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);

            Xamarin.FormsGoogleMaps.Init(this, bundle);
            Xamarin.FormsGoogleMapsBindings.Init();
            ImageCircleRenderer.Init();
            AnimationViewRenderer.Init();
            LoadApplication(new App(new AndroidInitializer()));
        }
    }

    public class AndroidInitializer : IPlatformInitializer
    {
        public void RegisterTypes(IContainerRegistry container)
        {
            container.Register<IAppUrl, AppUrl>();
        }
    }
}

