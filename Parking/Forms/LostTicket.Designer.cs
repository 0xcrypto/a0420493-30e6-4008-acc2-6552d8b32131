namespace Parking.Exit.Forms
{
    partial class LostTicket
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
            this.label1 = new System.Windows.Forms.Label();
            this.gridViewVehicleList = new System.Windows.Forms.DataGridView();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txtVehicleNumber = new System.Windows.Forms.RichTextBox();
            this.tblparkingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbVehicleOwnerDetails = new System.Windows.Forms.GroupBox();
            this.cbDocumentType = new System.Windows.Forms.ComboBox();
            this.txtDocumentNumber = new System.Windows.Forms.RichTextBox();
            this.txtName = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Submit = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewVehicleList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblparkingBindingSource)).BeginInit();
            this.gbVehicleOwnerDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please Enter the Vehicle Number  :";
            // 
            // gridViewVehicleList
            // 
            this.gridViewVehicleList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridViewVehicleList.Location = new System.Drawing.Point(29, 487);
            this.gridViewVehicleList.MultiSelect = false;
            this.gridViewVehicleList.Name = "gridViewVehicleList";
            this.gridViewVehicleList.ReadOnly = true;
            this.gridViewVehicleList.RowTemplate.Height = 24;
            this.gridViewVehicleList.Size = new System.Drawing.Size(836, 125);
            this.gridViewVehicleList.TabIndex = 2;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(746, 48);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(139, 42);
            this.btn_Search.TabIndex = 3;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txtVehicleNumber
            // 
            this.txtVehicleNumber.Location = new System.Drawing.Point(505, 48);
            this.txtVehicleNumber.Name = "txtVehicleNumber";
            this.txtVehicleNumber.Size = new System.Drawing.Size(221, 32);
            this.txtVehicleNumber.TabIndex = 4;
            this.txtVehicleNumber.Text = "";
            // 
            // gbVehicleOwnerDetails
            // 
            this.gbVehicleOwnerDetails.Controls.Add(this.cbDocumentType);
            this.gbVehicleOwnerDetails.Controls.Add(this.txtDocumentNumber);
            this.gbVehicleOwnerDetails.Controls.Add(this.txtName);
            this.gbVehicleOwnerDetails.Controls.Add(this.label6);
            this.gbVehicleOwnerDetails.Controls.Add(this.label5);
            this.gbVehicleOwnerDetails.Controls.Add(this.label4);
            this.gbVehicleOwnerDetails.Controls.Add(this.label2);
            this.gbVehicleOwnerDetails.Controls.Add(this.button_Submit);
            this.gbVehicleOwnerDetails.Enabled = false;
            this.gbVehicleOwnerDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbVehicleOwnerDetails.Location = new System.Drawing.Point(98, 128);
            this.gbVehicleOwnerDetails.Name = "gbVehicleOwnerDetails";
            this.gbVehicleOwnerDetails.Size = new System.Drawing.Size(738, 322);
            this.gbVehicleOwnerDetails.TabIndex = 15;
            this.gbVehicleOwnerDetails.TabStop = false;
            this.gbVehicleOwnerDetails.Text = "Vehicle Owner Details";
            // 
            // cbDocumentType
            // 
            this.cbDocumentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDocumentType.FormattingEnabled = true;
            this.cbDocumentType.Location = new System.Drawing.Point(293, 105);
            this.cbDocumentType.Name = "cbDocumentType";
            this.cbDocumentType.Size = new System.Drawing.Size(334, 37);
            this.cbDocumentType.TabIndex = 24;
            // 
            // txtDocumentNumber
            // 
            this.txtDocumentNumber.Location = new System.Drawing.Point(293, 163);
            this.txtDocumentNumber.Name = "txtDocumentNumber";
            this.txtDocumentNumber.Size = new System.Drawing.Size(334, 35);
            this.txtDocumentNumber.TabIndex = 23;
            this.txtDocumentNumber.Text = "";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(293, 52);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(334, 36);
            this.txtName.TabIndex = 21;
            this.txtName.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(49, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 29);
            this.label6.TabIndex = 20;
            this.label6.Text = "Document Image";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 29);
            this.label5.TabIndex = 19;
            this.label5.Text = "Document Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(133, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 29);
            this.label4.TabIndex = 18;
            this.label4.Text = "Document ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(188, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 29);
            this.label2.TabIndex = 16;
            this.label2.Text = "Name";
            // 
            // button_Submit
            // 
            this.button_Submit.Location = new System.Drawing.Point(595, 255);
            this.button_Submit.Name = "button_Submit";
            this.button_Submit.Size = new System.Drawing.Size(139, 46);
            this.button_Submit.TabIndex = 15;
            this.button_Submit.Text = "Submit";
            this.button_Submit.UseVisualStyleBackColor = true;
            this.button_Submit.Click += new System.EventHandler(this.button_Submit_Click);
            // 
            // LostTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 649);
            this.Controls.Add(this.gbVehicleOwnerDetails);
            this.Controls.Add(this.txtVehicleNumber);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.gridViewVehicleList);
            this.Controls.Add(this.label1);
            this.Name = "LostTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LostTicket";
            this.Load += new System.EventHandler(this.LostTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewVehicleList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblparkingBindingSource)).EndInit();
            this.gbVehicleOwnerDetails.ResumeLayout(false);
            this.gbVehicleOwnerDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridViewVehicleList;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.RichTextBox txtVehicleNumber;
        private System.Windows.Forms.BindingSource tblparkingBindingSource;
        private System.Windows.Forms.GroupBox gbVehicleOwnerDetails;
        private System.Windows.Forms.ComboBox cbDocumentType;
        private System.Windows.Forms.RichTextBox txtDocumentNumber;
        private System.Windows.Forms.RichTextBox txtName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Submit;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}