using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structure_and_algo
{
    class DynamicArray
    {
        private int[] array; // array itself 
        private int count; // num of element add by user
        private int size; // size of an array

        public DynamicArray()// constructure initializing basic values 
        {
            array = new int[1];
            count = 0;
            size = 1;
        }

        //implimentation functions for dynamic array 
        // add, remove, append etc and there helping functions 

        // Add function which will add element at the end of array
        public void add(int data)
        {
            //check for if there is space in array or not
            if (count == size)
            {
                //if num of element = to size of array then increase the size of array
                extendArray();
            }
            // after makeing space in array add the element at the end of array
            array[count] = data;
            //increment the count of element
            count++;
        }

        //function for making array double in size 
        private void extendArray()
        {
            
            int []temp = null;
            if (count == size)
            {
                temp = new int[size * 2];
                {
                    for (int i = 0; i < size; i++)
                    {
                        temp[i] = array[i];
                    }
                }
            }
            array = temp;

            size = size * 2;
        }

         public static void Main()
        {
            // user interface 
        }
    }
}
