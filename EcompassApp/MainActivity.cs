﻿using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System.Net.Http;
using System;
using System.Collections.Generic;
using ServiceProxy.EcompassServiceProxy;
using System.ServiceModel;

namespace EcompassApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : Activity
    {
        static readonly EndpointAddress Endpoint = new EndpointAddress("http://localhost:8733/Design_Time_Addresses/StoresService/EcompassService/");


        EcompassServiceClient _client;
        Button _getHelloWorldDataButton;
        TextView _getHelloWorldDataTextView;
        Button _sayHelloWorldButton;
        TextView _sayHelloWorldTextView;


        private Button btnLogin;
        private Button btnSpecials;
        private Button btnLocation;
        private EditText txtUsername;
        private EditText txtPassword;
        public object ToastLenght { get; private set; }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            btnLogin = FindViewById<Button>(Resource.Id.btnLogin);
            txtUsername = FindViewById<EditText>(Resource.Id.txtUsername);
            txtPassword = FindViewById<EditText>(Resource.Id.txtPassword);

            btnLogin.Click += btnLogin_Click;


            InitializeEcompassServiceClient();

            // This button will invoke the GetHelloWorldData - the method that takes a C# object as a parameter.
            _getHelloWorldDataButton = FindViewById<Button>(Resource.Id.getHelloWorldDataButton);
            _getHelloWorldDataButton.Click += GetHelloWorldDataButtonOnClick;
            _getHelloWorldDataTextView = FindViewById<TextView>(Resource.Id.getHelloWorldDataTextView);



            // This button will invoke SayHelloWorld - this method takes a simple string as a parameter.
            _sayHelloWorldButton = FindViewById<Button>(Resource.Id.sayHelloWorldButton);
            _sayHelloWorldButton.Click += SayHelloWorldButtonOnClick;
            _sayHelloWorldTextView = FindViewById<TextView>(Resource.Id.sayHelloWorldTextView);
        

    }

        void InitializeEcompassServiceClient()
        {
            BasicHttpBinding binding = CreateBasicHttpBinding();
            _client = new EcompassServiceClient(binding, Endpoint);
        }


        static BasicHttpBinding CreateBasicHttpBinding()
        {
            BasicHttpBinding binding = new BasicHttpBinding
            {
                Name = "basicHttpBinding",
                MaxBufferSize = 2147483647,
                MaxReceivedMessageSize = 2147483647
            };

            TimeSpan timeout = new TimeSpan(0, 0, 30);
            binding.SendTimeout = timeout;
            binding.OpenTimeout = timeout;
            binding.ReceiveTimeout = timeout;
            return binding;
        }

        private void btnLogin_Click(object sender,System. EventArgs e)
        {
            if (txtUsername.Text == "software" && txtPassword.Text == "dev")
            {
                StartActivity(typeof(Activity1));

            }
            else
            {
                Toast.MakeText(this, "üsername or password is incorrect", ToastLength.Long).Show();
            }
        }


        async void GetHelloWorldDataButtonOnClick(object sender, EventArgs e)
        {
            var data = new List<PnpProducts>
            {
                //Name = "Mr. Chad",
                //SayHello = true
            };

            _getHelloWorldDataTextView.Text = "Waiting for WCF...";
            PnpProducts result;
            try
            {
                //result = await _client.GetProductsData();
                //_getHelloWorldDataTextView.Text = result.ProductName;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        async void SayHelloWorldButtonOnClick(object sender, EventArgs e)
        {
            _sayHelloWorldTextView.Text = "Waiting for WCF...";
            try
            {
                //var result = await _client.SayHelloToAsync("Kilroy");
                //_sayHelloWorldTextView.Text = result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}