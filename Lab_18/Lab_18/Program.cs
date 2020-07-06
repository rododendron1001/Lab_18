using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Lab_18
{
    class Program
    {
        static void Main(string[] args)
        {
           

            
        }

        

        public static T[] Sum<T>(T[] array1, T[] array2)
            //adunare 2 arrays
        {
            int length = (array1.Length < array2.Length ? array1.Length : array2.Length);
            T[] newArray = new T[length];

            for (int i = 0; i < length; i++)
                if (i < length)
                    
                    newArray[i] = Add(array1[i],array2[i]);

                else
                newArray[i] = default(T);

            return newArray;
        }

        public static T Add <T>(T a, T b)
        //adunare intre 2 valori de un tip de date generic
        {
            // parameters
            dynamic A = a;
            dynamic B = b;

            // Add the parameters 
            T result = A + B;

            // Delegate

            Func<T, T, T> add1 = Add;

            // Call it
            return add1(a, b);                       
        }

        public static bool FindElem<T>( T[] array, T target )
        {
            // indica daca elementul exista sau nu in array
            bool result = array.Contains(target);

            // Delegate
            Func<T[], T, bool> find1 = FindElem;
          

            return find1(array,target);
        }

        public static (bool,int) FindElemIndex<T> (T[] array, T target)
        {
            // indica daca elementul exista (si intoarce indexul sau) sau nu (si intoarce index= -1) in array 
            bool result = Array.FindIndex(array, x => x.Equals(target)) != -1;
           
            int index = Array.FindIndex(array, x => x.Equals(target));
           
            //Func<T[], T, bool,int> findIndex1 = FindElemIndex;
            return (result, index);
        }


        public static T[] DelFromArray<T> (T[] array)
        {
            // stergere elemente care satisfac o anumita conditie :  sunt null

            List<T> list = array.ToList();

            list.RemoveAll(delegate (T elem)
            {
                if (elem is object)
                {
                    return (elem is null);
                }
                return false;
            }
                );
            T[] result = list.ToArray();
            return result;
        }

     


    }
}
