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
    public class ClarifaiHandler
    {
        ClarifaiClient client;


        public async Task<ClarifaiResponse<SearchInputsResult>> SearchByConcept(string concept) {
            ClarifaiClient client = new ClarifaiClient("dfa26cc77ace4f539eff32c420226fbc");
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

    }
}
