using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using JobBoard.Models;

namespace JobBoard.Controllers
{
  public class JobController : Controller
  {
    [HttpGet("/jobs")]
    public ActionResult Index() 
    { 
      List<Job> allJobs = Job.Jobs;
      return View(allJobs); 
    }

    [HttpGet("/jobs/new")]
    public ActionResult New() { return View(); }

    [HttpPost("/jobs")]
    public ActionResult Create(string title, string description, string name, int phoneNumber, string email)
    {
      ContactInfo newContact = new ContactInfo(name, phoneNumber, email);
      Job newJob = new Job(title, description, newContact);

      return RedirectToAction("Index");
    }
    [HttpGet("/jobs/{Id}")]
    public ActionResult Show(int Id)
    {
      Job thisJob = Job.Find(Id);
      return View(thisJob);
    }
  }
}