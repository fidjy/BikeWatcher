﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace BikeWatcher
{
    public class Repository
    {
        [JsonPropertyName("number")]
        public string number { get; set; }
        [JsonPropertyName("pole")]
        public string pole { get; set; }
        [JsonPropertyName("available_bike")]
        public string available_bikes { get; set; }
        [JsonPropertyName("code_insee")]
        public string code_insee { get; set; }
        [JsonPropertyName("lng")]
        public string lng { get; set; }
        [JsonPropertyName("availability")]
        public string availability { get; set; }
        [JsonPropertyName("availabilitycode")]
        public string availabilitycode { get; set; }
        [JsonPropertyName("etat")]
        public string etat { get; set; }
        [JsonPropertyName("startdate")]
        public string startdate { get; set; }
        [JsonPropertyName("langue")]
        public string langue { get; set; }
        [JsonPropertyName("bike_stand")]
        public string bike_stands { get; set; }
        [JsonPropertyName("last_update")]
        public string last_update { get; set; }
        [JsonPropertyName("available_bike_stands")]
        public string available_bike_stands { get; set; }
        [JsonPropertyName("gid")]
        public string gid { get; set; }
        [JsonPropertyName("titre")]
        public string titre { get; set; }
        [JsonPropertyName("status")]
        public string status { get; set; }
        [JsonPropertyName("comune")]
        public string commune { get; set; }
        [JsonPropertyName("description")]
        public string description { get; set; }
        [JsonPropertyName("nature")]
        public string nature { get; set; }
        [JsonPropertyName("bonus")]
        public string bonus { get; set; }
        [JsonPropertyName("adress2")]
        public string address2 { get; set; }
        [JsonPropertyName("address")]
        public string address { get; set; }
        [JsonPropertyName("lat")]
        public string lat { get; set; }
        [JsonPropertyName("last_update_fme")]
        public string last_update_fme { get; set; }
        [JsonPropertyName("enddate")]
        public string enddate { get; set; }
        [JsonPropertyName("name")]
        public string name { get; set; }
        [JsonPropertyName("banking")]
        public string banking { get; set; }
        [JsonPropertyName("marrond")]
        public string nmarrond { get; set; }
    }

    public class RootObject
    {
        public List<string> fields { get; set; }
        public List<Repository> values { get; set; }
        public int nb_results { get; set; }
        public string table_href { get; set; }
        public string layer_name { get; set; }
    }
}
