using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace objctojavacore
{
    public interface IProcess
    {
        List<string> ObjcClass { get; set; }
        List<string> Process();
    }
}
