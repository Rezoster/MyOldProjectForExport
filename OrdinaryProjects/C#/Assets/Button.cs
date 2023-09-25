using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    public Text title;
    public InputField replacement;
    int k = UnityEngine.Random.Range(0, 101);
    int m = 0;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Lets rock!");
    }
    public void onClick()
    {
        title.text = (k).ToString();
    }

    public void readText()
    {
        m = int.Parse(title.text);
        if (m == k)
        {
            title.text = "Правильно!";
        }
        else if (m < k)
        {
            title.text = $"Больше на {k - m}";
        }
        else if (m > k)
        {
            title.text = $"Меньше на {m - k}";
        }
        // Update is called once per frame
    }

}