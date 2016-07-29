using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App1.Views
{
    public partial class MyContentPage : ContentPage
    {
        public MyContentPage()
        {
            InitializeComponent();
        }

        void StackLayout_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new StackLayoutPage();
        }

        void MasterDetail_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new ComponentsPage();
        }

        void ListView_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new ListViewPage();
        }

        void Picker_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new MyPickerPage();
        }
    }
}
