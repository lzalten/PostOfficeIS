namespace PostOfficeIS.Models
{
    public class WorkerProfileEntity : PersonEntity
    {
        public int Id { get; set; }
        public int Phone { get; set; }
        public int WorkerId { get; set; }
        public WorkerEntity Worker { get; set; }
        public int PostOfficeId { get; set; }
        public PostOfficeEntity PostOffice { get; set; }
        public PositionEntity Position { get; set; }

        public WorkerProfileEntity() : base() { }
        public WorkerProfileEntity(int phone, string name, string surname, string birthDate, string gender) : base(name, surname, birthDate, gender)
        {
            Phone = phone;
        }


    }
}
