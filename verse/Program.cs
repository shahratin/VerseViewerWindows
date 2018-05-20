using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace verse
{
    public class MyCustomNumericBox : System.Windows.Forms.NumericUpDown
    {
        public MyCustomNumericBox()
        {
            Controls.Remove(Controls[0]);
        }
    }
    
    static class Program
    {
        public class Get
        {
            static string line(int l)
            {

                string[] lines = new string[6236];
                string line;
                int i = 0;
                System.IO.StringReader file = new System.IO.StringReader(global::verse.Properties.Resources.bengali);
                while ((line = (file.ReadLine())) != null)
                {
                   lines[i] = line;
                  i++;
                };
                return lines[l];
            }
            static decimal[] map = new decimal[]{
                7,  286, 200, 176, 120, 165, 206, 75,  129, 109, 123, 111, 43,
                52, 99,  128, 111, 110, 98,  135, 112, 78,  118, 64,  77,  227,
                93, 88,  69,  60,  34,  30,  73,  54,  45,  83,  182, 88,  75,
                85, 54,  53,  89,  59,  37,  35,  38,  29,  18,  45,  60,  49,
                62, 55,  78,  96,  29,  22,  24,  13,  14,  11,  11,  18,  12,
                12, 30,  52,  52,  44,  28,  28,  20,  56,  40,  31,  50,  40,
                46, 42,  29,  19,  36,  25,  22,  17,  19,  26,  30,  20,  15,
                21, 11,  8,   8,   19,  5,   8,   8,   11,  11,  8,   3,   9,
                5,  4,   7,   3,   6,   3,   5,   4,   5,   6};
            public static decimal vCount(decimal sNo)
            {
                sNo--;
                return map[(int)sNo];
            }

            static int verseNo(decimal s, decimal v)
            {
                s--;
                v--;
                decimal r = 0;
                for (int i = 0; i < s; i++)
                {
                    r += map[i];
                }
                r += v;

                return (int)r;
            }
            public static string verse(decimal s, decimal v)
            {
                int i = verseNo(s, v);
                return line(i);
            }
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
       
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
//            System.Diagnostics.Debug.WriteLine(Get.verse(2,3));
            Application.Run(new Form1());
            
            
        }
    }
}
