using System;
using System.Collections.Generic;
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

        public Hospital(string bName, string bRue, District bDistrict, City bCity, uint bNumberofFlors, uint bNumberofRoms, uint bNumberofBeds) 
            : base(bRue, bDistrict, bCity,bNumberofFlors, bNumberofRoms, bNumberofBeds)
        {
            this.Name = bName;

        }


        /// <summary>
        /// Destructor of object
        /// </summary>
        ~Hospital() { }

        /// <summary>
        /// Propertie Rue
        /// </summary>
        public string Name { get; set; }
    }
}
