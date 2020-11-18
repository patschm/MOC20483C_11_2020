using System;
using System.IO;
using System.Net;
using System.Net.Http;

namespace WebClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //OuweMeuk();
            VoorDeModerneMensch();
        }

        static HttpClient client = new HttpClient { BaseAddress = new Uri("https://www.nu.nl/") };
        
        private static void VoorDeModerneMensch()
        {
            //HttpClientHandler hdl = new HttpClientHandler();
            //hdl.Credentials = CredentialCache.DefaultCredentials;
            
            HttpResponseMessage resp =  client.GetAsync("rss").Result;
            if (resp.IsSuccessStatusCode)
            {
                Console.WriteLine(resp.Content.Headers.ContentType);
                string date = resp.Content.ReadAsStringAsync().Result;
                Console.WriteLine(date);
            }

            //client.Dispose();
        }

        private static void OuweMeuk()
        {
            //WebRequest
            //HttpWebRequest
            //FtpWebRequest
            //FileWebRequest
            //WebResponse

            //WebRequest req = WebRequest.Create("ftp://www.nu.nl/rss");
            HttpWebRequest request = WebRequest.Create("http://www.nu.nl/rss") as HttpWebRequest;
            // NetworkCredential ncrted = new NetworkCredential("aaa", "www");
            //request.Credentials = ncrted;

            request.Headers.Add("Accept", "application/xml");
            request.Method = "GET";

            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            if (response.StatusCode == HttpStatusCode.OK)
            {
                Console.WriteLine("Gelukt");
                Stream str = response.GetResponseStream();
                StreamReader rdr = new StreamReader(str);
                Console.WriteLine(rdr.ReadToEnd());
            }
        }
    }
}
