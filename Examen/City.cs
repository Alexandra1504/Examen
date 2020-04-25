using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class City
    {
        string name;
        DateTime data;
        int count;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public DateTime Date
        {
            get { return this.data; }
            set { this.data = value; }
        }

        public int Count
        {
            get { return this.count; }
            set { this.count = value; }
        }
    }
}
