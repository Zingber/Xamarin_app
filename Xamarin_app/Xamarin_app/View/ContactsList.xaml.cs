using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin_app.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactsList : ContentPage
    {
        public ContactsList()
        {
            InitializeComponent();
        }
    }
}
