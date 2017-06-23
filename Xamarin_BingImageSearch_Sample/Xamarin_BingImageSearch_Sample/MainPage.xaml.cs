using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace Xamarin_BingImageSearch_Sample
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<ImageData> ImageDataList { get; set; } = new ObservableCollection<ImageData>();
        public MainPage()
        {
            InitializeComponent();
            ListView.ItemsSource = ImageDataList;
        }

        private async void SearchButton_Clicked(object sender, EventArgs e)
        {
            var key = BingKey.Text;
            var Searchtext = SearchText.Text;
            foreach (var imageData in await BingClient.GetBingImageSeatchAsync(Searchtext, key))
            {
                ImageDataList.Add(imageData);
            }
        }
    }
}
