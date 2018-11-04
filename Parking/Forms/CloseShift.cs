using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Parking.Exit.Forms
{
    public partial class CloseShift : Form
    {
        
        public CloseShift(int exitVehiclesCount, int totalCollection)
        {
            InitializeComponent();
            this.lbl_ExitVehiclesCount.Text = exitVehiclesCount.ToString();
            this.lbl_TotalCollection.Text = totalCollection.ToString();
        }

    }
}
