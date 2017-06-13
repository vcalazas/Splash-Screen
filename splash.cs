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
using System.Threading;

namespace App1
{
    /*
        esta é a splash screen do app, onde será a tela inicial 
    */
    [Activity(Theme= "@style/myStyle.Theme", MainLauncher = true, NoHistory = true)]
    public class splash : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Thread.Sleep(3000);// espera 3 segundos para iniciar
            StartActivity(typeof(MainActivity));// chama a próxima activity do App

        }
    }
}
