using Class.CDoctor;
using Class.CHospital;
using Class.CNurse;
using Class.CPacient;
using Portugal.City;
using Portugal.District;
using System;
using System.Collections.Generic;
using System.Windows.Documents;


namespace Class.ManagerOfData
{
    public static class Class_Manager
    {

        public static List<Doctor> managerOfDoctors = new List<Doctor>();
        public static List<NurseClass> managerOfNurse = new List<NurseClass>();
        public static List<Hospital> managerOfHospitals = new List<Hospital>();
        public static List<PacientClass> managerOfPacients = new List<PacientClass>();

        public static void ReadDataOfDoctors()
        {


        }

        public static ref List<Doctor> GetDataOfDoctors() { return ref managerOfDoctors; }




        public static void ReadDataOfNurse()
        {


        }

        public static ref List<NurseClass> GetDataOfNurse() { return ref managerOfNurse; }



        public static void ReadDataOfHospital()
        {
            managerOfHospitals.Add(new Hospital("Bruno", "Rua", District.Braga, City.Guimarães, 2, 2, 2));
            managerOfHospitals.Add(new Hospital("Bruno", "Rua", District.Braga, City.Guimarães, 3, 3, 3));
            managerOfHospitals.Add(new Hospital("Bruno", "Rua", District.Braga, City.Guimarães, 4, 4, 4));
            managerOfHospitals.Add(new Hospital("Bruno", "Rua", District.Braga, City.Guimarães, 5, 5, 5));
            managerOfHospitals.Add(new Hospital("Bruno", "Rua", District.Braga, City.Guimarães, 6, 6, 6));
            managerOfHospitals.Add(new Hospital("Bruno", "Rua", District.Braga, City.Guimarães, 7, 7, 7));
        }

        public static ref List<Hospital> GetDataOfHospital() { return ref managerOfHospitals; }




        public static void ReadDataOfPacient()
        {

        }

        public static ref List<PacientClass> GetDataOfPacient() { return ref managerOfPacients; }

    }
}