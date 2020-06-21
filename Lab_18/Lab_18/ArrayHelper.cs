using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_18
{
    public class ArrayHelper<T>
        where T:IEquatable<T>
      
    {
        private readonly T[] array;
        public ArrayHelper(params T[] array)
        {
            this.array = array ?? new T[0];
        }

        

        public int FindElement(this T[] array, T searchElement)
        {
            int index = 0;
            bool res;
            for (int i =0; i < array.Length; i++)
            {
                res = ((IEquatable<T>)searchElement).Equals(array[i]);
                if (res)
                {
                    index = i;
                    
                }
                index = -1;
            }
            return index;
        }

        
    }
}
