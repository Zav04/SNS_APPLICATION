using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class ClassBase_Persons
    {

        public string name, rue, ccNumber, dateOfBirth;
        public int age,ccNIF, ccSNS,ccSS;

        /// <summary>
        ///  Variables of Class Base
        ///  Person is a Class Base From Doctor, Nurse, Pacient Class
        /// </summary>
        /// <param name="pName">Name of Person</param>
        /// <param name="pAge">Age of person</param>
        /// <param name="pRue">Rue of person</param>
        /// <param name="pCCNumber">CC Number</param>
        /// <param name="pCCNIF"> CC NIF </param>
        /// <param name="pCCSNS">CC Numero de Utente</param>
        /// <param name="pccSS">CC Segurança Social</param>
        /// <param name="pdateOfBirth"> Date of Birth</param>


        
        public ClassBase_Persons(string pName, int pAge, string pRue,string pCCNumber, int pCCNIF, int pCCSNS, int pccSS, string pdateOfBirth) 
        {
            this.name = pName;
            this.age = pAge;
            this.rue = pRue;
            this.ccNumber = pCCNumber;
            this.ccNIF = pCCNIF;
            this.ccSNS = pCCSNS;
            this.ccSS = pccSS;
            this.dateOfBirth = pdateOfBirth;
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
        public int Age { get; set; }

        /// <summary>
        /// Propertie Rue
        /// </summary>
        public int Rue { get; set; }

        /// <summary>
        /// Propertie CC Number
        /// </summary>
        public int CCNumber { get; set; }

        /// <summary>
        /// Propertie CC NIF
        /// </summary>
        public int CCNIF { get; set; }

        /// <summary>
        /// Propertie CC SNS
        /// </summary>
        public int CCSNS { get; set; }

        /// <summary>
        /// Propertie CC Segurança Social
        /// </summary>
        public int CCSS { get; set; }

        /// <summary>
        /// Propertie Date of Birth
        /// </summary>
        public int DateOfBirth { get; set; }














    }
}
