using System;
using System.Collections.Generic;
using System.IO;

namespace project5
{
    class Program
    {
        static string IFILE = "weblog.txt";
        static string OFILE = "out.txt";
        static void Main(string[] args)
        {
            try
            {
                WebLog log = new WebLog(IFILE);
                Console.WriteLine("Writing first 5 lines of the file \n");
                log.PrintFirst5();
                log.Save(OFILE);

                Console.WriteLine();
                WebLog outLog = new WebLog(OFILE);
                Console.WriteLine("Writing first 5 lines of the new file \n");
                outLog.PrintFirst5();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file {0} does not exist", IFILE);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occurred:\n" + e.Message);
                Console.WriteLine(e);
            }
            
        }
    }
    class WebLog
    {
        private List<string> log;
        public WebLog(string fileName)
        {
            StreamReader reader = new StreamReader(new FileStream(fileName, FileMode.Open));
            log = new List<string>();

            ReadLines(reader);
            reader.Close();
        }
        private void ReadLines(StreamReader reader)
        {
           string line;
            while ((line = reader.ReadLine()) != null)
            {
                log.Add(line);
            } 
        }
        public void Save(string fileName)
        {
            StreamWriter writer = new StreamWriter(new FileStream(fileName, FileMode.Create));

            for (int i = log.Count - 1; i >= 0; i--)
            {
                writer.WriteLine(log[i]);
            }
            writer.Close();
        }
        public void PrintFirst5()
        {
            int length = 5;
            if (log.Count < 5)
            {
                length = log.Count;
            }
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(log[i]);
            }
        }
    }
}
