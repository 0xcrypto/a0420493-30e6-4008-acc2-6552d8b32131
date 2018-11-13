using Parking.Common;
using Parking.Common.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Parking.Exit.Forms
{
    public partial class LostTicket : Form
    {
        private readonly ParkingDatabaseFactory _prkingDatabaseFactory;
        private Dictionary<string, string> _parkingIdMapper;
        public LostTicket()
        {
            InitializeComponent();
            _prkingDatabaseFactory = new ParkingDatabaseFactory(Common.Enums.Application.ManualPayStation);
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtVehicleNumber.Text))
            {
                MessageBox.Show("Vehicle number can't be empty, Please enter a valid vehicle number", "MPS ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                var result = _prkingDatabaseFactory.GetVehicleEntry(txtVehicleNumber.Text);

                if (result == null || result.Rows.Count < 1)
                {
                    MessageBox.Show("No information found for the vehicle number provided", "MPS ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                var ticketList = new List<object>();
                _parkingIdMapper = new Dictionary<string, string>();
                foreach (DataRow item in result.Rows)
                {
                    //var sss = Encoding.ASCII.GetBytes(item["DriverImage"].ToString().Trim());
                    //var driverImageStream = new MemoryStream((byte[])sss);
                    //var driverImage = Image.FromStream(driverImageStream);
                    //ss.Add(new { Ticket_Number = item["TicketNumber"], Vehicle_Number = item["VehicleNumber"], Vehicle_Type= item["VehicleType"], Entry_Time = item["EntryTime"], Driver_Image = driverImage });

                    var vehicleType = Enum.Parse(typeof(VehicleType), item["VehicleType"].ToString().Trim()).ToString();
                    ticketList.Add(new { TicketNumber = item["TicketNumber"], VehicleNumber = item["VehicleNumber"], VehicleType = vehicleType, EntryTime = item["EntryTime"] });
                    _parkingIdMapper.Add(item["TicketNumber"].ToString(), item["Id"].ToString());
                }

                gridViewVehicleList.DataSource = ticketList;
                gbVehicleOwnerDetails.Enabled = true;
            }
            catch (Exception exception)
            {
                FileLogger.Log($"Problem searching vehicle information : {exception.Message}");
            }
        }

        private void LostTicket_Load(object sender, EventArgs e)
        {
            LoadDocumentTypes();
        }

        private void button_Submit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtVehicleNumber.Text))
            {
                MessageBox.Show("Vehicle number can't be empty, Please enter a valid vehicle number", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Person name can't be empty, Please enter a valid name", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbDocumentType.SelectedIndex <= 0)
            {
                MessageBox.Show("Please select document type", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtDocumentNumber.Text))
            {
                MessageBox.Show("Document number can't be empty, Please enter a valid document number", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                _parkingIdMapper.TryGetValue(gridViewVehicleList.CurrentRow.Cells[0].Value.ToString(), out string parkingId);
                _prkingDatabaseFactory.SaveLostTicketInfo(parkingId, txtName.Text, txtVehicleNumber.Text, byte.Parse(cbDocumentType.SelectedValue.ToString()), txtDocumentNumber.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Error Saving Lost Ticket Information", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                _parkingIdMapper.Clear();
                this.Close();
            }
        }

        private void LoadDocumentTypes()
        {
            var source = new Dictionary<string, string>();
            source.Add("Nothing", "<Select>");
            foreach (var documentType in Enum.GetValues(typeof(DocumentType)))
            {
                source.Add(((int)(DocumentType)documentType).ToString(), documentType.ToString());
                cbDocumentType.DataSource = new BindingSource(source, null);
                cbDocumentType.DisplayMember = "Value";
                cbDocumentType.ValueMember = "Key";
            }
            cbDocumentType.SelectedIndex = 0;
        }
    }
}
