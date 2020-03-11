using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using JobBoard.Models;
using System;

namespace JobBoard.Tests 
{
  [TestClass]
  public class JobTest //: IDisposable
  {
    // public void Dispose()
    // {
    //   Job.ClearAll();
    // }

    [TestMethod]
    public void JobConstructor_CreatesInstanceOfJob_Job()
    {
      ContactInfo employer = new ContactInfo("Mark", 333, "yomark@gmail.com");
      Job newJob = new Job ("web developer", "making websites", employer);

      Job resultJob = newJob;

      Assert.AreEqual("web developer", resultJob.Title);
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
