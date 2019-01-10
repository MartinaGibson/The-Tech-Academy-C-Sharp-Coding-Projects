using System;
using System.Web.Mvc;
using System.Linq;
using CarInsurance3.Models;
using CarInsurance3.ViewModels;

namespace CarInsurance3.Controllers
{
    public class HomeController : Controller
    {
        InsuranceEntities1 _db = new InsuranceEntities1();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult QuoteInsurance()
        {
            return View("Index");
        }

        [HttpPost]
        public ActionResult QuoteInsurance(string firstName, string lastName, string emailAddress, DateTime dateOfBirth, int carYear, string carMake, string carModel, string dui, int speedTix, string coverage)
        {           
              if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress))
              {
                  return View("~/Views/Shared/Error.cshtml");
              }
              else 
              {
                //Check Age
                int todizzle = DateTime.Now.Year;
                int runningTotal = 0; 

                if (todizzle - dateOfBirth.Year < 25 || todizzle - dateOfBirth.Year > 100)
                {
                    runningTotal = 50 + 25; 
                }
                else if (todizzle - dateOfBirth.Year < 18)
                {
                    runningTotal = 50 + 100;
                }
                else
                {
                    runningTotal = 50;
                };
                //Car
                if (carYear < 2000 || carYear > 2015)
                {
                    runningTotal = runningTotal + 25;
                    if (carMake.ToLower() == "Porsche")
                    {
                        runningTotal = runningTotal + 25;
                        if (carModel.ToLower() == "911 Carrerra")
                        {
                            runningTotal = runningTotal + 25;
                        }
                    }
                };
                //Driver's History
                if (speedTix > 0)
                {
                    runningTotal = runningTotal + (speedTix * 10);
                };
                if (dui.ToLower() == "yes" || dui.ToLower() == "yeah" || dui.ToLower() == "y")
                {
                    runningTotal = (runningTotal / 4) + runningTotal;
                };
                if (coverage.ToLower() == "full coverage" || coverage.ToLower() == "full")
                {
                    runningTotal = (runningTotal / 2) + runningTotal;
                };
                int quote = runningTotal;
                using (InsuranceEntities1 db = new InsuranceEntities1())
                 {                    
                    {
                        var custQuote = new cqTable();
                        custQuote.FirstName = firstName;
                        custQuote.LastName = lastName;
                        custQuote.EmailAddress = emailAddress;
                        custQuote.DOB = dateOfBirth;
                        custQuote.CarYear = carYear;
                        custQuote.CarMake = carMake;
                        custQuote.CarModel = carModel;
                        custQuote.DUI = dui;
                        custQuote.NumberOfSpeedTix = speedTix;
                        custQuote.Coverage = coverage;
                        custQuote.Quote = quote;
                        
                        db.cqTables.Add(custQuote);
                        db.SaveChanges();
                    }
                      
                 }
              }


            var res = _db.cqTables.OrderByDescending(i => i.Id).First();

            return View("QuoteInsurance", res); // pass results to View
        }

        

            
        
    }
}