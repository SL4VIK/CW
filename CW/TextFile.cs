using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW
{
    class TextFile : File
    {
        public string Content { get; set; }
        public override void Parse(string text)
        {
            string[] words = text.Split(new char[] { ':', '.', '(', ')', ';' }, StringSplitOptions.RemoveEmptyEntries);
            base.Parse(text);
            Content = words[4];//Some string content
        }
        public void Print()
        {
            Console.WriteLine("\t" + $"{Name}");
            Console.WriteLine("\t" + "\t" + $"Extention: {Extention}");
            Console.WriteLine("\t" + "\t" + $"Size: {Size}");
            Console.WriteLine("\t" + "\t" + $"Content: {Content}");
        }
    }
    
}
