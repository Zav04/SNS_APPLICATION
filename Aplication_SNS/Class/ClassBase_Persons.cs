using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class ClassBase_Persons
    {
        
        public ClassBase_Persons(string pName, uint pAge, string pRue,string pCCNumber, uint pCCNIF, uint pCCSNS, uint pccSS, string pdateOfBirth) 
        {
            this.Name = pName;
            this.Age = pAge;
            this.Rue = pRue;
            this.CCNumber = pCCNumber;
            this.CCNIF = pCCNIF;
            this.CCSNS = pCCSNS;
            this.CCSS = pccSS;
            this.DateOfBirth = pdateOfBirth;
        }


        /// <summary>
        /// Destructor of object
        /// </summary>
        ~ClassBase_Persons() { }

        /// <summary>
        /// Propertie Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Propertie Age
        /// </summary>
        public uint Age { get; set; }

        /// <summary>
        /// Propertie Rue
        /// </summary>
        public string Rue { get; set; }

        /// <summary>
        /// Propertie CC Number
        /// </summary>
        public string CCNumber { get; set; }

        /// <summary>
        /// Propertie CC NIF
        /// </summary>
        public uint CCNIF { get; set; }

        /// <summary>
        /// Propertie CC SNS
        /// </summary>
        public uint CCSNS { get; set; }

        /// <summary>
        /// Propertie CC Segurança Social
        /// </summary>
        public uint CCSS { get; set; }

        /// <summary>
        /// Propertie Date of Birth
        /// </summary>
        public string DateOfBirth { get; set; }














    }
}
