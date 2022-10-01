namespace mustafakucukkoc.Restore1.NLayerCore
{
    public class Orders:BaseEntity
    {
        public int CategoryId { get; set; }
        public int OrderNumber { get; set; }
        public int PaymentId { get; set; }
        public int ShipperId { get; set; }
        
    }
}