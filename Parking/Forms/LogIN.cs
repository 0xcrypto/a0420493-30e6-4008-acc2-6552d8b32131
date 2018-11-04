﻿using Parking.Common;
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
                if (txtBoxUserName.Text == string.Empty)
                {
                    MessageBox.Show("Username Can't be empty, Please enter a valid Username", null, MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return;
                }
                if (txtBoxPassword.Text == string.Empty)
                {
                    MessageBox.Show("Password can't be empty, Please enter a valid Password", null, MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return;
                }

                if (txtBoxUserName.Text != MPSConfigurationReader.GetConfigurationSettings().UserId || txtBoxPassword.Text != MPSConfigurationReader.GetConfigurationSettings().UserPassword)
                {
                    MessageBox.Show("Username or Password didn't match", null, MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return;
                }                

                //Show MPS Screen                
                ThreadPool.QueueUserWorkItem(MPSLaunch);
                //Hide Log-In Screen
                this.Hide();
            }
            catch (Exception exception)
            {
                FileLogger.Log($"Login for user {txtBoxUserName.Text} failed as : {exception.Message} ");
                this.Close();
            }
        }

        private void MPSLaunch(object Object)
        {
            var mps = new MPS(DateTime.Now.ToString());
            mps.ShowDialog();
        }
    }
}
