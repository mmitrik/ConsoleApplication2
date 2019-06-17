using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Class1
    {
        static void DemoCheck() 
        {
            Console.WriteLine("Hello World!");
            
            bool a = true;
            bool b = false;
            if ( a != true ){
                Console.WriteLine("False {0} {1}", a);
            }
            
            if (b != false ){
                Console.WriteLine("True");
            }
        }
    }
}
