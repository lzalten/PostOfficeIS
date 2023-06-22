namespace PostOfficeIS.Models
{
    public abstract class PersonEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string BirthDate { get; set; }
        public string Gender { get; set; }


        public PersonEntity()
        {
        }
        public PersonEntity(string name, string surname, string birthDate, string gender)
        {
            Name = name;
            Surname = surname;
            BirthDate = birthDate;
            Gender = gender;
        }


    }
}
