using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace BucksSportsAcademy.Models
{
    public class Sport
    {
        public int SportID { get; set; }
        public string SportsType { get; set; }

        public ICollection<Fixture> Fixtures { get; set; }
    }
}

