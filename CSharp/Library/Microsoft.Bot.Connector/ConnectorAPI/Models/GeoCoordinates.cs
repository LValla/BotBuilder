// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Bot.Connector
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    /// <summary>
    /// GeoCoordinates
    /// https://schema.org/GeoCoordinates
    /// </summary>
    public partial class GeoCoordinates
    {
        /// <summary>
        /// Initializes a new instance of the GeoCoordinates class.
        /// </summary>
        public GeoCoordinates()
        {
            Type = "GeoCoordinates";
        }

        /// <summary>
        /// Initializes a new instance of the GeoCoordinates class.
        /// </summary>
        public GeoCoordinates(double? elevation = default(double?), double? latitude = default(double?), double? longitude = default(double?), string type = default(string), string name = default(string))
        {
            Elevation = elevation;
            Latitude = latitude;
            Longitude = longitude;
            Type = "GeoCoordinates";
            Name = name;
        }

        /// <summary>
        /// Elevation of the location [WGS
        /// 84](https://en.wikipedia.org/wiki/World_Geodetic_System)
        /// </summary>
        [JsonProperty(PropertyName = "elevation")]
        public double? Elevation { get; set; }

        /// <summary>
        /// Latitude of the location [WGS
        /// 84](https://en.wikipedia.org/wiki/World_Geodetic_System)
        /// </summary>
        [JsonProperty(PropertyName = "latitude")]
        public double? Latitude { get; set; }

        /// <summary>
        /// Longitude of the location [WGS
        /// 84](https://en.wikipedia.org/wiki/World_Geodetic_System)
        /// </summary>
        [JsonProperty(PropertyName = "longitude")]
        public double? Longitude { get; set; }

        /// <summary>
        /// The type of the thing
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// The name of the thing
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

    }
}
