using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculatore : MonoBehaviour
{
    [SerializeField] private Text title;
    [SerializeField] private InputField firstInput;
    [SerializeField] private InputField secondInput;

    private double firstNumber;
    private double secondNumber;


    string replace;
    double sum;

    void Start()
    {
        
    }

    private void Plus()
    {
        secondNumber = double.Parse(secondInput.text);
        firstNumber = double.Parse(firstInput.text);

        sum = secondNumber + firstNumber;
        replace = sum.ToString(); 
        title.text = replace;
    }

    private void Minus()
    {
        secondNumber = double.Parse(secondInput.text);
        firstNumber = double.Parse(firstInput.text);

        sum = firstNumber - secondNumber;
        replace = sum.ToString();
        title.text = replace;
    }

    private void Multiply()
    {
        secondNumber = double.Parse(secondInput.text);
        firstNumber = double.Parse(firstInput.text);

        sum = secondNumber * firstNumber;
        replace = sum.ToString();
        title.text = replace;
    }

    private void Share()
    {
        secondNumber = double.Parse(secondInput.text);
        firstNumber = double.Parse(firstInput.text);

        sum = firstNumber / secondNumber;
        replace = sum.ToString();
        title.text = replace;
    }

}
