using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipping
{
    [Serializable]
    class OvernightPackage : Package
    {
        #region ---- Private Class Fields ----
        private double additionalFeePerOunce;
        #endregion
        #region ---- Public Getters And Setters ----
        public double AdditionalFeePerOunce { get => additionalFeePerOunce; set => additionalFeePerOunce = value; }
        #endregion
        #region ---- Constructors ----
        /// <summary>
        /// Defualt No Arg Constuctor
        /// </summary>
        public OvernightPackage()
        {

        }
        /// <summary>
        /// Fully Populated Constructor
        /// </summary>
        public OvernightPackage(string SName, string SAddress, string SCity, string SState, string SZipCode, string RName, string RAddress, string RCity, string RState, string RZipCode, double weight, double costPerOunce, string company, double additionalFeePerOunce)
             : base(SName, SAddress, SCity, SState, SZipCode, RName, RAddress, RCity, RState, RZipCode, weight, costPerOunce, company)
        {
            this.AdditionalFeePerOunce = additionalFeePerOunce;
        }
        #endregion
        #region ---- Instance Methods ----
        public override string ToString()
        {
            return RecipientName + " " + Company + " $" + CalcCost();
        }
        public string CalcCost()
        {
            double cost = (CostPerOunce + additionalFeePerOunce) * Weight;
            string fCost = cost.ToString("f2");
            return fCost;
        }
        #endregion
    }
}
