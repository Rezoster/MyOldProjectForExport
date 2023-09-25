using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Compasion : MonoBehaviour
{
    [SerializeField] private InputField firstInput;
    [SerializeField] private InputField secondInput;
    [SerializeField] private InputField thirdInput;

    private double firstNumber;
    private double secondNumber;

    public void methodCompasion()
    {
        secondNumber = double.Parse(secondInput.text);
        firstNumber = double.Parse(firstInput.text);

        if (firstNumber > secondNumber)
        {
            thirdInput.text = firstNumber.ToString();
        }
        else if (firstNumber < secondNumber)
        {
            thirdInput.text = secondNumber.ToString();
        } else
        {
            thirdInput.text = "Равны";
        }

    }

    // Update is called once per frame
}
