using System;
using System.Collections.Generic;

namespace MarketManagement.Models;

public partial class Discount
{
    public Guid Id { get; set; }

    public Guid ProductId { get; set; }

    public int DiscountType { get; set; }

    public decimal DiscountValue { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsActive { get; set; }
}
