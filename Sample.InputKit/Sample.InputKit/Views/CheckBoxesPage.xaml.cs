﻿using Plugin.InputKit.Shared.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sample.InputKit.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CheckBoxesPage : ContentPage
	{
        static readonly Random rnd = new Random();
		public CheckBoxesPage()
		{
			InitializeComponent ();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var colors = typeof(Color).GetFields();
            var color = (Color)colors[rnd.Next(colors.Length)].GetValue(null);
            foreach (var view in mainLayout.Children)
            {
                if (view is CheckBox chk)
                {
                    chk.Color = color;
                }
            }
        }
    }
}