using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using FakeData;

namespace EntityFrameworkYapisi.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {
            // Veritabanı ilk oluşturulrken çalıştırılacak olan sınıf çağrısı contex sınıfının constructor metoduna yazıldı
            Database.SetInitializer(new DatabaseGenerator());
        }

        // Maplenecek tablo modellerinin tanımları
        public DbSet<Person> Person { get; set; }
        public DbSet<Address> Address { get; set; }

    }

    // Veritabanını ilk kurulurken içine başlangıç verileri atan sınıf tanımı
    public class DatabaseGenerator : CreateDatabaseIfNotExists<DatabaseContext>
    {
        // Veritabanı oluştuktan sonra çalışan bu metod ile başlangıç verileri veritabanına giriliyor
        protected override void Seed(DatabaseContext context)
        {
            for (int i = 0; i < 10; i++)
            {
                Person person = new Person();
                person.Name = FakeData.NameData.GetFemaleFirstName();
                person.Surname = FakeData.NameData.GetSurname();
                person.Age = FakeData.NumberData.GetNumber(4, 130);

                context.Person.Add(person);
            }
            context.SaveChanges();

            List<Person> allPersons = context.Person.ToList();

            foreach (Person person in allPersons)
            {
                for (int i = 0; i < FakeData.NumberData.GetNumber(1, 5); i++)
                {
                    Address address = new Address();
                    address.Description = FakeData.PlaceData.GetAddress();
                    address.Person = person;

                    context.Address.Add(address);
                }
            }
            context.SaveChanges();

            base.Seed(context);
        }
    }
}