using Newtonsoft.Json;
using System;
using System.Collections.Generic;

#nullable disable

namespace Nasa.DAL.Models
{
    public partial class Rainfall
    {
        public Rainfall()
        {
            Plants = new HashSet<Plant>();
        }

        public int Id { get; set; }
        public double? MinValue { get; set; }
        public double? MaxValue { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }

        [JsonIgnore]
        public virtual ICollection<Plant> Plants { get; set; }
    }
}
