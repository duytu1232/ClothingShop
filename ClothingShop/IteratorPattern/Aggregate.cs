﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingShop.IteratorPattern
{
    internal interface Aggregate<T>
    {
        Iterator<T> CreateIterator();
    }

}
