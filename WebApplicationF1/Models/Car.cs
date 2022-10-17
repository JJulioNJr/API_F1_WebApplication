using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationF1.Models {
    public class Car {
        
        [Key()]
        public int Id { get; set; }
    
        public string Name { get; set; }
        public int year { get; set; }
        public int Unit { get; set; }

        [ForeignKey("Team")]
        public int IdTeam { get; set; }

        public virtual Team Team {get; set; }

    }

    
}
