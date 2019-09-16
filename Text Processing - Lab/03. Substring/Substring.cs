using System;

namespace _03._Substring
{
    class Substring
    {
        static void Main()
        {
            string search = Console.ReadLine().ToLower();
            string str = Console.ReadLine().ToLower();

            //while (true)
            //{
            //    int index = str.IndexOf(search);

            //    if (index < 0)
            //    {
            //        break;
            //    }
            //    str = str.Remove(index, search.Length);
            //}
            //Console.WriteLine(str);

            //по-добрия вариант!
            while (str.Contains(search))
            {
                str = str.Replace(search, string.Empty);
            }

            Console.WriteLine(str);
        }
    }
}
