using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarInsurance3.Models;
using CarInsurance3.ViewModels;

namespace CarInsurance3.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (
                InsuranceEntities1 db = new InsuranceEntities1())
            {

                var custQuotesVm = (from c in db.cqTables
                                  where c.Id > 0
                                  select c).ToList();

                var customerQuotesVM = new List<custQuotesVM>();
                foreach (var custQuote in custQuotesVm)
                {
                    var custQuoteVm = new custQuotesVM();
                    custQuoteVm.firstName = custQuote.FirstName;
                    custQuoteVm.lastName = custQuote.LastName;
                    custQuoteVm.emailAddress = custQuote.EmailAddress;
                    custQuoteVm.quote = custQuote.Quote;
                    customerQuotesVM.Add(custQuoteVm);
                }
                

                return View(customerQuotesVM);
            }
        }
    }
}