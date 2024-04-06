using System;
using System.Collections.Generic;

namespace MarketManagement.Models;

public partial class Order
{
    public Guid Id { get; set; }

    public Guid CustomerId { get; set; }

    public decimal TotalAmount { get; set; }

    public int? Status { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsActive { get; set; }
}
