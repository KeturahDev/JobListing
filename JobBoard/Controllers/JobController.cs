using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using JobBoard.Models;

namespace JobBoard.Controllers
{
  public class JobController : Controller
  {
    [HttpGet("/jobs")]
    public ActionResult Index() { return View(); }
  }
}