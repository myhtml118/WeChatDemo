﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebApi.Model
{
    public class ApiServerMsg
    {
        public bool Success { get; set; }

        public Object Context { get; set; }

        public string ErrContext { get; set; }
    }
}
