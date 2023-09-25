using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{
    public InputField LineA;
    public InputField LineB;
    public Text ResultPanelText;

    public void Summ() {
        float A, B, C;
        A = float.Parse(LineA.text);
        B = float.Parse(LineB.text);
        C = A + B;
        ResultPanelText.text = C.ToString();
    }

    public void Subs() {
        float A, B, C;
        A = float.Parse(LineA.text);
        B = float.Parse(LineB.text);
        C = A - B;
        ResultPanelText.text = C.ToString();
    }

    public void Multi() {
        float A, B, C;
        A = float.Parse(LineA.text);
        B = float.Parse(LineB.text);
        C = A * B;
        ResultPanelText.text = C.ToString();
    }

    public void Divis() {
        float A, B, C;
        A = float.Parse(LineA.text);
        B = float.Parse(LineB.text);
        C = A / B;
        ResultPanelText.text = C.ToString();
    }
}
