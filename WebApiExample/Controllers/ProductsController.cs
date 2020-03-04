﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiExample.Models;

namespace WebApiExample.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product{Id=1,Name="Dell",Category="Laptop",Price= 20000},
            new Product{Id=2,Name="LG",Category="TV",Price= 30000},
            new Product{Id=3,Name="Apple",Category="Mobile",Price= 40000},
            new Product{Id=4,Name="Dell",Category="Laptop",Price= 20000}
        };
        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
