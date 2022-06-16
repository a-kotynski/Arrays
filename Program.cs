using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array is a data structure that is used to store a collection of
            //variables of the same type.

            /*
            int number1;
            int number2;
            int number3;
            */

            //int[] numbers = new int[3];
            //first set of brackets [] is used for declaring an array
            //and a second set [3] defines the size of an array
            //operator new is used for memory allocation

            //Accessing Array Elements:
            /*
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            */
            //if the values in the array are known it's better to use
            //object initialization syntax:
            int[] numbers = new int[] { 1, 2, 3 }; // instead of int[] numbers = new int[3];
        }
    }
}