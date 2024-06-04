namespace InventoryServiceAPI.Models.Dto
{
    public class ProductDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public string SKU { get; set; }
        public string Category { get; set; }
        public string Provider { get; set; }
        public string Warehouse { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }
}
