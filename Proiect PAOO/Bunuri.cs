using System;
using System.Collections.Generic;
using System.Text;

namespace Proiect_PAOO
{
    class Bunuri
    {
        public int Id {
            get;set;
        }
        public string Name {
            get;set;
        }

        public Bunuri(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        override public string ToString() {
            return Name;
        }


    }
}
