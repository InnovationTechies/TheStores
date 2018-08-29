using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System.ServiceModel;

using EcompassServiceProxy.EcompassServiceProxy;
using System;

namespace EcompassApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : Activity
    {
        static readonly EndpointAddress Endpoint = new EndpointAddress("<>");

        /// <summary>
        /// get service references
        /// </summary>
        //EcompassServiceClient _client;
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
            SetContentView(Resource.Layout.activity_home);

            btnLogin = FindViewById<Button>(Resource.Id.btnLogin);
            txtUsername = FindViewById<EditText>(Resource.Id.txtUsername);
            txtPassword = FindViewById<EditText>(Resource.Id.txtPassword);

            btnLocation = FindViewById<Button>(Resource.Id.)

            btnLogin.Click += btnLogin_Click;


            InitializeEcompassServiceClient();

            // This button will invoke the GetHelloWorldData - the method that takes a C# object as a parameter.
            _getHelloWorldDataButton = FindViewById<Button>(Resource.Id.get_hello_products_data);
           // _getHelloWorldDataButton.Click += GetHelloWorldDataButtonOnClick;
            _getHelloWorldDataTextView = FindViewById<TextView>(Resource.Id.listProducts);

            // This button will invoke SayHelloWorld - this method takes a simple string as a parameter.
            _sayHelloWorldButton = FindViewById<Button>(Resource.Id.say_hello_ecompass);
            //_sayHelloWorldButton.Click += SayHelloWorldButtonOnClick;
            _sayHelloWorldTextView = FindViewById<TextView>(Resource.Id.sayHelloTextView);

        }

        void InitializeEcompassServiceClient()
        {
            BasicHttpBinding binding = CreateBasicHttpBinding();
            //_client = new EcompassServiceClient(binding, Endpoint);
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

    }
}