
namespace ComputersDB.Models
{
    public class Department()
    {
        public int Id {get;set;}
        public string? Name {get;set;}

        public int OfficeId {get; set;}
        public List<Office>? offices {get;set;}

        public int UserId;
        public List<User>? Users {get;set;}
    }
}