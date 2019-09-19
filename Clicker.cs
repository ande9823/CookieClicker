using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clicker : MonoBehaviour
{
    // function int to name an item
    public int score = 0;
    Worker worker;


    // Start is called before the first frame update
    void Start()
    {
        worker = GetComponent<Worker>();

    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //this is executed if the condition is true 
            score++;
            Debug.Log("cookies clicked :"+score);

        }

        
        if (Input.GetKeyDown(KeyCode.R))
        {
            //this is executed if the condition is true 
            score = score + 1; //score++
            Debug.Log("cookies clicked :"+score);

        }
        else
        {
            //this is executed if the condition is false
            //Debug.Log("are you there?");
        }
        

        if (score == 10)
        {
            Debug.Log("you got 10!");
            AddTen();
            worker.enabled = true;

        }

        /* Arrays
        //int[] bonuses = new int[6];
        int[] bonuses = { 12, 31, 17, 8, 11, 22 };

        for(int i=0; i<bonuses.Length; i++)
        {
            Debug.Log(bonuses[i]);
        }
        */

    }

    void AddTen()
    {
        int HowManyTimes = 10;
        while (HowManyTimes > 0)
        {
            //do something
            score++;
            //make HowManyTimes smaller
            HowManyTimes--;
        }
    }

}
