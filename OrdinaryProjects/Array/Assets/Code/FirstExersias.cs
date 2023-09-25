using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class FirstExersias : MonoBehaviour
{
    private void Start()
    {
        int k = 0;
        for (int i = 7; i <= 21; i++)
        {
            if (i % 2 == 0)
            {
                k += i;
            }

        }
        Debug.Log($"Первое задание: {k}");

    }
}
