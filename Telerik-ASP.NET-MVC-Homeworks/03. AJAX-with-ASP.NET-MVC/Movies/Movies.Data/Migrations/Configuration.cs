using System;

namespace Movies.Data.Migrations
{
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Models;

    public sealed class Configuration : DbMigrationsConfiguration<MoviesDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(MoviesDbContext context)
        {
            if (context.Movies.Any())
            {
                return;
            }

            var now = float.Parse(DateTime.Now.ToString("yyyy.MMdd"));
            float dob;
            dob = float.Parse(new DateTime(1949, 8, 10).ToString("yyyy.MMdd"));
            var sigorney = new Actress
            {
                Name = "Sigorney Weaver",
                Age = (int)(now - dob)
            };

            dob = float.Parse(new DateTime(1967, 2, 10).ToString("yyyy.MMdd"));

            var laura = new Actress
            {
                Name = "Laura Dern",
                Age = (int)(now - dob)
            };

            dob = float.Parse(new DateTime(1956, 9, 26).ToString("yyyy.MMdd"));

            var linda = new Actress
            {
                Name = "Linda Hamilton",
                Age = (int)(now - dob)
            };

            dob = float.Parse(new DateTime(1970, 12, 12).ToString("yyyy.MMdd"));

            var jennifer = new Actress
            {
                Name = "Jennifer Connelly",
                Age = (int)(now - dob)
            };

            dob = float.Parse(new DateTime(1992, 4, 10).ToString("yyyy.MMdd"));

            var daisy = new Actress
            {
                Name = "Daisy Ridley",
                Age = (int)(now - dob)
            };

            dob = float.Parse(new DateTime(1950, 6, 24).ToString("yyyy.MMdd"));

            var nancy = new Actress
            {
                Name = "Nancy Allen",
                Age = (int)(now - dob)
            };


            context.Actresses.Add(sigorney);
            context.Actresses.Add(laura);
            context.Actresses.Add(linda);
            context.Actresses.Add(jennifer);
            context.Actresses.Add(daisy);
            context.Actresses.Add(nancy);
            context.SaveChanges();

            dob = float.Parse(new DateTime(1933, 8, 25).ToString("yyyy.MMdd"));

            var tom = new Actor
            {
                Name = "Tom Skerritt",
                Age = (int)(now - dob)
            };

            dob = float.Parse(new DateTime(1947, 9, 14).ToString("yyyy.MMdd"));

            var sam = new Actor
            {
                Name = "Sam Neill",
                Age = (int)(now - dob)
            };

            dob = float.Parse(new DateTime(1947, 7, 30).ToString("yyyy.MMdd"));

            var arnold = new Actor
            {
                Name = "Arnold Schwarzenegger",
                Age = (int)(now - dob)
            };

            dob = float.Parse(new DateTime(1964, 4, 7).ToString("yyyy.MMdd"));

            var russel = new Actor
            {
                Name = "Russell Crowe",
                Age = (int)(now - dob)
            };

            dob = float.Parse(new DateTime(1992, 3, 17).ToString("yyyy.MMdd"));

            var john = new Actor
            {
                Name = "John Boyega",
                Age = (int)(now - dob)
            };

            dob = float.Parse(new DateTime(1947, 6, 24).ToString("yyyy.MMdd"));

            var peter = new Actor
            {
                Name = "Peter Weller",
                Age = (int)(now - dob)
            };

            context.Actors.Add(tom);
            context.Actors.Add(sam);
            context.Actors.Add(arnold);
            context.Actors.Add(russel);
            context.Actors.Add(peter);
            context.SaveChanges();


            var fox = new Studio
            {
                Name = "20th Century-Fox",
                Address = "2121 Avenue of the Stars #100, Los Angeles, CA 90067, United States"
            };

            var universal = new Studio
            {
                Name = "Universal Pictures",
                Address = "825 8th Ave, New York, NY 10019, United States"

            };

