﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha02
{
    public interface ICar
    {
        string Model { get; }
        string Color { get; }
        string Start();
        string Stop();

    }
}
