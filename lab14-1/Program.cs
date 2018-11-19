using System;
using System.IO;


namespace lab14_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ProcessText addressBook = new ProcessText();
            Console.Write("Enter file to read from: ");
            String inFile = Console.ReadLine();
            Console.Write("Enter file to write to: ");
            String outFile = Console.ReadLine();
            addressBook.openFile(inFile, outFile, "415", "628");
        }

    }
    class ProcessText
    {
        public void openFile(String source, String target, String oldStr, String newStr)
        {
            StreamReader reader = new StreamReader(new FileStream(source, FileMode.Open));
            StreamWriter writer = new StreamWriter(new FileStream(target, FileMode.Create));
            String line1;
            String line2;
            while((line1 = reader.ReadLine()) != null)
            {
                line2 = line1.Replace(oldStr, newStr);
                writer.WriteLine(line2);
            }

            reader.Close();
            writer.Close();
        }
    }
}