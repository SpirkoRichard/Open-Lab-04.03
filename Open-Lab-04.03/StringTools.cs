using System;

namespace Open_Lab_04._03
{
    public class StringTools
    {
        public string RemoveFirstLast(string original)
        {

            original = original.Substring(1);
            original = original.Substring(0, original.Length - 1);
            return original;
        }
        
    }
}
