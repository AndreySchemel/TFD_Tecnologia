﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TFD_AndreySchemel.Models
{
    public class MembershipType
    {
        public short SignUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }

        public byte Id { get; set; }

    }
}