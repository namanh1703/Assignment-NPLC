namespace NPL.M.A011.Exercise3
{
    class Sedan : Car
    {
        public int Length { get; set; }         //Length of the Car

        /// <summary>
        /// Method to return Sale price of the car
        /// </summary>
        /// <returns>Price after discount from the manufacturer</returns>
        public override double GetSalePrice()
        {
            //Consider the length value of the car to reduce the price
            if (Length > 20)
                return RegularPrice * 0.95;     //discount 5%
            else
                return RegularPrice * 0.9;      //discount 10%
        }
    }
}
