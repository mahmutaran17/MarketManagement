using System;
using System.Collections.Generic;

namespace MarketManagement.Models;

public partial class Product
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public int Stock { get; set; }

    public decimal Price { get; set; }

    public Guid CategoryId { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsActive { get; set; }
}
