using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2_6_july2017
{
    public class ShapeDecorator <T> where T:IShape
    {
        public int Description { get; set; }
        public T Shape { get; set; }
    }
}
