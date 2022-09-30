namespace mustafakucukkoc.Restore1.NLayerCore
{
    public class OrderDetail:BaseEntity
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int OrderNumber { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public int Total { get; set; }
    }
}