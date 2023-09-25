using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Compasion : MonoBehaviour
{
    [SerializeField] private InputField LineC;
    [SerializeField] private InputField LineD;
    [SerializeField] private Text ComparePanelText;


    float FirstNumber, SecondNumber; // Исчезли все ошибки, кроме 1; почему инициализировал ComparePanelText второй раз

    public void Compason()
    {
        FirstNumber = float.Parse(LineC.text); // delite float
        SecondNumber = float.Parse(LineD.text); //

        if (FirstNumber > SecondNumber)
        {
            ComparePanelText.text = $"Большее число - {FirstNumber}"; // $"тект {переменная}" и .text
        }
        else
        {
            ComparePanelText.text = $"Большее число - {SecondNumber}"; //
        }
    }
}
