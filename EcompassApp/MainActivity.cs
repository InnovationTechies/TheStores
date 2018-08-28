using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace EcompassApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : Activity
    {

        private Button btnLogin;
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

            btnLogin.Click += btnLogin_Click;
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