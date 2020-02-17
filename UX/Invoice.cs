using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Shipping
{
    [Serializable]
    class Invoice
    {
        #region ---- Private Class Fields ----
        private double tax;
        private double totalCost;
        private double subTotal;
        private ArrayList packages;
        private DateTime date;
        private double taxRate = 0.08;
        #endregion
        #region ---- Public Getters And Setters ----
        public double Tax { get => tax; set => tax = value; }
        public double TotalCost { get => totalCost; set => totalCost = value; }
        public ArrayList Packages { get => packages; set => packages = value; }
        public DateTime Date { get => date; set => date = value; }
        public double SubTotal { get => subTotal; set => subTotal = value; }
        public double TaxRate { get => taxRate; set => taxRate = value; }
        #endregion
        #region ---- Constructors ----
        /// <summary>
        /// Defualt No Arg Constructor
        /// </summary>
        public Invoice()
        {

        }
        /// <summary>
        /// Fully Populated Constructor
        /// </summary>
        public Invoice(ArrayList packs)
        {
            this.packages = packs;
            this.date = DateTime.Today;
            Calculate();
        }
        #endregion
        #region ---- Instance Methods ----
        public override string ToString()
        {
            return date.ToString("d") + " Cost: $" + totalCost.ToString("f2"); 
        }
        public void Calculate()
        {
            foreach (object pack in packages)
            {
                string type = pack.GetType().ToString();
                if (type == "Shipping.OvernightPackage")
                {
                    OvernightPackage pkg = (OvernightPackage)pack;
                    subTotal += Convert.ToDouble(pkg.CalcCost());
                }
                else
                {
                    TwoDayPackage pkg = (TwoDayPackage)pack;
                    subTotal += Convert.ToDouble(pkg.CalcCost());
                }
            }
            tax = subTotal * taxRate;
            totalCost = subTotal + tax;
        }
        public ArrayList ReturnPacks()
        {
            return packages;
        }
        #endregion
    }
}
