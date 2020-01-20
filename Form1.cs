using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChalanSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBookChalan_Click(object sender, EventArgs e)
        {
            Chalan chalan = new Chalan();
            Driver driver = new Driver();
            Vehicle vehicle = new Vehicle();
            driver.DriverName = txtDriverName.Text;
            driver.DriverID = Convert.ToInt32( txtDriverID.Text);
            vehicle.RegNo = Convert.ToInt32 (txtRegNo.Text);
            vehicle.VehicleType = txtVehicleType.Text;
            vehicle.Model = txtVehicleModel.Text;
            Officer officer = new Officer();
            officer.OfficerName = txtOfficerName.Text;
            ChalanLocation location = new ChalanLocation();
            location.Location = txtLocation.Text;
            chalan.IssueChalan(driver.DriverName, driver.DriverID, vehicle.VehicleType,
                vehicle.Model, vehicle.RegNo, location.Location, officer.OfficerName);


        }
    }
}
