using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public Class1(string name)
        {
            MyString = name;
        }
        public string MyString { get; set; }
        public string GetMyString()
        {
            return MyString;
        }
    }
}
