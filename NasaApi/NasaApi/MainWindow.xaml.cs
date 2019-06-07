using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using RapidAPISDK;
using System.Net;
using NasaApi.Services;
using NasaApi.Models;
using Newtonsoft.Json;

namespace NasaApi
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async Task FillDataGridAsync()
        {
            Downloader downloader = new Downloader();
            string json = await downloader.DownloadRawJsonDataAsync($"https://api.nasa.gov/planetary/apod?api_key=GrA18CNZz3tg8JTgMtGCwpm97G4pNlDs3W2TKXmE");

            featuresDataGrid.ItemsSource = JsonConvert.DeserializeObject<FeatureCollection>(json).Features;
        }

        private async void ButtonSearchClick(object sender, RoutedEventArgs e)
        {
            await FillDataGridAsync();
        }
    }
}


/*4CxayL7ibUuXU3V3roBasXe7etmRfjf7UIoaIaNC apiKey
 GrA18CNZz3tg8JTgMtGCwpm97G4pNlDs3W2TKXmE apiKey
     */
