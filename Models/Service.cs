namespace DevCard.Models
{
    public class Service
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public Service(long id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
