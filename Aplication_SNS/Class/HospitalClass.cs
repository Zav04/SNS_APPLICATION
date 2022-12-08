using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Class.Building;
using Portugal.City;
using Portugal.District;


namespace Class.CHospital
{
    public class Hospital : ClassBase_Building
    {

        private static int idHospital = 0;

        public Hospital(string bName, string bRue, District bDistrict, City bCity, uint bNumberofFlors, uint bNumberofRoms, uint bNumberofBeds) 
            : base(bRue, bDistrict, bCity,bNumberofFlors, bNumberofRoms, bNumberofBeds)
        {
            this.Name = bName;
            this.IdHospital= System.Threading.Interlocked.Increment(ref idHospital);

        }


        /// <summary>
        /// Destructor of object
        /// </summary>
        ~Hospital() { }

        /// <summary>
        /// Propertie Rue
        /// </summary>
        public string Name { get; set; }


        /// <summary>
        /// Propertie Read Only ID
        /// </summary>
        public int IdHospital { get; }

    }
}
