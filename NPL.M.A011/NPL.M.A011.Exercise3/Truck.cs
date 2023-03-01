namespace NPL.M.A011.Exercise3
{
    class Truck : Car
    {
        public int Weight { get; set; }             //Weight of Car

        /// <summary>
        /// Method to return Sale price of the car
        /// </summary>
        /// <returns>Price after discount from the manufacturer</returns>
        public override double GetSalePrice()       
        {
            //Consider weight value to reduce price
            if (Weight > 2000)
                return RegularPrice * 0.9;          //discount 10%
            else
                return RegularPrice * 0.8;          //discount 20%
        }
    }
}
