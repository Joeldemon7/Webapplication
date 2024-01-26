using System;
using System.Collections.Generic;

namespace BucksSportsAcademy.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime FixtureDate { get; set; }


        public ICollection<Fixture> Fixtures { get; set; }
        public ICollection<Sport> Sports { get; set; }
    }
}
