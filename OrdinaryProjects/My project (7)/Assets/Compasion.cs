using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Compasion : MonoBehaviour
{
    [SerializeField] private InputField LineC;
    [SerializeField] private InputField LineD;
    [SerializeField] private Text ComparePanelText;


    float FirstNumber, SecondNumber; // ������� ��� ������, ����� 1; ������ ��������������� ComparePanelText ������ ���

    public void Compason()
    {
        FirstNumber = float.Parse(LineC.text); // delite float
        SecondNumber = float.Parse(LineD.text); //

        if (FirstNumber > SecondNumber)
        {
            ComparePanelText.text = $"������� ����� - {FirstNumber}"; // $"���� {����������}" � .text
        }
        else
        {
            ComparePanelText.text = $"������� ����� - {SecondNumber}"; //
        }
    }
}
