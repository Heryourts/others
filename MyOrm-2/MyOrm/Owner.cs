using System.ComponentModel.DataAnnotations;

namespace MyOrm
{
    public class Owner : IdentifierBase
    {
        public string Email { get; set; }
        public string Address { get; set; }
    }

    public class NaturalPerson : Owner
    {       
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public Gender Gender { get; set; }
    }

    public class Organization : Owner
    {
        public string LegalName { get; set; }
        public string LegalIdentifier { get; set; }
    }


    public enum Gender
    { 
        Male, 
        Female
    }


}
