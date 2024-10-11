using System.Text;

public class Order {
    private List<Product> _product;
    private Customer _customer;
    private double _shippingCost;

    public Order(List<Product> products, Customer customer)
    {
        _product = products;
        _customer = customer;
        _shippingCost = CalculateShippingCost();
    }

    private double CalculateShippingCost()
    {
        if (_customer.LivesInUsa())
        {
            return 5.00;
        }
        else 
        {
            return 35.00;
        }
    }

    public double CalculateTotal()
    {
        double total = 0;
        foreach (var product in _product)
        {
            total += product.GetCost();
        }
        return total + _shippingCost;
    }

    public string GetPackingLabel()
    {
        StringBuilder packingLabel = new StringBuilder();
        packingLabel.AppendLine("Packing Label");
        packingLabel.AppendLine("--------------------");
        foreach (var product in _product)
        {
            packingLabel.AppendLine($"{product.GetProductId()} - {product.GetName()}");
        }
        return packingLabel.ToString();
    }

    public string GetShippingLabel()
    {
        StringBuilder shippingLabel = new StringBuilder();
        shippingLabel.AppendLine("Shipping Label");
        shippingLabel.AppendLine("--------------------");
        shippingLabel.AppendLine(_customer.GetName());
        shippingLabel.AppendLine(_customer.GetAddress().ToString());
        return shippingLabel.ToString();
    }

}