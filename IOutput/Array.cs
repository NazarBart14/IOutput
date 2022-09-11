using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOutput
{
    internal class Array : IAOutput
    {
    
        public void Show()
        {
            Console.WriteLine($"Dima");
        }
        public void Shows(string info)
        {
            Console.WriteLine($"Kolja");
        }
        public void Info()
        {
            Console.WriteLine($"Nazar");
        }
    }
}
