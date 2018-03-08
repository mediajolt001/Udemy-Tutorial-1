using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LearnProgrammingAcademy.Learning
{
    public class Demo : MonoBehaviour
    {
        int lives = 3;
        string playerName = "Karl";
        bool gameOver; // false by default


        private void Start()
        {
            print("Hello");
            Debug.Log("Hello Log");

            Debug.Log("player " + playerName + " has " + lives + " lives left.");
            Debug.LogFormat("Player {0} has {1} lives left", playerName, lives);
        }

    }

}

