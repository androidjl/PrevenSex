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
    [Activity(Label = "Menú principal", Theme = "@style/AppTheme.NoActionBar")]
    public class MenuCls : AppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.menu);

            Android.Support.V7.Widget.Toolbar toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);

            ImageButton img_btn_botonpanico = FindViewById<ImageButton>(Resource.Id.img_btn_botonpanico);
            img_btn_botonpanico.Click += delegate {
                Intent intent = new Intent(this, typeof(BotonPanicoCls));
                StartActivity(intent);
            };

            ImageButton img_btn_detectarViolencia = FindViewById<ImageButton>(Resource.Id.img_btn_detectarViolencia);
            img_btn_detectarViolencia.Click += delegate {
                Intent intent = new Intent(this, typeof(DetectarViolenciaCls));
                StartActivity(intent);
            };

            ImageButton img_btn_encuestas = FindViewById<ImageButton>(Resource.Id.img_btn_encuestas);
            img_btn_encuestas.Click += delegate {
                Intent intent = new Intent(this, typeof(EncuestasCls));
                StartActivity(intent);
            };

            ImageButton img_btn_interaccion = FindViewById<ImageButton>(Resource.Id.img_btn_interaccion);
            img_btn_interaccion.Click += delegate {
                Intent intent = new Intent(this, typeof(InteraccionCls));
                StartActivity(intent);
            };

            ImageButton img_btn_interrupcionLegalEmbarazo = FindViewById<ImageButton>(Resource.Id.img_btn_interrupcionLegalEmbarazo);
            img_btn_interrupcionLegalEmbarazo.Click += delegate {
                Intent intent = new Intent(this, typeof(InterrupcionLegalEmbarazoCls));
                StartActivity(intent);
            };

            ImageButton img_btn_llamadasEmergencia = FindViewById<ImageButton>(Resource.Id.img_btn_llamadasEmergencia);
            img_btn_llamadasEmergencia.Click += delegate {
                Intent intent = new Intent(this, typeof(LlamadasEmergenciaCls));
                StartActivity(intent);
            };

            ImageButton img_btn_miscontactosconfianza = FindViewById<ImageButton>(Resource.Id.img_btn_miscontactosconfianza);
            img_btn_miscontactosconfianza.Click += delegate {
                Intent intent = new Intent(this, typeof(MiscontactosconfianzaCls));
                StartActivity(intent);
            };

            ImageButton img_btn_preguntasFrecuentes = FindViewById<ImageButton>(Resource.Id.img_btn_preguntasFrecuentes);
            img_btn_preguntasFrecuentes.Click += delegate {
                Intent intent = new Intent(this, typeof(PreguntasfrecuentesCls));
                StartActivity(intent);
            };

            ImageButton img_btn_serviciosMedicosAdolecentes = FindViewById<ImageButton>(Resource.Id.img_btn_serviciosMedicosAdolecentes);
            img_btn_serviciosMedicosAdolecentes.Click += delegate {
                Intent intent = new Intent(this, typeof(ServiciosMedicosAdolecentesCls));
                StartActivity(intent);
            };

        }
        
    }
}