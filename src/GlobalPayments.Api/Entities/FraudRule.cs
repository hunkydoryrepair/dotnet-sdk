﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalPayments.Api.Entities
{
    public class FraudRule
    {
        public string Key { get; set; }
        public FraudFilterMode Mode { get; set; }
    }
}
