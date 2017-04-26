using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinApp2
{
    public class SimpleContentPage : ContentPage
    {
        public SimpleContentPage()
        {
            var label1 = new Label
            {
                Text = "This is mark's label",
                Font = Font.SystemFontOfSize(NamedSize.Large)
            };

            var entry1 = new Entry
            {
                Placeholder = "Enter some stuff"
            };

            var button1 = new Button
            {
                Text = "Click Me!"
            };

            button1.Clicked += (sender, e) =>
            {
                label1.Text = "User typed: " + entry1.Text;
            };

            Content = new StackLayout
            {
                Padding = 30,
                Spacing = 10,
                Children = {label1, entry1, button1}
            };
        }
        
    }
}
