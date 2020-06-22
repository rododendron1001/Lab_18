using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_18
{
    public class SearchResult<T>
    {
        private readonly T[] array;

        public T FindElement(int index)
        {
            T element;
            string index_ok = String.Empty;

            if ((index >= 0) && (index < this.array.Length))
            {
                element = this.array[index];
                index_ok = "Index Ok ";
            }
            element = default(T);
            index_ok = "Index NOT Ok ";

            Console.WriteLine(index_ok);
            return  element;
        }
    }
}
