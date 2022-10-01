namespace NLayerCore.Modelss
{
    public class Product:BaseEntity
    {
        public string productName { get; set; } 
        public int Stock { get; set; }
        public int Price { get; set; }  
        public string Description { get; set; }
        public int UnitPrice { get; set; }   
        public int CategoryId { get; set; }
        public Category category{ get; set; }
        
    }
}