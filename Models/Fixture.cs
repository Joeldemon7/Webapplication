
namespace BucksSportsAcademy.Models
{
    public enum Location
    {
        StadiumA, StadiumB, StadiumC, StadiumD, StadiumF
    }
    public class Fixture
    {
        public int FixtureID { get; set; }
        public int SportID { get; set; }
        public int UserID { get; set; }
        public Location? Location { get; set; }

        public Sport Sport { get; set; }
        public User User { get; set; }
    }
}
