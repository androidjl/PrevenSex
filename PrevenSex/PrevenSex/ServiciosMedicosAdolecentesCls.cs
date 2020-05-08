using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace PrevenSex
{
    [Activity(Label = "Servicios médicos para adolecentes", Theme = "@style/AppTheme.NoActionBar")]
    public class ServiciosMedicosAdolecentesCls : AppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.serviciosMedicosAdolecentes_main);
        }
    }
}

