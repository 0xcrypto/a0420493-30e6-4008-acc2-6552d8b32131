using Parking.Common;
using Parking.Database.CommandFactory;
using System;
using System.Threading;
using System.Windows.Forms;

namespace Parking.Exit.Forms
{
    public partial class LogIN : Form
    {

        private readonly ParkingDatabaseFactory _parkingDatabaseFactory;
        public LogIN()
        {
            InitializeComponent();
            _parkingDatabaseFactory = new ParkingDatabaseFactory();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBox_UserName.Text == string.Empty)
                {
                    MessageBox.Show("User Name Can not be Empty, Please Enter a valid User Name", null, MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return;
                }
                if (txtBox_Password.Text == string.Empty)
                {
                    MessageBox.Show("Password can not be Empty, Please Enter a valid Password", null, MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return;
                }

                if (txtBox_UserName.Text != MPSConfigurationReader.GetConfigurationSettings().UserID || txtBox_Password.Text != MPSConfigurationReader.GetConfigurationSettings().UserPassword)
                {
                    MessageBox.Show("Invalid Credentials, Please Enter valid credentials", null, MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return;
                }                

                //Make Entry for MPS User
                var mpsUserEntryRecordIdentifier =_parkingDatabaseFactory.SaveMPSUserShiftEntry(MPSConfigurationReader.GetConfigurationSettings().MPSDeviceID, MPSConfigurationReader.GetConfigurationSettings().UserID, DateTime.Now.ToString());

                //Show MPS Screen
                ThreadPool.QueueUserWorkItem(MPSLaunch, mpsUserEntryRecordIdentifier);
                //Hide Log-In Screen
                this.Hide();
            }
            catch (Exception exception)
            {
                FileLogger.Log($"Login for user {txtBox_UserName.Text} failed as : {exception.Message} ");
                this.Close();
            }
        }

        private void MPSLaunch(object Object)
        {
            var mps = new MPS(Object.ToString());
            mps.ShowDialog();
        }
    }
}
