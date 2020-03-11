using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using JobBoard.Models;
using System;

namespace JobBoard.Tests 
{
  [TestClass]
  public class JobTest : IDisposable
  {
    public void Dispose()
    {
      Job.ClearAll();
    }

    [TestMethod]
    public void JobConstructor_CreatesInstanceOfJob_Job()
    {
      ContactInfo employer = new ContactInfo("Mark", 333, "yomark@gmail.com");
      Job newJob = new Job ("web developer", "making websites", employer);

      Job resultJob = newJob;

      Assert.AreEqual("web developer", resultJob.Title);
    }
    [TestMethod]
    public void InstantiateList_ReturnAllJobsinListOfJobs_List()
    {
      ContactInfo employer1 = new ContactInfo("Mark", 333, "yomark@gmail.com");
      Job newJob1 = new Job ("web developer", "making good websites", employer1);
      ContactInfo employer2 = new ContactInfo("Mike", 444, "yomike@gmail.com");
      Job newJob2 = new Job ("software developer", "making bad websites", employer2);

      Job resultJob1 = newJob1;
      Job resultJob2 = newJob2;

      Assert.AreEqual("software developer", Job.Jobs[1].Title);
    }
    [TestMethod]
    public void Find_ReturnsJobPostingGivenJobID_Job()
    {
      ContactInfo employer = new ContactInfo("Mark", 333, "yomark@gmail.com");
      Job newJob = new Job ("web developer", "making websites", employer);

      Job jobResult = Job.Find(1);

      Assert.AreEqual(newJob.Title,jobResult.Title);

    }
  }
  [TestClass]
  public class ContactInfoTest
  {
    [TestMethod]
    public void ContactInfoConstructor_CreatesInstanceOfContactInfo_ContactInfo()
    {
      //Arrange
      ContactInfo newContactInfo = new ContactInfo ("Jessie", 911, "jessie911@gmail.com");

      //Act
      ContactInfo contactInfoResult = newContactInfo;

      //Assert
      Assert.AreEqual(typeof(ContactInfo), contactInfoResult.GetType());
    }
  }
}
