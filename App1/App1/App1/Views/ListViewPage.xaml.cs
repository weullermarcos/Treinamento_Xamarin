using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App1.Views
{

    public class Person
    {
        public string Name { set; get; }

        public DateTime Birthday { set; get; }

        public Color FavoriteColor { set; get; }
    }

    public partial class ListViewPage : ContentPage
    {
        public ListViewPage()
        {
            InitializeComponent();

            PopulateList();
        }

        private void PopulateList()
        {
            List<Person> personList = new List<Person>();

            for (int i = 0; i < 20; i++)
            {

                Person person = new Person();
                person.Name = "Name " + i;
                person.Birthday = DateTime.Now.AddDays(-i);

                if (i%2 == 0)
                    person.FavoriteColor = Color.Red;
                else
                    person.FavoriteColor = Color.Black;

                personList.Add(person);

            }

            myListView.ItemsSource = personList;

        }
    }
}
