using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace objctojavacore
{
    public class Processor : IProcess
    {
        private List<string> _objcClass;
        public List<string> ObjcClass { get; set; }

        public Processor(List<string> input)
        {
            _objcClass = input;
        }

        public List<string> Process()
        {
            List<string> resultado = new List<string>();
            foreach (string line in _objcClass)
            {
                string copy = line;
                string foo = line;

                //Transformando cabeceras de metodos
                if (copy != "" && copy[0].Equals('-'))
                {
                    foo = TransformMethod(line);
                    resultado.Add(foo);
                    copy = foo;
                    continue;
                }
                //Haciendo que los if(variable) sean if(variable != null)
                if (line.Contains("if") && line.Trim().Split(' ').Length <= 5)
                {

                    foo = ifDistinctNull(line.TrimStart());
                    if (line.Split(' ').Length == 5)
                        foo = foo + " {";
                    //despues del trim tengo que volver a meterla las tabulaciones
                    int tabs = cuentaTabs(line);
                    string aux = "";
                    for (int i = 0; i < tabs; i++)
                    {
                        aux = aux + " ";
                    }
                    resultado.Add(aux + foo);
                    copy = foo;
                    continue;
                }


                resultado.Add(line);
            }

            return resultado;
        }

        private string ifDistinctNull(string line)
        {
            string[] words = line.Split(' ');
            string res = "";
            string variable = "";
            int llave = 0;
            if (words.Length == 5)
            {
                llave = 1;
            }
            switch (words.Length - llave)
            {
                case 3:
                    variable = words[1];
                    variable = variable.Replace("(", "");
                    variable = variable.Replace(")", "");
                    if (line.Contains("!"))
                        res = "if(" + variable + " == null)";
                    else
                        res = "if(" + variable + " != null)";
                    break;
                case 4:
                    variable = words[2];
                    variable = variable.Replace("(", "");
                    variable = variable.Replace(")", "");
                    if (line.Contains("!"))
                        res = "if(" + variable + " != null)";
                    else
                        res = "if(" + variable + " == null)";
                    break;
                default:
                    break;
            }

            return res;
        }

        private string TransformMethod(string line)
        {
            string res = "";
            string[] words = line.Split(' ');
            string tipo = words[0];
            tipo = tipo.Replace("-(", "");
            tipo = tipo.Replace(")", "");
            string nombre = words[1];

            nombre = nombre.Substring(0, nombre.Length) + "( ";
            if (nombre.Contains(":"))
                nombre = nombre.Replace(":", "");
            res = tipo + " " + nombre;
            int arguments = 0;
            if (words.Length > 3)
                arguments = ((words.Length - 3) / 3) + 1;
            else
                return res + "){";

            for (int i = 2; arguments > 0; arguments--)
            {
                string tipoArg1 = words[i];
                tipoArg1 = tipoArg1.Replace("(", "");
                tipoArg1 = tipoArg1.Replace(")", "");
                res = res + tipoArg1 + " ";
                i++;
                string tipoArg2 = words[i];

                res = res + tipoArg2 + ", ";
                i++;
                i++;
            }
            res = res.Substring(0, res.Length - 2) + "){";
            return res;

        }

        private int cuentaTabs(string line)
        {
            int counter = 0;
            foreach (string s in (line.Split(' ').ToList()))
            {

                if (s.Equals(""))
                    counter++;
                else
                    break;
            }
            return counter;
        }

    }
}
