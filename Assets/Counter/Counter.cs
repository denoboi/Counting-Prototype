using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public Text CounterText;

    public GameObject ball;

    private int Count = 0;

    public bool isIn;

    private void Start()
    {
        Count = 0;
    }

    private void OnTriggerEnter(Collider other)
    {

        isIn = true;

        if(isIn)
        {
            Count += 1;
            CounterText.text = "Count : " + Count;
        }

       
    }

   

}
