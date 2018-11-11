using System;
using System.Threading.Tasks;
using Clarifai.API;
using Clarifai.API.Responses;
using Clarifai.DTOs.Inputs;
using Clarifai.DTOs.Searches;

namespace GFood_API
{
    public class ClarifaiHandler
    {
        ClarifaiClient client;

        public async Task Main()
        {
            client = new ClarifaiClient("dfa26cc77ace4f539eff32c420226fbc");
  
        }

        public async Task searchByConcept(string concept) {
            client = new ClarifaiClient("dfa26cc77ace4f539eff32c420226fbc");
            await client.SearchInputs(SearchBy.ConceptName(concept))
            .Page(1)
            .ExecuteAsync();
        }
    }
}
