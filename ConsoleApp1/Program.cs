using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using JsonSample;

/*
 https://stackoverflow.com/questions/37672423/deserialize-json-array-with-json-net-from-url 相同問題
 [ {    }]會影響output
*/
namespace ConsoleApp1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            int num = 0;
            using (var client = new HttpClient())            using (var request = new HttpRequestMessage())            {                request.Method = HttpMethod.Get;
                //request.RequestUri = new Uri("https://opendata.epa.gov.tw/webapi/api/rest/datastore/355000000I-000259?sort=SiteName&offset=0&limit=1000");
                request.RequestUri = new Uri("http://opendata.epa.gov.tw/webapi/Data/REWIQA/?$orderby=SiteName&$skip=0&$top=1000&format=json");
                //request.RequestUri = new Uri("https://opendata.epa.gov.tw/ws/Data/ATM00625/?$format=json");
                var response = await client.SendAsync(request);//請求送出去等待回應
                var responseBody = await response.Content.ReadAsStringAsync();
                //Rootobject tranresult = JsonConvert.DeserializeObject<Rootobject>(responseBody);

                var list = JsonConvert.DeserializeObject<List<Class1>>(responseBody); //主要為List影響

                
                foreach (var item in list)
                {
                    num++;
                    if (item.County == "高雄市")
                    {
                        Console.WriteLine($"縣市：{item.County} / 站名：{item.SiteName} / PM2.5：{item.PM25} / 說明：{item.Status}");
                    }      
                    
                }
            }
        }
    }
}
