using System;
using System.IO;

namespace lab14_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string prompt = "Please type in the name of the file > "; 
            Console.Write(prompt);
            string fileName = Console.ReadLine();
            ColdCallFileReader peopleToRing = new ColdCallFileReader();

            try
            {
                peopleToRing.Open(fileName);
            }
            catch (FileNotFoundException)
            {
                
            
            }
            finally
            {

            }
        }
    }
    class ColdCallFileReader
    {
        public void Open(string fileName)
        {
            
        }
    }
}
