using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace PrevenSex
{
    [Activity(Label = "",Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            Android.Support.V7.Widget.Toolbar toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);

            Button buttonInicio = FindViewById<Button>(Resource.Id.buttonInicio);
            buttonInicio.Click += delegate {
                Intent intent = new Intent(this, typeof(MenuCls));
                StartActivity(intent);
            };
            Button buttonOmiitir = FindViewById<Button>(Resource.Id.buttonOmitir);
            buttonOmiitir.Click += delegate {
                Intent intent = new Intent(this, typeof(MenuCls));
                StartActivity(intent);
            };

        }

        
	}
}

