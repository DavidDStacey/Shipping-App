namespace Shipping
{
    partial class FormList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormList));
            this.label1 = new System.Windows.Forms.Label();
            this.grpBxCompany = new System.Windows.Forms.GroupBox();
            this.radBtnUSPS = new System.Windows.Forms.RadioButton();
            this.radBtnFedex = new System.Windows.Forms.RadioButton();
            this.radBtnUPS = new System.Windows.Forms.RadioButton();
            this.grpBxShipMethod = new System.Windows.Forms.GroupBox();
            this.radBtnTwoDay = new System.Windows.Forms.RadioButton();
            this.radBtnOvernight = new System.Windows.Forms.RadioButton();
            this.lstBxPackages = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstBxInvoices = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBxSName = new System.Windows.Forms.TextBox();
            this.txtBxSAddress = new System.Windows.Forms.TextBox();
            this.txtBxSCity = new System.Windows.Forms.TextBox();
            this.txtBxSState = new System.Windows.Forms.TextBox();
            this.txtBxSZip = new System.Windows.Forms.TextBox();
            this.txtBxRZip = new System.Windows.Forms.TextBox();
            this.txtBxRState = new System.Windows.Forms.TextBox();
            this.txtBxRCity = new System.Windows.Forms.TextBox();
            this.txtBxRAddress = new System.Windows.Forms.TextBox();
            this.txtBxRName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnCreateInvoice = new System.Windows.Forms.Button();
            this.btnPrintShippingLabel = new System.Windows.Forms.Button();
            this.btnAddPackage = new System.Windows.Forms.Button();
            this.btnPrintInvoice = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.txtBxWeight = new System.Windows.Forms.TextBox();
            this.btnStoreInvoice = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnLoadInvoice = new System.Windows.Forms.Button();
            this.btnDeleteInvoice = new System.Windows.Forms.Button();
            this.btnDeletePackage = new System.Windows.Forms.Button();
            this.btnUnselectInvoice = new System.Windows.Forms.Button();
            this.btnUnselectPackage = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.prtDialog = new System.Windows.Forms.PrintDialog();
            this.prtPrDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.grpBxCompany.SuspendLayout();
            this.grpBxShipMethod.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shipping Application";
            // 
            // grpBxCompany
            // 
            this.grpBxCompany.Controls.Add(this.radBtnUSPS);
            this.grpBxCompany.Controls.Add(this.radBtnFedex);
            this.grpBxCompany.Controls.Add(this.radBtnUPS);
            this.grpBxCompany.Location = new System.Drawing.Point(12, 67);
            this.grpBxCompany.Name = "grpBxCompany";
            this.grpBxCompany.Size = new System.Drawing.Size(105, 107);
            this.grpBxCompany.TabIndex = 80;
            this.grpBxCompany.TabStop = false;
            this.grpBxCompany.Text = "Company:";
            // 
            // radBtnUSPS
            // 
            this.radBtnUSPS.AutoSize = true;
            this.radBtnUSPS.Location = new System.Drawing.Point(6, 77);
            this.radBtnUSPS.Name = "radBtnUSPS";
            this.radBtnUSPS.Size = new System.Drawing.Size(71, 24);
            this.radBtnUSPS.TabIndex = 2;
            this.radBtnUSPS.TabStop = true;
            this.radBtnUSPS.Text = "USPS";
            this.radBtnUSPS.UseVisualStyleBackColor = true;
            // 
            // radBtnFedex
            // 
            this.radBtnFedex.AutoSize = true;
            this.radBtnFedex.Location = new System.Drawing.Point(6, 51);
            this.radBtnFedex.Name = "radBtnFedex";
            this.radBtnFedex.Size = new System.Drawing.Size(71, 24);
            this.radBtnFedex.TabIndex = 1;
            this.radBtnFedex.TabStop = true;
            this.radBtnFedex.Text = "Fedex";
            this.radBtnFedex.UseVisualStyleBackColor = true;
            // 
            // radBtnUPS
            // 
            this.radBtnUPS.AutoSize = true;
            this.radBtnUPS.Location = new System.Drawing.Point(6, 25);
            this.radBtnUPS.Name = "radBtnUPS";
            this.radBtnUPS.Size = new System.Drawing.Size(60, 24);
            this.radBtnUPS.TabIndex = 0;
            this.radBtnUPS.TabStop = true;
            this.radBtnUPS.Text = "UPS";
            this.radBtnUPS.UseVisualStyleBackColor = true;
            // 
            // grpBxShipMethod
            // 
            this.grpBxShipMethod.Controls.Add(this.radBtnTwoDay);
            this.grpBxShipMethod.Controls.Add(this.radBtnOvernight);
            this.grpBxShipMethod.Location = new System.Drawing.Point(12, 180);
            this.grpBxShipMethod.Name = "grpBxShipMethod";
            this.grpBxShipMethod.Size = new System.Drawing.Size(105, 107);
            this.grpBxShipMethod.TabIndex = 80;
            this.grpBxShipMethod.TabStop = false;
            this.grpBxShipMethod.Text = "Shipping Method:";
            // 
            // radBtnTwoDay
            // 
            this.radBtnTwoDay.AutoSize = true;
            this.radBtnTwoDay.Location = new System.Drawing.Point(4, 77);
            this.radBtnTwoDay.Name = "radBtnTwoDay";
            this.radBtnTwoDay.Size = new System.Drawing.Size(88, 24);
            this.radBtnTwoDay.TabIndex = 1;
            this.radBtnTwoDay.TabStop = true;
            this.radBtnTwoDay.Text = "Two Day";
            this.radBtnTwoDay.UseVisualStyleBackColor = true;
            // 
            // radBtnOvernight
            // 
            this.radBtnOvernight.AutoSize = true;
            this.radBtnOvernight.Location = new System.Drawing.Point(4, 47);
            this.radBtnOvernight.Name = "radBtnOvernight";
            this.radBtnOvernight.Size = new System.Drawing.Size(95, 24);
            this.radBtnOvernight.TabIndex = 0;
            this.radBtnOvernight.TabStop = true;
            this.radBtnOvernight.Text = "Overnight";
            this.radBtnOvernight.UseVisualStyleBackColor = true;
            // 
            // lstBxPackages
            // 
            this.lstBxPackages.FormattingEnabled = true;
            this.lstBxPackages.ItemHeight = 20;
            this.lstBxPackages.Location = new System.Drawing.Point(12, 322);
            this.lstBxPackages.Name = "lstBxPackages";
            this.lstBxPackages.Size = new System.Drawing.Size(254, 124);
            this.lstBxPackages.TabIndex = 80;
            this.lstBxPackages.SelectedIndexChanged += new System.EventHandler(this.lstBxPackages_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Packages:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Invoices:";
            // 
            // lstBxInvoices
            // 
            this.lstBxInvoices.FormattingEnabled = true;
            this.lstBxInvoices.ItemHeight = 20;
            this.lstBxInvoices.Location = new System.Drawing.Point(272, 322);
            this.lstBxInvoices.Name = "lstBxInvoices";
            this.lstBxInvoices.Size = new System.Drawing.Size(182, 124);
            this.lstBxInvoices.TabIndex = 76;
            this.lstBxInvoices.SelectedIndexChanged += new System.EventHandler(this.lstBxInvoices_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sender Information:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(132, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(132, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Address:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(132, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "City:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(132, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "State:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(132, 262);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Zip Code:";
            // 
            // txtBxSName
            // 
            this.txtBxSName.Location = new System.Drawing.Point(209, 103);
            this.txtBxSName.Name = "txtBxSName";
            this.txtBxSName.Size = new System.Drawing.Size(177, 26);
            this.txtBxSName.TabIndex = 0;
            // 
            // txtBxSAddress
            // 
            this.txtBxSAddress.Location = new System.Drawing.Point(209, 142);
            this.txtBxSAddress.Name = "txtBxSAddress";
            this.txtBxSAddress.Size = new System.Drawing.Size(177, 26);
            this.txtBxSAddress.TabIndex = 1;
            // 
            // txtBxSCity
            // 
            this.txtBxSCity.Location = new System.Drawing.Point(209, 181);
            this.txtBxSCity.Name = "txtBxSCity";
            this.txtBxSCity.Size = new System.Drawing.Size(177, 26);
            this.txtBxSCity.TabIndex = 2;
            // 
            // txtBxSState
            // 
            this.txtBxSState.Location = new System.Drawing.Point(209, 220);
            this.txtBxSState.Name = "txtBxSState";
            this.txtBxSState.Size = new System.Drawing.Size(177, 26);
            this.txtBxSState.TabIndex = 3;
            // 
            // txtBxSZip
            // 
            this.txtBxSZip.Location = new System.Drawing.Point(209, 256);
            this.txtBxSZip.Name = "txtBxSZip";
            this.txtBxSZip.Size = new System.Drawing.Size(177, 26);
            this.txtBxSZip.TabIndex = 4;
            // 
            // txtBxRZip
            // 
            this.txtBxRZip.Location = new System.Drawing.Point(504, 253);
            this.txtBxRZip.Name = "txtBxRZip";
            this.txtBxRZip.Size = new System.Drawing.Size(177, 26);
            this.txtBxRZip.TabIndex = 9;
            // 
            // txtBxRState
            // 
            this.txtBxRState.Location = new System.Drawing.Point(504, 217);
            this.txtBxRState.Name = "txtBxRState";
            this.txtBxRState.Size = new System.Drawing.Size(177, 26);
            this.txtBxRState.TabIndex = 8;
            // 
            // txtBxRCity
            // 
            this.txtBxRCity.Location = new System.Drawing.Point(504, 178);
            this.txtBxRCity.Name = "txtBxRCity";
            this.txtBxRCity.Size = new System.Drawing.Size(177, 26);
            this.txtBxRCity.TabIndex = 7;
            // 
            // txtBxRAddress
            // 
            this.txtBxRAddress.Location = new System.Drawing.Point(504, 139);
            this.txtBxRAddress.Name = "txtBxRAddress";
            this.txtBxRAddress.Size = new System.Drawing.Size(177, 26);
            this.txtBxRAddress.TabIndex = 6;
            // 
            // txtBxRName
            // 
            this.txtBxRName.Location = new System.Drawing.Point(504, 100);
            this.txtBxRName.Name = "txtBxRName";
            this.txtBxRName.Size = new System.Drawing.Size(177, 26);
            this.txtBxRName.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(427, 259);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "Zip Code:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(427, 220);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "State:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(427, 181);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 20);
            this.label12.TabIndex = 21;
            this.label12.Text = "City:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(427, 142);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 20);
            this.label13.TabIndex = 20;
            this.label13.Text = "Address:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(427, 103);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 20);
            this.label14.TabIndex = 19;
            this.label14.Text = "Name:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(427, 64);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(165, 20);
            this.label15.TabIndex = 18;
            this.label15.Text = "Recipient Information:";
            // 
            // btnCreateInvoice
            // 
            this.btnCreateInvoice.Location = new System.Drawing.Point(240, 456);
            this.btnCreateInvoice.Name = "btnCreateInvoice";
            this.btnCreateInvoice.Size = new System.Drawing.Size(98, 54);
            this.btnCreateInvoice.TabIndex = 29;
            this.btnCreateInvoice.Text = "Create Invoice";
            this.btnCreateInvoice.UseVisualStyleBackColor = true;
            this.btnCreateInvoice.Click += new System.EventHandler(this.btnCreateInvoice_Click);
            // 
            // btnPrintShippingLabel
            // 
            this.btnPrintShippingLabel.Location = new System.Drawing.Point(473, 363);
            this.btnPrintShippingLabel.Name = "btnPrintShippingLabel";
            this.btnPrintShippingLabel.Size = new System.Drawing.Size(208, 34);
            this.btnPrintShippingLabel.TabIndex = 30;
            this.btnPrintShippingLabel.Text = "Print Shipping Label";
            this.btnPrintShippingLabel.UseVisualStyleBackColor = true;
            // 
            // btnAddPackage
            // 
            this.btnAddPackage.Location = new System.Drawing.Point(12, 456);
            this.btnAddPackage.Name = "btnAddPackage";
            this.btnAddPackage.Size = new System.Drawing.Size(98, 54);
            this.btnAddPackage.TabIndex = 11;
            this.btnAddPackage.Text = "Add Package";
            this.btnAddPackage.UseVisualStyleBackColor = true;
            this.btnAddPackage.Click += new System.EventHandler(this.btnAddPackage_Click);
            // 
            // btnPrintInvoice
            // 
            this.btnPrintInvoice.Location = new System.Drawing.Point(473, 326);
            this.btnPrintInvoice.Name = "btnPrintInvoice";
            this.btnPrintInvoice.Size = new System.Drawing.Size(208, 34);
            this.btnPrintInvoice.TabIndex = 32;
            this.btnPrintInvoice.Text = "Print Invoice";
            this.btnPrintInvoice.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(469, 297);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(135, 20);
            this.label16.TabIndex = 33;
            this.label16.Text = "Weight in ounces:";
            // 
            // txtBxWeight
            // 
            this.txtBxWeight.Location = new System.Drawing.Point(610, 294);
            this.txtBxWeight.Name = "txtBxWeight";
            this.txtBxWeight.Size = new System.Drawing.Size(71, 26);
            this.txtBxWeight.TabIndex = 10;
            // 
            // btnStoreInvoice
            // 
            this.btnStoreInvoice.Location = new System.Drawing.Point(473, 400);
            this.btnStoreInvoice.Name = "btnStoreInvoice";
            this.btnStoreInvoice.Size = new System.Drawing.Size(208, 34);
            this.btnStoreInvoice.TabIndex = 35;
            this.btnStoreInvoice.Text = "Store Invoice/s";
            this.btnStoreInvoice.UseVisualStyleBackColor = true;
            this.btnStoreInvoice.Click += new System.EventHandler(this.btnStoreInvoice_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(473, 474);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(208, 34);
            this.btnClearAll.TabIndex = 36;
            this.btnClearAll.Text = "Clear All Fields";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnLoadInvoice
            // 
            this.btnLoadInvoice.Location = new System.Drawing.Point(473, 437);
            this.btnLoadInvoice.Name = "btnLoadInvoice";
            this.btnLoadInvoice.Size = new System.Drawing.Size(208, 34);
            this.btnLoadInvoice.TabIndex = 37;
            this.btnLoadInvoice.Text = "Load Invoice/s";
            this.btnLoadInvoice.UseVisualStyleBackColor = true;
            this.btnLoadInvoice.Click += new System.EventHandler(this.btnLoadInvoice_Click);
            // 
            // btnDeleteInvoice
            // 
            this.btnDeleteInvoice.Location = new System.Drawing.Point(354, 456);
            this.btnDeleteInvoice.Name = "btnDeleteInvoice";
            this.btnDeleteInvoice.Size = new System.Drawing.Size(98, 54);
            this.btnDeleteInvoice.TabIndex = 38;
            this.btnDeleteInvoice.Text = "Delete Invoice";
            this.btnDeleteInvoice.UseVisualStyleBackColor = true;
            this.btnDeleteInvoice.Click += new System.EventHandler(this.btnDeleteInvoice_Click);
            // 
            // btnDeletePackage
            // 
            this.btnDeletePackage.Location = new System.Drawing.Point(126, 456);
            this.btnDeletePackage.Name = "btnDeletePackage";
            this.btnDeletePackage.Size = new System.Drawing.Size(98, 54);
            this.btnDeletePackage.TabIndex = 39;
            this.btnDeletePackage.Text = "Delete Package";
            this.btnDeletePackage.UseVisualStyleBackColor = true;
            this.btnDeletePackage.Click += new System.EventHandler(this.btnDeletePackage_Click);
            // 
            // btnUnselectInvoice
            // 
            this.btnUnselectInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnselectInvoice.Location = new System.Drawing.Point(381, 297);
            this.btnUnselectInvoice.Name = "btnUnselectInvoice";
            this.btnUnselectInvoice.Size = new System.Drawing.Size(73, 26);
            this.btnUnselectInvoice.TabIndex = 81;
            this.btnUnselectInvoice.Text = "Unselect";
            this.btnUnselectInvoice.UseVisualStyleBackColor = true;
            this.btnUnselectInvoice.Click += new System.EventHandler(this.btnUnselectInvoice_Click);
            // 
            // btnUnselectPackage
            // 
            this.btnUnselectPackage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnselectPackage.Location = new System.Drawing.Point(193, 297);
            this.btnUnselectPackage.Name = "btnUnselectPackage";
            this.btnUnselectPackage.Size = new System.Drawing.Size(73, 26);
            this.btnUnselectPackage.TabIndex = 82;
            this.btnUnselectPackage.Text = "Unselect";
            this.btnUnselectPackage.UseVisualStyleBackColor = true;
            this.btnUnselectPackage.Click += new System.EventHandler(this.btnUnselectPackage_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(490, 9);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(202, 26);
            this.lblMessage.TabIndex = 83;
            this.lblMessage.Text = "Welcome! Input shipping information and \r\nadd a package to get started!";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // prtDialog
            // 
            this.prtDialog.UseEXDialog = true;
            // 
            // prtPrDialog
            // 
            this.prtPrDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.prtPrDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.prtPrDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.prtPrDialog.Enabled = true;
            this.prtPrDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("prtPrDialog.Icon")));
            this.prtPrDialog.Name = "prtPrDialog";
            this.prtPrDialog.Visible = false;
            // 
            // FormList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(704, 521);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnUnselectPackage);
            this.Controls.Add(this.btnUnselectInvoice);
            this.Controls.Add(this.btnDeletePackage);
            this.Controls.Add(this.btnDeleteInvoice);
            this.Controls.Add(this.btnLoadInvoice);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnStoreInvoice);
            this.Controls.Add(this.txtBxWeight);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnPrintInvoice);
            this.Controls.Add(this.btnAddPackage);
            this.Controls.Add(this.btnPrintShippingLabel);
            this.Controls.Add(this.btnCreateInvoice);
            this.Controls.Add(this.txtBxRZip);
            this.Controls.Add(this.txtBxRState);
            this.Controls.Add(this.txtBxRCity);
            this.Controls.Add(this.txtBxRAddress);
            this.Controls.Add(this.txtBxRName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtBxSZip);
            this.Controls.Add(this.txtBxSState);
            this.Controls.Add(this.txtBxSCity);
            this.Controls.Add(this.txtBxSAddress);
            this.Controls.Add(this.txtBxSName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstBxInvoices);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstBxPackages);
            this.Controls.Add(this.grpBxShipMethod);
            this.Controls.Add(this.grpBxCompany);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormList";
            this.Text = "Shipping Application";
            this.Load += new System.EventHandler(this.FormList_Load);
            this.grpBxCompany.ResumeLayout(false);
            this.grpBxCompany.PerformLayout();
            this.grpBxShipMethod.ResumeLayout(false);
            this.grpBxShipMethod.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpBxCompany;
        private System.Windows.Forms.RadioButton radBtnUSPS;
        private System.Windows.Forms.RadioButton radBtnFedex;
        private System.Windows.Forms.RadioButton radBtnUPS;
        private System.Windows.Forms.GroupBox grpBxShipMethod;
        private System.Windows.Forms.RadioButton radBtnTwoDay;
        private System.Windows.Forms.RadioButton radBtnOvernight;
        private System.Windows.Forms.ListBox lstBxPackages;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstBxInvoices;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBxSName;
        private System.Windows.Forms.TextBox txtBxSAddress;
        private System.Windows.Forms.TextBox txtBxSCity;
        private System.Windows.Forms.TextBox txtBxSState;
        private System.Windows.Forms.TextBox txtBxSZip;
        private System.Windows.Forms.TextBox txtBxRZip;
        private System.Windows.Forms.TextBox txtBxRState;
        private System.Windows.Forms.TextBox txtBxRCity;
        private System.Windows.Forms.TextBox txtBxRAddress;
        private System.Windows.Forms.TextBox txtBxRName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnCreateInvoice;
        private System.Windows.Forms.Button btnPrintShippingLabel;
        private System.Windows.Forms.Button btnAddPackage;
        private System.Windows.Forms.Button btnPrintInvoice;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtBxWeight;
        private System.Windows.Forms.Button btnStoreInvoice;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnLoadInvoice;
        private System.Windows.Forms.Button btnDeleteInvoice;
        private System.Windows.Forms.Button btnDeletePackage;
        private System.Windows.Forms.Button btnUnselectInvoice;
        private System.Windows.Forms.Button btnUnselectPackage;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.PrintDialog prtDialog;
        private System.Windows.Forms.PrintPreviewDialog prtPrDialog;
    }
}

