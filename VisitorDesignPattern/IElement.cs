﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDesignPattern
{
    public interface IElement
    {
        void Accept(IVisitor visitor);
    }
}
