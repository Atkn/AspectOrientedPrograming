using Aspect.Core.Domain.Entities;
using Aspect.Insfracture.Repository.Abstraction;
using Aspect.Insfracture.Repository.Concrete;
using Aspect.Insfracture.RepositoryFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aspect.Packages.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("***\r\n Begin Application - no Logging\r\n");
            //var repository = new EntityRepository<Customer>();
            //IEntityRepository<Customer> entityRepo = new LoggerRepository<Customer>(repository);
            IEntityRepository<Customer> customerRepository = RepositoryFactory.Create<Customer>();

            var customer = new Customer
            {
                Title = "Atakan ACAR",
                ModifiedAt = DateTime.Now
            };
            customerRepository.Add(customer);
            customerRepository.Delete(customer);
            customerRepository.Update(customer);
            Console.WriteLine("\r\nEnd program - logging with decorator\r\n***");
            Console.ReadLine();
        }
    }
}
