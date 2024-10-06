using Nasa.DAL.Models;
using QLBH.Common.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasa.DAL
{
    public class PlantRep : GenericRep<NasaHackathonContext, Plant>
    {
        #region -- Overrides --

        //public override Category Read(int id)
        //{
        //    var res = All.FirstOrDefault(p => p.CategoryId == id);
        //    return res;
        //}
        public override Plant Read(int id)
        {
            return base.Read(id);
        }

        public int Remove(int id)
        {
            var m = base.All.First(i => i.Id == id);
            m = base.Delete(m);
            return m.Id;
        }

        #endregion

        #region -- Methods --


        #endregion
    }
}
