using Parking.Common;
using Parking.Common.Enums;
using Parking.Database.CommandFactory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Parking.Exit.Forms
{
    public partial class LostTicket : Form
    {
        private readonly ParkingDatabaseFactory _prkingDatabaseFactory;
        public LostTicket()
        {
            InitializeComponent();
            _prkingDatabaseFactory = new ParkingDatabaseFactory();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBox_VehicleNumber.Text))
            {
                MessageBox.Show("Vehicle number Can not be empty, Please enter a valid Vehicle Nnumber", "MPS ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                var result = _prkingDatabaseFactory.GetVehicleEntry(txtBox_VehicleNumber.Text);

                if (result == null || result.Rows.Count < 1)
                {
                    MessageBox.Show("Parking information for this vehicle was not found", "MPS ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                var ticketList = new List<object>();
                foreach (DataRow item in result.Rows)
                {
                    //var sss = Encoding.ASCII.GetBytes(item["DriverImage"].ToString().Trim());
                    //var driverImageStream = new MemoryStream((byte[])sss);
                    //var driverImage = Image.FromStream(driverImageStream);
                    //ss.Add(new { Ticket_Number = item["TicketNumber"], Vehicle_Number = item["VehicleNumber"], Vehicle_Type= item["VehicleType"], Entry_Time = item["EntryTime"], Driver_Image = driverImage });

                    var vehicleType = Enum.Parse(typeof(VehicleType), item["VehicleType"].ToString().Trim()).ToString();
                    ticketList.Add(new { Ticket_Number = item["TicketNumber"], Vehicle_Number = item["VehicleNumber"], Vehicle_Type = vehicleType, Entry_Time = item["EntryTime"] });
                }

                gridView_VehicleList.DataSource = ticketList;
                groupBox_VehicleOwnerDetails.Enabled = true;
            }
            catch (Exception exception)
            {
                FileLogger.Log($"Vehicle's parking information search failed as : {exception.Message}");
            }
        }

        private void LostTicket_Load(object sender, EventArgs e)
        {
            LoadComboxBox();
        }

        private void button_Submit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBox_VehicleNumber.Text))
            {
                MessageBox.Show("Vehicle Number Can not be Empty, Please Enter a valid Vehicle Number", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtBox_Name.Text))
            {
                MessageBox.Show("Name of the person Can not be Empty, Please Enter a valid Name", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBox_DocumentType.SelectedIndex <= 0)
            {
                MessageBox.Show("Please select a Identity Document", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtBox_DocumentNumber.Text))
            {
                MessageBox.Show("Document number can not be empty, Please Enter a valid Document Number", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            _prkingDatabaseFactory.SaveLostTicketInfo(txtBox_Name.Text, txtBox_VehicleNumber.Text, byte.Parse(comboBox_DocumentType.SelectedValue.ToString()), txtBox_DocumentNumber.Text);
        }

        private void LoadComboxBox()
        {
            var comboSource = new Dictionary<string, string>();
            comboSource.Add("Nothing", "<Select>");
            foreach (var documentType in Enum.GetValues(typeof(DocumentType)))
            {
                comboSource.Add(((int)(DocumentType)documentType).ToString(), documentType.ToString());
                comboBox_DocumentType.DataSource = new BindingSource(comboSource, null);
                comboBox_DocumentType.DisplayMember = "Value";
                comboBox_DocumentType.ValueMember = "Key";
            }
            comboBox_DocumentType.SelectedIndex = 0;
        }
    }
}
