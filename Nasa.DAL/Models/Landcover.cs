using Newtonsoft.Json;
using System;
using System.Collections.Generic;

#nullable disable

namespace Nasa.DAL.Models
{
    public partial class Landcover
    {
        public Landcover()
        {
            Plants = new HashSet<Plant>();
        }

        public int Id { get; set; }
        public double? MinValue { get; set; }
        public double? MaxValue { get; set; }
        public double? Value { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        [JsonIgnore]

        public virtual ICollection<Plant> Plants { get; set; }
    }
}
