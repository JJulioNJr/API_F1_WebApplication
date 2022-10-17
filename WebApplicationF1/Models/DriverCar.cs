using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationF1.Models {
    public class DriverCar {
        [Key()]
        public int Id { get; set; }
    
        [ForeignKey("Driver")]
         public int IdDriver { get; set; }
    
        [ForeignKey("Car")]
        public int IdCar { get; set; }
        
        public DateTime EventDate{ get; set; }

        public virtual Driver Driver{ get; set; }
        public virtual Car Car { get; set; }


    }
}
