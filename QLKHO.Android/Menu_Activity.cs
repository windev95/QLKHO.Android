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

namespace QLKHO.Android
{
    [Activity(Label = "Menu_Activity")]
    public class Menu_Activity : Activity
    {
        EditText txt1;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);

            //txt1 = FindViewById<EditText>(Resource.Id.txt1);

            //Intent it = new Intent();
            //Bundle bundle = new Bundle();
            //bundle = it.GetBundleExtra("data");
            //txt1.Text = bundle.GetString("user");

            // Create your application here
        }
    }
}