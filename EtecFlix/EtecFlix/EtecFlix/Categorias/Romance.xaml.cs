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
    public partial class Romance : ContentPage
    {
        public Romance()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            logo.Source = ImageSource.FromResource("EtecFlix.Img.logo_romance.png");
            btnOViolinoDoMeuPai.Source = ImageSource.FromResource("EtecFlix.Posters.OViolinoDoMeuPai.jpg");
        }
    }
}