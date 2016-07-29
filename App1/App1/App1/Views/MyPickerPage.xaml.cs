using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App1.Views
{
    public partial class MyPickerPage : ContentPage
    {
        Dictionary<string, Color> nameToColor;

        public MyPickerPage()
        {
            InitializeComponent();

            PopulatePicker();
        }

        private void PopulatePicker()
        {
            nameToColor = new Dictionary<string, Color>
            {
                { "Selecione um valor", Color.Transparent},
                { "Aqua", Color.Aqua},
                { "Black", Color.Black},
                { "Blue", Color.Blue },
                { "Gray", Color.Gray },
                { "Green", Color.Green },
                { "Lime", Color.Lime },
                { "Maroon", Color.Maroon },
                { "Navy", Color.Navy },
                { "Olive", Color.Olive },
                { "Purple", Color.Purple },
                { "Red", Color.Red },
                { "Silver", Color.Silver },
                { "Teal", Color.Teal },
                { "White", Color.White },
                { "Yellow", Color.Yellow }
            };

            foreach (string colorName in nameToColor.Keys)
            {
                myPicker.Items.Add(colorName);
            }

            //Seleciona o primeiro item
            myPicker.SelectedIndex = 0;

        }

        private void MyPicker_SelectedIndexChanged(object sender, EventArgs eventArgs)
        {
            string itemSelecionado = myPicker.Items[myPicker.SelectedIndex];

            if ( string.IsNullOrEmpty(itemSelecionado))
                return;

            foreach (var item in nameToColor)
            {
                if (itemSelecionado == item.Key)
                {
                    myBoxView.Color = item.Value;
                }
            }
        }

        /// <summary>
        /// Volta para a página Inicial
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Voltar_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new MyContentPage();
        }
    }
}
