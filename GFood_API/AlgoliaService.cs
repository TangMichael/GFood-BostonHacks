using GFood_API.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace GFood_API
{
    public class AlgoliaService
    {
        public static List<string> GetPictureLocations()
        {
             List<string> url_list = ClarifaiController.url_list;
            string[] x = null;
            List<string> pictureIds = new List<string>();

            for (var i = 0; i < url_list.Count; i++)
            {
                
                 x = new Uri(url_list[i]).Segments;
                pictureIds.Add(x[2].Substring(0, x[2].Length - 1));
            }
            return pictureIds;
        }
    }
}
