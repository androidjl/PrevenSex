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
    [Activity(Label = "Interrupción Legal del Embarazo", Theme = "@style/AppTheme.NoActionBar")]
    public class InterrupcionLegalEmbarazoCls : AppCompatActivity
    {
        string[] items;
        string[] items2;
        string[] items3;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            items = new string[] {
            "Selecciona pais...",
            "Mexico"
            };
            items2 = new string[] {
            "Selecciona estado...",
            "Ciudad de México",
            "Michoacan de Ocampo",
            "Chiapas",
            "Oaxaca",
            "Yucatan"
            };
            items3 = new string[] {
            "Selecciona municipio...",
            "San Cristóbal de Las Casas",
            "Tuxtla Gutierrez",
            "Ocosingo",
            "Comitan de Dominguez",
            "Teopisca",
            "Berriozabal"
            };
           
            int cont = 0;
            List<string> lista_items = new List<string>();
            foreach (string p in items)
            {
                lista_items.Add(items[cont]);
                cont = cont + 1;
            }


            int cont2 = 0;
            List<string> lista_items2 = new List<string>();
            foreach (string p in items2)
            {
                lista_items2.Add(items2[cont2]);
                cont2 = cont2 + 1;
            }

            int cont3 = 0;
            List<string> lista_items3 = new List<string>();
            foreach (string p in items3)
            {
                lista_items3.Add(items3[cont3]);
                cont3 = cont3 + 1;
            }
            SetContentView(Resource.Layout.interrupcionLegalEmbarazo_main);

            Android.Support.V7.Widget.Toolbar toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);
            
            var spin = FindViewById<Spinner>(Resource.Id.spinner1);
            var adapter = new ArrayAdapter<string>(this,Android.Resource.Layout.SimpleSpinnerItem, lista_items);
            spin.Adapter = adapter;

            var spin2 = FindViewById<Spinner>(Resource.Id.spinner2);
            var adapter2 = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleSpinnerItem, lista_items2);
            spin2.Adapter = adapter2;

            var spin3 = FindViewById<Spinner>(Resource.Id.spinner3);
            var adapter3 = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleSpinnerItem, lista_items3);
            spin3.Adapter = adapter3;
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
               /*Intent intent = new Intent(this, typeof(InterrupcionLegalEmbarazoCls));
                StartActivity(intent);*/
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
            else if (id == Resource.Id.btn_action_contactanos)
            {
                Intent intent = new Intent(this, typeof(ContactanosCls));
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

    