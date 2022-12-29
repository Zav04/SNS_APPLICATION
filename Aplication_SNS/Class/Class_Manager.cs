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

            managerOfDoctors.Add(new Doctor("Doctor1", 28,"Rua Teste 1",District.Braga,City.Guimarães, "123455689sc", 123455689, 123455689, 123455689, "22/08/1990", DoctorSpecialty.Cardiologist));
            managerOfDoctors.Add(new Doctor("Doctor2", 35, "Rua Teste 2", District.Braga, City.Guimarães, "123455689sc", 123455689, 123455689, 123455689, "06/12/1984", DoctorSpecialty.Dermatology));
            managerOfDoctors.Add(new Doctor("Doctor3", 29, "Rua Teste 3", District.Braga, City.Guimarães, "123455689sc", 123455689, 123455689, 123455689, "16/01/1992", DoctorSpecialty.GeneralMedicine));
            managerOfDoctors.Add(new Doctor("Doctor4", 45, "Rua Teste 4", District.Braga, City.Guimarães, "123455689sc", 123455689, 123455689, 123455689, "06/06/1978", DoctorSpecialty.Orthopedics));
            managerOfDoctors.Add(new Doctor("Doctor5", 56, "Rua Teste 5", District.Braga, City.Guimarães, "123455689sc", 123455689, 123455689, 123455689, "06/06/1966", DoctorSpecialty.Oncology));
            managerOfDoctors.Add(new Doctor("Doctor6", 62, "Rua Teste 6", District.Braga, City.Guimarães, "123455689sc", 123455689, 123455689, 123455689, "06/06/1961", DoctorSpecialty.Neurology));

        }

        public static ref List<Doctor> GetDataOfDoctors() { return ref managerOfDoctors; }




        public static void ReadDataOfNurse()
        {


        }

        public static ref List<NurseClass> GetDataOfNurse() { return ref managerOfNurse; }



        public static void ReadDataOfHospital()
        {
            managerOfHospitals.Add(new Hospital("Hospital 1", "Rua Hospital 1", District.Braga, City.Guimarães, 2, 2, 2));
            managerOfHospitals.Add(new Hospital("Hospital 2", "Rua Hospital 2", District.Braga, City.Guimarães, 3, 3, 3));
            managerOfHospitals.Add(new Hospital("Hospital 3", "Rua Hospital 3", District.Braga, City.Guimarães, 4, 4, 4));
            managerOfHospitals.Add(new Hospital("Hospital 4", "Rua Hospital 4", District.Braga, City.Guimarães, 5, 5, 5));
            managerOfHospitals.Add(new Hospital("Hospital 5", "Rua Hospital 5", District.Braga, City.Guimarães, 6, 6, 6));
            managerOfHospitals.Add(new Hospital("Hospital 6", "Rua Hospital 6", District.Braga, City.Guimarães, 7, 7, 7));
        }

        public static ref List<Hospital> GetDataOfHospital() { return ref managerOfHospitals; }




        public static void ReadDataOfPacient()
        {

        }

        public static ref List<PacientClass> GetDataOfPacient() { return ref managerOfPacients; }

    }
}