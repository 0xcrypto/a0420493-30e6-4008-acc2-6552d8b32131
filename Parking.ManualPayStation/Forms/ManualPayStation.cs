using System;
using System.Windows.Forms;
using Parking.Common;
using Parking.Common.Enums;
using System.Globalization;

namespace Parking.Exit.Forms
{
    public partial class MPS : Form
    {
        private ManualPayStationSettings mpsSetting;
        private readonly ParkingDatabaseFactory _parkingDatabaseFactory;

        private readonly string _mpsUserEntryTime;
        public MPS(string mpsUserEntryTime)
        {
            _mpsUserEntryTime = mpsUserEntryTime;
            InitializeComponent();
            _parkingDatabaseFactory = new ParkingDatabaseFactory(Common.Enums.Application.ManualPayStation);

            mpsSetting = (ManualPayStationSettings)ConfigurationReader.GetConfigurationSettings(Common.Enums.Application.ManualPayStation);

            if (mpsSetting.DeviceId == null)
                FileLogger.Log($"Problem Loading Configuration Information from Configuration File");

        }

        private void MPSLoad(object sender, EventArgs e)
        {

        }

        private void clockTimer_Tick(object sender, EventArgs e)
        {
            var currentDateTime = DateTime.Now;

            this.lbl_dateAndTime.Text = $"{currentDateTime.DayOfWeek}, " +
                $"{CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(currentDateTime.Month)} {currentDateTime.Day}," +
                $" {currentDateTime.Year} {string.Format("{0:hh: mm: ss tt}", DateTime.Now)}";
        }

        private void btn_LostTicket_Click(object sender, EventArgs e)
        {
            var lostTicket = new LostTicket();
            lostTicket.ShowDialog();
        }

        private void btn_PendingVehicle_Click(object sender, EventArgs e)
        {
            var pendingVehicles = new PendingVehicles();
            pendingVehicles.ShowDialog();
        }

        private void btn_CloseShift_Click(object sender, EventArgs e)
        {
            try
            {
                var result = _parkingDatabaseFactory.GetShiftCollection(_mpsUserEntryTime);

                var closeShift = new CloseShift(result.Item1, result.Item2);
                closeShift.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Error Loading Shift Data", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }            
        }

        private void btn_VehicleStatus_Click(object sender, EventArgs e)
        {

        }
    }
}
