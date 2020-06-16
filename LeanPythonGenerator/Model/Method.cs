using System.Collections.Generic;

namespace LeanPythonGenerator.Model
{
    public class Method
    {
        public string Name { get; }
        public PythonType ReturnType { get; }

        public bool Abstract { get; set; }
        public bool Static { get; set; }
        public bool Overload { get; set; }

        public string Summary { get; set; }

        public IList<Parameter> Parameters { get; set; } = new List<Parameter>();

        public Method(string name, PythonType returnType)
        {
            Name = name;
            ReturnType = returnType;
        }
    }
}