
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace vidly.Models
{
    public class Customers
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubcribedToNewsLetter { get; set; }

        public MemberShipType MemberShipType { get; set; }
        public int MemberShipTypeId { get; set; }




    }
}
