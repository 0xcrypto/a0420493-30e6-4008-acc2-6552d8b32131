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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.clockTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbl_dateAndTime
            // 
            this.lbl_dateAndTime.AutoSize = true;
            this.lbl_dateAndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dateAndTime.Location = new System.Drawing.Point(671, 13);
            this.lbl_dateAndTime.Name = "lbl_dateAndTime";
            this.lbl_dateAndTime.Size = new System.Drawing.Size(86, 32);
            this.lbl_dateAndTime.TabIndex = 0;
            this.lbl_dateAndTime.Text = "Clock";
            // 
            // lbl_ParkingName
            // 
            this.lbl_ParkingName.AutoSize = true;
            this.lbl_ParkingName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ParkingName.Location = new System.Drawing.Point(671, 52);
            this.lbl_ParkingName.Name = "lbl_ParkingName";
            this.lbl_ParkingName.Size = new System.Drawing.Size(216, 32);
            this.lbl_ParkingName.TabIndex = 1;
            this.lbl_ParkingName.Text = "Parking Name : ";
            // 
            // lbl_DeviceID
            // 
            this.lbl_DeviceID.AutoSize = true;
            this.lbl_DeviceID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DeviceID.Location = new System.Drawing.Point(727, 93);
            this.lbl_DeviceID.Name = "lbl_DeviceID";
            this.lbl_DeviceID.Size = new System.Drawing.Size(151, 32);
            this.lbl_DeviceID.TabIndex = 2;
            this.lbl_DeviceID.Text = "Device ID :";
            // 
            // lbl_UserID
            // 
            this.lbl_UserID.AutoSize = true;
            this.lbl_UserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserID.Location = new System.Drawing.Point(753, 131);
            this.lbl_UserID.Name = "lbl_UserID";
            this.lbl_UserID.Size = new System.Drawing.Size(123, 32);
            this.lbl_UserID.TabIndex = 3;
            this.lbl_UserID.Text = "User ID :";
            // 
            // lbl_InTime
            // 
            this.lbl_InTime.AutoSize = true;
            this.lbl_InTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InTime.Location = new System.Drawing.Point(66, 231);
            this.lbl_InTime.Name = "lbl_InTime";
            this.lbl_InTime.Size = new System.Drawing.Size(137, 32);
            this.lbl_InTime.TabIndex = 4;
            this.lbl_InTime.Text = "In Time   :";
            // 
            // lbl_OutTime
            // 
            this.lbl_OutTime.AutoSize = true;
            this.lbl_OutTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OutTime.Location = new System.Drawing.Point(43, 310);
            this.lbl_OutTime.Name = "lbl_OutTime";
            this.lbl_OutTime.Size = new System.Drawing.Size(160, 32);
            this.lbl_OutTime.TabIndex = 5;
            this.lbl_OutTime.Text = "Out Time   :";
            // 
            // lbl_Duration
            // 
            this.lbl_Duration.AutoSize = true;
            this.lbl_Duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Duration.Location = new System.Drawing.Point(50, 383);
            this.lbl_Duration.Name = "lbl_Duration";
            this.lbl_Duration.Size = new System.Drawing.Size(152, 32);
            this.lbl_Duration.TabIndex = 6;
            this.lbl_Duration.Text = "Duration   :";
            // 
            // lbl_ToBePaid
            // 
            this.lbl_ToBePaid.AutoSize = true;
            this.lbl_ToBePaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ToBePaid.Location = new System.Drawing.Point(18, 463);
            this.lbl_ToBePaid.Name = "lbl_ToBePaid";
            this.lbl_ToBePaid.Size = new System.Drawing.Size(184, 32);
            this.lbl_ToBePaid.TabIndex = 7;
            this.lbl_ToBePaid.Text = "To Be Paid   :";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(90, 645);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(316, 63);
            this.button1.TabIndex = 8;
            this.button1.Text = "Lost Ticket";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(504, 645);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(316, 63);
            this.button2.TabIndex = 9;
            this.button2.Text = "Pending Vehicle";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(915, 645);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(316, 63);
            this.button3.TabIndex = 10;
            this.button3.Text = "Unsend Record";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(1332, 645);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(316, 63);
            this.button4.TabIndex = 11;
            this.button4.Text = "Save && Print";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(255, 764);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(331, 63);
            this.button5.TabIndex = 12;
            this.button5.Text = "Vehicles Status";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(707, 764);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(378, 63);
            this.button6.TabIndex = 13;
            this.button6.Text = "Complementary Ticket";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(1144, 764);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(343, 63);
            this.button7.TabIndex = 14;
            this.button7.Text = "Close Shift";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // clockTimer
            // 
            this.clockTimer.Enabled = true;
            this.clockTimer.Interval = 1000;
            this.clockTimer.Tick += new System.EventHandler(this.clockTimer_Tick);
            // 
            // MPS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1787, 869);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_ToBePaid);
            this.Controls.Add(this.lbl_Duration);
            this.Controls.Add(this.lbl_OutTime);
            this.Controls.Add(this.lbl_InTime);
            this.Controls.Add(this.lbl_UserID);
            this.Controls.Add(this.lbl_DeviceID);
            this.Controls.Add(this.lbl_ParkingName);
            this.Controls.Add(this.lbl_dateAndTime);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MPS";
            this.Text = "MPSHomeScreen";
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Timer clockTimer;
    }
}