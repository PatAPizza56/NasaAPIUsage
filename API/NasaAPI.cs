using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Project
{
    public class NasaPOTD : NasaAPI
    {
        public class NasaPOTDResponse
        {
            public string explanation;
            public string url;
        }

        public static NasaPOTDResponse Get(DateTime date)
        {
            return Get<NasaPOTDResponse>("https://api.nasa.gov/planetary/apod", $"?api_key=WkVxTsV5NGLUSUtdOQRRKcj4flEcyxezuqUrh5Cv&date={date.ToString("yyyy-MM-dd")}");
        }
    }

    public class NasaMRP : NasaAPI
    {
        public class NasaMRPResponse
        {
            public Photo[] photos { get; set; }

            public class Photo
            {
                public int id { get; set; }
                public int sol { get; set; }
                public Camera camera { get; set; }
                public string img_src { get; set; }
                public string earth_date { get; set; }
                public Rover rover { get; set; }

                public class Camera
                {
                    public int id { get; set; }
                    public string name { get; set; }
                    public int rover_id { get; set; }
                    public string full_name { get; set; }
                }

                public class Rover
                {
                    public int id { get; set; }
                    public string name { get; set; }
                    public string landing_date { get; set; }
                    public string launch_date { get; set; }
                    public string status { get; set; }
                }
            }
        }

        public static NasaMRPResponse Get(DateTime date)
        {
            return Get<NasaMRPResponse>("https://api.nasa.gov/mars-photos/api/v1/rovers/curiosity/photos", $"?earth_date={date.ToString("yyyy-MM-dd")}&api_key=WkVxTsV5NGLUSUtdOQRRKcj4flEcyxezuqUrh5Cv");
        }
    }

    public class NasaAPI
    {
        protected static T Get<T>(string url, string urlParams)
        {
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            string response = client.GetStringAsync(urlParams).Result;

            client.Dispose();

            return JsonConvert.DeserializeObject<T>(response);
        }
    }
}
