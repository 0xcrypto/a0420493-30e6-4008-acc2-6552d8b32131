using System;
using System.Windows.Forms;
using Parking.Database.CommandFactory;
using Parking.Common;
using System.Globalization;

namespace Parking.Exit.Forms
{
    public partial class MPS : Form
    {
        private MPSSettings mpsSetting;
        private readonly ParkingDatabaseFactory parkingDatabaseFactory;

        public MPS()
        {
            InitializeComponent();
            parkingDatabaseFactory = new ParkingDatabaseFactory();

            mpsSetting = MPSConfigurationReader.GetConfigurationSettings();

           // if (mpsSetting.MPSDeviceID == null)
             //   FileLogger.Log($"Problem Loading Configuration Information from Configuration File");

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
    }
}
