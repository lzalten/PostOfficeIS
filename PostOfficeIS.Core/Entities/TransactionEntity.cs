namespace PostOfficeIS.Models
{
    public class TransactionEntity
    {
        public int Id { get; set; }

        public int SenderId { get; set; }
        public ClientEntity Sender { get; set; }
        public int GeterId { get; set; }
        public ClientEntity Geter { get; set; }

        public int ParcelId { get; set; }
        public ParcelEntity Parcel { get; set; }

        public int? PostManId { get; set; }
        public WorkerProfileEntity PostMan { get; set; }

        public int? SenderCityId {  get; set; }
        public CityEntity SenderCity { get; set; }

        public string? SendTime { get; set; }
        public string? CheckTime { get; set; }

    }
}
