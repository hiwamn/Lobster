using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class WeatherPoint
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Lat { get; set; }
        public double Lon { get; set; }
        public double Temp { get; set; }
        public double TempMin { get; set; }
        public double TempMax { get; set; }
        public double Pressure { get; set; }
        public double Humidity { get; set; }
        public double WindSpeed{ get; set; }
        public double WindDegree { get; set; }
        //"weather":[{"id":804,"main":"Clouds","description":"overcast clouds","icon":"04d"}],"base":"stations","visibility":10000,,"clouds":{"all":96},
    }    
}


