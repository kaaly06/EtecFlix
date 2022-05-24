﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EtecFlix.Categorias
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Animacao : ContentPage
    {
        public Animacao()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            logo.Source = ImageSource.FromResource("EtecFlix.Img.animação.png");
            btnRayaUltimoDragao.Source = ImageSource.FromResource("EtecFlix.Posters.RayaUltimoDragao.jpg");
        }
    }
}