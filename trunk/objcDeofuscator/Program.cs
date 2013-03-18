using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objcDeofuscator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rawClass = System.IO.File.ReadAllLines("bar.txt");
            IProcess pre = new Preprocessor(rawClass);
            List<string> preResult = pre.Process();
            IProcess procesado = new Processor(preResult);
            List<string> procesadoResult = procesado.Process();
            System.IO.StreamWriter file = new System.IO.StreamWriter("test.txt");
            
            foreach (string s in procesadoResult)
            {
                file.WriteLine(s);
            }

            file.Close();
        }
    }
}
