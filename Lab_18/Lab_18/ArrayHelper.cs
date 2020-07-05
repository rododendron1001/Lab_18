using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_18
{
    public class ArrayHelper<T>
        where T:IEquatable<T>, IComparable<T>
      
    {
        private readonly T[] array;
        public ArrayHelper(params T[] array)
        {
            this.array = array ?? new T[0];
        }

       

        public int FindIndex( T[] array, T searchElement)
        {
            int index = 0;
            bool res;
            for (int i = 0; i < array.Length; i++)
            {
                //res = ((IEquatable<T>)searchElement).Equals(array[i]);
                res = ((searchElement).Equals(array[i]));
                if (res)
                {
                    index = i;

                }
                index = -1;
            }
            return index;
        }

        public T FindElement(int index)
        {
            T element;
            if ((index >=0) && (index < this.array.Length))
            {
                element = this.array[index];
               
            }
            element = default(T);
            return element;
        }

        public static T[] CopyRange(T[] array, int startIndex, int length)
        {
            if (array is null)
            {
                return new T[] { };
            }

            if ((startIndex < 0) || (startIndex >= array.Length))
            {
                return new T[] { };
            }

            int actualLength = Math.Min(length, array.Length - startIndex);

            T[] result = new T[actualLength];

            for (int i = 0; i < actualLength; i++)
            {
                result[i] = array[startIndex + i];
            }

            return result;
        }

        public static T[] ExchangeSort(T[] array, SortDirection sortDirection)
        {
            if ((array ?? new T[] { }).Length == 0)
            {
                return new T[] { };
            }

            T[] result = CopyRange(array, 0, array.Length);

            for (int i = 0; i < result.Length - 1; i++)
            {
                for (int j = i + 1; j < result.Length; j++)
                {
                    bool interchange = false;

                    switch (sortDirection)
                    {
                        case SortDirection.Descending:
                            
                            if ( result[i].CompareTo( result[j]) == -1 )
                                {
                                interchange = true;
                            }
                            break;

                        case SortDirection.Ascending:
                        default:
                            
                            if (result[i].CompareTo(result[j]) == 1)
                                {
                                interchange = true;
                            }
                            break;
                    }

                    if (interchange)
                    {
                        T aux = result[i];
                        result[i] = result[j];
                        result[j] = aux;
                    }
                }
            }

            return result;
        }



    }
}
