namespace CatsApp.Data.Migrations
{
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Microsoft.AspNet.Identity;
    using Models;

    public sealed class Configuration : DbMigrationsConfiguration<CatsAppDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(CatsAppDbContext context)
        {
            if (context.Cats.Any())
            {
                return;
            }

            var passwordHasher = new PasswordHasher();
            var newton = new User
            {
                UserName = "TheLordOfGravity",
                FirstName = "Isaac",
                LastName = "Newton",
                PasswordHash = passwordHasher.HashPassword("gravityDown")
            };

            var einstein = new User
            {
                UserName = "TheNewLordOfGravity",
                FirstName = "Albert",
                LastName = "Einstein",
                PasswordHash = passwordHasher.HashPassword("gravityUpAndDown")
            };

            var turing = new User
            {
                UserName = "CSIAmYourFather",
                FirstName = "Alan",
                LastName = "Turing",
                PasswordHash = passwordHasher.HashPassword("123456")
            };

            var test = new User
            {
                UserName = "IAmJustForTesting",
                FirstName = "John",
                LastName = "Doe",
                PasswordHash = passwordHasher.HashPassword("test123")
            };

            context.Users.Add(newton);
            context.Users.Add(einstein);
            context.Users.Add(turing);
            context.Users.Add(test);

            context.SaveChanges();

            context.Cats.Add(new Cat
            {
                Name = "Mr Principios",
                Age = 2,
                Breed = "Maine Coon",
                Owner = newton,
                OwnerId = newton.Id,
                ImageUrl = "https://www.mainecoonfancy.com/forums/uploads/a8bb829b61883adc791e465541bff9f8.jpg"
            });

            context.Cats.Add(new Cat
            {
                Name = "Catculus",
                Age = 1,
                Breed = "Scottish fold",
                Owner = newton,
                OwnerId = newton.Id,
                ImageUrl = "http://www.scottishfoldlove.com/wp-content/uploads/2014/09/adorable-scottish-fold-kitten.jpg"
            });

            context.Cats.Add(new Cat
            {
                Name = "General MeowAtivity",
                Age = 4,
                Breed = "British Shorthair",
                Owner = einstein,
                OwnerId = einstein.Id,
                ImageUrl = "http://science-lakes.com/images/british-shorthair/british-shorthair-03.jpg"
            });

            context.Cats.Add(new Cat
            {
                Name = "Purring Test",
                Age = 4,
                Breed = "Siamese",
                Owner = turing,
                OwnerId = turing.Id,
                ImageUrl = "http://buzzsharer.com/wp-content/uploads/2015/07/Siamese-Cat-beauty.jpg"
            });

            context.Cats.Add(new Cat
            {
                Name = "Goodles",
                Age = 3,
                Breed = "Egyptian Mau",
                Owner = test,
                OwnerId = test.Id,
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/7/7f/Egyptian_Mau_Bronze.jpg"
            });

            context.SaveChanges();

        }
    }
}
