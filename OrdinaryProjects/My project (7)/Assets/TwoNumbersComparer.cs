using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TwoNumersComparer : MonoBehaviour
{
    [SerializeField]  public InputField LineC;
    [SerializeField]  public InputField LineD;
    [SerializeField]  public Text ComparePanelText;


    float FirstNumber, SecondNumber; // Исчезли все ошибки, кроме 1; почему инициализировал ComparePanelText второй раз

    public void Main() {
        
    }
    
    public void Compasion()
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
