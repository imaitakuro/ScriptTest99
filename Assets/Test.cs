using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class Test : MonoBehaviour
{

    void Start()
    {
        int[] array = { 10, 20, 30, 40, 50 };

        for (int i = 0; i <= 4; i++)
        {
            Debug.Log(array[i]);
        }

        for (int i = 4; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }
    }

    void Update()
    {

    }
}

    // Update is called once per frame
  

