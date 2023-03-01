namespace DepartmentManage
{
    /// <summary>
    /// Class that implements the IPayable interface and represents an invoice with properties such as PartNumber,
    /// PartDescription, Quantity, and PricePeritem.
    /// </summary>
    class Invoice : IPayable
    {
        // Properties for storing the values of PartNumber, PartDescription, Quantity, and PricePeritem
        public string PartNumber { get; set; }
        public string PartDescription { get; set; }
        public int Quantity { get; set; }
        public double PricePeritem { get; set; }

        // Constructor to initialize the properties
        public Invoice(string partNumber, string partDescription, int quantity, double pricePeritem)
        {
            PartNumber = partNumber;
            PartDescription = partDescription;
            Quantity = quantity;
            PricePeritem = pricePeritem;
        }

        // Implementation of the GetPaymentAmount method from IPayable interface
        public double GetPaymentAmount()
        {
            return 1.5;
        }
    }

}
