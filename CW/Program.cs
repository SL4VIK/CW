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
            string text = @"Text:file.txt(6B);Some string content							Image:img.bmp(19MB);1920х1080							Text:data.txt(12B);Another string							Text:data1.txt(7B);Yet another string							Movie:logan.2017.mkv(19GB);1920х1080;2h12m";
            string[] words = text.Split(new char[] { ':', '.', '(', ')', ';' }, StringSplitOptions.RemoveEmptyEntries);
            string[] files = text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < files.Length; i++)
            {
                string[] split = files[i].Split(' ');
                string fileType = split[0].ToLower();
                switch (fileType)
                {
                    case "text":
                        TextFile textFile = new TextFile();
                        textFile.Parse(split[1]);
                        textFile.Print();
                        break;
                    case "image":
                        ImageFile imageFile = new ImageFile();
                        imageFile.Parse(split[1]);
                        imageFile.Print();
                        break;
                    case "movie":
                        VideoFile videoFile = new VideoFile();
                        videoFile.Parse(split[1]);
                        videoFile.Print();
                        break;
                }









                //if (words[0] == "Text")
                //{
                //    Console.WriteLine("Text files:");
                //    TextFile textfile = new TextFile();
                //    textfile.Parse(text);
                //    textfile.Print();
                //}
                //else if (words[0] == "Movie")
                //{
                //    Console.WriteLine("Movies:");
                //    VideoFile videoFile = new VideoFile();
                //    videoFile.Parse(text);
                //    videoFile.Print();
                //}
                //else if (words[0] == "Image")
                //{
                //    Console.WriteLine("Images:");
                //    ImageFile imageFile = new ImageFile();
                //    imageFile.Parse(text);
                //    imageFile.Print();
                //}
                //else
                //{
                //    Console.WriteLine("Incorrect type");
                //}
                Console.ReadKey();
            }
        }
    }
}
