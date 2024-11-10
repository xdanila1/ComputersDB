
namespace ComputersDB.Models
{
    public class Computer()
    {
        public int Id {get;set;}
        public string? NameModel {get;set;}
        public bool Workability {get;set;}
        public bool Services {get;set;}
        public string? SerialNumber {get;set;}
        public string? InventoryNumber {get;set;}
        
        public int UserId {get;set;}
        public User? User {get;set;}
    }
}