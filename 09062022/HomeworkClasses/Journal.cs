using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkClasses
{
    public class Journal:Product
    {
        public string Company;

        public override string GetInfo()
        {
            return $"Name: {Name} - Company: {Company} - Price: {Price}";
        }
    }
}
