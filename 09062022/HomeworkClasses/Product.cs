using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkClasses
{
    public abstract class Product
    {
        public string Name;
        public double Price;
        public abstract string GetInfo();
    }
}
