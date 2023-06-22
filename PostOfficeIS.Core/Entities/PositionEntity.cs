namespace PostOfficeIS.Models
{
    public class PositionEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<WorkerProfileEntity> WorkerProfiles { get; set; }
    }
}
