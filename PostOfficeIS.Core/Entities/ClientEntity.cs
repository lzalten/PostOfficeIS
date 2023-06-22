namespace PostOfficeIS.Models
{
    public class ClientEntity : PersonEntity
    {
        public int Id { get; set; }
        private int Ballance { get; set; }
        public int Phone { get; set; }

        public ClientEntity() : base()
        {

        }
        public ClientEntity(int ballance, int phone, string name, string surname, string gender, string birthdate) : base(name, surname, birthdate, gender)
        {
            Ballance = ballance;
            Phone = phone;
        }

    }
}
