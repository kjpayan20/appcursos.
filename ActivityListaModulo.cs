using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace regiones
{
    [Activity(Label = "ActivityListaModulo", MainLauncher = true)]
    public class ActivityListaModulo : Activity
  {

        ListView vlista;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.ListaModulo);

            vlista = FindViewById<ListView>(Resource.Id.listView1);

            vlista.Adapter = new adaptermodulo(this, Global.Modulos);
            vlista.ItemClick += Vlista_ItemClick;

        }

        private void Vlista_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Intent i = new Intent(this, typeof(ActivityDetalleModulo));

            Modulo modulo = Global.Modulos[e.Position];
            i.PutExtra("id", modulo.Id);
            StartActivity(i);
        }

    }
}