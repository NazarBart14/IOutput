using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOutput
{
    public interface IAOutput
        {
             void Show();
             void Shows(string info);
        }
    internal class Program : Array
    {
        
        
        static void Main(string[] args)
        {
           
            Array array = new Array();
            string info = null;
            array.Show();
            array.Shows(info);
            array.Info();
        }
    }
}
