using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SecondExersise : MonoBehaviour
{
    private void Start()
    {
        int[] arr = { 81, 22, 13, 54, 10, 34, 15, 26, 71, 68 };
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if ((arr[i] % 2) == 0)
            {
                sum += arr[i];
            }

        }
        Debug.Log($"Второе задание: {sum}");

    }
}
