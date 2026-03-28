using System;

class Program
{
    static void Main(string[] args)
    {
        // Customers
        // Customer One Variables
        string customerOne = "Frank Knarf";
        string streetAddressOne = "1234 Sunnyside Drive";
        string cityOne = "Rexburg";
        string stateProvinceOne = "Idaho";
        string zipCodeOne = "83440";
        string countryOne = "United States";

        // Customer Two Variables
        string customerTwo = "Mikayla Alyakim";
        string streetAddressTwo = "1234 New Line Drive";
        string cityTwo = "Paris";
        string stateProvinceTwo = "Île-de-France";
        string zipCodeTwo = "70123";
        string countryTwo = "France";

        // Customer Three Variables
        string customerThree = "Harold Dlorah";
        string streetAddressThree = "671 East Main Street";
        string cityThree = "Chicago";
        string stateProvinceThree = "Illinois";
        string zipCodeThree = "60601";
        string countryThree = "United States";

        //Products
        //Product One Variables
        string productOne = "Leather Chair";
        string productOneID = "LC00001";
        double productOnePrice = 37.50;
        int productOneQuantity = 4;

        //Product Two Variables
        string productTwo = "Soft Couch";
        string productTwoID = "SC00001";
        double productTwoPrice = 100.00;
        int productTwoQuantity = 6;

        //Product Three Variables
        string productThree = "Wood Rocking Chair";
        string productThreeID = "WRC00001";
        double productThreePrice = 80.50;
        int productThreeQuantity = 3;

        //Product Four Variables
        string productFour = "Flat Screen Television";
        string productFourID = "FSTV00001";
        double productFourPrice = 800.50;
        int productFourQuantity = 1;

        //Product Five Variables
        string productFive = "Hardwood Dresser";
        string productFiveID = "HWD00001";
        double productFivePrice = 200.00;
        int productFiveQuantity = 9;

        //Product Six Variables
        string productSix = "Softwood Dresser";
        string productSixID = "SWD00001";
        double productSixPrice = 215.90;
        int productSixQuantity = 3;

        //Product Seven Variables
        string productSeven = "Oak Chair";
        string productSevenID = "OC00001";
        double productSevenPrice = 45.00;
        int productSevenQuantity = 4;

        //Product Eight Variables
        string productEight = "Metal Coat Rack";
        string productEightID = "MCR00001";
        double productEightPrice = 70.00;
        int productEightQuantity = 2;

        // Order 1 ------------------------
        // Create Order 1
        Order orderOne = new Order();
        orderOne.CreateCustomer(customerOne, streetAddressOne, cityOne, stateProvinceOne, zipCodeOne, countryOne);
        orderOne.CreateProduct(productOne, productOneID, productOnePrice, productOneQuantity);
        orderOne.CreateProduct(productTwo, productTwoID, productTwoPrice, productTwoQuantity);
        orderOne.CreateProduct(productThree, productThreeID, productThreePrice, productThreeQuantity);
        orderOne.CreateOrder(customerOne);

        // Display Order 1
        Console.WriteLine(" ------------ Order One ------------ ");
        orderOne.PrintTotalCost(customerOne);
        orderOne.printLabels(customerOne);  
        Console.WriteLine(""); 

        // Order 2 ------------------------
        // Create Order 2
        Order orderTwo = new Order();
        orderTwo.CreateCustomer(customerTwo, streetAddressTwo, cityTwo, stateProvinceTwo, zipCodeTwo, countryTwo);
        orderTwo.CreateProduct(productTwo, productTwoID, productTwoPrice, productTwoQuantity);
        orderTwo.CreateProduct(productFour, productFourID, productFourPrice, productFourQuantity);
        orderTwo.CreateProduct(productFive, productFiveID, productFivePrice, productFiveQuantity);
        orderTwo.CreateOrder(customerTwo);

        // Display Order 2
        Console.WriteLine(" ------------ Order Two ------------ ");
        orderTwo.PrintTotalCost(customerTwo);
        orderTwo.printLabels(customerTwo);
        Console.WriteLine("");

        // Order 3 ------------------------
        // Create Order 3
        Order orderThree = new Order();
        orderThree.CreateCustomer(customerThree, streetAddressThree, cityThree, stateProvinceThree, zipCodeThree, countryThree);
        orderThree.CreateProduct(productSix, productSixID, productSixPrice, productSixQuantity);
        orderThree.CreateProduct(productSeven, productSevenID, productSevenPrice, productSevenQuantity);
        orderThree.CreateProduct(productEight, productEightID, productEightPrice, productEightQuantity);
        orderThree.CreateOrder(customerThree);

        // Display Order 3
        Console.WriteLine(" ------------ Order Three ------------ ");
        orderThree.PrintTotalCost(customerThree);
        orderThree.printLabels(customerThree);
        Console.WriteLine("");
    }
}