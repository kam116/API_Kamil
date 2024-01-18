using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTestWPF
{
    class WeatherResponse
    {
        public string Name { get; set; }
        public MainInfo Main { get; set; }
        public WindInfo Wind { get; set; }



        public int Visibility { get; set; }
        public SysInfo Sys { get; set; }


    }
    class MainInfo
    {
        public float Temp { get; set; }
        public int Pressure { get; set; }
        public int Humidity { get; set; }
    }
    class WindInfo
    {
        public double Speed { get; set; }
    }
    class SysInfo
    {
        public string Country { get; set; }
    }
}