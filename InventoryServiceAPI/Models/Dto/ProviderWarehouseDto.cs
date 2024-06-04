namespace InventoryServiceAPI.Models.Dto
{
    public class ProviderDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public string Phone { get; set; }
    }

    public class WarehouseDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
    }
}
