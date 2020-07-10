using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class PeopleController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {

            return View();
        }
        public ActionResult ListPeople()
        {
            List<PersonModel> people = new List<PersonModel>();

            people.Add(new PersonModel { FirstName = "Iyad", LastName = "Shobaki", Age = 38, IsAlive = true });
            people.Add(new PersonModel { FirstName = "Joe", LastName = "Smith", Age = 56, IsAlive = true });
            people.Add(new PersonModel { FirstName = "Sarah", LastName = "Connor", Age = 25, IsAlive = true });

            return View(people);
        }
    }
}