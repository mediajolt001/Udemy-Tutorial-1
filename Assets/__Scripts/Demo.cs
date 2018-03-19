using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LearnProgrammingAcademy.Learning
{
    public class Demo : MonoBehaviour
    {
        int[] names = new int[4];   //initialize empty array with 4 elements

        string[] pets = { "parrot", "cat", "dog" }; //anonymous array

        int[,] table = new int[3, 3]; // 3x3 array

        // jagged array of arrays
        string[][] myArray =
        {
            new string[]{"one","two"}, //1st row has 2 elements
            new string[] {"three","four","five"} //2nd row of three
        };


         private void Start()
        {
            Debug.LogFormat("pets-size = {0}", pets.Length);

            Debug.LogFormat("pets[0] = {0}", pets[0]);
            Debug.LogFormat("pets[1] = {0}", pets[1]);
            Debug.LogFormat("pets[2] = {0}", pets[2]);
            //Debug.LogFormat("pets[3] = {0}", pets[3]); //out of range

            table[0, 0] = 10;
            table[1, 1] = 20;

            Debug.LogFormat("table[0,0] = {0}", table[0, 0]);
            Debug.LogFormat("table[1,1] = {0}", table[1, 1]);
            Debug.LogFormat("table[2,2] = {0}", table[2, 2]);
            //Debug.LogFormat("table[3,2] = {0}", table[3, 2]); // out of range


        }

    }
}

