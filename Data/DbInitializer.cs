using BucksSportsAcademy.Models;
using System;
using System.Diagnostics;
using System.Linq;

namespace BucksSportsAcademy.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SportsContext context)
        {
            context.Database.EnsureCreated();

            // Look for any Users.
            if (context.Users.Any())
            {
                return;   // DB has been seeded
            }

            var Users = new User[]
            {
            new User{UserID=1,FirstMidName="Carson",LastName="Alexander",FixtureDate=DateTime.Parse("2024-02-11")},
            new User{UserID=2,FirstMidName="Meredith",LastName="Alonso",FixtureDate=DateTime.Parse("2024-01-29")},
            new User{UserID=3,FirstMidName="Arturo",LastName="Anand",FixtureDate=DateTime.Parse("2024-09-01")},
            new User{UserID=4,FirstMidName="Gytis",LastName="Barzdukas",FixtureDate=DateTime.Parse("2024-04-01")},
            new User{UserID=5,FirstMidName="Yan",LastName="Li",FixtureDate=DateTime.Parse("2024-05-07")},
            new User{UserID=6,FirstMidName="Peggy",LastName="Justice",FixtureDate=DateTime.Parse("2024-08-21")},
            new User{UserID=7,FirstMidName="Laura",LastName="Norman",FixtureDate=DateTime.Parse("2024-10-31")},
            new User{UserID=8,FirstMidName="Nino",LastName="Olivetto",FixtureDate=DateTime.Parse("2024-11-16")}
            };
            foreach (User u in Users)
            {
                context.Users.Add(u);
            }
            context.SaveChanges();

            var Sports = new Sport[]
            {
            new Sport{SportID=1050,SportsType="Football"},
            new Sport{SportID=4022,SportsType="Basketball"},
            new Sport{SportID=4041,SportsType="Volleyball"},
            };
            foreach (Sport s in Sports)
            {
                context.Sports.Add(s);
            }
            context.SaveChanges();

            var fixtures = new Fixture[]
            {
            new Fixture{FixtureID=1,UserID=1,SportID=1050,Location=Location.StadiumA},
            new Fixture{FixtureID=2,UserID=3,SportID=4022,Location=Location.StadiumC},
            new Fixture{FixtureID=3,UserID=1,SportID=4041,Location=Location.StadiumB},
            new Fixture{FixtureID=4,UserID=2,SportID=4041,Location=Location.StadiumB},
            new Fixture{FixtureID=5,UserID=2,SportID=4041,Location=Location.StadiumF},
            new Fixture{FixtureID=6,UserID=2,SportID=1050,Location=Location.StadiumF},
            new Fixture{FixtureID=7,UserID=3,SportID=1050},
            new Fixture{FixtureID=8,UserID=4,SportID=4022},
            new Fixture{FixtureID=9,UserID=4,SportID=1050,Location=Location.StadiumF},
            new Fixture{FixtureID=10,UserID=5,SportID=4041,Location=Location.StadiumC},
            new Fixture{FixtureID=11,UserID=6,SportID=4022},
            new Fixture{FixtureID=12,UserID=7,SportID=4022,Location=Location.StadiumA},
            };
            foreach (Fixture f in fixtures)
            {
                context.Fixtures.Add(f);
            }
            context.SaveChanges();
        }
    }
}