﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int [] array = {1, 2, 3, 4, 5};

        for (int i = 0; i < array.Length; i++)
        { 
                Debug.Log(array[i]);
        }

        for (int i = 4; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
