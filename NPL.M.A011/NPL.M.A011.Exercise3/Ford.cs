namespace NPL.M.A011.Exercise3
{
    class Ford : Car
    {
        public int Year { get; set; }                  //Year of car manufacture
        public int ManufacturerDiscount { get; set; }  //Manufacturer discounts car

        /// <summary>
        /// Method to return Sale price of the car
        /// </summary>
        /// <returns>Price after discount from the manufacturer</returns>
        public override double GetSalePrice()
        {
            return base.GetSalePrice() - ManufacturerDiscount;
        }
    }
}
