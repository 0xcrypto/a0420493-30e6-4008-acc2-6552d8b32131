namespace Parking.Exit.Forms
{
    partial class PendingVehicles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridView_PendingVehicles = new System.Windows.Forms.DataGridView();
            this.SerialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehicleNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalVehiclePending = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_PendingVehicles)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView_PendingVehicles
            // 
            this.gridView_PendingVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView_PendingVehicles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SerialNumber,
            this.VehicleNumber,
            this.InTime});
            this.gridView_PendingVehicles.Location = new System.Drawing.Point(14, 12);
            this.gridView_PendingVehicles.Name = "gridView_PendingVehicles";
            this.gridView_PendingVehicles.ReadOnly = true;
            this.gridView_PendingVehicles.RowTemplate.Height = 24;
            this.gridView_PendingVehicles.Size = new System.Drawing.Size(682, 332);
            this.gridView_PendingVehicles.TabIndex = 0;
            // 
            // SerialNumber
            // 
            this.SerialNumber.HeaderText = "S.No.";
            this.SerialNumber.Name = "SerialNumber";
            this.SerialNumber.ReadOnly = true;
            this.SerialNumber.Width = 80;
            // 
            // VehicleNumber
            // 
            this.VehicleNumber.HeaderText = "Vehicle Number";
            this.VehicleNumber.MinimumWidth = 250;
            this.VehicleNumber.Name = "VehicleNumber";
            this.VehicleNumber.ReadOnly = true;
            this.VehicleNumber.Width = 250;
            // 
            // InTime
            // 
            this.InTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.InTime.HeaderText = "In Time";
            this.InTime.Name = "InTime";
            this.InTime.ReadOnly = true;
            // 
            // lblTotalVehiclePending
            // 
            this.lblTotalVehiclePending.AutoSize = true;
            this.lblTotalVehiclePending.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVehiclePending.Location = new System.Drawing.Point(55, 375);
            this.lblTotalVehiclePending.Name = "lblTotalVehiclePending";
            this.lblTotalVehiclePending.Size = new System.Drawing.Size(158, 29);
            this.lblTotalVehiclePending.TabIndex = 1;
            this.lblTotalVehiclePending.Text = "TotalPending";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(479, 371);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(176, 39);
            this.btn_Cancel.TabIndex = 2;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // PendingVehicles
            // 
            this.AcceptButton = this.btn_Cancel;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 450);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.lblTotalVehiclePending);
            this.Controls.Add(this.gridView_PendingVehicles);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PendingVehicles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pending Vehicles Status";
            this.Load += new System.EventHandler(this.PendingVehicles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView_PendingVehicles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridView_PendingVehicles;
        private System.Windows.Forms.Label lblTotalVehiclePending;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn InTime;
    }
}