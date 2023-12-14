using System;
using System.Collections.Generic;

internal class Program2
{
    static void Main()
    {
        // Crear productos
        var product1 = new Product("Product 1", "P1", 10, 3);
        var product2 = new Product("Product 2", "P2", 20, 2);
        var product3 = new Product("Product 3", "P3", 15, 4);

        // Crear clientes y direcciones
        var addressUSA = new Address("123 Main St", "City", "State", "USA");
        var addressNonUSA = new Address("456 First St", "Town", "Province", "Canada");

        var customer1 = new Customer("John Doe", addressUSA);
        var customer2 = new Customer("Jane Smith", addressNonUSA);

        // Crear órdenes
        var order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        var order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        // Mostrar información de las órdenes
        DisplayOrderInfo(order1);
        DisplayOrderInfo(order2);
    }

    static void DisplayOrderInfo(Order order)
    {
        Console.WriteLine($"Packing Label:\n{order.GetPackingLabel()}");
        Console.WriteLine($"Shipping Label:\n{order.GetShippingLabel()}");
        Console.WriteLine($"Total Price: ${order.CalculateTotalPrice()}\n");
    }
}

class Order
{
    private readonly List<Product> products;
    private readonly Customer customer;

    public Order(Customer customer)
    {
        this.customer = customer;
        products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public string GetPackingLabel()
    {
        var packingLabel = "Packing Label:\n";
        foreach (var product in products)
        {
            packingLabel += $"{product.Name} - {product.ProductId}\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{customer.Name}\n{customer.Address.GetFullAddress()}";
    }

    public double CalculateTotalPrice()
    {
        double totalPrice = 0;
        foreach (var product in products)
        {
            totalPrice += product.TotalCost();
        }
        totalPrice += customer.Address.IsInUSA() ? 5 : 35; // Shipping cost
        return totalPrice;
    }
}

class Product
{
    public string Name { get; }
    public string ProductId { get; }
    private readonly double Price;
    private readonly int Quantity;

    public Product(string name, string productId, double price, int quantity)
    {
        Name = name;
        ProductId = productId;
        Price = price;
        Quantity = quantity;
    }

    public double TotalCost()
    {
        return Price * Quantity;
    }
}

class Customer
{
    public string Name { get; }
    public Address Address { get; }

    public Customer(string name, Address address)
    {
        Name = name;
        Address = address;
    }
}

class Address
{
    private readonly string Street;
    private readonly string City;
    private readonly string State;
    private readonly string Country;

    public Address(string street, string city, string state, string country)
    {
        Street = street;
        City = city;
        State = state;
        Country = country;
    }

    public string GetFullAddress()
    {
        return $"{Street}, {City}, {State}, {Country}";
    }

    public bool IsInUSA()
    {
        return Country == "USA";
    }
}
