﻿using GFood_API.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Algolia.Search;
using Algolia.Search.Models;
using Newtonsoft.Json.Linq;


namespace GFood_API
{
    public class AlgoliaService
    {

        AlgoliaClient client;
        Index index;

        public const string APPLICATION_ID = "59HBV2PWON";
        public const string API_KEY = "9d1d44d31f066fa800a674eb1eb076d4";
        public const string BUSINESS_INDEX = "yelp";
        public const string PHOTO_INDEX = "yelp_photo";


        public AlgoliaService()
        {
            client = new AlgoliaClient(APPLICATION_ID, API_KEY);
            index = client.InitIndex(BUSINESS_INDEX);
        }

        public void SetIndexToBusiness()
        {
            index = client.InitIndex(BUSINESS_INDEX);
        }

        public void SetIndexToPhoto()
        {
            index = client.InitIndex(PHOTO_INDEX);
        }


        public string GetBusinessIDFromPhotoID(string photoID)
        {
            this.SetIndexToPhoto();
            RequestOptions requestOptions = new RequestOptions();

            JObject jObject = index.Search(
                new Query(photoID),
                requestOptions: requestOptions
            );

            string businessID = "";

            foreach (JToken hits in jObject.SelectToken("hits"))
            {
                businessID = (string)hits.SelectToken("business_id");
            }
            return businessID;
        }

        public JObject GetBusinessFromID(string businessID)
        {
            this.SetIndexToBusiness();
            RequestOptions requestOptions = new RequestOptions();

            return index.Search(
                new Query(businessID),
                requestOptions: requestOptions
            );
        }

        public  List<string> GetIDfromURL(List<string> urlString)
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

        public string AddressFromObject(JObject jObject) {
            string address = "";
            foreach (JToken hits in jObject.SelectToken("hits"))
            {
                string url = (string)hits.SelectToken("input.data.image.url");
                address = url;
            }
            return address;
        }

    }
    }
