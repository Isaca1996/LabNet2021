using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TP4_Ejercicio_EF.Logic;
using TP4_Ejercicio_EF.Entitites;
using TP7_Ejercicio_MVC.MVC.Models;

namespace TP7_Ejercicio_MVC.MVC.Controllers
{
    public class CustomersController : Controller
    {

        CustomersLogic logic = new CustomersLogic();

        // GET: Customers
        public ActionResult Index()
        {
            List<Customers> customers = logic.getAll();

            List<CustomersViews> customerViews = customers.Select(c => new CustomersViews
            {
                CustomerID = c.CustomerID,
                ContactName = c.ContactName,
                ContactTitle = c.ContactTitle,
                CompanyName = c.CompanyName,
                Phone = c.Phone

            }).ToList();

            return View(customerViews);
        }

        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(CustomersViews customersViews)
        {

            try
            {
                Customers customersEntity = new Customers
                {
                    CustomerID = customersViews.CustomerID,
                    ContactName = customersViews.ContactName,
                    ContactTitle = customersViews.ContactTitle,
                    CompanyName = customersViews.CompanyName,
                    Phone = customersViews.Phone
                };
                logic.insert(customersEntity);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error");
            }
        }

        public ActionResult Update()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Update(CustomersViews customersViews)
        {
            try
            {
                Customers customersEntity = new Customers
                {
                    CustomerID = customersViews.CustomerID,
                    ContactName = customersViews.ContactName,
                    ContactTitle = customersViews.ContactTitle,
                    CompanyName = customersViews.CompanyName,
                    Phone = customersViews.Phone
                };
                logic.update(customersEntity);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error");
            }
        }

        public ActionResult Delete(Customers customers)
        {   
            try
            {
                Customers customersEntity = new Customers
                {
                    CustomerID = customers.CustomerID
                };
                logic.delete(customersEntity);
                return RedirectToAction("Index");
            } 
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error");
            }
            
        }


        public ActionResult Back()
        {
            return RedirectToAction("Index", "Customers");
        }
    }
}