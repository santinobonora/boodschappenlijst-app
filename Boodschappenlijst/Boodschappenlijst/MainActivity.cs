using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Boodschappenlijst
{
	[Activity (Label = "Boodschappenlijst", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		protected AlertDialog.Builder alert;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button btnRegister = FindViewById<Button> (Resource.Id.btnRegister);
			Button btnLogin = FindViewById<Button> (Resource.Id.btnLogIn);

			btnRegister.Click += (object sender, EventArgs e) => {
				DatabaseHandler dbh = new DatabaseHandler();

				//dbh.TestInsert();
				alert = new AlertDialog.Builder(this);
				alert.SetMessage("Je hebt op de registreer knop gedrukt!");
				alert.Show();
			};

			btnLogin.Click += (object sender, EventArgs e) => {
				alert = new AlertDialog.Builder(this);
				alert.SetMessage("Je hebt op de log in knop gedrukt!");
				alert.Show();
			};
		}
	}
}


