using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipping
{
    [Serializable]
    class TwoDayPackage : Package
    {
        #region ---- Private Class Fields ----
        private double flatFee;
        #endregion
        #region ---- Public Getters And Setters ----
        public double FlatFee { get => flatFee; set => flatFee = value; }
        #endregion
        #region ---- Constructors ----
        /// <summary>
        /// Defualt No Arg Constuctor
        /// </summary>
        public TwoDayPackage()
        {

        }
        /// <summary>
        /// Fully Populated Constructor
        /// </summary>
        public TwoDayPackage(string SName, string SAddress, string SCity, string SState, string SZipCode, string RName, string RAddress, string RCity, string RState, string RZipCode, double weight, double costPerOunce, string company, double flatFee)
            : base(SName, SAddress, SCity, SState, SZipCode, RName, RAddress, RCity, RState, RZipCode, weight, costPerOunce, company)
        {
            this.flatFee = flatFee;
        }
        #endregion
        #region ---- Instance Methods ----
        public override string ToString()
        {
            return RecipientName + " " + Company + " $" + CalcCost();
        }
        public string CalcCost()
        {
            double cost = (Weight * CostPerOunce) + flatFee;
            string fCost = cost.ToString("f2");
            return fCost;
        }
        #endregion
    }
}
