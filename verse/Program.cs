using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace verse
{
    class Program
    {
        public static int location = 12;
//        public static List<Text> texts = new List<Text>();
        
 //       public static void getText(string s)
  //      {
   //         texts.Add(new Text(s));
    //    }
        //public static List<Text> texts = new List<Text>();
        //static Text e = new Text(new System.IO.StreamReader("c:/Users/mahmud/Documents/en.yusufali.txt"));
        //static Text b = new Text(verse.Properties.Resources.bengali);
        //static System.IO.StreamReader file = new System.IO.StreamReader(global::verse.Properties.Resources.bengali);
        //static public Get b = new Get(global::verse.Properties.Resources.bengali);
        //static public Get b = new Get(new System.IO.StreamReader("c:/Users/mahmud/Documents/en.yusufali.txt"));
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

