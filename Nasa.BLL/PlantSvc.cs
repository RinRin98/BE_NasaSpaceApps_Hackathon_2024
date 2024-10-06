using Microsoft.EntityFrameworkCore;
using Nasa.Common.Req;
using Nasa.DAL;
using Nasa.DAL.Models;
using QLBH.Common.BLL;
using QLBH.Common.Rsp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasa.BLL
{
    public class PlantSvc : GenericSvc<PlantRep, Plant>
    {
        #region -- Overrides --
        private readonly NasaHackathonContext _context;

        public PlantSvc(NasaHackathonContext context)
        {
            _context = context;
        }

        public override SingleRsp Read(int id)
        {
            var res = new SingleRsp();

            // Lấy đối tượng Plant với các thông tin chi tiết từ các bảng liên quan
            var plant = _context.Plants
                .Where(p => p.Id == id)
                .Select(p => new PlantReq
                {
                    Id = p.Id,
                    PlantName = p.PlantName,
                    Description = p.Description,
                    Note = p.Note,
                    Weight = p.Weight,
                    Heigh = p.Heigh,
                    Info1 = p.Info1,
                    Info2 = p.Info2,
                    Info3 = p.Info3,
                    Info4 = p.Info4,
                    Des1 = p.Des1,
                    Des2 = p.Des2,
                    Des3 = p.Des3,
                    Des4 = p.Des4,

                    // Rainfall details
                    RainfallMinValue = p.Rainfall.MinValue,
                    RainfallMaxValue = p.Rainfall.MaxValue,
                    RainfallDescription = p.Rainfall.Description,
                    RainfallNote = p.Rainfall.Note,

                    // Salinity details
                    SalinityValue = p.Salinity.Value,
                    SalinityMinValue = p.Salinity.MinValue,
                    SalinityMaxValue = p.Salinity.MaxValue,
                    SalinityDescription = p.Salinity.Description,
                    SalinityNote = p.Salinity.Note,

                    // Moisture details
                    MoistureValue = p.Moisture.Value,
                    MoistureMinValue = p.Moisture.MinValue,
                    MoistureMaxValue = p.Moisture.MaxValue,
                    MoistureDescription = p.Moisture.Description,
                    MoistureNote = p.Moisture.Note,

                    // Landcover details
                    LandcoverValue = p.Landcover.Value,
                    LandcoverMinValue = p.Landcover.MinValue,
                    LandcoverMaxValue = p.Landcover.MaxValue,
                    LandcoverDescription = p.Landcover.Description,
                    LandcoverNote = p.Landcover.Note,

                    // Biomass details
                    BiomassValue = p.Biomass.Value,
                    BiomassMinValue = p.Biomass.MinValue,
                    BiomassMaxValue = p.Biomass.MaxValue,
                    BiomassDescription = p.Biomass.Description,
                    BiomassNote = p.Biomass.Note
                }).FirstOrDefault();

            if (plant != null)
            {
                res.Data = plant;
            }
            else
            {
                res.SetError("Plant not found");
            }

            return res;
        }

        public SingleRsp GetByName(string name)
        {
            var res = new SingleRsp();

            // Lấy đối tượng Plant với các thông tin chi tiết từ các bảng liên quan
            var plant = _context.Plants
                .Where(p => p.PlantName == name)
                .Select(p => new PlantReq
                {
                    Id = p.Id,
                    PlantName = p.PlantName,
                    Description = p.Description,
                    Note = p.Note,
                    Weight = p.Weight,
                    Heigh = p.Heigh,
                    Info1 = p.Info1,
                    Info2 = p.Info2,
                    Info3 = p.Info3,
                    Info4 = p.Info4,
                    Des1 = p.Des1,
                    Des2 = p.Des2,
                    Des3 = p.Des3,
                    Des4 = p.Des4,

                    // Rainfall details
                    RainfallMinValue = p.Rainfall.MinValue,
                    RainfallMaxValue = p.Rainfall.MaxValue,
                    RainfallDescription = p.Rainfall.Description,
                    RainfallNote = p.Rainfall.Note,

                    // Salinity details
                    SalinityValue = p.Salinity.Value,
                    SalinityMinValue = p.Salinity.MinValue,
                    SalinityMaxValue = p.Salinity.MaxValue,
                    SalinityDescription = p.Salinity.Description,
                    SalinityNote = p.Salinity.Note,

                    // Moisture details
                    MoistureValue = p.Moisture.Value,
                    MoistureMinValue = p.Moisture.MinValue,
                    MoistureMaxValue = p.Moisture.MaxValue,
                    MoistureDescription = p.Moisture.Description,
                    MoistureNote = p.Moisture.Note,

                    // Landcover details
                    LandcoverValue = p.Landcover.Value,
                    LandcoverMinValue = p.Landcover.MinValue,
                    LandcoverMaxValue = p.Landcover.MaxValue,
                    LandcoverDescription = p.Landcover.Description,
                    LandcoverNote = p.Landcover.Note,

                    // Biomass details
                    BiomassValue = p.Biomass.Value,
                    BiomassMinValue = p.Biomass.MinValue,
                    BiomassMaxValue = p.Biomass.MaxValue,
                    BiomassDescription = p.Biomass.Description,
                    BiomassNote = p.Biomass.Note
                }).FirstOrDefault();

            if (plant != null)
            {
                res.Data = plant;
            }
            else
            {
                res.SetError("Plant not found");
            }

            return res;
        }



        public MultipleRsp GetAllPlants()
        {
            var res = new MultipleRsp();

            // Lấy tất cả các Plant
            var plants = _context.Plants
                .Select(p => new PlantReq
                {
                    Id = p.Id,
                    PlantName = p.PlantName,
                    Description = p.Description,
                    Note = p.Note,
                    Weight = p.Weight,
                    Heigh = p.Heigh,
                    Info1 = p.Info1,
                    Info2 = p.Info2,
                    Info3 = p.Info3,
                    Info4 = p.Info4,
                    Des1 = p.Des1,
                    Des2 = p.Des2,
                    Des3 = p.Des3,
                    Des4 = p.Des4,

                    // Rainfall details
                    RainfallMinValue = p.Rainfall.MinValue,
                    RainfallMaxValue = p.Rainfall.MaxValue,
                    RainfallDescription = p.Rainfall.Description,
                    RainfallNote = p.Rainfall.Note,

                    // Salinity details
                    SalinityValue = p.Salinity.Value,
                    SalinityMinValue = p.Salinity.MinValue,
                    SalinityMaxValue = p.Salinity.MaxValue,
                    SalinityDescription = p.Salinity.Description,
                    SalinityNote = p.Salinity.Note,

                    // Moisture details
                    MoistureValue = p.Moisture.Value,
                    MoistureMinValue = p.Moisture.MinValue,
                    MoistureMaxValue = p.Moisture.MaxValue,
                    MoistureDescription = p.Moisture.Description,
                    MoistureNote = p.Moisture.Note,

                    // Landcover details
                    LandcoverValue = p.Landcover.Value,
                    LandcoverMinValue = p.Landcover.MinValue,
                    LandcoverMaxValue = p.Landcover.MaxValue,
                    LandcoverDescription = p.Landcover.Description,
                    LandcoverNote = p.Landcover.Note,

                    // Biomass details
                    BiomassValue = p.Biomass.Value,
                    BiomassMinValue = p.Biomass.MinValue,
                    BiomassMaxValue = p.Biomass.MaxValue,
                    BiomassDescription = p.Biomass.Description,
                    BiomassNote = p.Biomass.Note
                }).ToList();

            if (plants != null && plants.Count > 0)
            {
                res.SetData("plants", plants);
            }
            else
            {
                res.SetError("No plants found");
            }

            return res;
        }


        public override SingleRsp Update(Plant m)
        {
            var res = new SingleRsp();

            var m1 = m.Id > 0 ? _rep.Read(m.Id) : _rep.Read(m.Description);
            if (m1 == null)
            {
                res.SetError("EZ103", "No data.");
            }
            else
            {
                res = base.Update(m);
                res.Data = m;
            }

            return res;
        }

        public async Task<SingleRsp> CreatePlant(PlantReq plantReq)
        {
            var res = new SingleRsp();

            try
            {
                // Kiểm tra tính hợp lệ của model
                if (plantReq == null)
                {
                    res.SetError("Invalid plant data.");
                    return res;
                }

                var plant = new Plant
                {
                    PlantName = plantReq.PlantName,
                    Description = plantReq.Description,
                    Note = plantReq.Note,
                    Weight = plantReq.Weight,       // Có thể null
                    Heigh = plantReq.Heigh,         // Có thể null
                    Info1 = plantReq.Info1,         // Có thể null
                    Info2 = plantReq.Info2,         // Có thể null
                    Info3 = plantReq.Info3,         // Có thể null
                    Info4 = plantReq.Info4,         // Có thể null
                    Des1 = plantReq.Des1,           // Có thể null
                    Des2 = plantReq.Des2,           // Có thể null
                    Des3 = plantReq.Des3,           // Có thể null
                    Des4 = plantReq.Des4,           // Có thể null
                };

                // Xử lý Rainfall (nếu có)
                if (plantReq.RainfallMinValue != null || plantReq.RainfallMaxValue != null)
                {
                    plant.Rainfall = new Rainfall
                    {
                        MinValue = plantReq.RainfallMinValue,
                        MaxValue = plantReq.RainfallMaxValue,
                        Description = plantReq.RainfallDescription,
                        Note = plantReq.RainfallNote
                    };
                }

                // Xử lý Salinity (nếu có)
                if (plantReq.SalinityMinValue != null || plantReq.SalinityMaxValue != null || plantReq.SalinityValue != null)
                {
                    plant.Salinity = new SalinityTolerance
                    {
                        Value = plantReq.SalinityValue,
                        MinValue = plantReq.SalinityMinValue,
                        MaxValue = plantReq.SalinityMaxValue,
                        Description = plantReq.SalinityDescription,
                        Note = plantReq.SalinityNote
                    };
                }

                // Xử lý Moisture (nếu có)
                if (plantReq.MoistureMinValue != null || plantReq.MoistureMaxValue != null || plantReq.MoistureValue != null)
                {
                    plant.Moisture = new Moisture
                    {
                        Value = plantReq.MoistureValue,
                        MinValue = plantReq.MoistureMinValue,
                        MaxValue = plantReq.MoistureMaxValue,
                        Description = plantReq.MoistureDescription,
                        Note = plantReq.MoistureNote
                    };
                }

                // Xử lý Landcover (nếu có)
                if (plantReq.LandcoverMinValue != null || plantReq.LandcoverMaxValue != null || plantReq.LandcoverValue != null)
                {
                    plant.Landcover = new Landcover
                    {
                        Value = plantReq.LandcoverValue,
                        MinValue = plantReq.LandcoverMinValue,
                        MaxValue = plantReq.LandcoverMaxValue,
                        Description = plantReq.LandcoverDescription,
                        Note = plantReq.LandcoverNote
                    };
                }

                // Xử lý Biomass (nếu có)
                if (plantReq.BiomassMinValue != null || plantReq.BiomassMaxValue != null || plantReq.BiomassValue != null)
                {
                    plant.Biomass = new Biomass
                    {
                        Value = plantReq.BiomassValue,
                        MinValue = plantReq.BiomassMinValue,
                        MaxValue = plantReq.BiomassMaxValue,
                        Description = plantReq.BiomassDescription,
                        Note = plantReq.BiomassNote
                    };
                }

                // Thêm plant vào database
                _context.Plants.Add(plant);
                await _context.SaveChangesAsync();

                // Trả về kết quả thành công
                res.Data = plant;
            }
            catch (Exception ex)
            {
                res.SetError(ex.Message);
            }

            return res;
        }


        #endregion

        #region -- Methods --



        #endregion
    }
}
