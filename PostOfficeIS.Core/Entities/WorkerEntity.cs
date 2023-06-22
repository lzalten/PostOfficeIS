namespace PostOfficeIS.Models
{
    public class WorkerEntity
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public WorkerProfileEntity? WorkerProfile { get; set; }
    }
}
