using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Shipping
{
    public partial class FormList : Form
    {
        // Declare an arraylist to hold packages
        ArrayList packages = new ArrayList();
        ArrayList invoices = new ArrayList();
        OvernightPackage ovPack = new OvernightPackage();
        TwoDayPackage twPack = new TwoDayPackage();
        Invoice inv = new Invoice();
        ServiceReference1.PayableClient client = new ServiceReference1.PayableClient();

        public FormList()
        {
            InitializeComponent();
        }

        private void FormList_Load(object sender, EventArgs e)
        {
            btnDeleteInvoice.Enabled = false;
            btnDeletePackage.Enabled = false;
            btnUnselectInvoice.Enabled = false;
            btnUnselectPackage.Enabled = false;
            btnPrintInvoice.Enabled = false;
            btnPrintShippingLabel.Enabled = false;
            btnStoreInvoice.Enabled = false;
            btnCreateInvoice.Enabled = false;
            // Load the invoices from db onload
            invoices = DataAdapter.Get();
            foreach (Invoice inv in invoices)
            {
                lstBxInvoices.Items.Add(inv);
            }
        }

        private void btnAddPackage_Click(object sender, EventArgs e)
        {
            string company;
            if (radBtnFedex.Checked == true)
            {
                company = "Fedex";
            }
            else if (radBtnUPS.Checked == true)
            {
                company = "UPS";
            }
            else
            {
                company = "USPS";
            }
            if (radBtnOvernight.Checked == true)
            {
                ovPack = new OvernightPackage(txtBxSName.Text, txtBxSAddress.Text, txtBxSCity.Text, txtBxSState.Text, txtBxSZip.Text, txtBxRName.Text, txtBxRAddress.Text, txtBxRCity.Text, txtBxRState.Text, txtBxRZip.Text, Convert.ToDouble(txtBxWeight.Text), client.GetCost(company), company, client.GetOvernight());
                packages.Add(ovPack);
                lstBxPackages.Items.Clear();
                foreach (object pack in packages)
                {
                    lstBxPackages.Items.Add(pack);
                }
                ClearFields();
                btnCreateInvoice.Enabled = true;
            }
            else if (radBtnTwoDay.Checked == true)
            {
                twPack = new TwoDayPackage(txtBxSName.Text, txtBxSAddress.Text, txtBxSCity.Text, txtBxSState.Text, txtBxSZip.Text, txtBxRName.Text, txtBxRAddress.Text, txtBxRCity.Text, txtBxRState.Text, txtBxRZip.Text, Convert.ToDouble(txtBxWeight.Text), client.GetCost(company), company, client.GetFlatFee());
                packages.Add(twPack);
                lstBxPackages.Items.Clear();
                foreach (object pack in packages)
                {
                    lstBxPackages.Items.Add(pack);
                }
                ClearFields();
                btnCreateInvoice.Enabled = true;
            }
            else
            {
                lblMessage.Text = "Please select shipping method!";
            }
        }


        public void ClearFields()
        {
            txtBxSName.Text = "";
            txtBxSAddress.Text = "";
            txtBxSCity.Text = "";
            txtBxSState.Text = "";
            txtBxSZip.Text = "";
            txtBxRName.Text = "";
            txtBxRAddress.Text = "";
            txtBxRCity.Text = "";
            txtBxRState.Text = "";
            txtBxRZip.Text = "";
            txtBxWeight.Text = "";
            radBtnFedex.Checked = false;
            radBtnUPS.Checked = false;
            radBtnUSPS.Checked = false;
            radBtnOvernight.Checked = false;
            radBtnTwoDay.Checked = false;
            
        }

        public void EnableDisable(bool val)
        {
            txtBxSName.Enabled = val;
            txtBxSAddress.Enabled = val;
            txtBxSCity.Enabled = val;
            txtBxSState.Enabled = val;
            txtBxSZip.Enabled = val;
            txtBxRName.Enabled = val;
            txtBxRAddress.Enabled = val;
            txtBxRCity.Enabled = val;
            txtBxRState.Enabled = val;
            txtBxRZip.Enabled = val;
            txtBxWeight.Enabled = val;
            radBtnFedex.Enabled = val;
            radBtnUPS.Enabled = val;
            radBtnUSPS.Enabled = val;
            radBtnOvernight.Enabled = val;
            radBtnTwoDay.Enabled = val;
        }

        private void lstBxPackages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstBxPackages.SelectedIndex == -1)
            {

            }
            else
            {
            ClearFields();
            EnableDisable(false);
            if(lstBxInvoices.SelectedIndex == -1)
            {
                btnDeletePackage.Enabled = true;
            }
            btnUnselectPackage.Enabled = true;
            btnPrintShippingLabel.Enabled = true;
            int index = lstBxPackages.SelectedIndex;
            string type = packages[index].GetType().ToString();
                if (type == "Shipping.OvernightPackage")
                {
                    OvernightPackage obj = (OvernightPackage)packages[index];
                    txtBxSName.Text = obj.SenderName;
                    txtBxSAddress.Text = obj.SenderAddress;
                    txtBxSCity.Text = obj.SenderCity;
                    txtBxSState.Text = obj.SenderState;
                    txtBxSZip.Text = obj.SenderZipCode;
                    txtBxRName.Text = obj.RecipientName;
                    txtBxRAddress.Text = obj.RecipientAddress;
                    txtBxRCity.Text = obj.RecipientCity;
                    txtBxRState.Text = obj.RecipientState;
                    txtBxRZip.Text = obj.RecipientZipCode;
                    txtBxWeight.Text = obj.Weight.ToString();
                    radBtnOvernight.Checked = true;
                    if (obj.Company == "USPS")
                    {
                        radBtnUSPS.Checked = true;
                    }
                    else if (obj.Company == "UPS")
                    {
                        radBtnUPS.Checked = true;
                    }
                    else
                    {
                        radBtnFedex.Checked = true;
                    }
                }
                else
                {
                    TwoDayPackage obj = (TwoDayPackage)packages[index];
                    txtBxSName.Text = obj.SenderName;
                    txtBxSAddress.Text = obj.SenderAddress;
                    txtBxSCity.Text = obj.SenderCity;
                    txtBxSState.Text = obj.SenderState;
                    txtBxSZip.Text = obj.SenderZipCode;
                    txtBxRName.Text = obj.RecipientName;
                    txtBxRAddress.Text = obj.RecipientAddress;
                    txtBxRCity.Text = obj.RecipientCity;
                    txtBxRState.Text = obj.RecipientState;
                    txtBxRZip.Text = obj.RecipientZipCode;
                    txtBxWeight.Text = obj.Weight.ToString();
                    radBtnTwoDay.Checked = true;
                    if (obj.Company == "USPS")
                    {
                        radBtnUSPS.Checked = true;
                    }
                    else if (obj.Company == "UPS")
                    {
                        radBtnUPS.Checked = true;
                    }
                    else
                    {
                        radBtnFedex.Checked = true;
                    }
                }
            }
        }

        private void btnUnselectPackage_Click(object sender, EventArgs e)
        {
            ClearFields();
            if (lstBxInvoices.SelectedIndex > -1)
            {
                EnableDisable(true);
            }
            btnUnselectPackage.Enabled = false;
            btnDeletePackage.Enabled = false;
            btnPrintShippingLabel.Enabled = false;
            lstBxPackages.SelectedIndex = -1;
        }

        private void btnDeletePackage_Click(object sender, EventArgs e)
        {
            ClearFields();
            EnableDisable(true);
            int index = lstBxPackages.SelectedIndex;
            packages.RemoveAt(index);
            lstBxPackages.Items.Clear();
            foreach (object pack in packages)
            {
                lstBxPackages.Items.Add(pack);
            }
            btnPrintShippingLabel.Enabled = false;
            btnUnselectPackage.Enabled = false;
            btnDeletePackage.Enabled = false;
            try
            {
                packages[0].GetType();
            }
            catch
            {
                btnCreateInvoice.Enabled = false;
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnCreateInvoice_Click(object sender, EventArgs e)
        {
            inv = new Invoice(packages);
            invoices.Add(inv);
            lstBxInvoices.Items.Clear();
            foreach(object inv in invoices)
            {
                lstBxInvoices.Items.Add(inv);
            }
            packages = new ArrayList();
            lstBxPackages.Items.Clear();
            ClearFields();
            EnableDisable(true);
            btnStoreInvoice.Enabled = true;
            btnDeletePackage.Enabled = false;
            btnUnselectPackage.Enabled = false;
            btnCreateInvoice.Enabled = false;
            btnPrintShippingLabel.Enabled = false;
        }

        private void lstBxInvoices_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBxInvoices.SelectedIndex == -1)
            {

            }
            else
            {
                ClearFields();
                EnableDisable(false);
                lstBxPackages.Items.Clear();
                int index = lstBxInvoices.SelectedIndex;
                Invoice obj = (Invoice)invoices[index];
                packages = obj.Packages;
                foreach(object pack in packages)
                {
                    lstBxPackages.Items.Add(pack);
                }
                btnDeletePackage.Enabled = false;
                btnAddPackage.Enabled = false;
                btnUnselectPackage.Enabled = true;
                btnDeleteInvoice.Enabled = true;
                btnUnselectInvoice.Enabled = true;
                btnPrintInvoice.Enabled = true;
                btnStoreInvoice.Enabled = true;
            }
        }

        private void btnUnselectInvoice_Click(object sender, EventArgs e)
        {
            ClearFields();
            EnableDisable(true);
            lstBxPackages.Items.Clear();
            packages = new ArrayList();
            lstBxInvoices.SelectedIndex = -1;
            btnDeleteInvoice.Enabled = false;
            btnPrintInvoice.Enabled = false;
            btnAddPackage.Enabled = true;
            btnPrintShippingLabel.Enabled = false;
        }

        private void btnDeleteInvoice_Click(object sender, EventArgs e)
        {
            ClearFields();
            EnableDisable(true);
            lstBxPackages.Items.Clear();
            int index = lstBxInvoices.SelectedIndex;
            invoices.RemoveAt(index);
            lstBxInvoices.Items.Clear();
            foreach(object inv in invoices)
            {
                lstBxInvoices.Items.Add(inv);
            }
            btnPrintInvoice.Enabled = false;
            btnUnselectInvoice.Enabled = false;
            btnDeleteInvoice.Enabled = false;
            btnAddPackage.Enabled = true;
            packages = new ArrayList();
        }

        private void btnStoreInvoice_Click(object sender, EventArgs e)
        {
            DataAdapter.ClearDB();
            foreach(Invoice inv in invoices)
            {
                Serializer.SerializeNow(inv);
            }
            lstBxInvoices.Items.Clear();
            btnStoreInvoice.Enabled = false;
            btnPrintInvoice.Enabled = false;
            btnDeleteInvoice.Enabled = false;
            btnUnselectInvoice.Enabled = false;
            //invoices = new ArrayList();
        }

        private void btnLoadInvoice_Click(object sender, EventArgs e)
        {
            lstBxInvoices.Items.Clear();
            invoices = DataAdapter.Get();
            foreach(Invoice inv in invoices)
            {
                lstBxInvoices.Items.Add(inv);
            }
        }
    }
}
