namespace NLayerCore.Modelss
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }=DateTime.Now;
        public DateTime? UpdateDate { get; set; }
    }
}