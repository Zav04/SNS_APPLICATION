using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Portugal.District;
using Portugal.City;


namespace Class.CPerson
{
    public class ClassBase_Persons
    {
       

        public ClassBase_Persons(string pName, uint pAge, string pRue, District pDistrict, City pCity, string pCCNumber, ulong pCCNIF, ulong pCCSNS, ulong pccSS, string pdateOfBirth) 
        {
            this.Name = pName;
            this.Age = pAge;
            this.Rue = pRue;
            this.District = pDistrict;
            this.City = pCity; 
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
        /// Propertie District
        /// </summary>
        public District District { get; set; }

        /// <summary>
        /// Propertie City
        /// </summary>
        public City City { get; set; }


        /// <summary>
        /// Propertie CC Number
        /// </summary>
        public string CCNumber { get; set; }

        /// <summary>
        /// Propertie CC NIF
        /// </summary>
        public ulong CCNIF { get; set; }

        /// <summary>
        /// Propertie CC SNS
        /// </summary>
        public ulong CCSNS { get; set; }

        /// <summary>
        /// Propertie CC Segurança Social
        /// </summary>
        public ulong CCSS { get; set; }

        /// <summary>
        /// Propertie Date of Birth
        /// </summary>
        public string DateOfBirth { get; set; }














    }
}
