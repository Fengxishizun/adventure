﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Commands
{
    public abstract class BaseCommand
    {
        public abstract void Execute(World world, params string[] @params);
    }
}
