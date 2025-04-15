using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myBase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var context = new CarServiceDbContext();

            var cars = context.Cars.ToList(); 

            Console.WriteLine("Список клиентов:");

            foreach (var car in cars)
            {
                Console.WriteLine($"ID: {car.ClientId}, Фирма: {car.Brand}, VIN: {car.VIN}");
            }

        }
    }
}

