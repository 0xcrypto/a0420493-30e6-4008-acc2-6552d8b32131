using Parking.Common;
using Parking.Database.CommandFactory;
using System;
using System.Data;
using System.Windows.Forms;

namespace Parking.Exit.Forms
{
    public partial class PendingVehicles : Form
    {
        private readonly ParkingDatabaseFactory _prkingDatabaseFactory;
        public PendingVehicles()
        {
            InitializeComponent();
            _prkingDatabaseFactory = new ParkingDatabaseFactory();
        }
        
        private void PendingVehicles_Load(object sender, EventArgs e)
        {
            this.LoadPendingVehicles();
        }

        private void LoadPendingVehicles()
        {
            try
            {
                var result = _prkingDatabaseFactory.GetPendingVehicles();
                if (result.Rows.Count <= 0)
                {
                    MessageBox.Show("There are no pending vehicles in the Parking", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }

                var serialNo = 0;
                foreach (DataRow row in result.Rows)
                {
                    serialNo++;
                    gridView_PendingVehicles.Rows.Add(serialNo, row["VehicleNumber"].ToString(), row["EntryTime"].ToString());
                }

                lbl_TotalPending.Text = $"Total Pending  :  {result.Rows.Count}";
            }
            catch (Exception exception)
            {

                FileLogger.Log($"Pending Vehicles list Could not be retrieved from database as : {exception.Message}");
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
