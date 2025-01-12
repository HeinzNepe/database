﻿namespace Orderingsystem.Models;

public class Order
{
    
    public int Id { get; set; }
    
    public User User { get; set; } = null!;
    
    public IEnumerable<OrderProduct> Products { get; set; } = null!;
    
    public Address Address { get; set; } = null!;
    
    public float TotalPrice { get; set; }
    
    public DateTime OrderTime { get; set; }
    public string Status { get; set; } = null!;
}