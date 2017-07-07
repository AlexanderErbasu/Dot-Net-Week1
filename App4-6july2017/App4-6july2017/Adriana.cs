using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App4_6july2017
{

    public class Adriana
    {
        public int ID { get; set; }

        public string Name { get; set; }
        public override bool Equals(object obj)
        {
            Adriana x = obj as Adriana;
            if (x == null)
                return false;
            return x.ID == this.ID && x.Name == this.Name;
        }
        public override int GetHashCode()
        {
            return this.ID.GetHashCode();
        }
    }
}
