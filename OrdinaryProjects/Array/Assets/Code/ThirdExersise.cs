using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Random = System.Random;

public class ThirdExersise : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] arr = { 81, 22, 13, 34, 10, 34, 15, 26, 71, 68 };
        Random _checked = new Random();
        int res = -1;
        for (int i = 0; i < arr.Length; i++)
        {
            if (_checked.Next(0, 101) == arr[i])
            {
                res = i;
            }
        }
        Debug.Log($"Третье задание: {res}");

    }
}
