using Newtonsoft.Json;
using System;
using System.Collections.Generic;

#nullable disable

namespace Nasa.DAL.Models
{
    public partial class Plant
    {
        public int Id { get; set; }
        public string PlantName { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public double? Weight { get; set; }
        public double? Heigh { get; set; }
        public double? Info1 { get; set; }
        public double? Info2 { get; set; }
        public double? Info3 { get; set; }
        public double? Info4 { get; set; }
        public string Des1 { get; set; }
        public string Des2 { get; set; }
        public string Des3 { get; set; }
        public string Des4 { get; set; }
        public int? RainfallId { get; set; }
        public int? SalinityId { get; set; }
        public int? MoistureId { get; set; }
        public int? LandcoverId { get; set; }
        public int? BiomassId { get; set; }
        [JsonIgnore]
        public virtual Biomass Biomass { get; set; }
        [JsonIgnore]
        public virtual Landcover Landcover { get; set; }
        [JsonIgnore]
        public virtual Moisture Moisture { get; set; }
        [JsonIgnore]
        public virtual Rainfall Rainfall { get; set; }
        [JsonIgnore]
        public virtual SalinityTolerance Salinity { get; set; }
    }
}
