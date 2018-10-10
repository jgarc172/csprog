using System;

namespace lab7_4
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBook callList = new AddressBook();
            callList.add("Jim", 4321);
            Console.WriteLine(callList.getValue("Jim"));
            callList.replaceVal("Jim", 4322);
            Console.WriteLine(callList.showAll());
        }
    }
    class AddressBook
    {
        private PairT[] entries = new PairT[100];
        private int numUsed;
        public AddressBook()
        {
            numUsed = 0;
        }
        public void add(string newKey, int newVal)
        {
            var p = new PairT(newKey, newVal);
            entries[numUsed] = p;
            numUsed++;
        }
        public int getValue(string key)
        {
            var index = IndexOf(key);
            if (index > -1)
            {
                return entries[index].val;
            }
            return -1;
        }
        public void replaceVal(string aKey, int aVal){
            var index = IndexOf(aKey);
            if (index > -1)
            {
                entries[index].val = aVal;
            }
        }
        public string showAll()
        {
            var res = "";
            for (int i = 0; i < numUsed; i++)
            {
                res += entries[i].key + " " + entries[i].val + "\n";
            }
            return res;
        }
        private int IndexOf(string key)
        {
            for (int i = 0; i < numUsed; i++)
            {
                if (entries[i].key == key)
                {
                    return i;
                }
            }
            return -1;
        }
        private struct PairT
        {
            public string key;
            public int val;
            public PairT(string newKey, int newVal)
            {
                key = newKey;
                val = newVal;
            }
        }
    }
}
