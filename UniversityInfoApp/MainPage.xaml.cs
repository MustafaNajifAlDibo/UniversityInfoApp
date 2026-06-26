using System.Diagnostics.Metrics;
using System.Text.Json;
using UniversityInfoApp.Code;
using UniversityInfoApp.Models;
using UniversityInfoApp.Views;

namespace UniversityInfoApp {
    public partial class MainPage : ContentPage {

        private List<UniInfo> _uniInfos;
        private HttpHelper _httpHelper;

        public MainPage() {
            InitializeComponent();

            _uniInfos = new List<UniInfo>();
            _httpHelper = new HttpHelper();
        }


        private async Task LoadDataAsync(string countryName) {
            // Clear
            _uniInfos.Clear();
            ContainerLayout.Clear();
            // Display Indicator becaue long time response
            IndicatorLoading.IsRunning = true;
            IndicatorLoading.IsVisible = true;

            countryName = countryName.Replace(" ", "+");

            // Get Responce and Fill UniInfo
            var response = 
                await _httpHelper.GetReponceAsync($"http://universities.hipolabs.com/search?country={countryName}");

            _uniInfos = JsonSerializer.Deserialize<List<UniInfo>>(response) ?? [];
            // For loop into _umiInfos
            for (int i = 0; i < _uniInfos.Count; i++) {
                var item = _uniInfos[i];
                ContainerLayout.Add(new UnInfoView(item.name, item.web_pages[0]));
            }

            // Hide the Indicator
            IndicatorLoading.IsRunning = false;
            IndicatorLoading.IsVisible = false;
        }

        private void SearchButton_Clicked(object sender, EventArgs e) {
            if(!string.IsNullOrEmpty(countryName.Text))
            _ = LoadDataAsync(countryName.Text);
        }
    }
}
