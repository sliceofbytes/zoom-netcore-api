﻿using Newtonsoft.Json;

namespace AndcultureCode.ZoomClient.Models.Webinars
{



        /// <summary>
        /// Panelist base object.
        /// </summary>
        public partial class Panelist
        {
            /// <summary>
            /// Panelist's email.
            /// </summary>
            [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
            public string Email { get; set; }

            /// <summary>
            /// Panelist's ID.
            /// </summary>
            [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
            public string Id { get; set; }

            /// <summary>
            /// Join URL.
            /// </summary>
            [JsonProperty("join_url", NullValueHandling = NullValueHandling.Ignore)]
            public string JoinUrl { get; set; }

            /// <summary>
            /// Panelist's full name.
            /// </summary>
            [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
            public string Name { get; set; }
        }
    

}