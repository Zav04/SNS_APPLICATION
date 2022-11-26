using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class ClassBase_Persons
    {
        
        public string name;
        public int age;
        public string[] ccNumber = new string[12];
        public int[] ccNIF= new int[9];
        public int[] ccSNS= new int[9];
        public int[] ccSS=new int[11];
        public DateTime dateOfBirth;

        /// <summary>
        ///  Variables of Class Base
        ///  Person is a Class Base From Doctor, Nurse, Pacient Class
        /// </summary>
        /// <param name="pName">Name of Person</param>
        /// <param name="pAge">Age of person</param>
        /// <param name="pCCNumber">CC Number</param>
        /// <param name="pCCNIF"> CC NIF </param>
        /// <param name="pCCSNS">CC Numero de Utente</param>
        /// <param name="pccSS">CC Segurança Social</param>
        /// <param name="pdateOfBirth"> Date of Birth</param>
    


        public ClassBase_Persons(string pName, int pAge,string[] pCCNumber, int[] pCCNIF, int[] pCCSNS, int[] pccSS, DateTime pdateOfBirth) 
        {
            name = pName;
            age = pAge;
            ccNumber = pCCNumber;
            ccNIF = pCCNIF;
            ccSNS = pCCSNS;
            ccSS = pccSS;
            dateOfBirth = pdateOfBirth;
        }
        
        





    }
}
