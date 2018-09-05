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

namespace EcompassApp
{
    [Activity(Label = "MainActivityHome")]
    public class MainActivityHome : Activity

    {
        private Button btnSpecials;
        private Button btnLocation;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_home);

            // Create your application here
            btnLocation = FindViewById<Button>(Resource.Id.btnLocation);
            btnLocation.Click += btnLocation_Click;
            btnSpecials = FindViewById<Button>(Resource.Id.btnSpecials);
            btnSpecials.Click += btnSpecials_Click;
        }

        private void btnSpecials_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(SpecialActivity));
        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(LocationActivity));
        }
    }
}