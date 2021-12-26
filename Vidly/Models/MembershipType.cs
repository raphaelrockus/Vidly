using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }
        [Required]
        [StringLength(200)]
        public string Name { get; set; }
        public short SignUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }

        //readonly so we can't change them later
        public static readonly byte Unknow = 0;
        public static readonly byte PayAsYouGo = 1;
        //or an enum but the problem is that in validation we need often to cast to the right type
    }
}