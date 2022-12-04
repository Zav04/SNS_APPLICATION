using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Class.Hospital;
using Portugal.City;
using Portugal.District;

namespace Menus.HospitalInsert
{
    public partial class Hospital_Insert : Form
    {

        List<HospitalClass> listofHospitalObejects;
        public Hospital_Insert(List<HospitalClass> ListofObejects)
        {
            listofHospitalObejects = ListofObejects;
            InitializeComponent();
        }

 
    }
}
