using System.Collections.Generic;

namespace CSharpIntermediate
{
    partial class Program
    {
        public Dictionary<string, string> Music { get; set; }

        public string this[string name]
        {
            get { return Music[name]; }
            set { Music[name] = value; }
        }
    }
}
