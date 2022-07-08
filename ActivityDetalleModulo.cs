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
    [Activity(Label = "ActivityDetalleModulo")]
    public class ActivityDetalleModulo : Activity
       
    {
        Modulo modulo;
        TextView txtnombre, txtdescripcion;
        ListView vlist;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.DescripcionModulos);
                int id = Intent.GetIntExtra("id", 0);
            modulo = Global.Modulos.Where(x => x.Id == id).FirstOrDefault();

            txtnombre = FindViewById<TextView>(Resource.Id.textView2);

            txtdescripcion = FindViewById<TextView>(Resource.Id.textView3);
            vlist = FindViewById<ListView>(Resource.Id.listView1);

            txtnombre.Text = modulo.Nombre;
            vlist.Adapter = new adapterDmodulo(this, Global.DModulos.Where(x => x.IdModulo1 == modulo.Id).ToList());
        }
    }
}