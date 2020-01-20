using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChalanSystem
{
   public class Chalan
    {
        public string VoilationType { get; set; }
        public void IssueChalan (string driverName, int driverID, string vehicleType,
            string vehicleModel, int regNo, string location, string officerName)
        {
            string connectionString = "Data Source=Khan;Initial Catalog=ChalanDB;Integrated Security=True";
            string chalanQuery = "";
            SqlConnection cn = new SqlConnection(connectionString);
            using (SqlCommand cmd = new SqlCommand("InsertInChalan", cn))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cn.Open();
                cmd.Parameters.AddWithValue("@DriverName", driverName);
                cmd.Parameters.AddWithValue("@DriverID", driverID);
                cmd.Parameters.AddWithValue("@VehicleType", vehicleType);
                cmd.Parameters.AddWithValue("@VehicleModel", vehicleModel);
                cmd.Parameters.AddWithValue("@RegNo", regNo);
                cmd.Parameters.AddWithValue("@Location", location);
                cmd.Parameters.AddWithValue("@OfficerName", officerName);
                
                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    MessageBox.Show("Chalan issued successfully");
                }
                else
                {
                    MessageBox.Show("There was a problem");
                }



            
            }
        }

    }
}
