using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipping
{
    [Serializable]
    class Package
    {
        #region ---- Private Class Fields ----
        private string senderName;
        private string senderAddress;
        private string senderCity;
        private string senderState;
        private string senderZipCode;
        private string recipientName;
        private string recipientAddress;
        private string recipientCity;
        private string recipientState;
        private string recipientZipCode;
        private double weight;
        private double costPerOunce;
        private string company;
        #endregion
        #region ---- Public Getters And Setters ----
        public string SenderName { get => senderName; set => senderName = value; }
        public string SenderAddress { get => senderAddress; set => senderAddress = value; }
        public string SenderCity { get => senderCity; set => senderCity = value; }
        public string SenderState { get => senderState; set => senderState = value; }
        public string SenderZipCode { get => senderZipCode; set => senderZipCode = value; }
        public string RecipientName { get => recipientName; set => recipientName = value; }
        public string RecipientAddress { get => recipientAddress; set => recipientAddress = value; }
        public string RecipientCity { get => recipientCity; set => recipientCity = value; }
        public string RecipientState { get => recipientState; set => recipientState = value; }
        public string RecipientZipCode { get => recipientZipCode; set => recipientZipCode = value; }
        public double Weight { get => weight; set => weight = value; }
        public double CostPerOunce { get => costPerOunce; set => costPerOunce = value; }
        public string Company { get => company; set => company = value; }
        #endregion
        #region ---- Constructors ----
        /// <summary>
        /// Defualt No Arg Constuctor
        /// </summary>
        public Package()
        {

        }
        /// <summary>
        /// Fully Populated Constructor
        /// </summary>
        public Package(string SName, string SAddress, string SCity, string SState, string SZipCode, string RName, string RAddress, string RCity, string RState, string RZipCode, double weight, double costPerOunce, string company)
        {
            this.senderName = SName;
            this.senderAddress = SAddress;
            this.senderCity = SCity;
            this.senderState = SState;
            this.senderZipCode = SZipCode;
            this.recipientName = RName;
            this.recipientAddress = RAddress;
            this.recipientCity = RCity;
            this.recipientState = RState;
            this.recipientZipCode = RZipCode;
            this.weight = weight;
            this.costPerOunce = costPerOunce;
            this.company = company;
        }
        #endregion
    }
}
