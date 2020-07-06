using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_18
{
    public class SearchResult<T>
    {
        private readonly T[] array;

        public (string, T) FindElement(int index)
        {
            //returnarea elementului de la un index dat si un flag care sa indice daca indexul a fost valid sau nu

            T element;
            string index_ok = String.Empty;

            if ((index >= 0) && (index < this.array.Length))
            {
                element = this.array[index];
                index_ok = "Index found, Ok ";
            }
            element = default(T);
            index_ok = "Index NOT found, NOT Ok ";

            Console.WriteLine(index_ok);
            return  (index_ok, element);
        }
    }
}
