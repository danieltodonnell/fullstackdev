using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestSharp;


namespace Peak9.Libs
{
    public class Summit
    {
        public static string Request (string value){

            //Sweet
            //...you found the first problem...
            //bring restsharp in from nuget and the project will compile
            
            var uri = new Uri(value);

            var client = new RestSharp.RestClient($"http://{uri.Host}");
            var request = new RestRequest(uri.PathAndQuery, Method.POST);
            var response = client.Execute(request);
            var result = response.Content;

            return result;
        }
    }
}