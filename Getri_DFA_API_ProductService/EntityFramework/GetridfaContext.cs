using System;
using System.Collections.Generic;
using Getri_DFA_API_ProductService.Models;
using Microsoft.EntityFrameworkCore;

namespace Getri_DFA_API_ProductService.EntityFramework;

public partial class GetridfaContext : DbContext
{
    public GetridfaContext()
    {
    }

    public GetridfaContext(DbContextOptions<GetridfaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Product> Products { get; set; }    
}
