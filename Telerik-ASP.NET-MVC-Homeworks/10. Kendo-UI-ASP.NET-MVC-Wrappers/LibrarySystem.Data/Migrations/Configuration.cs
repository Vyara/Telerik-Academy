namespace LibrarySystem.Data.Migrations
{
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Models;

    public sealed class Configuration : DbMigrationsConfiguration<LibrarySystemDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(LibrarySystemDbContext context)
        {
            if (context.Books.Any())
            {
                return;
            }

            var scifi = new Category
            {
                Name = "Science Fiction"
            };

            var horror = new Category
            {
                Name = "Horror"
            };


            var drama = new Category
            {
                Name = "Drama"
            };


            context.Categories.Add(scifi);
            context.Categories.Add(horror);
            context.Categories.Add(drama);

            context.SaveChanges();

            var nineteenEightyFour = new Book
            {
                Title = "1984",
                Author = "George Orwell",
                ISBN = "9780141182957",
                Website = "http://www.goodreads.com/book/show/5470.1984",
                Description = "The year 1984 has come and gone, but George Orwell's prophetic, nightmarish vision in 1949 of the world we were becoming is timelier than ever. 1984 is still the great modern classic of negative utopia -a startlingly original and haunting novel that creates an imaginary world that is completely convincing, from the first sentence to the last four words. No one can deny the novel's hold on the imaginations of whole generations, or the power of its admonitions -a power that seems to grow, not lessen, with the passage of time.",
                CategoryId = scifi.Id
            };

            var shining = new Book
            {
                Title = "The Shining",
                Author = "Stephen King",
                ISBN = "9780451119674",
                Website = "http://www.goodreads.com/book/show/11588.The_Shining",
                Description = "Danny was only five years old but in the words of old Mr Halloran he was a 'shiner', aglow with psychic voltage. When his father became caretaker of the Overlook Hotel his visions grew frighteningly out of control.",
                CategoryId = horror.Id
            };

            var ringworld = new Book
            {
                Title = "Ringworld",
                Author = "Larry Niven",
                ISBN = "9780345316752",
                Website = "http://www.goodreads.com/book/show/61179.Ringworld",
                Description = "Pierson's puppeteers, three-leg two-head aliens find immense structure in unexplored part of the universe. Frightened of meeting the builders, they send a team of two humans, a puppeteer and a kzin, eight-foot red-fur catlike alien. Ringworld is 180 million miles across, sun at center. But the expedition crashes, and crew face disastrously long trek.",
                CategoryId = scifi.Id
            };


            var mocking = new Book
            {
                Title = "To Kill a Mockingbird",
                Author = "Harper Lee",
                ISBN = "9788931001990",
                Website = "http://www.goodreads.com/book/show/2657.To_Kill_a_Mockingbird",
                Description = "The unforgettable novel of a childhood in a sleepy Southern town and the crisis of conscience that rocked it, To Kill A Mockingbird became both an instant bestseller and a critical success when it was first published in 1960. It went on to win the Pulitzer Prize in 1961 and was later made into an Academy Award-winning film, also a classic.",
                CategoryId = drama.Id
            };


            context.Books.Add(nineteenEightyFour);
            context.Books.Add(shining);
            context.Books.Add(ringworld);
            context.Books.Add(mocking);
            context.SaveChanges();
        }
    }
}
