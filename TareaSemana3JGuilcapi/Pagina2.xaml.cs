using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TareaSemana3JGuilcapi
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pagina2 : ContentPage
    {
        public Pagina2(string user, string pass)
        {
            InitializeComponent();
            string usuario = IblUser.Text;
            IblUser.Text = usuario + user;
        }
    }
}