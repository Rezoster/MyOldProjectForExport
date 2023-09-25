using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Random = System.Random;

public class FourthExersise : MonoBehaviour
{
    void Start()
    {
        int[] arr = SetArray(9);
        int[] regArr = Regulation(arr);
        println(regArr);

    }




    private void println(int[] arr)
    {
        foreach (int a in arr)
        {
            Debug.Log(a);
        }
    }




    private int[] Regulation(int[] arr)
    {
        int before = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            for (int f = 0; f < arr.Length - i - 1; f++)
            {
                if (arr[f] > arr[f + 1])
                {
                    before = arr[f];
                    arr[f + 1] = arr[f];
                    arr[f] = before;
                }
                
            }
        }
        return arr;
    }




    private int[] SetArray(int length)
    {
        Random rand = new Random();
        int[] arr = new int[length];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rand.Next(0, 101);
        }
        return arr;
    }
}
