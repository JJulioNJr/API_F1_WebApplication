using System.ComponentModel.DataAnnotations;

namespace WebApplicationF1.Models {
    public class Team {

        [Key()]
        public int Id { get; set; }

        public string Name { get; set; }


    }
}
