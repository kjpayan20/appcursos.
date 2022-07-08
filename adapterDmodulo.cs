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

    class adapterDmodulo : BaseAdapter
    {
        Activity context;
        List<DetalleModulo> lista;

        public adapterDmodulo(Activity context, List<DetalleModulo> lista)
        {
            this.context = context;
            this.lista = lista;
        }

        public override int Count => lista.Count;

        public override Java.Lang.Object GetItem(int position)
        {
            throw new NotImplementedException();
        }

        public override long GetItemId(int position)
        {
            return position;

        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = lista[position];
            View view = convertView;
            if (view == null)
                view = context.LayoutInflater.Inflate(Resource.Layout.ItemDmodulo, null);				
			view.FindViewById<TextView>(Resource.Id.textView1).Text = item.NombreVideo1;
			view.FindViewById<TextView>(Resource.Id.textView2).Text = item.URLYoutube1;
			view.FindViewById<TextView>(Resource.Id.textView3).Text = item.NombreBD1;
			view.FindViewById<TextView>(Resource.Id.textView4).Text = item.URLBD1;


			return view;


        }
    }
}