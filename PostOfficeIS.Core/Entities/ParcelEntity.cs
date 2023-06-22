namespace PostOfficeIS.Models
{
    public class ParcelEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? Height { get; set; }
        public int? Width { get; set; }
        public bool? Fragility { get; set; }

        public TransactionEntity? Transaction { get; set; }

        public ParcelEntity()
        {
        }

        public ParcelEntity(string name, int height, int width, bool fragility)
        {
            Name = name;
            Height = height;
            Width = width;
            Fragility = fragility;
        }
    }
}
