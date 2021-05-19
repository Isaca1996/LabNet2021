using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using TP9_Ejercicio_API_Angular.Models;

namespace TP9_Ejercicio_API_Angular.Controllers
{
    [RoutePrefix("api/Products")]
    public class ProductsController : ApiController
    {
        private ProductEntities db = new ProductEntities();

        // GET: api/Products
        [HttpGet]
        [Route("AllProductsDetails")]
        public IQueryable<Products> GetProducts()
        {
            try
            {
                return db.Products;
            }
            catch (Exception)
            {

                throw;
            }
        }

        // GET: api/Products/5
        [ResponseType(typeof(Products))]
        [HttpGet]
        [Route("GetProductDetailsById/{id}")]
        public IHttpActionResult GetProducts(int? id)
        {

            Products products = db.Products.Find(id);

            if (products == null)
            {
                return NotFound();
            }

            return Ok(products);

           
        }

        // PUT: api/Products/5
        [ResponseType(typeof(void))]
        [HttpPut]
        [Route("UpdateProductDetails")]
        public IHttpActionResult PutProducts(int id, Products products)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                Products proDetails = new Products();
                proDetails = db.Products.Find(id);
                if (proDetails != null)
                {
                    proDetails.ProductID = products.ProductID;
                    proDetails.ProductName = products.ProductName;
                    proDetails.QuantityPerUnit = products.QuantityPerUnit;
                    proDetails.UnitPrice = products.UnitPrice;
                    proDetails.UnitsInStock = products.UnitsInStock;
                }
                int i = this.db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
            return Ok(products);
        }

        // POST: api/Products
        [ResponseType(typeof(Products))]
        [HttpPost]
        [Route("InsertProductDetails")]
        public IHttpActionResult PostProducts(Products products)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Products.Add(products);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = products.ProductID }, products);
        }

        // DELETE: api/Products/5
        [ResponseType(typeof(Products))]
        [HttpDelete]
        [Route("DeleteProductDetails")]
        public IHttpActionResult DeleteProducts(int id)
        {
            Products products = db.Products.Find(id);
            if (products == null)
            {
                return NotFound();
            }

            db.Products.Remove(products);
            db.SaveChanges();

            return Ok(products);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ProductsExists(int id)
        {
            return db.Products.Count(e => e.ProductID == id) > 0;
        }
    }
}