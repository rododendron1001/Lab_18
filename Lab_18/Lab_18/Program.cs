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
            
            Func<T[], T[], T[]> add = Sum;
        }

        

        public static T[] Sum<T>(T[] array1, T[] array2)
            //adunare 2 arrays
        {
            int length = (array1.Length < array2.Length ? array1.Length : array2.Length);
            T[] newArray = new T[length];

            for (int i = 0; i < length; i++)
                if (i < length)
                    //newArray[i] = array1[i] + array2[i];
                    newArray[i] = Add(array1[i],array2[i]);

                else
                newArray[i] = default(T);

            return newArray;
        }

        public static T Add <T>(T a, T b)
        //adunare intre 2 valori de un tip de date generic
        {
            // Declare the parameters
            dynamic A = a;
            dynamic B = b;


            // Add the parameters together
            T result = A + B;

            // Delegate

            Func<T, T, T> add1 = Add;

            // Call it
            return add1(a, b);           
            
        }

        public static bool FindElem<T>(T[] array, T target )
        {
            bool result = array.Contains(target);

            Func<T[], T, bool> find1 = FindElem;
            return find1(array,target);
        }


    }
}
