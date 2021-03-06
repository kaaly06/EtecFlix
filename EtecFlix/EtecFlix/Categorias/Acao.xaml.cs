using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EtecFlix.Categorias
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Acao : ContentPage
    {
        public Acao()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            logo.Source = ImageSource.FromResource("EtecFlix.Img.acao.png");
            btnAlertaVermelho.Source = ImageSource.FromResource("EtecFlix.Posters.AlertaVermelho.jpg");
        }
    }
}