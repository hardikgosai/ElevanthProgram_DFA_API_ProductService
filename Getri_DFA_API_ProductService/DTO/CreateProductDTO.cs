namespace Getri_DFA_API_ProductService.DTO
{
    public class CreateProductDTO
    {
        public string Name { get; set; } = null!;

        public string? Description { get; set; }

        public decimal Price { get; set; }

        public int? Quantity { get; set; }
    }
}
