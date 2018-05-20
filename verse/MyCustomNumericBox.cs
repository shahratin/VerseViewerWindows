using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verse
{
    public class MyCustomNumericBox : System.Windows.Forms.NumericUpDown
    {
        public MyCustomNumericBox()
        {
            Controls.Remove(Controls[0]);
        }
    }
}
