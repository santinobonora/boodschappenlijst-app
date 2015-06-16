using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Boodschappenlijst
{
	[Activity (Label = "Boodschappenlijst", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button btnRegister = FindViewById<Button> (Resource.Id.btnRegister);

			btnRegister.Click += (object sender, EventArgs e) => {
				AlertDialog.Builder alert = new AlertDialog.Builder(this);
				alert.SetMessage("Hallo hiero");
				alert.Show();
			};
		}
	}
}


