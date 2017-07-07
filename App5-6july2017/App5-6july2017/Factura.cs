using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App5_6july2017
{
    public class Factura
    {
        private int valoare;
        public int Valoare
        {
            get
            {
                return valoare;
            }
            set
            {
                if (null != FacturaChanged)
                    FacturaChanged(this, this);
                valoare = value;
            }
        }
        public int? Sold { get; set; }

        public event EventHandler<Factura> FacturaChanged;
    }
}
