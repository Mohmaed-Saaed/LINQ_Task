
using ConsoleApp2.Data;
using ConsoleApp2.Models;
using System.Collections.Generic;


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


        }
    }
}
