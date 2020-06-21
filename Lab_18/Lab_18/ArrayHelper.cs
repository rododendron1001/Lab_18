using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_18
{
    public class ArrayHelper<T>
        
    {
        private readonly T[] array;
        public ArrayHelper(params T[] array)
        {
            this.array = array ?? new T[0];
        }

        public int IndexOf<T>(this T[] array, T searchElement)
        {
            int index;
            bool res = Array.Exists<T>(array, x => x.Equals(searchElement));
            if (res == true) 
                {
                index = Array.IndexOf<T>(array, searchElement);
                return index;
            }

            //int index = Array.IndexOf<T>(array, x => x.Equals(searchElement))
            return -1;
        }

        public static bool Contains<T>(this T[] array, T searchElement)
        {
            // If you want this to find "null" values, you could change the code here
            return Array.Exists<T>(array, x => x.Equals(searchElement));
            
        }
    }
}