            var carolco = new Studio
            {
                Name = "Carolco Pictures",
                Address = "200 NW Corporate Boulevard, STE 303, United States"

            };

            var lucas = new Studio
            {
                Name = "Lucasfilm",
                Address = "1110 Gorgas Ave San Francisco, California 94129, United States"

            };


            var metro = new Studio
            {
                Name = "Metro-Goldwyn-Mayer",
                Address = "10250 Constellation Boulevard Los Angeles, CA. 90067, United States"

            };

            context.Studios.Add(fox);
            context.Studios.Add(universal);
            context.Studios.Add(carolco);
            context.Studios.Add(lucas);
            context.Studios.Add(metro);
            context.SaveChanges();

            var alien = new Movie
            {
                Title = "Alien",
                Director = "Ridley Scott",
                Year = 1979,
                ImageUrl = "http://i.telegraph.co.uk/multimedia/archive/03064/Alien-intro_3064438b.jpg",
                LeadingMaleId = tom.Id,
                LeadingMale = tom,
                LeadingFemaleId = sigorney.Id,
                LeadingFemale = sigorney,
                StudioId = fox.Id,
                Studio = fox,
            };

            var jurassic = new Movie
            {
                Title = "Jurassic Park",
                Director = "Steven Spielberg",
                Year = 1993,
                ImageUrl = "https://ak-hdl.buzzfed.com/static/2014-08/12/12/enhanced/webdr10/enhanced-14020-1407861668-13.jpg",
                LeadingMaleId = sam.Id,
                LeadingMale = sam,
                LeadingFemaleId = laura.Id,
                LeadingFemale = laura,
                StudioId = universal.Id,
                Studio = universal,
            };


            var terminator = new Movie
            {
                Title = "Terminator 2: Judgment Day",
                Director = "James Cameron",
                Year = 1991,
                ImageUrl = "http://vignette3.wikia.nocookie.net/terminator/images/1/14/Terminator_2_poster.jpg/revision/20110513040054",
                LeadingMaleId = arnold.Id,
                LeadingMale = arnold,
                LeadingFemaleId = linda.Id,
                LeadingFemale = linda,
                StudioId = carolco.Id,
                Studio = carolco,
            };


            var beautifulMind = new Movie
            {
                Title = "A Beautiful Mind",
                Director = "James Cameron",
                Year = 2001,
                ImageUrl = "http://cdn.fontmeme.com/images/A-Beautiful-Mind-Poster.jpg",
                LeadingMaleId = russel.Id,
                LeadingMale = russel,
                LeadingFemaleId = jennifer.Id,
                LeadingFemale = jennifer,
                StudioId = universal.Id,
                Studio = universal,
            };

            var star = new Movie
            {
                Title = "Star Wars: Episode VII - The Force Awakens",
                Director = "J.J. Abrams",
                Year = 2015,
                ImageUrl = "http://cdn.christianitydaily.com/data/images/full/4018/star-wars-force-awakens-official-poster-jpg.jpg?w=600",
                LeadingMaleId = john.Id,
                LeadingMale = john,
                LeadingFemaleId = daisy.Id,
                LeadingFemale = daisy,
                StudioId = lucas.Id,
                Studio = lucas,
            };

            var robocop = new Movie
            {
                Title = "Robocop",
                Director = "Paul Verhoeven",
                Year = 1987,
                ImageUrl = "http://media.aintitcool.com/media/uploads/2013/draven/robocop_1987_large.jpg",
                LeadingMaleId = peter.Id,
                LeadingMale = peter,
                LeadingFemaleId = nancy.Id,
                LeadingFemale = nancy,
                StudioId = metro.Id,
                Studio = metro,
            };

            context.Movies.Add(alien);
            context.Movies.Add(jurassic);
            context.Movies.Add(terminator);
            context.Movies.Add(beautifulMind);
            context.Movies.Add(star);
            context.Movies.Add(robocop);
            context.SaveChanges();
        }
    }
}
