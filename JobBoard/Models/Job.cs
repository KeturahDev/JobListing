using System.Collections.Generic;

namespace JobBoard.Models
{
  public class Job
  {
    public string Title {get;set;}
    public string Description {get;set;}
    public ContactInfo ContactInfo {get;set;}
    public static List<Job> Jobs {get; set;} = new List<Job>();
    public Job(string title, string description, ContactInfo contactInfo)
    {
      Title = title;
      Description = description;
      ContactInfo = contactInfo;
      Jobs.Add(this);
    }
    public static void ClearAll()
    {
      Jobs.Clear();
    }
  }
  public class ContactInfo
  {
    public string Name {get;set;}
    public int PhoneNumber {get;set;}
    public string Email {get;set;}
    public ContactInfo( string name, int phoneNumber, string email)
    {
      Name = name;
      PhoneNumber = phoneNumber; //regX
      Email = email;
    }
  }
}