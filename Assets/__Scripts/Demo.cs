using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LearnProgrammingAcademy.Learning
{
    public class Demo : MonoBehaviour
    {
        int lives = 3;
        int score;
        int coinCount = 90;
        bool gameOver;

        private void Start()
        {
           // lives = 0;
            while ( lives > 0)
            {
                Debug.LogFormat("lives =  {0}", lives);
                lives--;
            }
            Debug.Log("after while loop");
            lives = 3;

            do
            {
                coinCount += 20;
                lives--;
            } while (lives > 0);

            Debug.LogFormat("coins = {0}, lives = {1}", coinCount, lives);
        }
    }
}

