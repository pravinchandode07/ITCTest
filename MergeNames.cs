using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramApp
{
    class MergeNames
    {
        
        public static string[] UniqueNames(string[] names1,string[] names2)
        {
            List<string> resultArray = new List<string>(); 
            foreach(string c in names1)
            {
                if (!resultArray.Contains(c))
                {
                    resultArray.Add(c);
                }

            }
            foreach (string c in names2)
            {
                if (!resultArray.Contains(c))
                {
                    resultArray.Add(c);
                }
                
            }
             resultArray.Sort();
            return resultArray.ToArray();
            //throw new NotImplementedException();
        }
        public static void Main(string[] args)
        {
            string[] names1 = new string[] { "Ava", "Emma", "Olivia" };
            string[] names2 = new string[] {"Olivia","Sophia","Emma" };
            Console.WriteLine(string.Join(", ", MergeNames.UniqueNames(names1, names2)));
            Console.ReadKey();
        }
    }
}
