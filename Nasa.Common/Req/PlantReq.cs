using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasa.Common.Req
{
    public class PlantReq
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
        public double? RainfallValue { get; set; }
        public double? RainfallMinValue { get; set; }
        public double? RainfallMaxValue { get; set; }
        public string RainfallDescription { get; set; }
        public string RainfallNote { get; set; }
        public double? SalinityValue { get; set; }
        public double? SalinityMinValue { get; set; }
        public double? SalinityMaxValue { get; set; }
        public string SalinityDescription { get; set; }
        public string SalinityNote { get; set; }
        public int? MoistureValue { get; set; }
        public double? MoistureMinValue { get; set; }
        public double? MoistureMaxValue { get; set; }
        public string MoistureDescription { get; set; }
        public string MoistureNote { get; set; }
        public double? LandcoverValue { get; set; }
        public double? LandcoverMinValue { get; set; }
        public double? LandcoverMaxValue { get; set; }
        public string LandcoverDescription { get; set; }
        public string LandcoverNote { get; set; }
        public double? BiomassValue { get; set; }
        public double? BiomassMinValue { get; set; }
        public double? BiomassMaxValue { get; set; }
        public string BiomassDescription { get; set; }
        public string BiomassNote { get; set; }
    }
}
