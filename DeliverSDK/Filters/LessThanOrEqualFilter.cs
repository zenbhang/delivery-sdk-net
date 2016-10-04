﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KenticoCloud.Deliver
{
    public class LessThanOrEqualFilter : BaseFilter, IFilter
    {
        public LessThanOrEqualFilter(string element, string value)
            : base(element, value)
        {
            Operator = "[lte]";
        }
    }
}
