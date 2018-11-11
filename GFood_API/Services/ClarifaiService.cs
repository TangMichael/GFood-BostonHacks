using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Clarifai.API;
using Clarifai.API.Responses;
using Clarifai.DTOs.Inputs;
using Clarifai.DTOs.Searches;
using Newtonsoft.Json.Linq;

namespace GFood_API
{
    public class ClarifaiService
    {
        ClarifaiClient client;
        private const string API_KEY = "dfa26cc77ace4f539eff32c420226fbc";

        public ClarifaiService() {

        }

        public async Task<ClarifaiResponse<SearchInputsResult>> SearchByConcept(string concept) {
            ClarifaiClient client = new ClarifaiClient(API_KEY);
            var response = await client.SearchInputs(SearchBy.ConceptName("breakfast"))
            .Page(1)
            .ExecuteAsync();
            return response;
        }

        public List<string> JObjectToURL(JObject jObject) {
            List<string> urlList = new List<string>();
            foreach (JToken hits in jObject.SelectToken("hits")) {
                string url = (string)hits.SelectToken("input.data.image.url");
                urlList.Add(url);
            }
            return urlList;
        }

        public void UrlWithAddress(List<string> urlList, JObject jObject) {

        }

    }
}
