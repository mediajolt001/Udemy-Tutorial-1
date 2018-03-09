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

        int itemCount = 24;
        int itemsPerPage = 5;

        private void Start()
        {
            Debug.LogFormat("score= " + score);
            score += 10; 
            Debug.LogFormat("score = {0}, lives = {1}", score, lives);
            lives--;
            Debug.LogFormat("score = {0}, lives = {1}", score, lives);

            score *= 2;
            Debug.LogFormat("score = {0}, lives = {1}", score, lives);

            score /= 2;
            Debug.LogFormat("score = {0}, lives = {1}", score, lives);

            coinCount += 40;
            Debug.LogFormat("coinCount = {0}", coinCount);

            coinCount = coinCount % 100;
            Debug.LogFormat("coinCount = {0}", coinCount);

            int remainingItems = itemCount % itemsPerPage;
            Debug.LogFormat("remainingItems = {0}", remainingItems);

        }
    }

}

