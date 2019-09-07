using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Text:data.txt(12B);Another string";
            //string[] words = text.Split(new char[] { ':', '.', '(', ')', ';' }, StringSplitOptions.RemoveEmptyEntries);
            //for (int i = 0; i < words.Length; i++)
            //{
            //    Console.Write($"{words[i]}|");
            //}
            if (words[0] == "Text")
            {
                TextFile textfile = new TextFile();
                textfile.Parse(text);
                textfile.Print();
            }
            else if (words[0] == "Movie")
            {
                VideoFile videoFile = new VideoFile();
                videoFile.Parse(text);
                videoFile.Print();
            }
            else if (words[0] == "Movie")
            {
                ImageFile imageFile = new ImageFile();
                imageFile.Parse(text);
                imageFile.Print();
            }
            else
            {
                Console.WriteLine("Incorrect type");
            }






            Console.ReadKey();
        }
    }
}
