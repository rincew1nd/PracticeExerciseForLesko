using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1_2_List_Value_Types
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SByte a = 0;
            Byte b = 0;
            Int16 c = 0;
            Int32 d = 0;
            Int64 e = 0;
            string s = "";
            Exception ex = new Exception();
                
            object[] types = new object[] { a, b, c, d, e, s, ex };

            foreach (var o in types)
            {
                string type = o.GetType().IsValueType ? "Value type" : "Reference Type";
                Console.WriteLine($"{o.GetType()} {type}");
            }
            Console.ReadKey();
        }
    }
}
