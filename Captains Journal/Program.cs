using System;
using System.IO;
namespace Captains_Journal
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText;
            bool start = true;
            string journalContent = "";
            while (start)
            {   
                
                inputText = Console.ReadLine();
                string[] words = inputText.Split(' ');
                foreach(string word in words)
                {
                    if (word == "start")
                    {
                        start = false;
                        continue;
                    }

                    if (!start)
                    {
                        journalContent += word+" ";
                    }
                }
                journalContent += Environment.NewLine;
            }


            bool stop=true;
            while (stop)
            {
                inputText = Console.ReadLine();
                string[] words = inputText.Split(' ');
                foreach(string word in words)
                {
                    if (word == "stop")
                    {
                        stop = false;
                        break;
                    }
                    else
                    {
                        journalContent += word+" ";
                    }
                }
                journalContent += Environment.NewLine;

            }

            string nameDate=DateTime.Now.ToString("yyyy-MM-dd_hh");
            string fileName = nameDate+".txt";

            File.WriteAllText(fileName, journalContent);
        }
    }
}
