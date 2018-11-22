using System;
using System.IO;

namespace lab14_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ColdCallFileReader peopleToRing = new ColdCallFileReader();

            string prompt = "Please type in the name of the file > ";
            Console.Write(prompt);
            string fileName = Console.ReadLine();
            try
            {
                peopleToRing.Open(fileName);
                for (int i = 0; i < peopleToRing.NPeopleToRing; i++)
                {
                    peopleToRing.ProcessNextPerson();
                }
                Console.WriteLine("All callees processed correctly");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("file not found");
            }
            catch (ColdCallFileFormatException e)
            {
                Console.WriteLine(
              "The file {0} appears to have been corrupted", fileName);
                Console.WriteLine("Details of problem are: {0}", e.Message);
                if (e.InnerException != null)
                    Console.WriteLine(
                       "Inner exception was: {0}", e.InnerException.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occurred:\n" + e.Message);
                Console.WriteLine(e);
            }
            finally
            {
                peopleToRing.Dispose();
            }
        }
    }
    class ColdCallFileReader
    {
        private StreamReader reader;
        public int NPeopleToRing { get; private set; }
        public void Open(string fileName)
        {
            reader = new StreamReader(new FileStream(fileName, FileMode.Open));
            try
            {
                NPeopleToRing = Convert.ToInt32(reader.ReadLine());
            }
            catch (System.FormatException e)
            {

                throw new ColdCallFileFormatException("incorrect format for number of people", e);
            }
            //Console.WriteLine($"File is opened with {NPeopleToRing} people");
        }

        public void ProcessNextPerson()
        {
            string person = reader.ReadLine();
            Console.WriteLine($"person {person} being processed . . .");
        }
        public void Dispose()
        {
            if (reader != null)
            {
                //Console.WriteLine("disposing of the file");
                reader.Close();
            }
        }
    }
    public class ColdCallFileFormatException : Exception
    {
        public ColdCallFileFormatException()
        {
        }

        public ColdCallFileFormatException(string message)
            : base(message)
        {
        }

        public ColdCallFileFormatException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
