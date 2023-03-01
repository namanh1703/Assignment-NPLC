namespace NPL.M.A011.Exercise3
{
    class Car
    {
        public decimal Speed { get; set; }              //Speed of the Car
        public double RegularPrice { get; set; }        //Regular price of the Car
        public string Color { get; set; }               //Color of the Car

        /// <summary>
        /// Sale price of the Car
        /// </summary>
        /// <returns>Regular Price</returns>
        public virtual double GetSalePrice()            
        {
            return RegularPrice;
        }
    }
}
