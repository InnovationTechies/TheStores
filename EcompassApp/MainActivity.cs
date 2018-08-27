using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System.Collections.Generic;
using System.Net.Http;
using System;
using System.ServiceModel;
using EcompassServiceProxy.EcompassServiceProxy;

namespace EcompassApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {

        static readonly EndpointAddress Endpoint = new EndpointAddress("<insert_WCF_service_endpoint_here>");


        EcompassServiceClient _client;
        Button _getHelloWorldDataButton;
        ListView _getHelloWorldDataTextView;
        Button _sayHelloWorldButton;
        TextView _sayHelloWorldTextView;



        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);



            // This button will invoke the GetHelloWorldData - the method that takes a C# object as a parameter.
            //_getHelloWorldDataButton = FindViewById<Button>(Resource.Id.get_hello_products_data);
            //_getHelloWorldDataButton.Click += GetHelloWorldDataButtonOnClick;
            //_getHelloWorldDataTextView = FindViewById<TextView>(Resource.Id.getHelloWorldDataTextView);

            //// This button will invoke SayHelloWorld - this method takes a simple string as a parameter.
            //_sayHelloWorldButton = FindViewById<Button>(Resource.Id.sayHelloWorldButton);
            //_sayHelloWorldButton.Click += SayHelloWorldButtonOnClick;
            //_sayHelloWorldTextView = FindViewById<TextView>(Resource.Id.sayHelloWorldTextView);

        }
    }
}