using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckBoxAlignTester
{
    internal class StartupPage : ContentPage
    {
        public StartupPage()
        {

            var layoutGrid = new Grid() { HorizontalOptions = LayoutOptions.Center };
            layoutGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            layoutGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Auto) });
            layoutGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Auto) });
            layoutGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Auto) });
            var checkBox1 = new CheckBox(){ HorizontalOptions = LayoutOptions.Center, BackgroundColor = Colors.Red };
            var checkBox2 = new CheckBox() { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Colors.Blue };
            var checkBox3 = new CheckBox() { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Colors.Green };
            layoutGrid.Add(checkBox1, 0, 0);
            layoutGrid.Add(checkBox2, 1, 0);
            layoutGrid.Add(checkBox3, 2, 0);

            var frame = new Frame() { BorderColor = Colors.Black, Content = layoutGrid };

            var layoutGrid2 = new Grid() { HorizontalOptions = LayoutOptions.Center };
            layoutGrid2.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            layoutGrid2.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Auto) });
            layoutGrid2.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Auto) });
            layoutGrid2.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Auto) });
            var checkBox21 = new CheckBox() { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Colors.Red, Margin = new Thickness(0, 0, -15, 0) };
            var checkBox22 = new CheckBox() { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Colors.Blue, Margin = new Thickness(0, 0, -15, 0) };
            var checkBox23 = new CheckBox() { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Colors.Green, Margin = new Thickness(0, 0, -15, 0) };
            layoutGrid2.Add(checkBox21, 0, 0);
            layoutGrid2.Add(checkBox22, 1, 0);
            layoutGrid2.Add(checkBox23, 2, 0);

            var frame1 = new Frame() { BorderColor = Colors.Black, Content = layoutGrid };
            var frame2 = new Frame() { BorderColor = Colors.Black, Content = layoutGrid2 };

            Title = "StartupPage";
            Content = new VerticalStackLayout{ Children = { frame1, frame2} };
        }
    }
}
