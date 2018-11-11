using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace GFood_API.Models
{

    public class Description
    {
        public string business_id;
        public string name;
        public string address;
        public string city;
        public string state;
        public string postal_code;
        public string latitude;
        public string longitude;
        public string stars;
        public string review_count;

        public Description(string business_id, string name, string address, string city, string state, string postal_code, string latitude, string longitude, string stars, string review_count)
        {
            this.business_id = business_id;
            this.name = name;
            this.address = address;
            this.city = city;
            this.state = state;
            this.postal_code = postal_code;
            this.latitude = latitude;
            this.longitude = longitude;
            this.stars = stars;
            this.review_count = review_count;
        }



        public override bool Equals(object obj)
        {
            var description = obj as Description;
            return description != null &&
                   business_id == description.business_id &&
                   name == description.name &&
                   address == description.address &&
                   city == description.city &&
                   state == description.state &&
                   postal_code == description.postal_code &&
                   latitude == description.latitude &&
                   longitude == description.longitude &&
                   stars == description.stars &&
                   review_count == description.review_count;
        }

        public override int GetHashCode()
        {
            var hash = new HashCode();
            hash.Add(business_id);
            hash.Add(name);
            hash.Add(address);
            hash.Add(city);
            hash.Add(state);
            hash.Add(postal_code);
            hash.Add(latitude);
            hash.Add(longitude);
            hash.Add(stars);
            hash.Add(review_count);
            return hash.ToHashCode();
        }
    }


}
