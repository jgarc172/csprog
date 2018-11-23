using System;
using System.IO;

namespace lab14_4
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
                Console.WriteLine("The file {0} does not exist", fileName);
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
    class ColdCallFileReader : IDisposable
    {
        private uint nPeopleToRing = 0;
        private bool isDisposed = false;
        private bool isOpen = false;
        private StreamReader reader;
        public uint NPeopleToRing
        {
            get
            {
                if (isDisposed)
                    throw new ObjectDisposedException("peopleToRing");
                if (!isOpen)
                    throw new UnexpectedException(
                       "Attempt to access cold call file that is not open");
                return nPeopleToRing;
            }
            private set
            {

            }
        }
        public void Open(string fileName)
        {
            if (isDisposed)
            {
                throw new ObjectDisposedException("peopleToRing");
            }
            reader = new StreamReader(new FileStream(fileName, FileMode.Open));
            try
            {
                nPeopleToRing = uint.Parse(reader.ReadLine());
                isOpen = true;
            }
            catch (System.FormatException e)
            {

                throw new ColdCallFileFormatException("First line is not an integer", e);
            }
            //Console.WriteLine($"File is opened with {NPeopleToRing} people");
        }

        public void ProcessNextPerson()
        {
            if (isDisposed) throw new ObjectDisposedException("peopleToRing");
            if (!isOpen)
            {
                throw new UnexpectedException("Attempt to access cold call file that is not open.  Call Open() first.");
            }
            try
            {
                string person = reader.ReadLine();
                if (person == "")
                    throw new ColdCallFileFormatException("Not enough names");
                if (person[0] == 'B')
                    throw new SalesSpyFoundException(person);
                Console.WriteLine(person);
            }
            catch (SalesSpyFoundException e)
            {
                Console.WriteLine("** SPY ** " + e.Message);
            }
        }
        public void Dispose()
        {
            if (isDisposed) return;
            if (reader != null)
            {
                //Console.WriteLine("disposing of the file");
                reader.Close();
                reader = null;
            }
            isDisposed = true;
            isOpen = false;
        }
    }
    public class ColdCallFileFormatException : ApplicationException
    {
        public ColdCallFileFormatException(string message)
            : base(message)
        {
        }

        public ColdCallFileFormatException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
    public class SalesSpyFoundException : ApplicationException
    {
        public SalesSpyFoundException(string spyName)
            : base("LandLine spy found, with name " + spyName)
        {
        }
        public SalesSpyFoundException(string spyName, Exception inner)
            : base("LandLine spy found, with name " + spyName, inner)
        {
        }
    }
    class UnexpectedException : ApplicationException
   {
      public UnexpectedException(string message)
         :   base(message)
      {
      }

      public UnexpectedException(string message, Exception innerException)
         :   base(message, innerException)
      {
      }
   }
}
