namespace PostOfficeIS.Models
{
    public class PostOfficeEntity
    {
        public int Id { get; set; }
        public string Adress { get; set; }
        public int CityId { get; set; }
        public CityEntity City { get; set; }

        public List<WorkerProfileEntity> Workers { get; set; }

        public PostOfficeEntity() { }
        public PostOfficeEntity(string adress)
        {
            Adress = adress;
        }
    }
}
