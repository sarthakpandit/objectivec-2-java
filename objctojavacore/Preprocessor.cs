using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace objctojavacore
{
    public class Preprocessor : IProcess
    {
        private List<string> _objcClass;
        public List<string> ObjcClass { get; set; }

        public Preprocessor(string[] objcClass)
        {
            this._objcClass = objcClass.ToList();

        }

        public List<String> Process()
        {
            List<string> resultado = new List<string>();
            List<string> trimmedFile = removeTabs(_objcClass);


            foreach (string line in trimmedFile)
            {
                string copy = line;
                string foo = line;
                //sustitucion simple de self por this
                if (copy.Contains("self"))
                {
                    foo = replaceSelf(line);
                    copy = foo;
                }
                //cambiar los set por los sets de java
                if (copy.Contains("set") && !copy[0].Equals('-'))
                {
                    foo = replaceSet(copy);
                    copy = foo;


                }
                //no añadir al fichero las lineas q contiene release,end, etc
                if (line.Contains("release") || line.Equals("") || line.Contains("@end") || line.Contains("#import"))
                    continue;

                resultado.Add(copy);
            }
            return resultado;

        }

        private string replaceSelf(string input)
        {
            return input.Replace("self", "this");
        }

        private List<string> removeTabs(List<string> file)
        {
            List<string> trimmedFile = new List<string>();
            string trimmedLine = "";
            foreach (var line in file)
            {
                trimmedLine = line.Replace("\r", String.Empty);
                trimmedLine = line.Replace("\t", String.Empty);
                trimmedFile.Add(trimmedLine);
            }
            return trimmedFile;
        }


        private string replaceSet(string s)
        {
            return s.Replace("set", "this.");
        }




    }
}
