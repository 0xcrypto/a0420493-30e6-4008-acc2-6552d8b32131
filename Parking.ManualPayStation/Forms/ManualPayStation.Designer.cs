namespace Parking.Exit.Forms
{
    partial class MPS
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
            this.components = new System.ComponentModel.Container();
            this.lbl_dateAndTime = new System.Windows.Forms.Label();
            this.lbl_ParkingName = new System.Windows.Forms.Label();
            this.lbl_DeviceID = new System.Windows.Forms.Label();
            this.lbl_UserID = new System.Windows.Forms.Label();
            this.lbl_InTime = new System.Windows.Forms.Label();
            this.lbl_OutTime = new System.Windows.Forms.Label();
            this.lbl_Duration = new System.Windows.Forms.Label();
            this.lbl_ToBePaid = new System.Windows.Forms.Label();
            this.btn_LostTicket = new System.Windows.Forms.Button();
            this.btn_PendingVehicle = new System.Windows.Forms.Button();
            this.btn_UnsendRecord = new System.Windows.Forms.Button();
            this.btn_SaveAndPrint = new System.Windows.Forms.Button();
            this.btn_VehicleStatus = new System.Windows.Forms.Button();
            this.btn_ComplimentaryTicket = new System.Windows.Forms.Button();
            this.btn_CloseShift = new System.Windows.Forms.Button();
            this.clockTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbl_dateAndTime
            // 
            this.lbl_dateAndTime.AutoSize = true;
            this.lbl_dateAndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dateAndTime.Location = new System.Drawing.Point(503, 11);
            this.lbl_dateAndTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_dateAndTime.Name = "lbl_dateAndTime";
            this.lbl_dateAndTime.Size = new System.Drawing.Size(67, 26);
            this.lbl_dateAndTime.TabIndex = 0;
            this.lbl_dateAndTime.Text = "Clock";
            // 
            // lbl_ParkingName
            // 
            this.lbl_ParkingName.AutoSize = true;
            this.lbl_ParkingName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ParkingName.Location = new System.Drawing.Point(503, 42);
            this.lbl_ParkingName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ParkingName.Name = "lbl_ParkingName";
            this.lbl_ParkingName.Size = new System.Drawing.Size(169, 26);
            this.lbl_ParkingName.TabIndex = 1;
            this.lbl_ParkingName.Text = "Parking Name : ";
            // 
            // lbl_DeviceID
            // 
            this.lbl_DeviceID.AutoSize = true;
            this.lbl_DeviceID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DeviceID.Location = new System.Drawing.Point(545, 76);
            this.lbl_DeviceID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_DeviceID.Name = "lbl_DeviceID";
            this.lbl_DeviceID.Size = new System.Drawing.Size(119, 26);
            this.lbl_DeviceID.TabIndex = 2;
            this.lbl_DeviceID.Text = "Device ID :";
            // 
            // lbl_UserID
            // 
            this.lbl_UserID.AutoSize = true;
            this.lbl_UserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserID.Location = new System.Drawing.Point(565, 106);
            this.lbl_UserID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_UserID.Name = "lbl_UserID";
            this.lbl_UserID.Size = new System.Drawing.Size(98, 26);
            this.lbl_UserID.TabIndex = 3;
            this.lbl_UserID.Text = "User ID :";
            // 
            // lbl_InTime
            // 
            this.lbl_InTime.AutoSize = true;
            this.lbl_InTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InTime.Location = new System.Drawing.Point(50, 188);
            this.lbl_InTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_InTime.Name = "lbl_InTime";
            this.lbl_InTime.Size = new System.Drawing.Size(108, 26);
            this.lbl_InTime.TabIndex = 4;
            this.lbl_InTime.Text = "In Time   :";
            // 
            // lbl_OutTime
            // 
            this.lbl_OutTime.AutoSize = true;
            this.lbl_OutTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OutTime.Location = new System.Drawing.Point(32, 252);
            this.lbl_OutTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_OutTime.Name = "lbl_OutTime";
            this.lbl_OutTime.Size = new System.Drawing.Size(125, 26);
            this.lbl_OutTime.TabIndex = 5;
            this.lbl_OutTime.Text = "Out Time   :";
            // 
            // lbl_Duration
            // 
            this.lbl_Duration.AutoSize = true;
            this.lbl_Duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Duration.Location = new System.Drawing.Point(38, 311);
            this.lbl_Duration.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Duration.Name = "lbl_Duration";
            this.lbl_Duration.Size = new System.Drawing.Size(118, 26);
            this.lbl_Duration.TabIndex = 6;
            this.lbl_Duration.Text = "Duration   :";
            // 
            // lbl_ToBePaid
            // 
            this.lbl_ToBePaid.AutoSize = true;
            this.lbl_ToBePaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ToBePaid.Location = new System.Drawing.Point(14, 376);
            this.lbl_ToBePaid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ToBePaid.Name = "lbl_ToBePaid";
            this.lbl_ToBePaid.Size = new System.Drawing.Size(143, 26);
            this.lbl_ToBePaid.TabIndex = 7;
            this.lbl_ToBePaid.Text = "To Be Paid   :";
            // 
            // btn_LostTicket
            // 
            this.btn_LostTicket.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_LostTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LostTicket.Location = new System.Drawing.Point(68, 524);
            this.btn_LostTicket.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_LostTicket.Name = "btn_LostTicket";
            this.btn_LostTicket.Size = new System.Drawing.Size(237, 51);
            this.btn_LostTicket.TabIndex = 8;
            this.btn_LostTicket.Text = "Lost Ticket";
            this.btn_LostTicket.UseVisualStyleBackColor = true;
            this.btn_LostTicket.Click += new System.EventHandler(this.btn_LostTicket_Click);
            // 
            // btn_PendingVehicle
            // 
            this.btn_PendingVehicle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_PendingVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PendingVehicle.Location = new System.Drawing.Point(378, 524);
            this.btn_PendingVehicle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_PendingVehicle.Name = "btn_PendingVehicle";
            this.btn_PendingVehicle.Size = new System.Drawing.Size(237, 51);
            this.btn_PendingVehicle.TabIndex = 9;
            this.btn_PendingVehicle.Text = "Pending Vehicle";
            this.btn_PendingVehicle.UseVisualStyleBackColor = true;
            this.btn_PendingVehicle.Click += new System.EventHandler(this.btn_PendingVehicle_Click);
            // 
            // btn_UnsendRecord
            // 
            this.btn_UnsendRecord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_UnsendRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UnsendRecord.Location = new System.Drawing.Point(686, 524);
            this.btn_UnsendRecord.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_UnsendRecord.Name = "btn_UnsendRecord";
            this.btn_UnsendRecord.Size = new System.Drawing.Size(237, 51);
            this.btn_UnsendRecord.TabIndex = 10;
            this.btn_UnsendRecord.Text = "Unsend Record";
            this.btn_UnsendRecord.UseVisualStyleBackColor = true;
            // 
            // btn_SaveAndPrint
            // 
            this.btn_SaveAndPrint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_SaveAndPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveAndPrint.Location = new System.Drawing.Point(999, 524);
            this.btn_SaveAndPrint.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_SaveAndPrint.Name = "btn_SaveAndPrint";
            this.btn_SaveAndPrint.Size = new System.Drawing.Size(237, 51);
            this.btn_SaveAndPrint.TabIndex = 11;
            this.btn_SaveAndPrint.Text = "Save && Print";
            this.btn_SaveAndPrint.UseVisualStyleBackColor = true;
            // 
            // btn_VehicleStatus
            // 
            this.btn_VehicleStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_VehicleStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VehicleStatus.Location = new System.Drawing.Point(191, 621);
            this.btn_VehicleStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_VehicleStatus.Name = "btn_VehicleStatus";
            this.btn_VehicleStatus.Size = new System.Drawing.Size(248, 51);
            this.btn_VehicleStatus.TabIndex = 12;
            this.btn_VehicleStatus.Text = "Vehicles Status";
            this.btn_VehicleStatus.UseVisualStyleBackColor = true;
            this.btn_VehicleStatus.Click += new System.EventHandler(this.btn_VehicleStatus_Click);
            // 
            // btn_ComplimentaryTicket
            // 
            this.btn_ComplimentaryTicket.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ComplimentaryTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ComplimentaryTicket.Location = new System.Drawing.Point(530, 621);
            this.btn_ComplimentaryTicket.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_ComplimentaryTicket.Name = "btn_ComplimentaryTicket";
            this.btn_ComplimentaryTicket.Size = new System.Drawing.Size(284, 51);
            this.btn_ComplimentaryTicket.TabIndex = 13;
            this.btn_ComplimentaryTicket.Text = "Complementary Ticket";
            this.btn_ComplimentaryTicket.UseVisualStyleBackColor = true;
            // 
            // btn_CloseShift
            // 
            this.btn_CloseShift.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_CloseShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CloseShift.Location = new System.Drawing.Point(858, 621);
            this.btn_CloseShift.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_CloseShift.Name = "btn_CloseShift";
            this.btn_CloseShift.Size = new System.Drawing.Size(257, 51);
            this.btn_CloseShift.TabIndex = 14;
            this.btn_CloseShift.Text = "Close Shift";
            this.btn_CloseShift.UseVisualStyleBackColor = true;
            this.btn_CloseShift.Click += new System.EventHandler(this.btn_CloseShift_Click);
            // 
            // clockTimer
            // 
            this.clockTimer.Enabled = true;
            this.clockTimer.Interval = 1000;
            this.clockTimer.Tick += new System.EventHandler(this.clockTimer_Tick);
            // 
            // MPS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1022, 602);
            this.Controls.Add(this.btn_CloseShift);
            this.Controls.Add(this.btn_ComplimentaryTicket);
            this.Controls.Add(this.btn_VehicleStatus);
            this.Controls.Add(this.btn_SaveAndPrint);
            this.Controls.Add(this.btn_UnsendRecord);
            this.Controls.Add(this.btn_PendingVehicle);
            this.Controls.Add(this.btn_LostTicket);
            this.Controls.Add(this.lbl_ToBePaid);
            this.Controls.Add(this.lbl_Duration);
            this.Controls.Add(this.lbl_OutTime);
            this.Controls.Add(this.lbl_InTime);
            this.Controls.Add(this.lbl_UserID);
            this.Controls.Add(this.lbl_DeviceID);
            this.Controls.Add(this.lbl_ParkingName);
            this.Controls.Add(this.lbl_dateAndTime);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MPS";
            this.Text = "Manual Pay Station";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MPSLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_dateAndTime;
        private System.Windows.Forms.Label lbl_ParkingName;
        private System.Windows.Forms.Label lbl_DeviceID;
        private System.Windows.Forms.Label lbl_UserID;
        private System.Windows.Forms.Label lbl_InTime;
        private System.Windows.Forms.Label lbl_OutTime;
        private System.Windows.Forms.Label lbl_Duration;
        private System.Windows.Forms.Label lbl_ToBePaid;
        private System.Windows.Forms.Button btn_LostTicket;
        private System.Windows.Forms.Button btn_PendingVehicle;
        private System.Windows.Forms.Button btn_UnsendRecord;
        private System.Windows.Forms.Button btn_SaveAndPrint;
        private System.Windows.Forms.Button btn_VehicleStatus;
        private System.Windows.Forms.Button btn_ComplimentaryTicket;
        private System.Windows.Forms.Button btn_CloseShift;
        private System.Windows.Forms.Timer clockTimer;
    }
}