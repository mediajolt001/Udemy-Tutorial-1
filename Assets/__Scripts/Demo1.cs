using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LearnProgrammingAcademy.Learning
{
    public class Demo1 : MonoBehaviour
    {
         string[] pets = { "parrot", "cat", "dog" }; //anonymous array

        int[,] table = {
            {1,2,3 },
            {4,5,6 },
            {7,8,9},
        };

         private void Start()
        {
            for (int i = 0; i < pets.Length; i ++)
                Debug.LogFormat("pet[{0}] = {1}", i, pets[i]);

            foreach (string pet in pets)
            {
                Debug.LogFormat("pet ={0}", pet);
            }

            foreach(int number in table)
            {
                Debug.LogFormat("number = {0}", number);
            }
        }

    }
}

