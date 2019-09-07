using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW
{
    class ImageFile : File
    {
        public string Resolution { get; set; }
        public override void Parse(string text)
        {
            string[] words = text.Split(new char[] { ':', '.', '(', ')', ';' }, StringSplitOptions.RemoveEmptyEntries);
            base.Parse(text);
            Resolution = words[4];
        }
        public void Print()
        {
            Console.WriteLine("\t" + $"{Name}");
            Console.WriteLine("\t" + "\t" + $"Extention: {Extention}");
            Console.WriteLine("\t" + "\t" + $"Size: {Size}");
            Console.WriteLine("\t" + "\t" + $"Resolution: {Resolution}");
        }
    }
}
