﻿using System;
using Android.Views;
using Android.Widget;
using AndroidX.RecyclerView.Widget;

namespace AuthenticatorPro.List
{
    internal class IconListHolder : RecyclerView.ViewHolder
    {
        public ImageView Icon { get; }


        public IconListHolder(View itemView, Action<int> clickListener) : base(itemView)
        {
            Icon = itemView.FindViewById<ImageView>(Resource.Id.imageIcon);
            itemView.Click += (sender, e) => clickListener(AdapterPosition);
        }
    }
}