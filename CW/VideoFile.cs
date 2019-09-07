using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW
{
    class VideoFile : File
    {
        public string Resolution { get; set; }
        public string Length { get; set; }
        public override void Parse(string text)
        {
            string[] words = text.Split(new char[] { ':', '.', '(', ')', ';' }, StringSplitOptions.RemoveEmptyEntries);
            base.Parse(text);
            Resolution = words[5];
            Length = words[6];
        }
        public void Print()
        {
            Console.WriteLine(
                "\t" + $"{Name}" + "\n\r" +
                "\t\t" + $"Extention: {Extention}" + "\n\r" +
                "\t\t" + $"Size: {Size}" + "\n\r" +
                "\t\t" + $"Resolution: {Resolution}" + "\n\r" +
                "\t\t" + $"Length: {Length}");
        }
    }
}
