
using ConsoleApp2.Data;
using ConsoleApp2.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext _context = new ApplicationDbContext();

            //List all customers' first and last names along with their email addresses

            //var CustomersData = _context.Customers.Select(c => new { c.FirstName , c.LastName , c.Email});
            //foreach (var customer in CustomersData) {
            //    Console.WriteLine($"FirstName = {customer.FirstName}, LastName = {customer.LastName}, Email = {customer.Email}");
            //}

            //Retrieve all orders processed by a specific staff member(e.g., staff_id = 3)

            //var Orders = _context.Orders.Where(o => o.StaffId == 3);
            //foreach (var Order in Orders)
            //{
            //    Console.WriteLine(Order.OrderId);
            //}


            //Get all products that belong to a category named "Mountain Bikes"
            //var products = _context.Products.Include(p => p.Category).Where(p=> p.Category.CategoryName == "Mountain Bikes").ToList();    
            //foreach (var product in products)
            //{
            //    Console.WriteLine(product.ProductName); 
            //}

            //Count the total number of orders per store.

            //var totalNumOfStores = _context.Orders.Include(s => s.Store).GroupBy(s => s.Store.StoreName).Select(s => new {s.Key , OrderCount = s.Count() }).ToList();
            //foreach (var store in totalNumOfStores)
            //{
            //    Console.WriteLine($" StoreName = {store.Key}, Count = {store.OrderCount}");
            //}


            //List all orders that have not been shipped yet(shipped_date is null)

            //var NotShippedOrders = _context.Orders.Where(o => o.ShippedDate == null);
            //foreach (var orders in NotShippedOrders)
            //{
            //    Console.WriteLine($"OrderId = {orders.OrderId}");
            //}

            //Display each customer’s full name and the number of orders they have placed

            //var customerOrderCounts = _context.Customers.Include(o => o.Orders)
            //    .GroupBy(x => new { x.FirstName, x.LastName })
            //    .Select(g => new { FullName = g.Key.FirstName + " " + g.Key.LastName, OrderCount = g.Count() });
            //foreach (var orders in customerOrderCounts)
            //{
            //    Console.WriteLine($"FullName = {orders.FullName} {orders.OrderCount} ");
            //}

            //List all products that have never been ordered(not found in order_items)

            //var items = _context.Products
            //     .Where(p => !p.OrderItems.Any())
            //     .ToList();
            //foreach (var item in items)
            //{
            //    Console.WriteLine($" {item.ProductId} {item.ProductName}");
            //}

            //Display products that have a quantity of less than 5 in any store stock

            //var items = _context.Stocks.Include(s => s.Product)
            //.Where(s => s.Quantity < 5).ToList();
            //foreach (var item in items)
            //{
            //    Console.WriteLine($"{ item.Product.ProductName} {item.Quantity}");
            //}

            //Retrieve the first product from the products table.

            //var Product = _context.Products.FirstOrDefault();
            //Console.WriteLine(Product.ProductName);


            //Retrieve all products from the products table with a certain model year. 

            //var Products2016 = _context.Products.Where(p => p.ModelYear == 2016);
            //foreach (var product in Products2016) {
            //    Console.WriteLine(product.ModelYear);
            //}

            //Display each product with the number of times it was ordered.

            //var Items = _context.OrderItems.Include(o => o.Product).GroupBy(o => o.Product.ProductName)
            //    .Select(g => new{ProductName = g.Key, OrderCount = g.Count() }).ToList();
            //foreach (var Item in Items)
            //{
            //    Console.WriteLine(Item.ProductName);
            //    Console.WriteLine(Item.OrderCount);
            //}

            //Count the number of products in a specific category.

            //var Items = _context.Products.Include(p => p.Category)
            //    .GroupBy(g => g.Category.CategoryName)
            //    .Select(e => new { CategoryName = e.Key , NumberOfCategories =  e.Count() }).ToList();
            //foreach (var Item in Items)
            //{
            //    Console.WriteLine(Item.CategoryName);
            //    Console.WriteLine(Item.NumberOfCategories);
            //}

            //Calculate the average list price of products.

            //var ProductsPriceAvg = _context.Products.Average(e => e.ListPrice);
            //Console.WriteLine(ProductsPriceAvg);

            //Retrieve a specific product from the products table by ID.

            //var Product1 = _context.Products.FirstOrDefault(x => x.ProductId == 1);
            //Console.WriteLine(Product1?.ProductName ?? "NotFount");


            //List all products that were ordered with a quantity greater than 3 in any order.

            //var Items = _context.OrderItems.Include(o => o.Product)
            //    .GroupBy(o => o.Product.ProductName)
            //    .Select(e=> new {e.Key , CountNum = e.Count() })
            //    .Where(e => e.CountNum > 3).ToList();
            //foreach (var item in Items) {
            //    Console.WriteLine($"PName {item.Key} Items {item.CountNum}");
            //}

            //Display each staff member’s name and how many orders they processed.

            //var Staffs = _context.Orders.Include(s => s.Staff)
            //    .GroupBy(s => s.Staff.FirstName)
            //    .Select(s => new { s.Key , Number =  s.Count() }).ToList();
            //foreach (var Staff in Staffs)
            //{
            //    Console.WriteLine($"PName {Staff.Key} Items {Staff.Number}");
            //}


            //List active staff members only(active = true) along with their phone numbers.

            //var Staffs = _context.Staffs.Where(s => s.Active == 1)
            //    .Select(e => new {e.FirstName , e.Phone}).ToList();
            //foreach (var Staff in Staffs)
            //{
            //    Console.WriteLine($"{Staff.FirstName} {Staff.Phone}");
            //}


            //List all products with their brand name and category name.

            //var Items = _context.Products.Include(e => e.Brand)
            //    .Include(e => e.Category)
            //    .Select(e => new { e.Brand.BrandName, e.Category.CategoryName , e.ProductName}).ToList();
            //foreach (var Item in Items)
            //{
            //    Console.WriteLine($"{Item.ProductName} {Item.BrandName}  {Item.CategoryName}  ");
            //}

            //Retrieve orders that are completed.

            //var Items = _context.Orders.Where(e => e.ShippedDate != null).ToList();
            //foreach (var Item in Items)
            //{
            //    Console.WriteLine($"{Item.OrderId}");
            //}

            //List each product with the total quantity sold(sum of quantity from order_items).

            //var Items = _context.OrderItems .Include(p=> p.Product)
            //    .GroupBy(p=> p.Product.ProductName)
            //    .Select(p=> new {p.Key , Sum = p.Sum(p => p.Quantity)})
            //    .ToList();
            //foreach (var Item in Items)
            //{
            //    Console.WriteLine($"{Item.Key} {Item.Sum}");
            //}

        }
    }
}
