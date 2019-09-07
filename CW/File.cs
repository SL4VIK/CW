using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW
{
    abstract class File
    {
        public string Name { get; set; }
        public string Extention { get; set; }
        public string Size { get; set; }
        public virtual void Parse(string text)
        {
            string[] words = text.Split(new char[] { ':', '.', '(', ')', ';' }, StringSplitOptions.RemoveEmptyEntries);
            Name = $"{words[1]}.{words[2]}";//file.txt
            Extention = words[2];           //txt
            Size = words[3];                //6B
        }
    }
}
