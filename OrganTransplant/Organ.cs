using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganTransplant
{
    internal class Organ
    {
        public string Type { get; }

        public Organ(string type)
        {
            Type = type;
        }
    }
}
