/*
NOTES:
1. BufferedStream provides better performance for read/write, than direct File or Memory stream
https://microsoft.public.dotnet.framework.performance.narkive.com/371g7mv5/bufferedstream-versus-filestream
https://docs.microsoft.com/en-us/dotnet/api/system.io.bufferedstream?view=net-5.0



*/

using System;
using System.IO;
using System.Text;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read & write file
            using (FileStream rs = File.Open("input.txt", FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using(FileStream ws = File.Open("outpur.txt", FileMode.Create, FileAccess.Write, FileShare.Read))  
            using (BufferedStream bsr = new BufferedStream(rs))
            using (BufferedStream bsw = new BufferedStream(ws))
            using(StreamWriter sw = new StreamWriter(bsw))
            using (StreamReader sr = new StreamReader(rs))
            {
                string line;
                int lineNumber = 1;
                while ((line = sr.ReadLine()) != null)
                {
                    if(Int32.TryParse(line, out int inNumber))
                    {
                        sw.WriteLine(inNumber);
                        Console.WriteLine("Line number {0}: {1}",lineNumber, inNumber);
                    }
                    else
                    {
                        Console.WriteLine("Line number {0} - skipped - : {1}",lineNumber, line);
                    }
                    lineNumber++;
                }   
            }
        }
 
    }
}
