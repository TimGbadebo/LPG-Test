using NUnit.Framework;
using RestSharp;
using System;
using System.Collections.Generic;

namespace LPG_Test
{
    public class Tests
    {
        RestClient client;
        RestRequest request;

        [Test]
        public void GetAllCity()
        {
            client = new RestClient(Utilities.ApiBaseUrl);
            request = new RestRequest(Utilities.AllCitys, Method.GET);
            request.AddParameter("Accept", "application/json");

            var response = client.Execute<List<Locations>>(request);
            if (response.IsSuccessful == true)
            {
                Assert.Multiple(() =>
                {
                    Assert.AreEqual(200, (int)response.StatusCode);
                    Assert.AreEqual("New York", response.Data[0].title);
                    Assert.AreEqual("London", response.Data[1].title);
                    Assert.AreEqual("Los Angeles", response.Data[2].title);
                    Assert.AreEqual("Sydney", response.Data[3].title);
                    Assert.AreEqual("Paris", response.Data[4].title);
                });
               
            }
            else
            {
                throw new Exception("Expected does not match actual");
            }
        }


        [Test]
        public void GetAllAttractionsInNewYork()
        {
            client = new RestClient(Utilities.ApiBaseUrl);
            request = new RestRequest(Utilities.AllAttractions, Method.GET);
            request.AddParameter("Accept", "application/json");

            var response = client.Execute<List<Attractions>>(request);
            if (response.IsSuccessful == true)
            {
                Assert.Multiple(() =>
                {
                    Assert.AreEqual(200, (int)response.StatusCode, "Statuscode not as expected");
                    Assert.AreEqual(30, response.Data.Count, "Total number of attractions not equal");
                });
            }
            else
            {
                throw new Exception("Count not as expected");
            }
        }


        [Test]
        public void GetAllAttractionsOfTypeMuseumInNewyork()
        {
            client = new RestClient(Utilities.ApiBaseUrl);
            request = new RestRequest(Utilities.AllAttractions, Method.GET);
            request.AddParameter("Accept", "application/json");

            var response = client.Execute<List<Attractions>>(request)
                .Data.FindAll(x=>x.type.Equals("MUSEUM"));
            
            if (response.Count.Equals(Convert.ToInt32(Utilities.ExpectedAttractionsforMuseum)))
            {
                    Assert.AreEqual(Convert.ToInt32(Utilities.ExpectedAttractionsforMuseum), response.Count, 
                        "Total number of attractions for museum not equal");
            }
            else
            {
                throw new Exception("Count not as expected");
            }
        }
    }
}