using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinApp2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var listViewItems = new[]
            {
                "Cherry",
                "Mark",
                "Arsene Wenger"
            };

            //listOfNames.ItemsSource = listViewItems;
            listOfNames.ItemsSource = Names.GetNames();

            var cell = new DataTemplate(typeof(TextCell));
            cell.SetBinding(TextCell.TextProperty, new Binding("Name"));
            cell.SetBinding(TextCell.DetailProperty, new Binding("FavouriteTeam"));
            cell.SetValue(TextCell.TextColorProperty, Color.Red);
            cell.SetValue(TextCell.DetailColorProperty, Color.Yellow);

            listOfNames.ItemTemplate = cell;

            Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);
        }


    }
}
