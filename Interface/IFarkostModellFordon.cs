﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farkost.Interface
{
    public interface IFarkostModellFordon : IFarkostModell
    {
        int hjul { get; set; }
    }
}
