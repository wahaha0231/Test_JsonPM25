﻿
using Newtonsoft.Json;


namespace JsonSample
{



    public class Rootobject
    {
        public Class1[] Property1 { get; set; }
    }

    public class Class1
    {
        public string SiteName { get; set; }
        public string County { get; set; }
        public string AQI { get; set; }
        public string Pollutant { get; set; }
        public string Status { get; set; }
        public string SO2 { get; set; }
        public string CO { get; set; }
        public string CO_8hr { get; set; }
        public string O3 { get; set; }
        public string O3_8hr { get; set; }
        public string PM10 { get; set; }
        //public string PM25 { get; set; }
        public string NO2 { get; set; }
        public string NOx { get; set; }
        public string NO { get; set; }
        public string WindSpeed { get; set; }
        public string WindDirec { get; set; }
        public string PublishTime { get; set; }
        public string PM25_AVG { get; set; }
        public string PM10_AVG { get; set; }
        public string SO2_AVG { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }

        //https://dotblogs.com.tw/noncoder/2018/04/24/json-model-property-name-symbol  解決方法
        public string _PM2x5 { get; set; }
        [JsonProperty(PropertyName = "PM2.5")]
        public string PM25
        {
            get { return _PM2x5; }
            set { _PM2x5 = value; }
        }
    }



}