using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Reflection.Metadata;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LK19
{
    public class Http
    {
        public Http() { }
        public async void GetUrl(string url)
        {
            using(HttpClient client = new HttpClient()) 
            {
                try
                {
                    HttpResponseMessage responseMessage = await client.GetAsync(url);
                    responseMessage.EnsureSuccessStatusCode();

                    string responseBody = await responseMessage.Content.ReadAsStringAsync();
                    Console.WriteLine(responseBody);
                }
                catch(HttpRequestException ex) 
                {
                    Console.WriteLine($"Exception: {ex.Message}");
                }
            }
        }
        public async void PostUrl(string url)
        {
            var values = new Dictionary<string, string>
            {
                { "thing1", "hello" },
                { "thing2", "world" }
            };
            var content = new FormUrlEncodedContent(values);

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var responseMessage = await client.PostAsync(url, content);

                    responseMessage.EnsureSuccessStatusCode();
                    string responseBody = await responseMessage.Content.ReadAsStringAsync();
                    Console.WriteLine(responseBody);
                }
                catch (HttpRequestException ex)
                {
                    Console.WriteLine($"Exception: {ex.Message}");
                }
            }


        }
        public async void PutUrl(string url, object load)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var request = (HttpWebRequest)WebRequest.Create(url);
                    request.Method = "PUT";
                    request.ContentType = "application/xml";

                    if (load != null)
                    {
                        Stream dataStream = request.GetRequestStream();
                        Serialize(dataStream, load);
                        dataStream.Close();
                    }

                    HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                    string returnString = response.StatusCode.ToString();
                }
                catch (HttpRequestException ex)
                {
                    Console.WriteLine($"Exception: {ex.Message}");
                }
            }
        }

        public void Serialize(Stream output, object input)
        {
            var ser = new DataContractSerializer(input.GetType());
            ser.WriteObject(output, input);
        }
    }
}
