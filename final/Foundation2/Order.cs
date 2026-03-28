public class Order
{
    // Class Attributes
    private Customer _customer;
    private Product _product;

    // String Attributes
    private string _address;
    private string _packingName;
    private string _packingID;
    private string _packingItem;
    private string _packingLabel;
    private string _shippingLabel;

    // Bool Attribute
    private bool _inUSA;

    // Double Attributes
    private double _productCost;
    private double _totalCost;
    private double _shippingCost;
    private double _totalShippingCost;

    // List/Dictionary Attributes
    private List<Product> _productList;
    private List<string> _packingList = new List<string>();
    private Dictionary<string, List<Product>> _orderList = new Dictionary<string, List<Product>>();

    // Constructor
    public Order()
    {
        
    }

    // Print the Total cost of all the products in the order, plush shipping.
    // This method calls the two private methods CalculateTotalCost() and CalculateShippingCost().
    public void PrintTotalCost(string customer)
    {
        // Call the private method to calculate the total cost
        CalculateTotalCost(customer);
        CalculateShippingCost();
        Console.WriteLine($"Total cost of products: ${_totalCost}");
        Console.WriteLine($"Total shipping cost: ${_shippingCost}");
        Console.WriteLine($"Total cost with shipping: ${_totalShippingCost}");
        Console.WriteLine("");
    }

    // Helper method for PrintTotalCost() public method.
    private void CalculateTotalCost(string customer)
    {
        // Get the product list for the specified customer.
        _productList = _orderList[customer];

        // Get the product cost for each product in the product list.
        foreach(Product product in _productList)
        {
            // Add up the total cost of each product
            _productCost = product.GetTotalCost();
            _totalCost = _totalCost + _productCost;
        }

        // // Return the total cost of all the products in the list.
        // return _totalCost;
    }

    // Helper method for PrintTotalCost() public method.
    // References the GetCustomerUsa() method in the Customer class, which itself references a method in the Address class.
    private void CalculateShippingCost()
    {
        _inUSA = _customer.GetCustomerUsa();

        if (_inUSA == true)
        {
            _shippingCost = 5;
        }
        else
        {
            _shippingCost = 35;
        }

        _totalShippingCost = _totalCost + _shippingCost;
    }

    // This method Displays the Packing Label and Shipping Label for the order.
    // It calls the two private methods GetPackingLabel() and GetShippingLabel()
    public void printLabels(string customer)
    {
        // Call private helper methods
        GetPackingLabel(customer);
        GetShippingLabel(customer);

        // Print labels
        Console.Write($"Packing Label for {customer}:");
        Console.WriteLine($"{_packingLabel}");
        Console.WriteLine("");
        Console.WriteLine($"Shipping Label for {customer}:");
        Console.WriteLine($"{_shippingLabel}");
        Console.WriteLine("");
    }

    // Helper function for public printLabels() method.
    private void GetPackingLabel(string customer)
    {
        // Get the product list for the specified customer.
        _productList = _orderList[customer];

        foreach(Product product in _productList)
        {
            _packingName = product.GetProductName();
            _packingID = product.GetProductID();

            // Merge the name and ID into a single string, and append it to a packing list.
            _packingItem = $" {_packingName}--{_packingID}";
            _packingList.Add(_packingItem);
        }

        // Grab each item in the packing list, and concatenate it into a long string.
        foreach(string item in _packingList)
        {
            if (_packingLabel == "")
            {
                _packingLabel = item;
            }
            else
            {
                _packingLabel = _packingLabel + "\n" + item;
            }
        }
    }

    // Helper function for public printLabels() method.
    private void GetShippingLabel(string customer)
    {
        // Get the address for the specified customer
        _address = _customer.GetCustomerAddress();
        // Combine the customer name and address into a shipping label.
        _shippingLabel = $" {customer} \n {_address}";
    }

    // Create a customer object, and a new product list, within the class.
    public void CreateCustomer(string customerName, string streetAddress, string city, string stateProvince, string zipCode, string country)
    {
        // Create a new customer object.
        _customer = new Customer();
        // Populate the object.
        _customer.SetCustomerName(customerName);
        _customer.SetCustomerAddress(streetAddress, city, stateProvince, zipCode, country);

        // Create a new proudct list for the customer.
        _productList = new List<Product>();
    }

    // Create a product object, and add it to the product list, within the class.
    public void CreateProduct(string productName, string productID, double productPrice, int productQuantity)
    {
        // Create a new product object.
        _product = new Product();
        // Populate the object.
        _product.SetProductName(productName);
        _product.SetProductID(productID);
        _product.SetUnitPrice(productPrice, productQuantity);

        // Add the newly created product to the product list.
        _productList.Add(_product);
    }

    // Add the customer name and product list to the order dictionary.
    public void CreateOrder(string customerName)
    {
        _orderList.Add(customerName, _productList);
    }

}