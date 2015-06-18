
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Collections;
using System.Net.Http;
using System.Net;
using System.Web.Services;
using System.Web;

namespace Boodschappenlijst
{			
	public class DatabaseHandler
	{
		public SqlConnection con;

		public DatabaseHandler()
		{
			con = new SqlConnection("server=db4free.net;database=telefoontje;uid=jowiet;Pwd=tokky123;");
		}

		public void TestConnection()
		{
			con.Open ();
		}

		public void TestInsert()
		{
			
		}

		public void OpenConnectionToDB()
		{
			con.Open();
		}

		public void CloseConnectionToDB()
		{
			con.Close();
		}

		public System.Data.DataTable fillDT(string query)
		{
			TestConnection();
			OpenConnectionToDB();

			SqlDataAdapter dataAdapter = new SqlDataAdapter(query, GetCon());
			DataTable dt = new DataTable();
			dataAdapter.Fill(dt);

			CloseConnectionToDB();

			return dt;
		}

		public SqlConnection GetCon()
		{
			return con;
		}
	}
}

