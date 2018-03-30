using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Funtion_Overloading
{
    class Program
    {
        public string AddString(string F_Name, string L_Name)
        {
            return (F_Name + L_Name);
        }

        public string AddString(string F_Name, string M_Name, string L_Name)
        {
            return (F_Name + M_Name + L_Name);
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            Console.WriteLine("FullName:{0}", obj.AddString("Manoj", " Kandpal"));
            Console.WriteLine("FullName:{0}", obj.AddString("Govind"," Ballabh"," Kandpal"));
            Console.Read();

        }
    }
}
