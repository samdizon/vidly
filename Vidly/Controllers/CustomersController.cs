﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            return View(GetCustomers());
        }

        public ActionResult Details(int? id)
        {
            if (!id.HasValue)
                id = 1;
            var customer = GetCustomers().First(c => c.Id == id);
            if (customer == null)
                return HttpNotFound();
            return View(customer);
        }


        //temporary customers
        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer { Id = 1, Name = "Marisol Abduraman" },
                new Customer { Id = 2, Name = "Mickey Mausong" },
            };
        }
    }
}