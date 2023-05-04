namespace ProjectAPI.Controllers.Models
{
    public class PersonModel
    {
        public PersonModel (int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }    
    }
}
