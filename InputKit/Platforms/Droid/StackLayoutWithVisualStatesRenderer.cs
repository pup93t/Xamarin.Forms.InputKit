﻿using System;
using System.Collections.Generic;
using System.Text;
using Android.Content;
using Android.Views;
using Plugin.InputKit.Platforms.Droid;
using Plugin.InputKit.Shared.Controls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly:ExportRenderer(typeof(StackLayout),typeof(StackLayoutWithVisualStatesRenderer))]
namespace Plugin.InputKit.Platforms.Droid
{
    public class StackLayoutWithVisualStatesRenderer : VisualElementRenderer<StackLayout>, Android.Views.View.IOnTouchListener
    {
        public StackLayoutWithVisualStatesRenderer(Context context) : base(context)
        {

        }

        public override bool OnTouchEvent(MotionEvent e)
        {
            System.Diagnostics.Debug.WriteLine("[OnTouchEvent] - " + e.Action);
            if (e.Action == MotionEventActions.Down)
            {
                VisualStateManager.GoToState(Element, "Pressed");
            }
            else if (e.Action == MotionEventActions.Up || e.Action == MotionEventActions.Cancel)
            {
                VisualStateManager.GoToState(Element, "Normal");
            }
            return base.OnTouchEvent(e);
        }

        public bool OnTouch(Android.Views.View v, MotionEvent e)
        {
            return base.OnTouchEvent(e);
        }
    }
}
