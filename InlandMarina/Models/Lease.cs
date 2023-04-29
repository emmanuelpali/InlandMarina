using System.ComponentModel.DataAnnotations;

namespace InlandMarina.Models
{
    public class Lease
    {
        public int ID { get; set; }
        [Display(Name = "Slip ID")]
        public int SlipID { get; set; }
        public int CustomerID { get; set; }

        //navigation properties
        public virtual Customer? Customer { get; set; }
        public virtual Slip? Slip { get; set; }
    }

}
