
using ConsoleApp2.Data;
using ConsoleApp2.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Numerics;


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

            //var customerOrderCounts = _context.Customers.Include(o => o.Orders).GroupBy(x => new { x.FirstName, x.LastName }).Select(g => new {FullName = g.Key.FirstName + " " + g.Key.LastName,OrderCount = g.Count()});
            //var x = 0;
            //foreach (var orders in customerOrderCounts)
            //{
            //    Console.WriteLine($"FullName = {orders.FullName} {orders.OrderCount} ");
            //}

            //List all products that have never been ordered(not found in order_items)
            //??

            //Display products that have a quantity of less than 5 in any store stock

        }
    }
}
