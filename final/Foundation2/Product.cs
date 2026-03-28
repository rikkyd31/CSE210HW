public class Product
{
    // String Attributes
    private string _productName;
    private string _productID;

    // Double Attributes
    private double _unitPrice;
    private double _totalPrice;

    // Int Attribute
    private int _unitQuantity;

    // Constructor
    public Product()
    {
        
    }

    // Getters
    // Calculate the total cost of the product
    public double GetTotalCost()
    {
        _totalPrice = (_unitPrice * _unitQuantity);

        return _totalPrice;
    }

    public string GetProductName()
    {
        return _productName;
    }

    public string GetProductID()
    {
        return _productID;
    }

    // Setters
    public void SetProductName(string productName)
    {
        _productName = productName;
    }

    public void SetProductID(string productID)
    {
        _productID = productID;
    }

    public void SetUnitPrice(double unitPrice, int unitQuantity)
    {
        _unitPrice = unitPrice;
        _unitQuantity = unitQuantity;
    }
}