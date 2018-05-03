﻿using System.Collections.Generic;
using EVEStandard.Models;
using Newtonsoft.Json;

namespace EVEStandard.Models
{
    public class Region : ModelBase<Region>
    {
        /// <summary>
        /// region_id integer
        /// </summary>
        /// <value>region_id integer</value>
        [JsonProperty("region_id")]
        public int? RegionId { get; set; }

        /// <summary>
        /// name string
        /// </summary>
        /// <value>name string</value>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// description string
        /// </summary>
        /// <value>description string</value>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// constellations array
        /// </summary>
        /// <value>constellations array</value>
        [JsonProperty("constellations")]
        public List<int?> Constellations { get; set; }
    }
}