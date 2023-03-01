namespace NPL.M.A011.Exercise3
{
    class MyOwnAutoShop
    {
        static void Main(string[] args)
        {
            //Try cases
            Truck truck1 = new Truck
            {
                Speed = 90,
                RegularPrice = 30000,
                Color = "Green",
                Weight = 2300
            };

            Truck truck2 = new Truck
            {
                Speed = 150,
                RegularPrice = 30000,
                Color = "Black",
                Weight = 1900
            };
            Ford ford1 = new Ford
            {
                Speed = 200,
                RegularPrice = 35000,
                Color = "Blue",
                Year = 2022,
                ManufacturerDiscount = 1500
            };

            Ford ford2 = new Ford
            {
                Speed = 170,
                RegularPrice = 28000,
                Color = "White",
                Year = 2023,
                ManufacturerDiscount = 1000
            };
            Sedan sedan1 = new Sedan
            {
                Speed = 100,
                RegularPrice = 47000,
                Color = "Red",
                Length = 17
            };
            Sedan sedan2 = new Sedan
            {
                Speed = 130,
                RegularPrice = 47000,
                Color = "Pink",
                Length = 25
            };

            //Print out the results after the discount
            Console.WriteLine("Truck 1 Sale Price: " + truck1.GetSalePrice());
            Console.WriteLine("Truck 2 Sale Price: " + truck2.GetSalePrice());
            
            Console.WriteLine("Ford 1 Sale Price: " + ford1.GetSalePrice());
            Console.WriteLine("Ford 2 Sale Price: " + ford2.GetSalePrice());

            Console.WriteLine("Sedan1 Sale Price: " + sedan1.GetSalePrice());
            Console.WriteLine("Sedan2 Sale Price: " + sedan2.GetSalePrice());

        }
    }
}
