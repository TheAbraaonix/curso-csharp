using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CursoCsharp.desafio_section_9.Entities;
using CursoCsharp.desafio_section_9.Enums;

namespace CursoCsharp.desafio_section_9
{
    internal class DesafioEnumMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data (name, email, birthdate):");
            string name = Console.ReadLine();
            string email = Console.ReadLine();
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Client client = new Client { Name = name, Email = email, BirthDate = birthDate };

            Console.WriteLine("Enter order data (status):");
            OrderStatus os = (OrderStatus)Enum.Parse(typeof(OrderStatus), Console.ReadLine());
            DateTime moment = DateTime.Now;

            Order order = new Order();
            order.Client = client;
            order.Status = os;

            Console.WriteLine("How many items to this order?");
            int itensAmount = int.Parse(Console.ReadLine());

            for (int i = 0; i < itensAmount; i++)
            {
                Console.WriteLine($"Enter #{i + 1} item data (name, price, quantity):");
                string itemName = Console.ReadLine();
                double itemPrice = double.Parse(Console.ReadLine());
                int itemQuantity = int.Parse(Console.ReadLine());

                Product product = new Product { Name = itemName, Price = itemPrice };
                OrderItem orderItem = new OrderItem { Product = product, Price = product.Price, Quantity = itemQuantity };
                order.Items.Add(orderItem);
            }

            Console.WriteLine("ORDER SUMMARY");
            Console.WriteLine($"Order moment: {order.Moment.ToString("dd/MM/yyyy HH:mm:ss")}");
            Console.WriteLine($"Order status: {order.Status.ToString()}");
            Console.WriteLine($"Client: {order.Client.ToString()}");

            Console.WriteLine("Order itens:");
            
            double totalPrice = 0;
            foreach (OrderItem item in order.Items)
            {
                Console.WriteLine($"{item.Product.Name}, Quantity: {item.Quantity}, Subtotal: {item.SubTotal()}");
                totalPrice += item.SubTotal();
            }
            
            Console.WriteLine($"Total price: ${totalPrice.ToString("F2")}");
        }
    }
}
