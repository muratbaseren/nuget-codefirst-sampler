using Nuget_CodeFirst_Sampler.Models;
using System;
using System.Data.Entity;
using System.Linq;

namespace Nuget_CodeFirst_Sampler.Context
{
    public class DatabaseInitializer : CreateDatabaseIfNotExists<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            InsertSeedData(context);
        }

        public static void InsertSeedData(DatabaseContext context)
        {
            InsertCategories(context);
            InsertProducts(context);
            InsertCustomers(context);
        }

        private static void InsertCustomers(DatabaseContext context)
        {
            if (context.Customers.Any()) return;

            for (int i = 0; i < 30; i++)
            {
                context.Customers.Add(new Customer()
                {
                    Name = FakeData.NameData.GetFirstName(),
                    Surname = FakeData.NameData.GetSurname(),
                    Email = FakeData.NetworkData.GetEmail(),
                    Birthdate = FakeData.DateTimeData.GetDatetime(
                         new DateTime(1940, 1, 1), new DateTime(1990, 12, 31))
                });
            }

            context.SaveChanges();
        }

        private static void InsertProducts(DatabaseContext context)
        {
            if (context.Products.Any()) return;

            foreach (Category cat in context.Categories)
            {
                for (int i = 0; i < FakeData.NumberData.GetNumber(5, 10); i++)
                {
                    cat.Products.Add(new Product()
                    {
                        Name = FakeData.PlaceData.GetState(),
                        Price = (decimal)(FakeData.NumberData.GetDouble() * 100),
                        Amount = FakeData.NumberData.GetNumber(5, 100)
                    });
                }
            }

            context.SaveChanges();
        }

        private static void InsertCategories(DatabaseContext context)
        {
            if (context.Categories.Any()) return;

            for (int i = 0; i < 10; i++)
            {
                context.Categories.Add(new Category()
                {
                    Name = FakeData.NameData.GetCompanyName(),
                    Description = FakeData.TextData.GetSentence()
                });
            }

            context.SaveChanges();
        }
    }
}