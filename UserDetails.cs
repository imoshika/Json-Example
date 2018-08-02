using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace JsonExample
{
    [JsonObject]
    public class UserDetails
    {
        [JsonProperty(PropertyName = "userId")]
        public int UserId
        {
            get;
            set;
        }

        [JsonProperty(PropertyName = "id")]
        public int Id
        {
            get;
            set;
        }

        [JsonProperty(PropertyName = "title")]
        public string Title
        {
            get;
            set;
        }

        [JsonProperty(PropertyName = "completed")]
        public string Completed
        {
            get;
            set;
        }
    }
}