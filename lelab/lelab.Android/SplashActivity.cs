﻿using System;
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

namespace lelab.Droid
{
    [Activity(
        Icon = "@drawable/icon", 
        Theme = "@style/splashscreen", 
        MainLauncher = true, 
        NoHistory = true
    )]
    public class SplashActivity : AppCompatActivity
    {
        /// <summary>
        /// Instant new object
        /// </summary>
        public SplashActivity() { }

        /// <summary>
        /// 
        /// </summary>
        protected override void OnResume()
        {
            // 
            base.OnResume();

            StartActivity(
                typeof(MainActivity)
            );
        }
    }
}