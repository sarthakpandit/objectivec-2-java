using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objcDeofuscator
{
    public interface IProcess
    {
        
       List<string> ObjcClass { get; set; }
       List<string> Process();
    }
}
