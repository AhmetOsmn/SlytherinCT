﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTender.Core.Utilities
{
    public class ErrorDataResult<T> : DataResult<T>
    {

        public ErrorDataResult(string message) : base(default, false, message)
        {
        }
    }
}
