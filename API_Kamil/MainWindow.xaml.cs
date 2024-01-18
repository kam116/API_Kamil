﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
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

namespace ApiTestWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string url = $"https://api.openweathermap.org/data/2.5/weather?q=Monaco&appid=6d6f583dd6f204ba8a29096a7ba55711&units=metric";
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);

            //ответ от сервера
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();

            StreamReader reader = new StreamReader(res.GetResponseStream());
            string response = reader.ReadToEnd();

            WeatherResponse weatherResponse = JsonConvert.DeserializeObject<WeatherResponse>(response);
            CityTb.Text = weatherResponse.Name;
            WeatherTb.Text = weatherResponse.Main.Temp.ToString();
            WindTb.Text = weatherResponse.Wind.Speed.ToString();
            VisibilityTb.Text = weatherResponse.Visibility.ToString();
            PressureTb.Text = weatherResponse.Main.Pressure.ToString();
            HumidityTb.Text = weatherResponse.Main.Humidity.ToString();
        }



        private void KazanBtn_Click(object sender, RoutedEventArgs e)
        {
            string url = $"https://api.openweathermap.org/data/2.5/weather?q=Kazan&appid=6d6f583dd6f204ba8a29096a7ba55711&units=metric";
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);

            //ответ от сервера
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();

            StreamReader reader = new StreamReader(res.GetResponseStream());
            string response = reader.ReadToEnd();

            WeatherResponse weatherResponse = JsonConvert.DeserializeObject<WeatherResponse>(response);
            CityTb.Text = weatherResponse.Name;
            WeatherTb.Text = weatherResponse.Main.Temp.ToString();
            WindTb.Text = weatherResponse.Wind.Speed.ToString();
            VisibilityTb.Text = weatherResponse.Visibility.ToString();
            PressureTb.Text = weatherResponse.Main.Pressure.ToString();
            HumidityTb.Text = weatherResponse.Main.Humidity.ToString();
        }

        private void DallasBtn_Click(object sender, RoutedEventArgs e)
        {
            string url = $"https://api.openweathermap.org/data/2.5/weather?q=Dallas&appid=6d6f583dd6f204ba8a29096a7ba55711&units=metric";
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);

            //ответ от сервера
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();

            StreamReader reader = new StreamReader(res.GetResponseStream());
            string response = reader.ReadToEnd();


            WeatherResponse weatherResponse = JsonConvert.DeserializeObject<WeatherResponse>(response);
            CityTb.Text = weatherResponse.Name;
            WeatherTb.Text = weatherResponse.Main.Temp.ToString();
            WindTb.Text = weatherResponse.Wind.Speed.ToString();
            VisibilityTb.Text = weatherResponse.Visibility.ToString();
            PressureTb.Text = weatherResponse.Main.Pressure.ToString();
            HumidityTb.Text = weatherResponse.Main.Humidity.ToString();
        }

        private void MonacoBtn_Click(object sender, RoutedEventArgs e)
        {
            string url = $"https://api.openweathermap.org/data/2.5/weather?q=Monaco&appid=6d6f583dd6f204ba8a29096a7ba55711&units=metric";
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);

            //ответ от сервера
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();

            StreamReader reader = new StreamReader(res.GetResponseStream());
            string response = reader.ReadToEnd();


            WeatherResponse weatherResponse = JsonConvert.DeserializeObject<WeatherResponse>(response);
            CityTb.Text = weatherResponse.Name;
            WeatherTb.Text = weatherResponse.Main.Temp.ToString();
            WindTb.Text = weatherResponse.Wind.Speed.ToString();
            VisibilityTb.Text = weatherResponse.Visibility.ToString();
            PressureTb.Text = weatherResponse.Main.Pressure.ToString();
            HumidityTb.Text = weatherResponse.Main.Humidity.ToString();
        }
    }
}