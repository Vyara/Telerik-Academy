namespace Chirper.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Models;
    using Microsoft.AspNet.Identity;

    public sealed class Configuration : DbMigrationsConfiguration<ChirperDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(ChirperDbContext context)
        {
            if (context.Users.Any())
            {
                return;
            }
            var passwordHasher = new PasswordHasher();

            var admin = new User()
            {
                UserName = "theAdmin",
                FirstName = "Admin",
                LastName = "Adminov",
                PasswordHash = passwordHasher.HashPassword("admin"),
                SecurityStamp = Guid.NewGuid().ToString(),
            };

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
            context.Users.Add(admin);

            context.SaveChanges();

            var fail = new Tag
            {
                Name = "#fail"
            };

            var success = new Tag
            {
                Name = "#success"
            };

            var programming = new Tag
            {
                Name = "#programming"
            };

            var physics = new Tag
            {
                Name = "#physics"
            };

            var wondering = new Tag
            {
                Name = "#wondering"
            };


            var ai = new Tag
            {
                Name = "#ai"
            };



            var work = new Tag
            {
                Name = "#work"
            };

            var winning = new Tag
            {
                Name = "#winning"
            };


            var war = new Tag
            {
                Name = "#war"
            };

            context.Tags.Add(fail);
            context.Tags.Add(success);
            context.Tags.Add(programming);
            context.Tags.Add(physics);
            context.Tags.Add(wondering);
            context.Tags.Add(ai);
            context.Tags.Add(work);
            context.Tags.Add(winning);
            context.Tags.Add(war);

            context.SaveChanges();

            var newtonChirp = new Chirp
            {
                Message = "I did it! I discovered gravity!",
                CreationDate = DateTime.UtcNow,
                CreatorId = newton.Id
            };
            newtonChirp.Tags.Add(success);
            newtonChirp.Tags.Add(physics);

            var newtonSecondChirp = new Chirp
            {
                Message = "Curses, Einstein came up with a better theory!",
                CreationDate = DateTime.UtcNow,
                CreatorId = newton.Id
            };

            newtonSecondChirp.Tags.Add(fail);
            newtonSecondChirp.Tags.Add(physics);

            var turingChirp = new Chirp
            {
                Message = "Could an intelligent machine be created?",
                CreationDate = DateTime.UtcNow,
                CreatorId = turing.Id
            };
            turingChirp.Tags.Add(wondering);
            turingChirp.Tags.Add(programming);
            turingChirp.Tags.Add(ai);

            var turingNewChirp = new Chirp
            {
                Message = "No time, got to get decripting the Enigma machine",
                CreationDate = DateTime.UtcNow,
                CreatorId = turing.Id
            };

            turingNewChirp.Tags.Add(work);
            turingNewChirp.Tags.Add(winning);
            turingNewChirp.Tags.Add(war);


            var einsteinChirp = new Chirp
            {
                Message = "My theory is superior, but people still use Newton's to calculate :(",
                CreationDate = DateTime.UtcNow,
                CreatorId = einstein.Id
            };
            einsteinChirp.Tags.Add(physics);
            einsteinChirp.Tags.Add(fail);


            var einsteinNewChirp = new Chirp
            {
                Message = "Still, I explained how time works and planets bend space-time!",
                CreationDate = DateTime.UtcNow,
                CreatorId = einstein.Id
            };
            einsteinNewChirp.Tags.Add(physics);
            einsteinNewChirp.Tags.Add(success);

            var testChirp = new Chirp
            {
                Message = "I'm just a test user, I didn't accomplish anything significant :(",
                CreationDate = DateTime.UtcNow,
                CreatorId = test.Id
            };
            testChirp.Tags.Add(fail);

            context.Chirps.Add(newtonChirp);
            context.Chirps.Add(newtonSecondChirp);
            context.Chirps.Add(turingChirp);
            context.Chirps.Add(turingNewChirp);
            context.Chirps.Add(einsteinChirp);
            context.Chirps.Add(einsteinNewChirp);
            context.Chirps.Add(testChirp);
            context.SaveChanges();


        }
    }
}
