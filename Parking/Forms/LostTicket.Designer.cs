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
            this.gridView_VehicleList = new System.Windows.Forms.DataGridView();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txtBox_VehicleNumber = new System.Windows.Forms.RichTextBox();
            this.tblparkingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox_VehicleOwnerDetails = new System.Windows.Forms.GroupBox();
            this.comboBox_DocumentType = new System.Windows.Forms.ComboBox();
            this.txtBox_DocumentNumber = new System.Windows.Forms.RichTextBox();
            this.txtBox_Name = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Submit = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_VehicleList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblparkingBindingSource)).BeginInit();
            this.groupBox_VehicleOwnerDetails.SuspendLayout();
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
            // gridView_VehicleList
            // 
            this.gridView_VehicleList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridView_VehicleList.Location = new System.Drawing.Point(29, 487);
            this.gridView_VehicleList.MultiSelect = false;
            this.gridView_VehicleList.Name = "gridView_VehicleList";
            this.gridView_VehicleList.ReadOnly = true;
            this.gridView_VehicleList.RowTemplate.Height = 24;
            this.gridView_VehicleList.Size = new System.Drawing.Size(836, 125);
            this.gridView_VehicleList.TabIndex = 2;
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
            // txtBox_VehicleNumber
            // 
            this.txtBox_VehicleNumber.Location = new System.Drawing.Point(505, 48);
            this.txtBox_VehicleNumber.Name = "txtBox_VehicleNumber";
            this.txtBox_VehicleNumber.Size = new System.Drawing.Size(221, 32);
            this.txtBox_VehicleNumber.TabIndex = 4;
            this.txtBox_VehicleNumber.Text = "";
            // 
            // groupBox_VehicleOwnerDetails
            // 
            this.groupBox_VehicleOwnerDetails.Controls.Add(this.comboBox_DocumentType);
            this.groupBox_VehicleOwnerDetails.Controls.Add(this.txtBox_DocumentNumber);
            this.groupBox_VehicleOwnerDetails.Controls.Add(this.txtBox_Name);
            this.groupBox_VehicleOwnerDetails.Controls.Add(this.label6);
            this.groupBox_VehicleOwnerDetails.Controls.Add(this.label5);
            this.groupBox_VehicleOwnerDetails.Controls.Add(this.label4);
            this.groupBox_VehicleOwnerDetails.Controls.Add(this.label2);
            this.groupBox_VehicleOwnerDetails.Controls.Add(this.button_Submit);
            this.groupBox_VehicleOwnerDetails.Enabled = false;
            this.groupBox_VehicleOwnerDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_VehicleOwnerDetails.Location = new System.Drawing.Point(98, 128);
            this.groupBox_VehicleOwnerDetails.Name = "groupBox_VehicleOwnerDetails";
            this.groupBox_VehicleOwnerDetails.Size = new System.Drawing.Size(738, 322);
            this.groupBox_VehicleOwnerDetails.TabIndex = 15;
            this.groupBox_VehicleOwnerDetails.TabStop = false;
            this.groupBox_VehicleOwnerDetails.Text = "Vehicle Owner Details";
            // 
            // comboBox_DocumentType
            // 
            this.comboBox_DocumentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_DocumentType.FormattingEnabled = true;
            this.comboBox_DocumentType.Location = new System.Drawing.Point(293, 105);
            this.comboBox_DocumentType.Name = "comboBox_DocumentType";
            this.comboBox_DocumentType.Size = new System.Drawing.Size(334, 37);
            this.comboBox_DocumentType.TabIndex = 24;
            // 
            // txtBox_DocumentNumber
            // 
            this.txtBox_DocumentNumber.Location = new System.Drawing.Point(293, 163);
            this.txtBox_DocumentNumber.Name = "txtBox_DocumentNumber";
            this.txtBox_DocumentNumber.Size = new System.Drawing.Size(334, 35);
            this.txtBox_DocumentNumber.TabIndex = 23;
            this.txtBox_DocumentNumber.Text = "";
            // 
            // txtBox_Name
            // 
            this.txtBox_Name.Location = new System.Drawing.Point(293, 52);
            this.txtBox_Name.Name = "txtBox_Name";
            this.txtBox_Name.Size = new System.Drawing.Size(334, 36);
            this.txtBox_Name.TabIndex = 21;
            this.txtBox_Name.Text = "";
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
            this.Controls.Add(this.groupBox_VehicleOwnerDetails);
            this.Controls.Add(this.txtBox_VehicleNumber);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.gridView_VehicleList);
            this.Controls.Add(this.label1);
            this.Name = "LostTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LostTicket";
            this.Load += new System.EventHandler(this.LostTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView_VehicleList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblparkingBindingSource)).EndInit();
            this.groupBox_VehicleOwnerDetails.ResumeLayout(false);
            this.groupBox_VehicleOwnerDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridView_VehicleList;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.RichTextBox txtBox_VehicleNumber;
        private System.Windows.Forms.BindingSource tblparkingBindingSource;
        private System.Windows.Forms.GroupBox groupBox_VehicleOwnerDetails;
        private System.Windows.Forms.ComboBox comboBox_DocumentType;
        private System.Windows.Forms.RichTextBox txtBox_DocumentNumber;
        private System.Windows.Forms.RichTextBox txtBox_Name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Submit;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}