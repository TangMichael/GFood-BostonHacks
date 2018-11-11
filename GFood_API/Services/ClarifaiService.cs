using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Clarifai.API;
using Clarifai.API.Responses;
using Clarifai.DTOs.Inputs;
using Clarifai.DTOs.Searches;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GFood_API
{
    public class ClarifaiService
    {
        ClarifaiClient client;
        AlgoliaService algoliaService;
        private const string API_KEY = "dfa26cc77ace4f539eff32c420226fbc";

        public ClarifaiService() {
            client = new ClarifaiClient(API_KEY);
            algoliaService = new AlgoliaService();
        }

        public async Task<ClarifaiResponse<SearchInputsResult>> SearchByConcept(string concept) {
            var response = await client.SearchInputs(SearchBy.ConceptName(concept))
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


        public async Task<JObject> UrlWithAddressAsync(string concept) {
            var response = await SearchByConcept(concept);
            var x = JsonConvert.SerializeObject((Object)response);
            // get the response body and transform it into temp object
            var z = JObject.Parse(response.RawBody);
            // access the url for the first hit
            // need to do for loop to get all the hits
            List<string> url = JObjectToURL(z);
            List<string> url_id = algoliaService.GetIDfromURL(url);
            List<string> address = new List<string>();
            JObject jObject = new JObject();

            for (int i = 0; i < url.Count; i++) {
                jObject = algoliaService.GetBusinessFromID(url_id[i]);
                jObject.Add(new JProperty(url[i], new JObject()));
            }

            return jObject;

        }

        

    }
}
