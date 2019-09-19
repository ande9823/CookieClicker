using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Worker : MonoBehaviour
{
    Clicker clickerScript;
    int counter;
    // Start is called before the first frame update
    void Start()
    {
        clickerScript = GetComponent<Clicker>();
    }

    private void FixedUpdate()
    {
        counter++;
        if (counter == 50)
        {
            clickerScript.score++;
            counter = 0;
        }
       
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("+1 cookie");
        //clickerScript.score++;
    }
}
