using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace App1
{
    public class Adapter : BaseAdapter<string>
    {
        string[] Items;

        Activity Context;

        public Adapter(Activity context, string[] items) : base()
        {
            this.Context = context;
            this.Items = items;
        }

        public override string this[int position]
        {
            get { return Items[position]; }
        }





        public override int Count { get { return Items.Length; } }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View view = convertView;
            if (view == null)
                view = Context.LayoutInflater.Inflate(Resource.Layout.Customprogram, null);
            view.FindViewById<TextView>(Resource.Id.textView2).Text = Items[position];
            return view;
            

            
        }
    }
}