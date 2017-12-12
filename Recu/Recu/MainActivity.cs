using Android.App;
using Android.Widget;
using Android.OS;
using System.Net;
using System.Net.Sockets;
using System;
using System.Text;
using Android.Views;

namespace Recu
{
    [Activity(Label = "Media", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        EditText nota1;
        EditText nota2;
        EditText nota3;
        EditText nota4;
        Button calcular;
        TextView media;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);

            nota1 = FindViewById<EditText>(Resource.Id.editText1);
            nota2 = FindViewById<EditText>(Resource.Id.editText2);
            nota3 = FindViewById<EditText>(Resource.Id.editText3);
            nota4 = FindViewById<EditText>(Resource.Id.editText4);
            calcular = FindViewById<Button>(Resource.Id.button1);
            media = FindViewById<TextView>(Resource.Id.mediaTxt);

            calcular.Click += (sender, e) =>
            {
                try
                {
                    if (Convert.ToDouble(nota1.Text) > 10 || Convert.ToDouble(nota2.Text) > 10 || Convert.ToDouble(nota3.Text) > 10 || Convert.ToDouble(nota4.Text) > 10)
                    {
                        media.Text = "É impossível ter nota maior que 10";
                    }
                    else if (Convert.ToDouble(nota1.Text) < 0 || Convert.ToDouble(nota2.Text) < 0 || Convert.ToDouble(nota3.Text) < 0 || Convert.ToDouble(nota4.Text) < 0)
                    {
                        media.Text = "É impossível ter nota menor que 0";
                    }
                    else
                    {
                        double mediaD = Math.Round(((Convert.ToDouble(nota1.Text) + Convert.ToDouble(nota2.Text) + Convert.ToDouble(nota3.Text) + Convert.ToDouble(nota4.Text)) / 4), 2);
                        media.Text = "Média: " + mediaD.ToString(); 
                    }
                }
                catch (Exception ex)
                {
                    media.Text = "Preencha todos os campos";
                }
            };
        }
    }
}

