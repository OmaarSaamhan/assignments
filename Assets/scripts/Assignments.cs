using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignments : MonoBehaviour
{
    void Start()
    {

        /*while (true)
        {
            int randomNNum = Random.Range(1, 21);
            if (randomNNum == 5)
            {
                continue;
            }
            else if (randomNNum == 15)
            {
                break;
            }
            Debug.Log(randomNNum);
        }*/

        string[] words = { "Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird" };
        int count = 0;
        int lenghtt = words.Length;
        string sentence = "";
        while (count < 7)
        {

            int random = Random.Range(0, lenghtt);
            sentence+= words[random]+ " ";
            count++;
        }
        
            Debug.Log(sentence);

    }

}
