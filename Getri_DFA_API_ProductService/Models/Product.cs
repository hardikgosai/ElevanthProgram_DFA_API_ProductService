using System;
using System.Collections.Generic;

namespace Getri_DFA_API_ProductService.Models;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public decimal Price { get; set; }

    public int? Quantity { get; set; }
}
