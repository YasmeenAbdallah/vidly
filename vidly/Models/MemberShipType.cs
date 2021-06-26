using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vidly.Models
{
    public class MemberShipType 
    {
        public int Id { get; set; }
        public short SignUpFee { get; set; }
        public byte DurationInMonthes { get; set; }
        public byte DiscountRate { get; set; }
    }
}
