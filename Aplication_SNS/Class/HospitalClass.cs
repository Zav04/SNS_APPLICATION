using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class HospitalClass : ClassBase_Building
    {

        public HospitalClass(string Name, string bRue, uint bNumberofFlors, uint bNumberofRoms, uint bNumberofBeds) : base(bRue, bNumberofFlors, bNumberofRoms, bNumberofBeds)
        {
            this.Name = bRue;

        }


        /// <summary>
        /// Destructor of object
        /// </summary>
        ~HospitalClass() { }

        /// <summary>
        /// Propertie Rue
        /// </summary>
        public string Name { get; set; }
    }
}
