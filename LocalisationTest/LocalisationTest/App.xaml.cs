using LocalisationTest.Resources;
using Plugin.Multilingual;
using System.Globalization;
using Xamarin.Forms;

namespace LocalisationTest
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();
            CrossMultilingual.Current.CurrentCultureInfo = new CultureInfo("da");
            AppResources.Culture = CrossMultilingual.Current.CurrentCultureInfo;
            MainPage = new MainPage();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
