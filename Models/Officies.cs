
namespace ComputersDB.Models
{
    public class Office()
    {
        public int Id {get;set;}
        public decimal NumberRoom {get;set;}

        public int DepartmentId;
        public Department? department {get;set;}

        public int UserId;
        public List<User>? Users {get;set;}

        public int ComputerId;
        public List<Computer>? Computers {get;set;}
    }
}