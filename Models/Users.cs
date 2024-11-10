

using ComputersDB.Models;

public class User()
{
    public int Id {get;set;}
    public string? Name {get;set;}

    public int OfficeId {get;set;}
    public Office? Office {get;set;}

    public int departmentId {get;set;}
    public Department? department {get;set;}

    public int ComputerId {get;set;}
    public List<Computer>? Computers {get;set;}
}