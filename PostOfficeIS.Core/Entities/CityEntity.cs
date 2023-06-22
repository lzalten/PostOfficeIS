namespace PostOfficeIS.Models
{
    public class CityEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<PostOfficeEntity> PostOffices { get; set; }
        public CityEntity() { }
        public CityEntity(string name)
        {
            Name = name;
        }
    }
}
