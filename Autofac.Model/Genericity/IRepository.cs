﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autofac.Model.Genericity
{
    public interface IRepository<T> where T:class
    {
        string Write();
    }
}
