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
    [Activity(Label = "Botón de panico", Theme = "@style/AppTheme.NoActionBar")]
    public class BotonPanicoCls : AppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.botonPanico_main);
            Android.Support.V7.Widget.Toolbar toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            if (id == Resource.Id.btn_action_botonPanico)
            {
                Intent intent = new Intent(this, typeof(BotonPanicoCls));
                StartActivity(intent);
            }
            else if (id == Resource.Id.btn_action_detectarViolencia)
            {
                Intent intent = new Intent(this, typeof(DetectarViolenciaCls));
                StartActivity(intent);
            }
            else if (id == Resource.Id.btn_action_encuestas)
            {
                Intent intent = new Intent(this, typeof(EncuestasCls));
                StartActivity(intent);
            }
            else if (id == Resource.Id.btn_action_interaccion)
            {
                Intent intent = new Intent(this, typeof(InteraccionCls));
                StartActivity(intent);
            }
            else if (id == Resource.Id.btn_action_interrupcionLegalEmbarazo)
            {
                Intent intent = new Intent(this, typeof(InterrupcionLegalEmbarazoCls));
                StartActivity(intent);
            }
            else if (id == Resource.Id.btn_action_llamadasEmergencia)
            {
                Intent intent = new Intent(this, typeof(LlamadasEmergenciaCls));
                StartActivity(intent);
            }
            else if (id == Resource.Id.btn_action_misContactosConfianza)
            {
                Intent intent = new Intent(this, typeof(MiscontactosconfianzaCls));
                StartActivity(intent);
            }
            else if (id == Resource.Id.btn_action_serviciosMedicosAdolecentes)
            {
                Intent intent = new Intent(this, typeof(ServiciosMedicosAdolecentesCls));
                StartActivity(intent);
            }
            else if (id == Resource.Id.btn_action_preguntasFrecuentes)
            {
                Intent intent = new Intent(this, typeof(PreguntasfrecuentesCls));
                StartActivity(intent);
            }
            else if (id == Resource.Id.btn_action_acercaDe)
            {
                Intent intent = new Intent(this, typeof(AcercaDeCls));
                StartActivity(intent);
            }
            return base.OnOptionsItemSelected(item);
        }

    }
}